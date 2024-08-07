﻿using MovInfoService.CLASSI.NGTEC.JSON_MODEL;
using MovInfoService_CMD;
using MovInfoService_CMD.CLASSI.JSON_MODEL;
using MovInfoService_CMD.MODEL;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

//Chiamata TIPO 0  singolarizzatore
//Chiamata TIPO 1  fondo rulliera 1C / CSM
//Chiamata TIPO 2  carico da magazzino (xxxCSMxxx)
//Chiamata TIPO 3  imballo automatico
//Chiamata TIPO 4  isola produttiva 2

namespace MovInfoService.CLASSI.NGTEC.BS
{
    public static class BusinessLogic
    {

        /// <summary>Esegue una chiamata di Tipo 0
        /// </summary>
        /// <param name="req">messaggio di richiesta</param>
        /// <returns></returns>
        public static (string json, bool fl_PrintLabel, bool error) ExecRequest0(Request req)
        {
            string json = "";
            var err = new Error();
            DbOperation dbo = new DbOperation();
            //Eseguo storeprocedure mov_sp_check_udcDetail_flSing
            dbo.Exec_mov_sp_check_udcDetail_flSing(req.ContenutoPila.TrackingCode);
            using (var db = new ItaltonContext())
            {
                var MovUDCDet = db.vw_mov_UDCDetailDestinationGroup.Where(z => z.trackingcode == req.ContenutoPila.TrackingCode && (z.flprocessed == null || z.flprocessed == false)).OrderBy(z => z.IdDettUDCOrder).FirstOrDefault();
                if (MovUDCDet != null)
                {
                    var Destination = MovUDCDet.LocationCodeR1C;
                    //if (Destination == "D04-IMBA") // se la destinazione è Imballo Automatico e questo non è funzionante forzo su imballo manuale
                    //{
                    //    var DestCode = db.vw_mov_Destinationstatus.FirstOrDefault(x => x.LocationCodeR1C == Destination)?.StatusCode;
                    //    if (DestCode != "1")
                    //    {
                    //        Destination = "D05-IMBM";
                    //    }
                    //}

                    var resp = new Response();
                    resp.IdResponse = 0;
                    resp.IdMissione = req.IdMissione;
                    resp.TipoIncarico = 4;                      //carico + scarico
                    resp.DestCarico = null;
                    resp.DestScarico = null;
                    resp.CDLOrigine = req.PosizioneAttuale;
                    resp.CDLDestinazione = Destination;
                    resp.OrdineDiLav = MovUDCDet.ErpOrderCode;
                    //resp.ErpOrderId = MovUDCDet.ErpOrderId;
                    resp.ErpOrderId = GetErpId(MovUDCDet);
                    resp.NumPezzi = MovUDCDet.Qty;
                    resp.Larghezza = MovUDCDet.PanelWidth;
                    resp.Lunghezza = MovUDCDet.PanelLength;
                    resp.SpessorePezzo = MovUDCDet.PanelThickness;
                    resp.Peso = MovUDCDet.PesoUnitario;
                    resp.UDC = MovUDCDet.UDCCode;
                    resp.RFID = MovUDCDet.rfidApplicato;
                    resp.TrackingCode = req.ContenutoPila.TrackingCode;
                    resp.PalletQty = MovUDCDet.Qty;
                    resp.StackQty = MovUDCDet.StackQty;
                    resp.ErpCodicePallet = MovUDCDet.ErpCodicePallet;
                    resp.Gruppo = MovUDCDet.Gruppo;
                    resp.Transfer = false;
                    resp.Errore = null;

                    //serializzo e restituisco la risposta
                    json = JsonConvert.SerializeObject(resp);
                    return (json, false, false);
                }
                err = new Error();
                err.Messaggio = "ERRORE Tipo 0: in base alle informazioni ricevute non è possibile  determinare e garantire la corretta movimentazione della pila";
                err.Bloccante = true;
                json = JsonConvert.SerializeObject(err);
                return (json, false, true);
            }
        }


