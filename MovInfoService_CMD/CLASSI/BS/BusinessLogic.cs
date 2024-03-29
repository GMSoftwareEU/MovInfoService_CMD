using MovInfoService.CLASSI.NGTEC.JSON_MODEL;
using MovInfoService_CMD;
using MovInfoService_CMD.CLASSI.JSON_MODEL;
using MovInfoService_CMD.MODEL;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovInfoService.CLASSI.NGTEC.BS
{
    public static class BusinessLogic
    {
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
                return (res.json,res.fl_PrintLabel,false);
            }
            else
            {
                using (var db = new ItaltonContext())
                {
                    var err = new Error();
                    //ricavo ErpOrderId della pila presente nella rulliera  tramite il TrackingCode
                    var OrderID = db.mov_UDCDetail.FirstOrDefault(z => z.trackingcode.ToUpper().Trim() == req.ContenutoPila.TrackingCode.ToUpper().Trim()).ErpOrderId;
                    //ricavo Destinazione della pila presente nella rulliera  tramite il TrackingCode
                    var DestReq = db.mov_UDCDetail.FirstOrDefault(z => z.trackingcode.ToUpper().Trim() == req.ContenutoPila.TrackingCode.ToUpper().Trim()).Destination;


                    //estraggo la prima pila tra quelle non gestite con destinazione RULLIERA 1C
                    var MovUDCDet = db.vw_mov_UDCDetailDestinazionGroup.Where(z => (z.flprocessed == null || z.flprocessed == false) && (z.DestinazionGroupCode == "GRP_RULLIERA1C")).OrderBy(z => z.IdDettUDC).FirstOrDefault();
                    if (MovUDCDet != null)
                    {
                        //1) verifico se il TrackingCode corrisponde a quello del messaggio di richiesta 
                        if (MovUDCDet.trackingcode == req.ContenutoPila.TrackingCode)
                        {
                            var res = StandardResponse1(req.ContenutoPila.TrackingCode, req.PosizioneAttuale, req.IdMissione);
                            return (res.json, res.fl_PrintLabel, false);
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
                            resp.ErpCodicePallet = null;
                            resp.Transfer = false;
                            resp.Errore = null;
                            json = JsonConvert.SerializeObject(resp);
                            return (json, false, false);
                        }
                        //3) se 1) e 2) sono false, verifico che Destinazione = CSM
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
                            resp.Peso = null;
                            resp.UDC = null;
                            resp.RFID = null;
                            resp.TrackingCode = req.ContenutoPila.TrackingCode;
                            resp.PalletQty = null;
                            resp.ErpCodicePallet = null;
                            resp.Transfer = false;
                            resp.Errore = null;
                            json = JsonConvert.SerializeObject(resp);
                            return (json, true, false);
                        }
                        //4) se 1), 2) e 3) sono false verifico se appartengono allo stesso orderID
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

        /// <summary>Crea la riposta standard per una chiamata di Tipo1
        /// </summary>
        /// <param name="trackingCode">chiave di ricerca della prima pila non gestita</param>
        /// <param name="machine"> indica il centro di lavoro (macchinario) di provenienza</param>
        /// <returns></returns>
        private static (string json,bool fl_PrintLabel) StandardResponse1(string trackingCode, string machine, int idMissione, bool FL_Nav1AFull = false)  
        {
            string json = "";
            using (var db = new ItaltonContext())
            {
                //var MovUDCDet = db.mov_UDCDetail.FirstOrDefault(z => z.trackingcode == trackingCode);
                var MovUDCDet = db.vw_mov_UDCDetailDestinazionGroup.FirstOrDefault(z => z.trackingcode == trackingCode && (z.flprocessed == null || z.flprocessed==false));
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
                        resp.OrdineDiLav = null;                                             // TODO: X SIMONE => dove lo rimedio?
                        resp.ErpOrderId = MovUDCDet.ErpOrderId;
                        resp.NumPezzi = MovUDCDet.Qty;
                        resp.Larghezza = MovUDCDet.PanelWidth;
                        resp.Lunghezza = MovUDCDet.PanelLength;
                        resp.SpessorePezzo = MovUDCDet.PanelThickness;
                        resp.Peso = null;                                                  // TODO: X SIMONE => dove lo rimedio?
                        resp.UDC = MovUDCDet.UDCCode;
                        resp.RFID = MovUDCDet.rfidApplicato;
                        resp.TrackingCode = trackingCode;
                        resp.PalletQty = MovUDCDet.StackQty;                                 // TODO: X SIMONE => è corretto?
                        resp.ErpCodicePallet = MovUDCDet.ErpCodicePallet;
                        resp.Transfer = false;
                        resp.Errore = null;
                        json = JsonConvert.SerializeObject(resp);
                        return (json, true);
                    }
                    //else if (MovUDCDet.Destination == "1C")
                    else
                    {
                        // Ricavo l'ordine della mia fase attuale in modo da restituire la prima fase successiva 
                        int myPhaseOrder = 0;
                        var myPhase = db.mov_Phases.FirstOrDefault(z => z.ErpId == MovUDCDet.ErpOrderId && z.Machine == machine);
                        if (myPhase != null)
                        {
                            myPhaseOrder = (int)myPhase.PhaseOrder;
                        }
                        var movPhases = db.mov_Phases.Where(z => z.ErpId == MovUDCDet.ErpOrderId && z.PhaseOrder>myPhaseOrder).OrderBy(z => z.PhaseOrder).ToList();
                        
                        var resp = new Response();
                        //Controllo che tutti i CDL previsti dalle fasi siano attivi
                        var check = CheckCDL(movPhases, MovUDCDet.IdDettUDC, MovUDCDet.trackingcode);
                        if (check.error)
                        {
                            return (check.json, check.fl_PrintLabel);
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
                        resp.OrdineDiLav = null;                                             // TODO: X SIMONE => dove lo rimedio?
                        resp.ErpOrderId = MovUDCDet.ErpOrderId;
                        resp.NumPezzi = MovUDCDet.Qty;
                        resp.Larghezza = MovUDCDet.PanelWidth;
                        resp.Lunghezza = MovUDCDet.PanelLength;
                        resp.SpessorePezzo = MovUDCDet.PanelThickness;
                        resp.Peso = null;                                                  // TODO: X SIMONE => dove lo rimedio?
                        resp.UDC = MovUDCDet.UDCCode;
                        resp.RFID = MovUDCDet.rfidApplicato;
                        resp.TrackingCode = MovUDCDet.trackingcode;
                        resp.PalletQty = MovUDCDet.StackQty;                                 // TODO: X SIMONE => è corretto?
                        resp.ErpCodicePallet = MovUDCDet.ErpCodicePallet;
                        resp.Transfer = false;
                        resp.Errore = null;
                        json = JsonConvert.SerializeObject(resp);
                        return (json, false);
                    }
                }
                return (null, false);
            }
            
        }


        /// <summary>Esegue una chiamata di Tipo 2
        /// </summary>
        /// <param name="req">messaggio di richiesta di Tipo 2</param>
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
                    var MagDetail = db.vw_mov_UDCMagDetail.FirstOrDefault();
                    if (MagDetail != null)
                    {
                        //estraggo la prima pila tra quelle non gestite di mov_UDCDetail
                        var MovUDCDet = db.vw_mov_UDCDetailDestinazionGroup.Where(z => (z.flprocessed == null || z.flprocessed == false) && (z.DestinazionGroupCode == "GRP_RULLIERA1C")).OrderBy(z => z.IdDettUDC).FirstOrDefault();
                        // verifico che il record di mov_UDCMagDetail sia conforme con il primo disponibile di mov_UDCDetail
                        if (MagDetail.ErpOrderId == MovUDCDet.ErpOrderId && MagDetail.ItemCode.Trim() == MovUDCDet.ItemCode.Trim())
                        {
                            // Ricavo l'ordine della mia fase attuale in modo da restituire la prima fase successiva 
                            int myPhaseOrder = 0;
                            var myPhase = db.mov_Phases.FirstOrDefault(z => z.ErpId == MagDetail.ErpOrderId && z.Machine == MagDetail.Origin);
                            //var myPhase = db.mov_Phases.Where(z => z.ErpId == MagDetail.ErpOrderId).OrderBy(x => x.PhaseOrder).FirstOrDefault();
                            if (myPhase != null)
                            {
                                myPhaseOrder = (int)myPhase.PhaseOrder;
                            }
                            var movPhases = db.mov_Phases.Where(z => z.ErpId == MovUDCDet.ErpOrderId && z.PhaseOrder > myPhaseOrder).OrderBy(z => z.PhaseOrder).ToList();

                            //Controllo che tutti i CDL previsti dalle fasi siano attivi
                            var check = CheckCDL(movPhases, MagDetail.UDCMagDetailId, MagDetail.trackingcode);
                            if (check.error)
                            {
                                return (check.json, check.fl_PrintLabel, check.error);
                            }
                            var resp = new Response();
                            resp.IdResponse = 2;
                            resp.IdMissione = req.IdMissione;
                            resp.TipoIncarico = 4;                      //carico + scarico
                            resp.DestCarico = MagDetail.Origin;
                            resp.DestScarico = MovUDCDet.Destination;
                            resp.CDLOrigine = null;
                            resp.CDLDestinazione = null;
                            resp.OrdineDiLav = null;                                             // TODO: X SIMONE => dove lo rimedio?
                            resp.ErpOrderId = MagDetail.ErpOrderId;
                            resp.NumPezzi = MagDetail.Qty;
                            resp.Larghezza = MovUDCDet.PanelWidth;
                            resp.Lunghezza = MovUDCDet.PanelLength;
                            resp.SpessorePezzo = MovUDCDet.PanelThickness;
                            resp.Peso = null;                                                  // TODO: X SIMONE => dove lo rimedio?
                            resp.UDC = MagDetail.UDCCode;
                            resp.RFID = MovUDCDet.rfidApplicato;
                            resp.TrackingCode = MagDetail.trackingcode;
                            resp.PalletQty = MovUDCDet.StackQty;                                 // TODO: X SIMONE => è corretto?
                            resp.ErpCodicePallet = MovUDCDet.ErpCodicePallet;
                            resp.Transfer = false;
                            resp.Errore = null;
                            json = JsonConvert.SerializeObject(resp);
                            return (json, false,false);
                        }
                        else
                        {
                            err = new Error();
                            err.Messaggio = "ERRORE: in base alle informazioni ricevute non è possibile  determinare e garantire la corretta movimentazione della pila";
                            err.Bloccante = true;
                            json = JsonConvert.SerializeObject(err);
                            return (json, false,true);
                        }
                    }
                    else
                    {
                        return ("", false,false);
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

        public static (string json, bool error) ExecRequest4(Request req)
        {
            var err = new Error();
            string json = "";
            using (var db = new ItaltonContext())
            {
                // Ricavo l'ordine della mia fase attuale in modo da restituire la prima fase successiva 
                int myPhaseOrder = 0;
                var myPhase = db.mov_Phases.FirstOrDefault(z => z.ErpId == req.ContenutoPila.ErpOrderId && z.Machine == req.PosizioneAttuale);
                if (myPhase != null)
                {
                    myPhaseOrder = (int)myPhase.PhaseOrder;
                }
                var movPhases = db.mov_Phases.Where(z => z.ErpId == req.ContenutoPila.ErpOrderId && z.PhaseOrder > myPhaseOrder).OrderBy(z => z.PhaseOrder).FirstOrDefault();
                if (movPhases != null)
                {
                    //rispondo con la prima fase (destinazione) da eseguire
                    var resp = new Response();
                    resp.IdResponse = 4;
                    resp.IdMissione = req.IdMissione;
                    resp.TipoIncarico = 4;                                                //carico + scarico
                    resp.DestCarico = null;
                    resp.DestScarico = null;
                    resp.CDLOrigine = req.PosizioneAttuale;
                    resp.CDLDestinazione = movPhases.Machine;
                    resp.OrdineDiLav = null;                                             // TODO: X SIMONE => dove lo rimedio?
                    resp.ErpOrderId = movPhases.ErpId;
                    resp.NumPezzi = req.ContenutoPila.NumPezzi;
                    resp.Larghezza = null;
                    resp.Lunghezza = null;
                    resp.SpessorePezzo = null;
                    resp.Peso = null;                                                  // TODO: X SIMONE => dove lo rimedio?
                    resp.UDC = null;
                    resp.RFID = null;
                    resp.TrackingCode = req.ContenutoPila.TrackingCode;
                    resp.PalletQty = null;                                             
                    resp.ErpCodicePallet = null;
                    resp.Transfer = false;
                    resp.Errore = null;

                    json = JsonConvert.SerializeObject(resp);
                    return (json, false);
                }
                else
                {
                    err.Messaggio = "ERRORE: Centro di lavoro di destinazione non trovato ";
                    err.Bloccante = true;
                    json = JsonConvert.SerializeObject(err);
                    return (json, true);
                }
            }
        }


        private static (string json, bool error, bool fl_PrintLabel) CheckCDL( List<mov_Phases> movPhases, int idMissione, string TrackingCode)
        {
            var resp = new Response();
            string json;
            using (var db = new ItaltonContext())
            {
                //Controllo che tutti i CDL previsti dalle fasi siano attivi
                foreach (var phase in movPhases)
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
                                resp.OrdineDiLav = null;                                            // TODO: X SIMONE => dove lo rimedio?
                                resp.ErpOrderId = null;
                                resp.NumPezzi = null;
                                resp.Larghezza = null;
                                resp.Lunghezza = null;
                                resp.SpessorePezzo = null;
                                resp.Peso = null;                                                    // TODO: X SIMONE => dove lo rimedio?
                                resp.UDC = null;
                                resp.RFID = null;
                                resp.TrackingCode = TrackingCode;
                                resp.PalletQty = null;                                              // TODO: X SIMONE => è corretto?
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
                        return (json, true,false);
                    }
                }
                return ("", false,false);   // tutti i CDL sono attivi e funzionanati
            }
        }

    }


}