        /// <summary>Esegue una chiamata di Tipo 1
        /// </summary>
        /// <param name="req">messaggio di richiesta</param>
        /// <returns></returns>
        public static (string json, bool fl_PrintLabel, bool error) ExecRequest1(Request req)
        {
            string json = "";
            if (req.ContenutoNav1A != null && req.ContenutoNav1A.TrackingCode != null)
            {
                var res = StandardResponse1(req.ContenutoNav1A.TrackingCode,req.PosizioneAttuale,req.IdMissione,true);
                if (!res.error)
                    return (res.json,res.fl_PrintLabel,false);
                else
                    return (res.json, false, true);
            }
            else
            {
                using (var db = new ItaltonContext())
                {
                    var err = new Error();
                    
                    //estraggo la prima pila tra quelle non gestite con destinazione RULLIERA 1C
                    var MovUDCDet = db.vw_mov_UDCDetailDestinationGroup.Where(z => (z.flprocessed == null || z.flprocessed == false) && (z.DestinationGroupCode == "GRP_RULLIERA1C")).OrderBy(z => z.IdDettUDCOrder).FirstOrDefault();

                    if (MovUDCDet != null && req.ContenutoPila.TrackingCode == "xxxA33xxx") // polling da fondo rulliera 1C
                    {
                        if (MovUDCDet.Origin == "CSM")
                        {
                            //rispondo con posizionamento per carico manuale da magazzino
                            var resp = new Response();
                            resp.IdResponse = 1;
                            resp.IdMissione = req.IdMissione;
                            resp.TipoIncarico = 1;                      //posizionamento   
                            resp.DestCarico = "CSM";
                            resp.DestScarico = null;
                            resp.CDLOrigine = null;
                            resp.CDLDestinazione = null;
                            resp.OrdineDiLav = null;
                            resp.ErpOrderId = null;
                            resp.NumPezzi = null;
                            resp.Larghezza = null;
                            resp.Lunghezza = null;
                            resp.SpessorePezzo = null;
                            resp.Peso = null;
                            resp.UDC = null;
                            resp.RFID = null;
                            resp.TrackingCode = null;
                            resp.PalletQty = null;
                            resp.StackQty = null;
                            resp.ErpCodicePallet = null;
                            resp.Gruppo = null;
                            resp.Transfer = false;
                            resp.Errore = null;
                            json = JsonConvert.SerializeObject(resp);
                            return (json, false, false);
                        }
                        else
                        {
                            //rispondo con niente da caricare da CSM
                            var resp = new Response();
                            resp.IdResponse = 1;
                            resp.IdMissione = req.IdMissione;
                            resp.TipoIncarico = 0;           //niente da caricare              
                            resp.DestCarico = null;
                            resp.DestScarico = null;
                            resp.CDLOrigine = null;
                            resp.CDLDestinazione = null;
                            resp.OrdineDiLav = null;
                            resp.ErpOrderId = null;
                            resp.NumPezzi = null;
                            resp.Larghezza = null;
                            resp.Lunghezza = null;
                            resp.SpessorePezzo = null;
                            resp.Peso = null;
                            resp.UDC = null;
                            resp.RFID = null;
                            resp.TrackingCode = null;
                            resp.PalletQty = null;
                            resp.StackQty = null;
                            resp.ErpCodicePallet = null;
                            resp.Gruppo = null;
                            resp.Transfer = false;
                            resp.Errore = null;
                            json = JsonConvert.SerializeObject(resp);
                            return (json, false, false);
                        }
                    }

                    if (MovUDCDet == null && req.ContenutoPila.TrackingCode == "xxxA33xxx")
                    {
                        return ("-", false, false);
                    }

                    if (MovUDCDet != null)
                    {
                        //1) verifico se il TrackingCode corrisponde a quello del messaggio di richiesta 
                        if (MovUDCDet.trackingcode == req.ContenutoPila.TrackingCode)
                        {
                            var res = StandardResponse1(req.ContenutoPila.TrackingCode, req.PosizioneAttuale, req.IdMissione);
                            if (!res.error)
                                return (res.json, res.fl_PrintLabel, false);
                            else
                                return (res.json, false, true);
                        }
 
                        //2) se 1) è falsa verifico che la prima pila non gestita abbia origine = CSM
                        if (MovUDCDet.Origin == "CSM")
                        {   
                            //rispondo con posizionamento per carico manuale da magazzino
                            var resp = new Response();
                            resp.IdResponse = 1;
                            resp.IdMissione = req.IdMissione;
                            resp.TipoIncarico = 1;                      //posizionamento   
                            resp.DestCarico = "CSM";
                            resp.DestScarico = null;
                            resp.CDLOrigine = null;
                            resp.CDLDestinazione = null;
                            resp.OrdineDiLav = null;
                            resp.ErpOrderId = null;
                            resp.NumPezzi = null;
                            resp.Larghezza = null;
                            resp.Lunghezza = null;
                            resp.SpessorePezzo = null;
                            resp.Peso = null;
                            resp.UDC = null;
                            resp.RFID = null;
                            resp.TrackingCode = null;
                            resp.PalletQty = null;
                            resp.StackQty = null;
                            resp.ErpCodicePallet = null;
                            resp.Gruppo = null;
                            resp.Transfer = false;
                            resp.Errore = null;
                            json = JsonConvert.SerializeObject(resp);
                            return (json, false, false);
                        }
                        //3) se 1) e 2) sono false, verifico che Destinazione = CSM
                        //ricavo Destinazione della pila presente nella rulliera  tramite il TrackingCode
                        var data = db.vw_mov_UDCDetailDestinationGroup.FirstOrDefault(z => z.trackingcode.ToUpper().Trim() == req.ContenutoPila.TrackingCode.ToUpper().Trim() && (z.flprocessed == null || z.flprocessed == false));
                        if (data==null)
                        {
                            err = new Error();
                            err.Messaggio = "ERRORE: tracking code non trovato";
                            err.Bloccante = true;
                            json = JsonConvert.SerializeObject(err);
                            return (json, false, true);
                        }
                        var DestReq = data.Destination;


                        if (DestReq == "CSM")
                        {
                            //Rispondo con scarico a magazzino e relativa stampa etichetta
                            var resp = new Response();
                            resp.IdResponse = 1;
                            resp.IdMissione = req.IdMissione;
                            resp.TipoIncarico = 4;                       //carico + scarico   
                            resp.DestCarico = "1C";
                            resp.DestScarico = "CSM";
                            resp.CDLOrigine = null;
                            resp.CDLDestinazione = null;
                            resp.OrdineDiLav = null;
                            resp.ErpOrderId = null;
                            resp.NumPezzi = null;
                            resp.Larghezza = null;
                            resp.Lunghezza = null;
                            resp.SpessorePezzo = null;
                            resp.Peso = MovUDCDet.PesoUnitario;
                            resp.UDC = MovUDCDet.UDCCode;
                            resp.RFID = null;
                            resp.TrackingCode = req.ContenutoPila.TrackingCode;
                            resp.PalletQty = null;
                            resp.StackQty = MovUDCDet.StackQty;
                            resp.ErpCodicePallet = null;
                            resp.Gruppo = MovUDCDet.Gruppo;
                            resp.Transfer = false;
                            resp.Errore = null;
                            json = JsonConvert.SerializeObject(resp);
                            return (json, true, false);
                        }
                        //4) se 1), 2) e 3) sono false verifico se appartengono allo stesso orderID
                        //ricavo ErpOrderId della pila presente nella rulliera  tramite il TrackingCode
                        var OrderID = db.mov_UDCDetail.FirstOrDefault(z => z.trackingcode.ToUpper().Trim() == req.ContenutoPila.TrackingCode.ToUpper().Trim()).ErpOrderId;
                        
                        if (MovUDCDet.ErpOrderId == OrderID)
                        {
                            var res = StandardResponse1(req.ContenutoPila.TrackingCode, req.PosizioneAttuale, req.IdMissione);
                            return (res.json, res.fl_PrintLabel, false);
                        }
                    }
                    err = new Error(); 
                    err.Messaggio = "ERRORE: in base alle informazioni ricevute non è possibile  determinare e garantire la corretta movimentazione della pila";
                    err.Bloccante = true;
                    json = JsonConvert.SerializeObject(err);
                    return (json, false, true);    
                }
            }
        }


        /// <summary>Esegue una chiamata di Tipo 2
        /// </summary>
        /// <param name="req">messaggio di richiesta</param>
        /// <returns></returns>
        public static (string json, bool fl_PrintLabel, bool error) ExecRequest2(Request req)
        {
            var err = new Error();
            string json = "";
            if (req.PosizioneAttuale == "CSM" && req.ContenutoPila.TrackingCode == "xxxCSMxxx")
            {
                using (var db = new ItaltonContext())
                {
                    //estraggo la prima pila tra quelle non gestite di mov_UDCMagDetail
                    //var MagDetail = db.mov_UDCMagDetail.Where(z => (z.DtProcessingDate == null)).FirstOrDefault();

                    vw_mov_UDCMagDetail MagDetail = null;
                    //int k = 0;
                    //while (MagDetail == null && k<100)
                    {
                        MagDetail = db.vw_mov_UDCMagDetail.FirstOrDefault();
                        if (MagDetail != null)
                        {
                            var movPhases = GetRemainingPhases((int)MagDetail.ErpOrderId, MagDetail.Origin);

                            //Controllo che tutti i CDL previsti dalle fasi siano attivi
                            var check = CheckCDL(movPhases, MagDetail.UDCMagDetailId, MagDetail.trackingcode);
                            if (check.error)
                            {
                                return (check.json, check.fl_PrintLabel, check.error);
                            }
                            var resp = new Response();
                            resp.IdResponse = 2;
                            resp.IdMissione = req.IdMissione;
                            resp.TipoIncarico = 3;                      //scarico
                            resp.DestCarico = MagDetail.Origin.Trim();
                            resp.DestScarico = MagDetail.Destination.Trim();
                            resp.CDLOrigine = null;
                            resp.CDLDestinazione = null;
                            resp.OrdineDiLav = MagDetail.ErpOrderCode;
                            resp.ErpOrderId = MagDetail.ErpOrderId;
                            resp.NumPezzi = MagDetail.Qty;
                            resp.Larghezza = MagDetail.PanelWidth;
                            resp.Lunghezza = MagDetail.PanelLength;
                            resp.SpessorePezzo = MagDetail.PanelThickness;
                            resp.Peso = MagDetail.PesoUnitario;
                            resp.UDC = MagDetail.UDCCode;
                            resp.RFID = null;
                            resp.TrackingCode = MagDetail.trackingcode;
                            resp.PalletQty = MagDetail.Qty;                    // In questo caso metto uguale a num pezzi perchè siamo in fondo alla rulliera 1C
                            resp.StackQty = null;                                                       
                            resp.ErpCodicePallet = MagDetail.ErpCodicePallet;
                            resp.Gruppo = null;
                            resp.Transfer = false;
                            resp.Errore = null;
                            json = JsonConvert.SerializeObject(resp);
                            return (json, false, false);
                        }
                        else
                        {
                            return ("-", false, false);
                        }    
                        //k++;
                        //Thread.Sleep(1000);
                    }
                    
                }
            }
            else
            {
                err = new Error();
                err.Messaggio = "ERRORE: Messaggio di Tipo 2 errato ";
                err.Bloccante = true;
                json = JsonConvert.SerializeObject(err);
                return (json, false, true);
            }
            
        }

        /// <summary>Esegue una chiamata di Tipo 3
        /// </summary>
        /// <param name="req">messaggio di richiesta</param>
        /// <returns></returns>
        public static (string json, bool fl_PrintLabel, bool error) ExecRequest3(Request req)
        {
            DbOperation dbo = new DbOperation();
            var err = new Error();
            string json = "";
            var resp = new Response();
            using (var db = new ItaltonContext())
            {
                //if (req.PosizioneAttuale == "IMB") //TODO PAOLO 05/06/2023 Da usare solo per test imballo manuale
                //{
                //    req.PosizioneAttuale = "IMBM";
                //}

                var destPacking = db.vw_mov_DestinationPackaging.FirstOrDefault(z => z.trackingcode == req.ContenutoPila.TrackingCode);
                if (destPacking != null)
                {
                    if (req.IngressoUscita == "I")
                    {
                        resp.IdResponse = 3;
                        resp.IdMissione = req.IdMissione;
                        resp.TipoIncarico = 4;   // sentire con fabio cosa gli devo passare in ingresso                                               
                        resp.DestCarico = null;
                        resp.DestScarico = null;
                        resp.CDLOrigine = req.PosizioneAttuale;
                        resp.CDLDestinazione = req.PosizioneAttuale;
                        resp.OrdineDiLav = null;
                        resp.ErpOrderId = req.ContenutoPila.ErpOrderId;
                        resp.NumPezzi = destPacking.Qty;
                        resp.Larghezza = null;
                        resp.Lunghezza = null;
                        resp.SpessorePezzo = null;
                        resp.Peso = destPacking.UnitWeight;
                        resp.UDC = destPacking.UDCCode;
                        resp.RFID = null;
                        resp.TrackingCode = req.ContenutoPila.TrackingCode;
                        resp.PalletQty = destPacking.Qty;
                        resp.PalletQty = null;
                        resp.StackQty = null;
                        resp.StackQty = destPacking.StackQty;
                        resp.ErpCodicePallet = null;
                        resp.Gruppo = null;
                        resp.Transfer = false;
                        resp.Errore = null;

                        //Eseguo storeprocedure mov_sp_insert_mov_tracking_udc
                        int? ErpId = req.ContenutoPila.ErpOrderId;
                        int? ErpIdPianoCaricoId = 0;
                        int? ManualExtractionId = 0;
                        if (destPacking.ErpRigaPianoCaricoID != null)
                            ErpIdPianoCaricoId = destPacking.ErpRigaPianoCaricoID;
                        if (destPacking.ManualExtractionId != null)
                            ManualExtractionId = destPacking.ManualExtractionId;
                        string Dest = req.PosizioneAttuale;
                        string DestOrig = req.PosizioneAttuale;
                        dbo.Exec_mov_sp_insert_mov_tracking_udc(resp.TrackingCode, 1, resp.CDLDestinazione, ErpId, ErpIdPianoCaricoId, ManualExtractionId, "0", "0", (int)resp.NumPezzi, Dest, DestOrig);

                        //serializzo e restituisco la risposta
                        json = JsonConvert.SerializeObject(resp);
                        return (json, false, false);
                    }
                    else
                    {
                        resp.IdResponse = 3;
                        resp.IdMissione = req.IdMissione;
                        resp.TipoIncarico = 4;
                        resp.DestCarico = null;
                        resp.DestScarico = null;
                        resp.CDLOrigine = req.PosizioneAttuale;
                        resp.CDLDestinazione = "MAG";
                        resp.OrdineDiLav = null;
                        resp.ErpOrderId = req.ContenutoPila.ErpOrderId;
                        resp.NumPezzi = req.ContenutoPila.NumPezzi;
                        resp.Larghezza = null;
                        resp.Lunghezza = null;
                        resp.SpessorePezzo = null;
                        resp.Peso = null;
                        resp.UDC = null;
                        resp.RFID = null;
                        resp.TrackingCode = req.ContenutoPila.TrackingCode;
                        resp.PalletQty = req.ContenutoPila.NumPezzi;
                        resp.StackQty = null;
                        resp.ErpCodicePallet = null;
                        resp.Gruppo = null;
                        resp.Transfer = false;
                        resp.Errore = null;

                        //Eseguo storeprocedure mov_sp_insert_mov_tracking_udc
                        int? ErpId = req.ContenutoPila.ErpOrderId;
                        int? ErpIdPianoCaricoId = 0;
                        int? ManualExtractionId = 0;
                        if (destPacking.ErpRigaPianoCaricoID != null)
                            ErpIdPianoCaricoId = destPacking.ErpRigaPianoCaricoID;
                        if (destPacking.ManualExtractionId != null)
                            ManualExtractionId = destPacking.ManualExtractionId;
                        string Dest = "MAG";
                        string DestOrig = "MAG";
                        dbo.Exec_mov_sp_insert_mov_tracking_udc(resp.TrackingCode, 2, resp.CDLDestinazione, ErpId, ErpIdPianoCaricoId, ManualExtractionId, "0", "0", (int)resp.NumPezzi, Dest, DestOrig);

                        //serializzo e restituisco la risposta
                        json = JsonConvert.SerializeObject(resp);
                        return (json, false, false);
                    }
                }
                else
                {
                    return ("", false, true);
                }
            }
        }


        /// <summary>Esegue una chiamata di Tipo 4
        /// </summary>
        /// <param name="req">messaggio di richiesta</param>
        /// <returns></returns>
        public static (string json, bool fl_PrintLabel, bool error) ExecRequest4(Request req)
        {
            DbOperation dbo = new DbOperation();
            var err = new Error();
            string json = "";
            var resp = new Response();
            if (req.IngressoUscita == "I")
            {
                resp.IdResponse = 4;
                resp.IdMissione = req.IdMissione;
                resp.TipoIncarico = 4;   // sentire con fabio cosa gli devo passare in ingresso                                               
                resp.DestCarico = null;
                resp.DestScarico = null;
                resp.CDLOrigine = req.PosizioneAttuale;
                resp.CDLDestinazione = req.PosizioneAttuale;
                resp.OrdineDiLav = null;                                           
                resp.ErpOrderId = req.ContenutoPila.ErpOrderId;
                resp.NumPezzi = req.ContenutoPila.NumPezzi;
                resp.Larghezza = null;     
                resp.Lunghezza = null;     
                resp.SpessorePezzo = null; 
                resp.Peso = null;   
                resp.UDC = null;
                resp.RFID = null;
                resp.TrackingCode = req.ContenutoPila.TrackingCode;
                resp.PalletQty = GetQty4Pallet(req.ContenutoPila.ErpOrderId, req.PosizioneAttuale, req.ContenutoPila.NumPezzi);
                resp.StackQty = null;
                resp.ErpCodicePallet = null; 
                resp.Gruppo = null; 
                resp.Transfer = false;
                resp.Errore = null;

                //Eseguo storeprocedure mov_sp_insert_mov_tracking_udc
                int? ErpId = req.ContenutoPila.ErpOrderId;
                int? ErpIdPianoCaricoId = 0;
                int? ManualExtractionId = 0;
                string Dest = req.PosizioneAttuale;
                string DestOrig = req.PosizioneAttuale;
                dbo.Exec_mov_sp_insert_mov_tracking_udc(resp.TrackingCode, 1, resp.CDLOrigine, ErpId, ErpIdPianoCaricoId, ManualExtractionId, "0", "0", (int)resp.NumPezzi, Dest, DestOrig);

                //serializzo e restituisco la risposta
                json = JsonConvert.SerializeObject(resp);
                return (json, false, false);
            }
            else
            {
                var movPhase = GetNextPhase(req.ContenutoPila.ErpOrderId, req.PosizioneAttuale);
                if (movPhase != null)
                {
                    resp.IdResponse = 4;
                    resp.IdMissione = req.IdMissione;
                    resp.TipoIncarico = 4;   
                    resp.DestCarico = null;
                    resp.DestScarico = null;
                    resp.CDLOrigine = req.PosizioneAttuale;
                    if (!movPhase.WorkCenter.ToUpper().Contains("TERRA"))
                        resp.CDLDestinazione = movPhase.Machine;
                    else
                        resp.CDLDestinazione = movPhase.WorkCenter;
                    resp.OrdineDiLav = null;  
                    resp.ErpOrderId = req.ContenutoPila.ErpOrderId;
                    resp.NumPezzi = req.ContenutoPila.NumPezzi;
                    resp.Larghezza = null;     
                    resp.Lunghezza = null;     
                    resp.SpessorePezzo = null; 
                    resp.Peso = null;   
                    resp.UDC = null;
                    resp.RFID = null;
                    resp.TrackingCode = req.ContenutoPila.TrackingCode;
                    resp.PalletQty = req.ContenutoPila.NumPezzi;
                    resp.StackQty = null;
                    resp.ErpCodicePallet = null; 
                    resp.Gruppo = null; 
                    resp.Transfer = false;
                    resp.Errore = null;

                    //Eseguo storeprocedure mov_sp_insert_mov_tracking_udc
                    int? ErpId = req.ContenutoPila.ErpOrderId;
                    int? ErpIdPianoCaricoId = 0;
                    int? ManualExtractionId = 0;
                    string Dest = resp.CDLDestinazione;
                    string DestOrig = resp.CDLDestinazione;
                    dbo.Exec_mov_sp_insert_mov_tracking_udc(resp.TrackingCode, 2, resp.CDLOrigine, ErpId, ErpIdPianoCaricoId, ManualExtractionId, "0", "0", (int)resp.NumPezzi, Dest, DestOrig);

                    //serializzo e restituisco la risposta
                    json = JsonConvert.SerializeObject(resp);
                    return (json, false, false);
                }
                else
                {
                    err.Messaggio = "ERRORE: Centro di lavoro di destinazione non trovato ";
                    err.Bloccante = true;
                    json = JsonConvert.SerializeObject(err);
                    return (json, false, true);
                }
            }
            
        }


        /// <summary>Crea la riposta standard per una chiamata di Tipo1
        /// </summary>
        /// <param name="trackingCode">chiave di ricerca della prima pila non gestita</param>
        /// <param name="machine"> indica il centro di lavoro (macchinario) di provenienza</param>
        /// <returns></returns>
        private static (string json, bool fl_PrintLabel, bool error) StandardResponse1(string trackingCode, string machine, int idMissione, bool FL_Nav1AFull = false)
        {
            string json = "";
            using (var db = new ItaltonContext())
            {
                var MovUDCDet = db.vw_mov_UDCDetailDestinationGroup.FirstOrDefault(z => z.trackingcode == trackingCode);
                if (MovUDCDet != null)
                {
                    if (MovUDCDet.Destination == "CSM")
                    {
                        //Rispondo con scarico a magazzino e relativa stampa etichetta
                        var resp = new Response();
                        resp.IdResponse = 1;
                        resp.IdMissione = idMissione;
                        if (!FL_Nav1AFull)
                            resp.TipoIncarico = 4;                      //carico + scarico
                        else
                            resp.TipoIncarico = 3;
                        resp.DestCarico = "1C";
                        resp.DestScarico = "CSM";
                        resp.CDLOrigine = null;
                        resp.CDLDestinazione = null;
                        resp.OrdineDiLav = MovUDCDet.ErpOrderCode;
                        //resp.ErpOrderId = MovUDCDet.ErpOrderId;
                        resp.ErpOrderId = GetErpId(MovUDCDet);
                        resp.NumPezzi = MovUDCDet.Qty;
                        resp.Larghezza = MovUDCDet.PanelWidth;
                        resp.Lunghezza = MovUDCDet.PanelLength;
                        resp.SpessorePezzo = MovUDCDet.PanelThickness;
                        resp.Peso = MovUDCDet.PesoUnitario;
                        resp.UDC = MovUDCDet.UDCCode;
                        resp.RFID = MovUDCDet.rfidApplicato;
                        resp.TrackingCode = trackingCode;
                        resp.PalletQty = MovUDCDet.Qty;                                  // In questo caso metto uguale a num pezzi perchè siamo in fondo alla rulliera 1C             
                        resp.StackQty = MovUDCDet.StackQty;
                        resp.ErpCodicePallet = MovUDCDet.ErpCodicePallet;
                        resp.Gruppo = MovUDCDet.Gruppo;
                        resp.Transfer = false;
                        resp.Errore = null;
                        json = JsonConvert.SerializeObject(resp);
                        return (json, true,false);
                    }
                    //else if (MovUDCDet.Destination == "1C")
                    else
                    {
                        var movPhases = GetRemainingPhases((int)MovUDCDet.ErpOrderId, machine);
                        var resp = new Response();
                        //Controllo che tutti i CDL previsti dalle fasi siano attivi
                        var check = CheckCDL(movPhases, MovUDCDet.IdDettUDC, MovUDCDet.trackingcode);
                        if (check.error)
                        {
                            return (check.json, check.fl_PrintLabel,true);
                        }
                        if (movPhases[0].Machine == null)
                        {
                            var err = new Error();
                            err.Messaggio = "Non è stato possibile ricavare una destinazione";
                            err.Bloccante = true;
                            json = JsonConvert.SerializeObject(err);
                            return (json, true, true);
                        }

                        //rispondo con la prima fase (destinazione) da eseguire
                        resp.IdResponse = 1;
                        resp.IdMissione = idMissione;
                        if (!FL_Nav1AFull)
                            resp.TipoIncarico = 4;                      //carico + scarico
                        else
                            resp.TipoIncarico = 3;
                        resp.DestCarico = "1C";
                        resp.DestScarico = movPhases[0].Machine;
                        resp.CDLOrigine = null;
                        resp.CDLDestinazione = null;
                        resp.OrdineDiLav = MovUDCDet.ErpOrderCode;
                        //resp.ErpOrderId = MovUDCDet.ErpOrderId;
                        resp.ErpOrderId = GetErpId(MovUDCDet);
                        resp.NumPezzi = MovUDCDet.Qty;
                        resp.Larghezza = MovUDCDet.PanelWidth;
                        resp.Lunghezza = MovUDCDet.PanelLength;
                        resp.SpessorePezzo = MovUDCDet.PanelThickness;
                        resp.Peso = MovUDCDet.PesoUnitario;
                        resp.UDC = MovUDCDet.UDCCode;
                        resp.RFID = MovUDCDet.rfidApplicato;
                        resp.TrackingCode = MovUDCDet.trackingcode;
                        resp.PalletQty = MovUDCDet.Qty;                                    // In questo caso metto uguale a num pezzi perchè siamo in fondo alla rulliera 1C            
                        resp.StackQty = MovUDCDet.StackQty;
                        resp.ErpCodicePallet = MovUDCDet.ErpCodicePallet;
                        resp.Gruppo = MovUDCDet.Gruppo;
                        resp.Transfer = false;
                        resp.Errore = null;
                        json = JsonConvert.SerializeObject(resp);
                        return (json, false,false);
                    }
                }
                return (null, false,false);
            }

        }



        /// <summary>Crea elenco delle fasi che devono ancora essere eseguite
        /// </summary>
        /// <param name="ErpId">Codice Ordine ErpId</param>
        /// <param name="Machine">Codice macchina relativo alla fase attuale</param>
        /// <returns></returns>
        private static List<mov_Phases> GetRemainingPhases(int ErpId, string Machine)
        {
            List<mov_Phases> res = null;
            //Ricavo l'ordine della mia fase attuale
            int myPhaseOrder = 0;
            using (var db = new ItaltonContext())
            {
                var myPhase = db.mov_Phases.FirstOrDefault(z => z.ErpId == ErpId && z.Machine == Machine);
                if (myPhase != null)
                {
                    myPhaseOrder = (int)myPhase.PhaseOrder;
                }
                //Ricavo elenco delle fasi da eseguire ancora
                res = db.mov_Phases.Where(z => z.ErpId == ErpId && z.PhaseOrder > myPhaseOrder).OrderBy(z => z.PhaseOrder).ToList();
            }
            return res;
        }

        /// <summary>Trova la prossima fase da eseguire
        /// </summary>
        /// <param name="ErpId">Codice Ordine ErpId</param>
        /// <param name="Machine">Codice macchina relativo alla fase attuale</param>
        /// <returns></returns>
        private static mov_Phases GetNextPhase(int ErpId, string Machine)
        {
            var mov_Phases = GetRemainingPhases(ErpId, Machine);
            if (mov_Phases.Count > 0)
                return mov_Phases[0];
            else
                return null;
        }

        /// <summary>Verifica che i Centri di Lavoro successivi siano attivi e funzionanti
        /// </summary>
        /// <param name="movPhases">Elenco delle fasi da eseguire</param>
        /// <param name="idMissione">IdMissione contenuto nella richiesta inviata al MIS</param>
        /// <param name="TrackingCode">TrackingCode della pila</param>
        /// <returns></returns>
        private static (string json, bool error, bool fl_PrintLabel) CheckCDL( List<mov_Phases> movPhases, int idMissione, string TrackingCode)
        {
            var resp = new Response();
            string json;
            using (var db = new ItaltonContext())
            {
                //Controllo che tutti i CDL previsti dalle fasi siano attivi
                foreach (var phase in movPhases)
                {
                    if (phase.WorkCenter != "TERRA")
                    {
                        var DestStatus = db.vw_mov_Destinationstatus.FirstOrDefault(x => x.DestinationCode == phase.Machine);
                        if (DestStatus != null)
                        {
                            //CDL non attivo
                            if (DestStatus.StatusCode != "1")
                            {
                                if (Program.ForceDownload.ToUpper() == "SI")
                                {
                                    // Forzo scarico a magazzino(CSM) con stampa etichetta
                                    resp.IdResponse = 1;
                                    resp.IdMissione = idMissione;
                                    resp.TipoIncarico = 3;
                                    resp.DestCarico = "1C";
                                    resp.DestScarico = "CSM";
                                    resp.OrdineDiLav = null;
                                    resp.ErpOrderId = null;
                                    resp.NumPezzi = null;
                                    resp.Larghezza = null;
                                    resp.Lunghezza = null;
                                    resp.SpessorePezzo = null;
                                    resp.Peso = null;
                                    resp.UDC = null;
                                    resp.RFID = null;
                                    resp.TrackingCode = TrackingCode;
                                    resp.PalletQty = null;
                                    resp.StackQty = null;
                                    resp.ErpCodicePallet = null;
                                    resp.Transfer = false;
                                    resp.Errore = "Scarico forzato a magazzino causato da CDL " + DestStatus.DestinationCode + " fuori servizio";
                                    json = JsonConvert.SerializeObject(resp);
                                    return (json, true, true);
                                }
                                else
                                {
                                    // Blocco della linea di produzione senza stampa etichetta
                                    var err = new Error();
                                    err.Messaggio = "Blocco della linea causato da CDL " + DestStatus.DestinationCode + " fuori servizio";
                                    err.Bloccante = true;
                                    json = JsonConvert.SerializeObject(err);
                                    return (json, true, false);
                                }
                            }
                        }
                        else  //CDL non riconosciuto
                        {
                            // Blocco della linea di produzione senza stampa etichetta
                            var err = new Error();
                            err.Messaggio = "Blocco della linea causato da CDL sconosciuto";
                            err.Bloccante = true;
                            json = JsonConvert.SerializeObject(err);
                            return (json, true, false);
                        }
                    }
                }
                return ("", false,false);   // tutti i CDL sono attivi e funzionanati
            }
        }


        private static int GetQty4Pallet(int ErpId, string Machine, int NumPezzi)
        {
            int res = 0;
            using (var db = new ItaltonContext())
            {
                var phase = db.mov_Phases.FirstOrDefault(z => z.ErpId == ErpId && z.Machine == Machine);
                if (phase != null)
                {
                    res = (int)phase.Qty4Pallet;
                }
            }
            if (res == 0)
                res = NumPezzi;
            return res;
        }

        private static int? GetErpId(vw_mov_UDCDetailDestinationGroup MovUDCDet)
        {
            int? erpId = null;
            if (MovUDCDet.ErpOrderId != null)
            {
                erpId = MovUDCDet.ErpOrderId;
            }
            else if (MovUDCDet.ErpRigaPianoCaricoID != null)
            {
                erpId = MovUDCDet.ErpRigaPianoCaricoID * (-1);
            }
            else if (MovUDCDet.ManualExtractionId != null)
            {
                erpId = MovUDCDet.ManualExtractionId * (-1);
            }
            return erpId;
        }

    }


}
