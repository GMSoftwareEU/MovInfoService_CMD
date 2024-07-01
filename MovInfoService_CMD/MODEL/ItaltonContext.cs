using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace MovInfoService_CMD.MODEL
{
    public partial class ItaltonContext : DbContext
    {
        public ItaltonContext()
            : base("name=ItaltonContext")
        {
        }

        public virtual DbSet<C_mov_UDCProduced_obsoleta> C_mov_UDCProduced_obsoleta { get; set; }
        public virtual DbSet<C_mov_UDCSingulDetail_obsoleta> C_mov_UDCSingulDetail_obsoleta { get; set; }
        public virtual DbSet<anag_articoli> anag_articoli { get; set; }
        public virtual DbSet<anag_macchine> anag_macchine { get; set; }
        public virtual DbSet<aree_macchine> aree_macchine { get; set; }
        public virtual DbSet<commesse_001> commesse_001 { get; set; }
        public virtual DbSet<cvm_pos_1_in> cvm_pos_1_in { get; set; }
        public virtual DbSet<cvm_pos_1_in_storico> cvm_pos_1_in_storico { get; set; }
        public virtual DbSet<cvm_pos_1_out> cvm_pos_1_out { get; set; }
        public virtual DbSet<cvm_pos_1_park> cvm_pos_1_park { get; set; }
        public virtual DbSet<cvm_rfid_applicato> cvm_rfid_applicato { get; set; }
        public virtual DbSet<cvm_rfid_posiz_uscita> cvm_rfid_posiz_uscita { get; set; }
        public virtual DbSet<cvm_sez_todo_001> cvm_sez_todo_001 { get; set; }
        public virtual DbSet<logaut_errori> logaut_errori { get; set; }
        public virtual DbSet<logaut_listediprelievo> logaut_listediprelievo { get; set; }
        public virtual DbSet<logaut_movimenti> logaut_movimenti { get; set; }
        public virtual DbSet<logaut_udcinuscita_storico> logaut_udcinuscita_storico { get; set; }
        public virtual DbSet<mac_consumi_001> mac_consumi_001 { get; set; }
        public virtual DbSet<mac_manut_disp> mac_manut_disp { get; set; }
        public virtual DbSet<mac_manut_storico> mac_manut_storico { get; set; }
        public virtual DbSet<mac_produzioni> mac_produzioni { get; set; }
        public virtual DbSet<mac_sottotipo_evento> mac_sottotipo_evento { get; set; }
        public virtual DbSet<MachineParameters> MachineParameters { get; set; }
        public virtual DbSet<mat_prima_pos_1_in> mat_prima_pos_1_in { get; set; }
        public virtual DbSet<mat_prima_pos_1_out> mat_prima_pos_1_out { get; set; }
        public virtual DbSet<mat_prima_pos_2_in> mat_prima_pos_2_in { get; set; }
        public virtual DbSet<mat_prima_pos_2_out> mat_prima_pos_2_out { get; set; }
        public virtual DbSet<mat_prima_pos_3_in> mat_prima_pos_3_in { get; set; }
        public virtual DbSet<mat_prima_pos_3_out> mat_prima_pos_3_out { get; set; }
        public virtual DbSet<mov_DestinationGroupCapacity> mov_DestinationGroupCapacity { get; set; }
        public virtual DbSet<mov_DestinationStatus> mov_DestinationStatus { get; set; }
        public virtual DbSet<mov_Label> mov_Label { get; set; }
        public virtual DbSet<mov_LabelType> mov_LabelType { get; set; }
        public virtual DbSet<mov_PhaseMaterials> mov_PhaseMaterials { get; set; }
        public virtual DbSet<mov_Phases> mov_Phases { get; set; }
        public virtual DbSet<mov_ProductionOrders> mov_ProductionOrders { get; set; }
        public virtual DbSet<mov_Status> mov_Status { get; set; }
        public virtual DbSet<mov_Tracking_log> mov_Tracking_log { get; set; }
        public virtual DbSet<mov_Tracking_udc> mov_Tracking_udc { get; set; }
        public virtual DbSet<mov_UDCDetail> mov_UDCDetail { get; set; }
        public virtual DbSet<mov_UDCMagDetail> mov_UDCMagDetail { get; set; }
        public virtual DbSet<ola_log> ola_log { get; set; }
        public virtual DbSet<ola_messages> ola_messages { get; set; }
        public virtual DbSet<par_tbldefaultparameters_calandra> par_tbldefaultparameters_calandra { get; set; }
        public virtual DbSet<par_tbldefaultparameters_levigatrice> par_tbldefaultparameters_levigatrice { get; set; }
        public virtual DbSet<par_tbldefaultrecipes_levigatrice> par_tbldefaultrecipes_levigatrice { get; set; }
        public virtual DbSet<par_tblparameterscode> par_tblparameterscode { get; set; }
        public virtual DbSet<par_tblproject> par_tblproject { get; set; }
        public virtual DbSet<rfid_global> rfid_global { get; set; }
        public virtual DbSet<rfid_global_error> rfid_global_error { get; set; }
        public virtual DbSet<stato_ordini_001> stato_ordini_001 { get; set; }
        public virtual DbSet<tb_LabelPrinterSpooler> tb_LabelPrinterSpooler { get; set; }
        public virtual DbSet<tblbasketnextjob> tblbasketnextjob { get; set; }
        public virtual DbSet<tblchangedsettings> tblchangedsettings { get; set; }
        public virtual DbSet<tblevents> tblevents { get; set; }
        public virtual DbSet<tblevents_statusChanged> tblevents_statusChanged { get; set; }
        public virtual DbSet<tblprioritycover> tblprioritycover { get; set; }
        public virtual DbSet<tblpriorityhoney> tblpriorityhoney { get; set; }
        public virtual DbSet<tblprioritylath> tblprioritylath { get; set; }
        public virtual DbSet<tbltodo> tbltodo { get; set; }
        public virtual DbSet<tbltodo_storico> tbltodo_storico { get; set; }
        public virtual DbSet<tbludcexit> tbludcexit { get; set; }
        public virtual DbSet<tbludcproduce> tbludcproduce { get; set; }
        public virtual DbSet<C_cvm_sez_todo_001_old> C_cvm_sez_todo_001_old { get; set; }
        public virtual DbSet<C_mov_Cdl_obsoleta> C_mov_Cdl_obsoleta { get; set; }
        public virtual DbSet<C_mov_LabelParams_obsoleta> C_mov_LabelParams_obsoleta { get; set; }
        public virtual DbSet<logaut_udciningresso_storico> logaut_udciningresso_storico { get; set; }
        public virtual DbSet<mac_tipo_evento> mac_tipo_evento { get; set; }
        public virtual DbSet<mov_UDCLoadLocationRequest> mov_UDCLoadLocationRequest { get; set; }
        public virtual DbSet<mov_UDCQtyChangeEvents> mov_UDCQtyChangeEvents { get; set; }
        public virtual DbSet<par_tblprojectdefaultparameters> par_tblprojectdefaultparameters { get; set; }
        public virtual DbSet<stato_ordini_001_StatusChange> stato_ordini_001_StatusChange { get; set; }
        public virtual DbSet<tblelectric> tblelectric { get; set; }
        public virtual DbSet<tblparameters> tblparameters { get; set; }
        public virtual DbSet<InfoService_vw_Destinazione> InfoService_vw_Destinazione { get; set; }
        public virtual DbSet<mac_consumi_001_view> mac_consumi_001_view { get; set; }
        public virtual DbSet<mac_eventi_001_view> mac_eventi_001_view { get; set; }
        public virtual DbSet<vw_cvm_sez_todo_001> vw_cvm_sez_todo_001 { get; set; }
        public virtual DbSet<vw_LabelData> vw_LabelData { get; set; }
        public virtual DbSet<vw_mac_consumi_001_WIP> vw_mac_consumi_001_WIP { get; set; }
        public virtual DbSet<vw_mov_cdl> vw_mov_cdl { get; set; }
        public virtual DbSet<vw_mov_DestinationCode> vw_mov_DestinationCode { get; set; }
        public virtual DbSet<vw_mov_DestinationGroupCapacity> vw_mov_DestinationGroupCapacity { get; set; }
        public virtual DbSet<vw_mov_Destinationgroupdestinationstatus> vw_mov_Destinationgroupdestinationstatus { get; set; }
        public virtual DbSet<vw_mov_DestinationPackaging> vw_mov_DestinationPackaging { get; set; }
        public virtual DbSet<vw_mov_DestinationPrinter> vw_mov_DestinationPrinter { get; set; }
        public virtual DbSet<vw_mov_Destinationstatus> vw_mov_Destinationstatus { get; set; }
        public virtual DbSet<vw_mov_SlotOccupati> vw_mov_SlotOccupati { get; set; }
        public virtual DbSet<vw_mov_SlotOccupatiDettaglio> vw_mov_SlotOccupatiDettaglio { get; set; }
        public virtual DbSet<vw_mov_status> vw_mov_status { get; set; }
        public virtual DbSet<vw_mov_UDCDetailDestinationGroup> vw_mov_UDCDetailDestinationGroup { get; set; }
        public virtual DbSet<vw_mov_UDCMagDetail> vw_mov_UDCMagDetail { get; set; }
        public virtual DbSet<vw_mov_UDCQuantity> vw_mov_UDCQuantity { get; set; }
        public virtual DbSet<vw_ProduzioniCalandra> vw_ProduzioniCalandra { get; set; }
        public virtual DbSet<vw_ProduzioniLevigatrice> vw_ProduzioniLevigatrice { get; set; }
        public virtual DbSet<vw_ProduzioniSezionatrice1> vw_ProduzioniSezionatrice1 { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<C_mov_UDCSingulDetail_obsoleta>()
                .Property(e => e.Key_General)
                .IsUnicode(false);

            modelBuilder.Entity<anag_articoli>()
                .Property(e => e.strCodProd)
                .IsUnicode(false);

            modelBuilder.Entity<anag_articoli>()
                .Property(e => e.peso)
                .HasPrecision(18, 3);

            modelBuilder.Entity<anag_macchine>()
                .Property(e => e.desc_macchina)
                .IsUnicode(false);

            modelBuilder.Entity<anag_macchine>()
                .Property(e => e.s_cod_macchina)
                .IsUnicode(false);

            modelBuilder.Entity<aree_macchine>()
                .Property(e => e.Descrittivo)
                .IsUnicode(false);

            modelBuilder.Entity<commesse_001>()
                .Property(e => e.dtDateOfModify)
                .HasPrecision(0);

            modelBuilder.Entity<commesse_001>()
                .Property(e => e.dtDateOfDelivery)
                .HasPrecision(0);

            modelBuilder.Entity<commesse_001>()
                .Property(e => e.dtDateStartWork)
                .HasPrecision(0);

            modelBuilder.Entity<commesse_001>()
                .Property(e => e.dtDateEndWork)
                .HasPrecision(0);

            modelBuilder.Entity<commesse_001>()
                .Property(e => e.strCode)
                .IsUnicode(false);

            modelBuilder.Entity<commesse_001>()
                .Property(e => e.strDescription)
                .IsUnicode(false);

            modelBuilder.Entity<commesse_001>()
                .Property(e => e.strCodStrip1)
                .IsUnicode(false);

            modelBuilder.Entity<commesse_001>()
                .Property(e => e.strCodStrip2)
                .IsUnicode(false);

            modelBuilder.Entity<commesse_001>()
                .Property(e => e.strCodStrip3)
                .IsUnicode(false);

            modelBuilder.Entity<commesse_001>()
                .Property(e => e.strCodStrip4)
                .IsUnicode(false);

            modelBuilder.Entity<commesse_001>()
                .Property(e => e.strCodStrip5)
                .IsUnicode(false);

            modelBuilder.Entity<commesse_001>()
                .Property(e => e.strCodStrip6)
                .IsUnicode(false);

            modelBuilder.Entity<commesse_001>()
                .Property(e => e.strCodStrip7)
                .IsUnicode(false);

            modelBuilder.Entity<commesse_001>()
                .Property(e => e.strCodStrip8)
                .IsUnicode(false);

            modelBuilder.Entity<commesse_001>()
                .Property(e => e.strCodStrip9)
                .IsUnicode(false);

            modelBuilder.Entity<commesse_001>()
                .Property(e => e.strCoverUpCode)
                .IsUnicode(false);

            modelBuilder.Entity<commesse_001>()
                .Property(e => e.strCoverDwCode)
                .IsUnicode(false);

            modelBuilder.Entity<commesse_001>()
                .Property(e => e.strCodProd_Pos_1_1)
                .IsUnicode(false);

            modelBuilder.Entity<commesse_001>()
                .Property(e => e.strCodProd_Pos_1_2)
                .IsUnicode(false);

            modelBuilder.Entity<commesse_001>()
                .Property(e => e.strCodProd_Pos_1_3)
                .IsUnicode(false);

            modelBuilder.Entity<commesse_001>()
                .Property(e => e.strCodProd_Pos_1_4)
                .IsUnicode(false);

            modelBuilder.Entity<commesse_001>()
                .Property(e => e.strCodProd_Pos_1_5)
                .IsUnicode(false);

            modelBuilder.Entity<commesse_001>()
                .Property(e => e.strCodProd_Pos_2_1)
                .IsUnicode(false);

            modelBuilder.Entity<commesse_001>()
                .Property(e => e.strCodProd_Pos_2_2)
                .IsUnicode(false);

            modelBuilder.Entity<commesse_001>()
                .Property(e => e.strCodProd_Pos_2_3)
                .IsUnicode(false);

            modelBuilder.Entity<commesse_001>()
                .Property(e => e.strCodProd_Pos_2_4)
                .IsUnicode(false);

            modelBuilder.Entity<commesse_001>()
                .Property(e => e.strCodProd_Pos_2_5)
                .IsUnicode(false);

            modelBuilder.Entity<commesse_001>()
                .Property(e => e.strCodHoney)
                .IsUnicode(false);

            modelBuilder.Entity<commesse_001>()
                .Property(e => e.ProjectCode)
                .IsUnicode(false);

            modelBuilder.Entity<commesse_001>()
                .Property(e => e.CodArt)
                .IsUnicode(false);

            modelBuilder.Entity<cvm_pos_1_in>()
                .Property(e => e.Key_General)
                .IsUnicode(false);

            modelBuilder.Entity<cvm_pos_1_in>()
                .Property(e => e.DateModify)
                .HasPrecision(0);

            modelBuilder.Entity<cvm_pos_1_in_storico>()
                .Property(e => e.Key_General)
                .IsUnicode(false);

            modelBuilder.Entity<cvm_pos_1_in_storico>()
                .Property(e => e.DateModify)
                .HasPrecision(0);

            modelBuilder.Entity<cvm_pos_1_out>()
                .Property(e => e.Key_General)
                .IsUnicode(false);

            modelBuilder.Entity<cvm_pos_1_out>()
                .Property(e => e.DateModify)
                .HasPrecision(0);

            modelBuilder.Entity<cvm_pos_1_out>()
                .Property(e => e.ErroreSagoma)
                .IsUnicode(false);

            modelBuilder.Entity<cvm_pos_1_park>()
                .Property(e => e.ID_Ola)
                .IsUnicode(false);

            modelBuilder.Entity<cvm_pos_1_park>()
                .Property(e => e.ID_Fase)
                .IsUnicode(false);

            modelBuilder.Entity<cvm_pos_1_park>()
                .Property(e => e.Causale)
                .IsUnicode(false);

            modelBuilder.Entity<cvm_pos_1_park>()
                .Property(e => e.Key_General)
                .IsUnicode(false);

            modelBuilder.Entity<cvm_pos_1_park>()
                .Property(e => e.ErroreSagoma)
                .IsUnicode(false);

            modelBuilder.Entity<cvm_pos_1_park>()
                .Property(e => e.DataModifica)
                .HasPrecision(0);

            modelBuilder.Entity<cvm_rfid_applicato>()
                .Property(e => e.Key_General)
                .IsUnicode(false);

            modelBuilder.Entity<cvm_rfid_applicato>()
                .Property(e => e.codice_rfid)
                .IsUnicode(false);

            modelBuilder.Entity<cvm_rfid_applicato>()
                .Property(e => e.trackingcode)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<cvm_rfid_posiz_uscita>()
                .Property(e => e.ID_Ola)
                .IsUnicode(false);

            modelBuilder.Entity<cvm_rfid_posiz_uscita>()
                .Property(e => e.ID_Fase)
                .IsUnicode(false);

            modelBuilder.Entity<cvm_rfid_posiz_uscita>()
                .Property(e => e.Key_General)
                .IsUnicode(false);

            modelBuilder.Entity<cvm_rfid_posiz_uscita>()
                .Property(e => e.codice_rfid)
                .IsUnicode(false);

            modelBuilder.Entity<cvm_sez_todo_001>()
                .Property(e => e.ID_OLA)
                .IsUnicode(false);

            modelBuilder.Entity<cvm_sez_todo_001>()
                .Property(e => e.ID_Fase)
                .IsUnicode(false);

            modelBuilder.Entity<cvm_sez_todo_001>()
                .Property(e => e.strCodProd_Pos_1_1)
                .IsUnicode(false);

            modelBuilder.Entity<cvm_sez_todo_001>()
                .Property(e => e.strCodProd_Pos_1_2)
                .IsUnicode(false);

            modelBuilder.Entity<cvm_sez_todo_001>()
                .Property(e => e.strCodProd_Pos_1_3)
                .IsUnicode(false);

            modelBuilder.Entity<cvm_sez_todo_001>()
                .Property(e => e.strCodProd_Pos_1_4)
                .IsUnicode(false);

            modelBuilder.Entity<cvm_sez_todo_001>()
                .Property(e => e.strCodProd_Pos_1_5)
                .IsUnicode(false);

            modelBuilder.Entity<cvm_sez_todo_001>()
                .Property(e => e.strCodProd_Pos_2_1)
                .IsUnicode(false);

            modelBuilder.Entity<cvm_sez_todo_001>()
                .Property(e => e.strCodProd_Pos_2_2)
                .IsUnicode(false);

            modelBuilder.Entity<cvm_sez_todo_001>()
                .Property(e => e.strCodProd_Pos_2_3)
                .IsUnicode(false);

            modelBuilder.Entity<cvm_sez_todo_001>()
                .Property(e => e.strCodProd_Pos_2_4)
                .IsUnicode(false);

            modelBuilder.Entity<cvm_sez_todo_001>()
                .Property(e => e.strCodProd_Pos_2_5)
                .IsUnicode(false);

            modelBuilder.Entity<logaut_errori>()
                .Property(e => e.Descrizione)
                .IsUnicode(false);

            modelBuilder.Entity<logaut_listediprelievo>()
                .Property(e => e.NumeroLista)
                .IsUnicode(false);

            modelBuilder.Entity<logaut_listediprelievo>()
                .Property(e => e.UDC)
                .IsUnicode(false);

            modelBuilder.Entity<logaut_listediprelievo>()
                .Property(e => e.DataOraInserimento)
                .HasPrecision(0);

            modelBuilder.Entity<logaut_listediprelievo>()
                .Property(e => e.DataOraElaborazione)
                .HasPrecision(0);

            modelBuilder.Entity<logaut_movimenti>()
                .Property(e => e.DataOra)
                .HasPrecision(0);

            modelBuilder.Entity<logaut_movimenti>()
                .Property(e => e.Tipo)
                .IsUnicode(false);

            modelBuilder.Entity<logaut_movimenti>()
                .Property(e => e.UDC)
                .IsUnicode(false);

            modelBuilder.Entity<logaut_movimenti>()
                .Property(e => e.ErroreSagoma)
                .IsUnicode(false);

            modelBuilder.Entity<logaut_movimenti>()
                .Property(e => e.NumeroLista)
                .IsUnicode(false);

            modelBuilder.Entity<logaut_movimenti>()
                .Property(e => e.DataOraInserimento)
                .HasPrecision(0);

            modelBuilder.Entity<logaut_movimenti>()
                .Property(e => e.DataOraElaborazione)
                .HasPrecision(0);

            modelBuilder.Entity<logaut_movimenti>()
                .Property(e => e.Posizione)
                .IsUnicode(false);

            modelBuilder.Entity<logaut_udcinuscita_storico>()
                .Property(e => e.UDC)
                .IsUnicode(false);

            modelBuilder.Entity<logaut_udcinuscita_storico>()
                .Property(e => e.Stato)
                .IsUnicode(false);

            modelBuilder.Entity<logaut_udcinuscita_storico>()
                .Property(e => e.DataModifica)
                .HasPrecision(0);

            modelBuilder.Entity<logaut_udcinuscita_storico>()
                .Property(e => e.UtenteModifica)
                .IsUnicode(false);

            modelBuilder.Entity<mac_consumi_001>()
                .Property(e => e.ID_Ola)
                .IsUnicode(false);

            modelBuilder.Entity<mac_consumi_001>()
                .Property(e => e.ID_Fase)
                .IsUnicode(false);

            modelBuilder.Entity<mac_consumi_001>()
                .Property(e => e.Testo_Udc)
                .IsUnicode(false);

            modelBuilder.Entity<mac_consumi_001>()
                .Property(e => e.strMaterialCode)
                .IsUnicode(false);

            modelBuilder.Entity<mac_consumi_001>()
                .Property(e => e.data_ora_evento)
                .HasPrecision(0);

            modelBuilder.Entity<mac_manut_disp>()
                .Property(e => e.abilitato)
                .IsUnicode(false);

            modelBuilder.Entity<mac_manut_disp>()
                .Property(e => e.zona)
                .IsUnicode(false);

            modelBuilder.Entity<mac_manut_disp>()
                .Property(e => e.seriale)
                .IsUnicode(false);

            modelBuilder.Entity<mac_manut_disp>()
                .Property(e => e.descrizione)
                .IsUnicode(false);

            modelBuilder.Entity<mac_manut_storico>()
                .Property(e => e.data_ora)
                .HasPrecision(0);

            modelBuilder.Entity<mac_manut_storico>()
                .Property(e => e.DESCR)
                .IsUnicode(false);

            modelBuilder.Entity<mac_produzioni>()
                .Property(e => e.ID_Ola)
                .IsUnicode(false);

            modelBuilder.Entity<mac_produzioni>()
                .Property(e => e.ID_Fase)
                .IsUnicode(false);

            modelBuilder.Entity<mac_produzioni>()
                .Property(e => e.Data_Ultima_Modifica)
                .HasPrecision(0);

            modelBuilder.Entity<mac_sottotipo_evento>()
                .Property(e => e.descr_sottotipo_evento)
                .IsUnicode(false);

            modelBuilder.Entity<mat_prima_pos_1_in>()
                .Property(e => e.Testo_Udc)
                .IsUnicode(false);

            modelBuilder.Entity<mat_prima_pos_1_in>()
                .Property(e => e.strMaterialCode)
                .IsUnicode(false);

            modelBuilder.Entity<mat_prima_pos_1_in>()
                .Property(e => e.dtInsertDate)
                .HasPrecision(0);

            modelBuilder.Entity<mat_prima_pos_1_in>()
                .Property(e => e.dtProcessingDate)
                .HasPrecision(0);

            modelBuilder.Entity<mat_prima_pos_1_out>()
                .Property(e => e.Testo_Udc)
                .IsUnicode(false);

            modelBuilder.Entity<mat_prima_pos_1_out>()
                .Property(e => e.strMaterialCode)
                .IsUnicode(false);

            modelBuilder.Entity<mat_prima_pos_1_out>()
                .Property(e => e.dtInsertDate)
                .HasPrecision(0);

            modelBuilder.Entity<mat_prima_pos_1_out>()
                .Property(e => e.dtProcessingDate)
                .HasPrecision(0);

            modelBuilder.Entity<mat_prima_pos_1_out>()
                .Property(e => e.dDataInvioImag)
                .HasPrecision(0);

            modelBuilder.Entity<mat_prima_pos_2_in>()
                .Property(e => e.Testo_Udc)
                .IsUnicode(false);

            modelBuilder.Entity<mat_prima_pos_2_in>()
                .Property(e => e.strMaterialCode)
                .IsUnicode(false);

            modelBuilder.Entity<mat_prima_pos_2_in>()
                .Property(e => e.dtInsertDate)
                .HasPrecision(0);

            modelBuilder.Entity<mat_prima_pos_2_in>()
                .Property(e => e.dtProcessingDate)
                .HasPrecision(0);

            modelBuilder.Entity<mat_prima_pos_2_out>()
                .Property(e => e.Testo_Udc)
                .IsUnicode(false);

            modelBuilder.Entity<mat_prima_pos_2_out>()
                .Property(e => e.strMaterialCode)
                .IsUnicode(false);

            modelBuilder.Entity<mat_prima_pos_2_out>()
                .Property(e => e.dtInsertDate)
                .HasPrecision(0);

            modelBuilder.Entity<mat_prima_pos_2_out>()
                .Property(e => e.dtProcessingDate)
                .HasPrecision(0);

            modelBuilder.Entity<mat_prima_pos_2_out>()
                .Property(e => e.dDataInvioImag)
                .HasPrecision(0);

            modelBuilder.Entity<mat_prima_pos_3_in>()
                .Property(e => e.Testo_Udc)
                .IsUnicode(false);

            modelBuilder.Entity<mat_prima_pos_3_in>()
                .Property(e => e.strMaterialCode)
                .IsUnicode(false);

            modelBuilder.Entity<mat_prima_pos_3_in>()
                .Property(e => e.dtInsertDate)
                .HasPrecision(0);

            modelBuilder.Entity<mat_prima_pos_3_in>()
                .Property(e => e.dtProcessingDate)
                .HasPrecision(0);

            modelBuilder.Entity<mat_prima_pos_3_out>()
                .Property(e => e.Testo_UDC)
                .IsUnicode(false);

            modelBuilder.Entity<mat_prima_pos_3_out>()
                .Property(e => e.strMaterialCode)
                .IsUnicode(false);

            modelBuilder.Entity<mat_prima_pos_3_out>()
                .Property(e => e.dtInsertDate)
                .HasPrecision(0);

            modelBuilder.Entity<mat_prima_pos_3_out>()
                .Property(e => e.dtProcessingDate)
                .HasPrecision(0);

            modelBuilder.Entity<mat_prima_pos_3_out>()
                .Property(e => e.dDataInvioImag)
                .HasPrecision(0);

            modelBuilder.Entity<mov_DestinationGroupCapacity>()
                .HasMany(e => e.mov_DestinationStatus)
                .WithOptional(e => e.mov_DestinationGroupCapacity)
                .HasForeignKey(e => e.DestinationGroupCapacity);

            modelBuilder.Entity<mov_DestinationStatus>()
                .Property(e => e.DestinationCodeCVM)
                .IsFixedLength();

            modelBuilder.Entity<mov_Label>()
                .Property(e => e.Quantity)
                .IsFixedLength();

            modelBuilder.Entity<mov_Label>()
                .HasMany(e => e.tb_LabelPrinterSpooler)
                .WithRequired(e => e.mov_Label)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<mov_PhaseMaterials>()
                .Property(e => e.MaterialItemCodeLenght)
                .HasPrecision(18, 3);

            modelBuilder.Entity<mov_PhaseMaterials>()
                .Property(e => e.MaterialItemCodeWidth)
                .HasPrecision(18, 3);

            modelBuilder.Entity<mov_PhaseMaterials>()
                .Property(e => e.PesoUnitario)
                .HasPrecision(18, 3);

            modelBuilder.Entity<mov_ProductionOrders>()
                .Property(e => e.ItemCodeLenght)
                .HasPrecision(18, 3);

            modelBuilder.Entity<mov_ProductionOrders>()
                .Property(e => e.ItemCodeWidth)
                .HasPrecision(18, 3);

            modelBuilder.Entity<mov_ProductionOrders>()
                .Property(e => e.ItemCodeThickness)
                .HasPrecision(18, 3);

            modelBuilder.Entity<mov_ProductionOrders>()
                .Property(e => e.PesoUnitario)
                .HasPrecision(18, 3);

            modelBuilder.Entity<mov_Tracking_log>()
                .Property(e => e.Key_General)
                .IsUnicode(false);

            modelBuilder.Entity<mov_Tracking_log>()
                .Property(e => e.trackingcode)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<mov_Tracking_log>()
                .Property(e => e.Destination)
                .IsUnicode(false);

            modelBuilder.Entity<mov_Tracking_log>()
                .Property(e => e.UDCCode)
                .IsUnicode(false);

            modelBuilder.Entity<mov_Tracking_log>()
                .Property(e => e.CallerPosition)
                .IsUnicode(false);

            modelBuilder.Entity<mov_Tracking_udc>()
                .Property(e => e.trackingcode)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<mov_Tracking_udc>()
                .Property(e => e.CdlOrigine)
                .IsUnicode(false);

            modelBuilder.Entity<mov_Tracking_udc>()
                .Property(e => e.extrainfo)
                .IsUnicode(false);

            modelBuilder.Entity<mov_UDCDetail>()
                .Property(e => e.ItemCode)
                .IsFixedLength();

            modelBuilder.Entity<mov_UDCDetail>()
                .Property(e => e.ParentUdc)
                .IsUnicode(false);

            modelBuilder.Entity<mov_UDCDetail>()
                .Property(e => e.rfidApplicato)
                .IsUnicode(false);

            modelBuilder.Entity<mov_UDCDetail>()
                .Property(e => e.trackingcode)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<mov_UDCDetail>()
                .Property(e => e.trackingcode_dest)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<mov_UDCDetail>()
                .Property(e => e.OriginalDestination)
                .IsUnicode(false);

            modelBuilder.Entity<mov_UDCMagDetail>()
                .Property(e => e.trackingcode)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<mov_UDCMagDetail>()
                .Property(e => e.Destination)
                .IsFixedLength();

            modelBuilder.Entity<ola_log>()
                .Property(e => e.DESCR)
                .IsUnicode(false);

            modelBuilder.Entity<ola_log>()
                .Property(e => e.FUNC)
                .IsUnicode(false);

            modelBuilder.Entity<ola_log>()
                .Property(e => e.LOGDT)
                .HasPrecision(0);

            modelBuilder.Entity<ola_messages>()
                .Property(e => e.message)
                .IsUnicode(false);

            modelBuilder.Entity<ola_messages>()
                .Property(e => e.modified)
                .HasPrecision(0);

            modelBuilder.Entity<par_tbldefaultparameters_calandra>()
                .Property(e => e.CodArt)
                .IsUnicode(false);

            modelBuilder.Entity<par_tbldefaultparameters_calandra>()
                .Property(e => e.DesArt)
                .IsUnicode(false);

            modelBuilder.Entity<par_tbldefaultparameters_calandra>()
                .Property(e => e.PressioneSpazzolatrice)
                .IsUnicode(false);

            modelBuilder.Entity<par_tbldefaultparameters_calandra>()
                .Property(e => e.IncollatricePann)
                .IsUnicode(false);

            modelBuilder.Entity<par_tbldefaultparameters_calandra>()
                .Property(e => e.Accoppiatore)
                .IsUnicode(false);

            modelBuilder.Entity<par_tbldefaultparameters_calandra>()
                .Property(e => e.Spintore)
                .IsUnicode(false);

            modelBuilder.Entity<par_tbldefaultparameters_calandra>()
                .Property(e => e.TipoRivestSup)
                .IsUnicode(false);

            modelBuilder.Entity<par_tbldefaultparameters_calandra>()
                .Property(e => e.TipoRivestInf)
                .IsUnicode(false);

            modelBuilder.Entity<par_tbldefaultparameters_calandra>()
                .Property(e => e.DistribuzioneCollaSup)
                .IsUnicode(false);

            modelBuilder.Entity<par_tbldefaultparameters_calandra>()
                .Property(e => e.DistribuzioneCollaInf)
                .IsUnicode(false);

            modelBuilder.Entity<par_tbldefaultparameters_calandra>()
                .Property(e => e.TipoCollaInf)
                .IsUnicode(false);

            modelBuilder.Entity<par_tbldefaultparameters_calandra>()
                .Property(e => e.TipoCollaSup)
                .IsUnicode(false);

            modelBuilder.Entity<par_tbldefaultparameters_calandra>()
                .Property(e => e.VelocitaMassima)
                .IsUnicode(false);

            modelBuilder.Entity<par_tbldefaultparameters_calandra>()
                .Property(e => e.PosizioneTaglioSeparazione)
                .IsUnicode(false);

            modelBuilder.Entity<par_tbldefaultparameters_calandra>()
                .Property(e => e.TempRulliAccoppiatoreSup)
                .IsUnicode(false);

            modelBuilder.Entity<par_tbldefaultparameters_calandra>()
                .Property(e => e.TempRulliAccoppiatoreInf)
                .IsUnicode(false);

            modelBuilder.Entity<par_tbldefaultparameters_calandra>()
                .Property(e => e.TempForno1LatoInfPann)
                .IsUnicode(false);

            modelBuilder.Entity<par_tbldefaultparameters_calandra>()
                .Property(e => e.TempForno1LatoSupPann)
                .IsUnicode(false);

            modelBuilder.Entity<par_tbldefaultparameters_calandra>()
                .Property(e => e.TempForno2LatoSupPann)
                .IsUnicode(false);

            modelBuilder.Entity<par_tbldefaultparameters_calandra>()
                .Property(e => e.TempForno2LatoInfPann)
                .IsUnicode(false);

            modelBuilder.Entity<par_tbldefaultparameters_calandra>()
                .Property(e => e.RiscaldRivestSup)
                .IsUnicode(false);

            modelBuilder.Entity<par_tbldefaultparameters_calandra>()
                .Property(e => e.RiscaldRivestInf)
                .IsUnicode(false);

            modelBuilder.Entity<par_tbldefaultparameters_calandra>()
                .Property(e => e.QtaCollaBobinaSup)
                .IsUnicode(false);

            modelBuilder.Entity<par_tbldefaultparameters_calandra>()
                .Property(e => e.QtaCollaLatoSupPann)
                .IsUnicode(false);

            modelBuilder.Entity<par_tbldefaultparameters_calandra>()
                .Property(e => e.QtaCollaBobinaInf)
                .IsUnicode(false);

            modelBuilder.Entity<par_tbldefaultparameters_calandra>()
                .Property(e => e.QtaCollaLatoInfPann)
                .IsUnicode(false);

            modelBuilder.Entity<par_tbldefaultparameters_levigatrice>()
                .Property(e => e.CodArt)
                .IsUnicode(false);

            modelBuilder.Entity<par_tbldefaultparameters_levigatrice>()
                .Property(e => e.DesArt)
                .IsUnicode(false);

            modelBuilder.Entity<par_tbldefaultrecipes_levigatrice>()
                .Property(e => e.Ricetta)
                .IsUnicode(false);

            modelBuilder.Entity<par_tbldefaultrecipes_levigatrice>()
                .Property(e => e.Zona1)
                .IsUnicode(false);

            modelBuilder.Entity<par_tbldefaultrecipes_levigatrice>()
                .Property(e => e.Z1Velocita)
                .IsUnicode(false);

            modelBuilder.Entity<par_tbldefaultrecipes_levigatrice>()
                .Property(e => e.Z1Velocita_Min)
                .IsUnicode(false);

            modelBuilder.Entity<par_tbldefaultrecipes_levigatrice>()
                .Property(e => e.Z1Velocita_Max)
                .IsUnicode(false);

            modelBuilder.Entity<par_tbldefaultrecipes_levigatrice>()
                .Property(e => e.Z1Velocita_Nota)
                .IsUnicode(false);

            modelBuilder.Entity<par_tbldefaultrecipes_levigatrice>()
                .Property(e => e.Z1GestioneSettori)
                .IsUnicode(false);

            modelBuilder.Entity<par_tbldefaultrecipes_levigatrice>()
                .Property(e => e.Z1GestioneSettori_Min)
                .IsUnicode(false);

            modelBuilder.Entity<par_tbldefaultrecipes_levigatrice>()
                .Property(e => e.Z1GestioneSettori_Max)
                .IsUnicode(false);

            modelBuilder.Entity<par_tbldefaultrecipes_levigatrice>()
                .Property(e => e.Z1GestioneSettori_Nota)
                .IsUnicode(false);

            modelBuilder.Entity<par_tbldefaultrecipes_levigatrice>()
                .Property(e => e.Z1AntRitMotoriTamponi)
                .IsUnicode(false);

            modelBuilder.Entity<par_tbldefaultrecipes_levigatrice>()
                .Property(e => e.Z1AntRitMotoriTamponi_Min)
                .IsUnicode(false);

            modelBuilder.Entity<par_tbldefaultrecipes_levigatrice>()
                .Property(e => e.Z1AntRitMotoriTamponi_Max)
                .IsUnicode(false);

            modelBuilder.Entity<par_tbldefaultrecipes_levigatrice>()
                .Property(e => e.Z1AntRitMotoriTamponi_Nota)
                .IsUnicode(false);

            modelBuilder.Entity<par_tbldefaultrecipes_levigatrice>()
                .Property(e => e.Z1PressTamponi)
                .IsUnicode(false);

            modelBuilder.Entity<par_tbldefaultrecipes_levigatrice>()
                .Property(e => e.Z1PressTamponi_Min)
                .IsUnicode(false);

            modelBuilder.Entity<par_tbldefaultrecipes_levigatrice>()
                .Property(e => e.Z1PressTamponi_Max)
                .IsUnicode(false);

            modelBuilder.Entity<par_tbldefaultrecipes_levigatrice>()
                .Property(e => e.Z1PressTamponi_Nota)
                .IsUnicode(false);

            modelBuilder.Entity<par_tbldefaultrecipes_levigatrice>()
                .Property(e => e.Z1InnalzSuppGrafite_Nota)
                .IsUnicode(false);

            modelBuilder.Entity<par_tbldefaultrecipes_levigatrice>()
                .Property(e => e.Zona2)
                .IsUnicode(false);

            modelBuilder.Entity<par_tbldefaultrecipes_levigatrice>()
                .Property(e => e.Z2Velocita)
                .IsUnicode(false);

            modelBuilder.Entity<par_tbldefaultrecipes_levigatrice>()
                .Property(e => e.Z2Velocita_Min)
                .IsUnicode(false);

            modelBuilder.Entity<par_tbldefaultrecipes_levigatrice>()
                .Property(e => e.Z2Velocita_Max)
                .IsUnicode(false);

            modelBuilder.Entity<par_tbldefaultrecipes_levigatrice>()
                .Property(e => e.Z2Velocita_Nota)
                .IsUnicode(false);

            modelBuilder.Entity<par_tbldefaultrecipes_levigatrice>()
                .Property(e => e.Z2GestioneSettori)
                .IsUnicode(false);

            modelBuilder.Entity<par_tbldefaultrecipes_levigatrice>()
                .Property(e => e.Z2GestioneSettori_Min)
                .IsUnicode(false);

            modelBuilder.Entity<par_tbldefaultrecipes_levigatrice>()
                .Property(e => e.Z2GestioneSettori_Max)
                .IsUnicode(false);

            modelBuilder.Entity<par_tbldefaultrecipes_levigatrice>()
                .Property(e => e.Z2GestioneSettori_Nota)
                .IsUnicode(false);

            modelBuilder.Entity<par_tbldefaultrecipes_levigatrice>()
                .Property(e => e.Z2AntRitMotoriTamponi)
                .IsUnicode(false);

            modelBuilder.Entity<par_tbldefaultrecipes_levigatrice>()
                .Property(e => e.Z2AntRitMotoriTamponi_Min)
                .IsUnicode(false);

            modelBuilder.Entity<par_tbldefaultrecipes_levigatrice>()
                .Property(e => e.Z2AntRitMotoriTamponi_Max)
                .IsUnicode(false);

            modelBuilder.Entity<par_tbldefaultrecipes_levigatrice>()
                .Property(e => e.Z2AntRitMotoriTamponi_Nota)
                .IsUnicode(false);

            modelBuilder.Entity<par_tbldefaultrecipes_levigatrice>()
                .Property(e => e.Z2PressTamponi)
                .IsUnicode(false);

            modelBuilder.Entity<par_tbldefaultrecipes_levigatrice>()
                .Property(e => e.Z2PressTamponi_Min)
                .IsUnicode(false);

            modelBuilder.Entity<par_tbldefaultrecipes_levigatrice>()
                .Property(e => e.Z2PressTamponi_Max)
                .IsUnicode(false);

            modelBuilder.Entity<par_tbldefaultrecipes_levigatrice>()
                .Property(e => e.Z2PressTamponi_Nota)
                .IsUnicode(false);

            modelBuilder.Entity<par_tbldefaultrecipes_levigatrice>()
                .Property(e => e.Zona3)
                .IsUnicode(false);

            modelBuilder.Entity<par_tbldefaultrecipes_levigatrice>()
                .Property(e => e.Z3Velocita)
                .IsUnicode(false);

            modelBuilder.Entity<par_tbldefaultrecipes_levigatrice>()
                .Property(e => e.Z3Velocita_Min)
                .IsUnicode(false);

            modelBuilder.Entity<par_tbldefaultrecipes_levigatrice>()
                .Property(e => e.Z3Velocita_Max)
                .IsUnicode(false);

            modelBuilder.Entity<par_tbldefaultrecipes_levigatrice>()
                .Property(e => e.Z3Velocita_Nota)
                .IsUnicode(false);

            modelBuilder.Entity<par_tbldefaultrecipes_levigatrice>()
                .Property(e => e.Z3GestioneSettori)
                .IsUnicode(false);

            modelBuilder.Entity<par_tbldefaultrecipes_levigatrice>()
                .Property(e => e.Z3GestioneSettori_Min)
                .IsUnicode(false);

            modelBuilder.Entity<par_tbldefaultrecipes_levigatrice>()
                .Property(e => e.Z3GestioneSettori_Max)
                .IsUnicode(false);

            modelBuilder.Entity<par_tbldefaultrecipes_levigatrice>()
                .Property(e => e.Z3GestioneSettori_Nota)
                .IsUnicode(false);

            modelBuilder.Entity<par_tbldefaultrecipes_levigatrice>()
                .Property(e => e.Z3AntRitMotoriTamponi)
                .IsUnicode(false);

            modelBuilder.Entity<par_tbldefaultrecipes_levigatrice>()
                .Property(e => e.Z3AntRitMotoriTamponi_Min)
                .IsUnicode(false);

            modelBuilder.Entity<par_tbldefaultrecipes_levigatrice>()
                .Property(e => e.Z3AntRitMotoriTamponi_Max)
                .IsUnicode(false);

            modelBuilder.Entity<par_tbldefaultrecipes_levigatrice>()
                .Property(e => e.Z3AntRitMotoriTamponi_Nota)
                .IsUnicode(false);

            modelBuilder.Entity<par_tbldefaultrecipes_levigatrice>()
                .Property(e => e.Z3PressTamponi)
                .IsUnicode(false);

            modelBuilder.Entity<par_tbldefaultrecipes_levigatrice>()
                .Property(e => e.Z3PressTamponi_Min)
                .IsUnicode(false);

            modelBuilder.Entity<par_tbldefaultrecipes_levigatrice>()
                .Property(e => e.Z3PressTamponi_Max)
                .IsUnicode(false);

            modelBuilder.Entity<par_tbldefaultrecipes_levigatrice>()
                .Property(e => e.Z3PressTamponi_Nota)
                .IsUnicode(false);

            modelBuilder.Entity<par_tbldefaultrecipes_levigatrice>()
                .Property(e => e.Z3InnalzSuppGrafite_Nota)
                .IsUnicode(false);

            modelBuilder.Entity<par_tbldefaultrecipes_levigatrice>()
                .Property(e => e.Zona4)
                .IsUnicode(false);

            modelBuilder.Entity<par_tbldefaultrecipes_levigatrice>()
                .Property(e => e.Z4Velocita)
                .IsUnicode(false);

            modelBuilder.Entity<par_tbldefaultrecipes_levigatrice>()
                .Property(e => e.Z4Velocita_Min)
                .IsUnicode(false);

            modelBuilder.Entity<par_tbldefaultrecipes_levigatrice>()
                .Property(e => e.Z4Velocita_Max)
                .IsUnicode(false);

            modelBuilder.Entity<par_tbldefaultrecipes_levigatrice>()
                .Property(e => e.Z4Velocita_Nota)
                .IsUnicode(false);

            modelBuilder.Entity<par_tbldefaultrecipes_levigatrice>()
                .Property(e => e.Z4GestioneSettori)
                .IsUnicode(false);

            modelBuilder.Entity<par_tbldefaultrecipes_levigatrice>()
                .Property(e => e.Z4GestioneSettori_Min)
                .IsUnicode(false);

            modelBuilder.Entity<par_tbldefaultrecipes_levigatrice>()
                .Property(e => e.Z4GestioneSettori_Max)
                .IsUnicode(false);

            modelBuilder.Entity<par_tbldefaultrecipes_levigatrice>()
                .Property(e => e.Z4GestioneSettori_Nota)
                .IsUnicode(false);

            modelBuilder.Entity<par_tbldefaultrecipes_levigatrice>()
                .Property(e => e.Z4AntRitMotoriTamponi)
                .IsUnicode(false);

            modelBuilder.Entity<par_tbldefaultrecipes_levigatrice>()
                .Property(e => e.Z4AntRitMotoriTamponi_Min)
                .IsUnicode(false);

            modelBuilder.Entity<par_tbldefaultrecipes_levigatrice>()
                .Property(e => e.Z4AntRitMotoriTamponi_Max)
                .IsUnicode(false);

            modelBuilder.Entity<par_tbldefaultrecipes_levigatrice>()
                .Property(e => e.Z4AntRitMotoriTamponi_Nota)
                .IsUnicode(false);

            modelBuilder.Entity<par_tbldefaultrecipes_levigatrice>()
                .Property(e => e.Z4PressTamponi)
                .IsUnicode(false);

            modelBuilder.Entity<par_tbldefaultrecipes_levigatrice>()
                .Property(e => e.Z4PressTamponi_Min)
                .IsUnicode(false);

            modelBuilder.Entity<par_tbldefaultrecipes_levigatrice>()
                .Property(e => e.Z4PressTamponi_Max)
                .IsUnicode(false);

            modelBuilder.Entity<par_tbldefaultrecipes_levigatrice>()
                .Property(e => e.Z4PressTamponi_Nota)
                .IsUnicode(false);

            modelBuilder.Entity<par_tbldefaultrecipes_levigatrice>()
                .Property(e => e.Z4InnalzSuppGrafite_Nota)
                .IsUnicode(false);

            modelBuilder.Entity<par_tbldefaultrecipes_levigatrice>()
                .Property(e => e.Zona5)
                .IsUnicode(false);

            modelBuilder.Entity<par_tbldefaultrecipes_levigatrice>()
                .Property(e => e.Z5Velocita)
                .IsUnicode(false);

            modelBuilder.Entity<par_tbldefaultrecipes_levigatrice>()
                .Property(e => e.Z5Velocita_Min)
                .IsUnicode(false);

            modelBuilder.Entity<par_tbldefaultrecipes_levigatrice>()
                .Property(e => e.Z5Velocita_Max)
                .IsUnicode(false);

            modelBuilder.Entity<par_tbldefaultrecipes_levigatrice>()
                .Property(e => e.Z5Velocita_Nota)
                .IsUnicode(false);

            modelBuilder.Entity<par_tbldefaultrecipes_levigatrice>()
                .Property(e => e.Z5GestioneSettori)
                .IsUnicode(false);

            modelBuilder.Entity<par_tbldefaultrecipes_levigatrice>()
                .Property(e => e.Z5GestioneSettori_Min)
                .IsUnicode(false);

            modelBuilder.Entity<par_tbldefaultrecipes_levigatrice>()
                .Property(e => e.Z5GestioneSettori_Max)
                .IsUnicode(false);

            modelBuilder.Entity<par_tbldefaultrecipes_levigatrice>()
                .Property(e => e.Z5GestioneSettori_Nota)
                .IsUnicode(false);

            modelBuilder.Entity<par_tbldefaultrecipes_levigatrice>()
                .Property(e => e.Z5AntRitMotoriTamponi)
                .IsUnicode(false);

            modelBuilder.Entity<par_tbldefaultrecipes_levigatrice>()
                .Property(e => e.Z5AntRitMotoriTamponi_Min)
                .IsUnicode(false);

            modelBuilder.Entity<par_tbldefaultrecipes_levigatrice>()
                .Property(e => e.Z5AntRitMotoriTamponi_Max)
                .IsUnicode(false);

            modelBuilder.Entity<par_tbldefaultrecipes_levigatrice>()
                .Property(e => e.Z5AntRitMotoriTamponi_Nota)
                .IsUnicode(false);

            modelBuilder.Entity<par_tbldefaultrecipes_levigatrice>()
                .Property(e => e.Z5PressTamponi)
                .IsUnicode(false);

            modelBuilder.Entity<par_tbldefaultrecipes_levigatrice>()
                .Property(e => e.Z5PressTamponi_Min)
                .IsUnicode(false);

            modelBuilder.Entity<par_tbldefaultrecipes_levigatrice>()
                .Property(e => e.Z5PressTamponi_Max)
                .IsUnicode(false);

            modelBuilder.Entity<par_tbldefaultrecipes_levigatrice>()
                .Property(e => e.Z5PressTamponi_Nota)
                .IsUnicode(false);

            modelBuilder.Entity<par_tbldefaultrecipes_levigatrice>()
                .Property(e => e.Zona6)
                .IsUnicode(false);

            modelBuilder.Entity<par_tbldefaultrecipes_levigatrice>()
                .Property(e => e.Z6Velocita)
                .IsUnicode(false);

            modelBuilder.Entity<par_tbldefaultrecipes_levigatrice>()
                .Property(e => e.Z6Velocita_Min)
                .IsUnicode(false);

            modelBuilder.Entity<par_tbldefaultrecipes_levigatrice>()
                .Property(e => e.Z6Velocita_Max)
                .IsUnicode(false);

            modelBuilder.Entity<par_tbldefaultrecipes_levigatrice>()
                .Property(e => e.Z6Velocita_Nota)
                .IsUnicode(false);

            modelBuilder.Entity<par_tbldefaultrecipes_levigatrice>()
                .Property(e => e.Z6GestioneSettori)
                .IsUnicode(false);

            modelBuilder.Entity<par_tbldefaultrecipes_levigatrice>()
                .Property(e => e.Z6GestioneSettori_Min)
                .IsUnicode(false);

            modelBuilder.Entity<par_tbldefaultrecipes_levigatrice>()
                .Property(e => e.Z6GestioneSettori_Max)
                .IsUnicode(false);

            modelBuilder.Entity<par_tbldefaultrecipes_levigatrice>()
                .Property(e => e.Z6GestioneSettori_Nota)
                .IsUnicode(false);

            modelBuilder.Entity<par_tbldefaultrecipes_levigatrice>()
                .Property(e => e.Z6AntRitMotoriTamponi)
                .IsUnicode(false);

            modelBuilder.Entity<par_tbldefaultrecipes_levigatrice>()
                .Property(e => e.Z6AntRitMotoriTamponi_Min)
                .IsUnicode(false);

            modelBuilder.Entity<par_tbldefaultrecipes_levigatrice>()
                .Property(e => e.Z6AntRitMotoriTamponi_Max)
                .IsUnicode(false);

            modelBuilder.Entity<par_tbldefaultrecipes_levigatrice>()
                .Property(e => e.Z6AntRitMotoriTamponi_Nota)
                .IsUnicode(false);

            modelBuilder.Entity<par_tbldefaultrecipes_levigatrice>()
                .Property(e => e.Z6PressTamponi)
                .IsUnicode(false);

            modelBuilder.Entity<par_tbldefaultrecipes_levigatrice>()
                .Property(e => e.Z6PressTamponi_Min)
                .IsUnicode(false);

            modelBuilder.Entity<par_tbldefaultrecipes_levigatrice>()
                .Property(e => e.Z6PressTamponi_Max)
                .IsUnicode(false);

            modelBuilder.Entity<par_tbldefaultrecipes_levigatrice>()
                .Property(e => e.Z6PressTamponi_Nota)
                .IsUnicode(false);

            modelBuilder.Entity<par_tbldefaultrecipes_levigatrice>()
                .Property(e => e.Z6InnalzSuppGrafite_Nota)
                .IsUnicode(false);

            modelBuilder.Entity<par_tblparameterscode>()
                .Property(e => e.description)
                .IsUnicode(false);

            modelBuilder.Entity<par_tblparameterscode>()
                .Property(e => e.WorkCenter)
                .IsFixedLength();

            modelBuilder.Entity<par_tblparameterscode>()
                .Property(e => e.Machine)
                .IsFixedLength();

            modelBuilder.Entity<par_tblparameterscode>()
                .Property(e => e.Note)
                .IsUnicode(false);

            modelBuilder.Entity<par_tblproject>()
                .Property(e => e.ProjectCode)
                .IsUnicode(false);

            modelBuilder.Entity<par_tblproject>()
                .Property(e => e.descrizione)
                .IsUnicode(false);

            modelBuilder.Entity<par_tblproject>()
                .Property(e => e.articolo_codice)
                .IsUnicode(false);

            modelBuilder.Entity<par_tblproject>()
                .Property(e => e.articolo_descrizione)
                .IsUnicode(false);

            modelBuilder.Entity<par_tblproject>()
                .Property(e => e.tipo)
                .IsUnicode(false);

            modelBuilder.Entity<par_tblproject>()
                .Property(e => e.note)
                .IsUnicode(false);

            modelBuilder.Entity<par_tblproject>()
                .Property(e => e.lunghezza)
                .HasPrecision(18, 6);

            modelBuilder.Entity<par_tblproject>()
                .Property(e => e.larghezza)
                .HasPrecision(18, 6);

            modelBuilder.Entity<par_tblproject>()
                .Property(e => e.spessore)
                .HasPrecision(18, 6);

            modelBuilder.Entity<par_tblproject>()
                .Property(e => e.pos_list1)
                .HasPrecision(18, 6);

            modelBuilder.Entity<par_tblproject>()
                .Property(e => e.pos_list2)
                .HasPrecision(18, 6);

            modelBuilder.Entity<par_tblproject>()
                .Property(e => e.pos_list3)
                .HasPrecision(18, 6);

            modelBuilder.Entity<par_tblproject>()
                .Property(e => e.pos_list4)
                .HasPrecision(18, 6);

            modelBuilder.Entity<par_tblproject>()
                .Property(e => e.pos_list5)
                .HasPrecision(18, 6);

            modelBuilder.Entity<par_tblproject>()
                .Property(e => e.pos_list6)
                .HasPrecision(18, 6);

            modelBuilder.Entity<par_tblproject>()
                .Property(e => e.pos_list7)
                .HasPrecision(18, 6);

            modelBuilder.Entity<par_tblproject>()
                .Property(e => e.pos_list8)
                .HasPrecision(18, 6);

            modelBuilder.Entity<par_tblproject>()
                .Property(e => e.pos_list9)
                .HasPrecision(18, 6);

            modelBuilder.Entity<par_tblproject>()
                .Property(e => e.tipocolla_codice)
                .IsUnicode(false);

            modelBuilder.Entity<par_tblproject>()
                .Property(e => e.tipocolla_descrizione)
                .IsUnicode(false);

            modelBuilder.Entity<par_tblproject>()
                .Property(e => e.BladeThickness1)
                .HasPrecision(18, 6);

            modelBuilder.Entity<par_tblproject>()
                .Property(e => e.BladeThickness2)
                .HasPrecision(18, 6);

            modelBuilder.Entity<par_tblproject>()
                .Property(e => e.BladeThickness3)
                .HasPrecision(18, 6);

            modelBuilder.Entity<par_tblproject>()
                .Property(e => e.BladeThickness4)
                .HasPrecision(18, 6);

            modelBuilder.Entity<par_tblproject>()
                .Property(e => e.MovableChipperPosition)
                .HasPrecision(18, 6);

            modelBuilder.Entity<rfid_global>()
                .Property(e => e.ID_Ola)
                .IsUnicode(false);

            modelBuilder.Entity<rfid_global>()
                .Property(e => e.ID_Fase)
                .IsUnicode(false);

            modelBuilder.Entity<rfid_global>()
                .Property(e => e.codice_rfid)
                .IsUnicode(false);

            modelBuilder.Entity<rfid_global_error>()
                .Property(e => e.codice_rfid)
                .IsUnicode(false);

            modelBuilder.Entity<stato_ordini_001>()
                .Property(e => e.ID_Ola)
                .IsUnicode(false);

            modelBuilder.Entity<stato_ordini_001>()
                .Property(e => e.ID_Fase)
                .IsUnicode(false);

            modelBuilder.Entity<stato_ordini_001>()
                .Property(e => e.Data_Ultima_Modifica)
                .HasPrecision(0);

            modelBuilder.Entity<stato_ordini_001>()
                .Property(e => e.dtDateStartWork)
                .HasPrecision(0);

            modelBuilder.Entity<stato_ordini_001>()
                .Property(e => e.dtDateEndWord)
                .HasPrecision(0);

            modelBuilder.Entity<tb_LabelPrinterSpooler>()
                .Property(e => e.PrinterName)
                .IsUnicode(false);

            modelBuilder.Entity<tb_LabelPrinterSpooler>()
                .HasOptional(e => e.tb_LabelPrinterSpooler1)
                .WithRequired(e => e.tb_LabelPrinterSpooler2);

            modelBuilder.Entity<tb_LabelPrinterSpooler>()
                .HasOptional(e => e.tb_LabelPrinterSpooler11)
                .WithRequired(e => e.tb_LabelPrinterSpooler3);

            modelBuilder.Entity<tblbasketnextjob>()
                .Property(e => e.ID_OLA)
                .IsUnicode(false);

            modelBuilder.Entity<tblbasketnextjob>()
                .Property(e => e.Line1_cod)
                .IsUnicode(false);

            modelBuilder.Entity<tblbasketnextjob>()
                .Property(e => e.Line2_cod)
                .IsUnicode(false);

            modelBuilder.Entity<tblbasketnextjob>()
                .Property(e => e.Line3_cod)
                .IsUnicode(false);

            modelBuilder.Entity<tblbasketnextjob>()
                .Property(e => e.Line4_cod)
                .IsUnicode(false);

            modelBuilder.Entity<tblchangedsettings>()
                .Property(e => e.ID_OLA)
                .IsUnicode(false);

            modelBuilder.Entity<tblevents>()
                .Property(e => e.ID_OLA)
                .IsUnicode(false);

            modelBuilder.Entity<tblevents>()
                .Property(e => e.ID_Fase)
                .IsUnicode(false);

            modelBuilder.Entity<tblevents>()
                .Property(e => e.dtDateOfEvent)
                .HasPrecision(0);

            modelBuilder.Entity<tblevents>()
                .Property(e => e.dSubEvent10)
                .IsUnicode(false);

            modelBuilder.Entity<tblevents>()
                .Property(e => e.dSubEvent11)
                .IsUnicode(false);

            modelBuilder.Entity<tblevents_statusChanged>()
                .Property(e => e.ID_OLA)
                .IsUnicode(false);

            modelBuilder.Entity<tblevents_statusChanged>()
                .Property(e => e.ID_Fase)
                .IsUnicode(false);

            modelBuilder.Entity<tblevents_statusChanged>()
                .Property(e => e.dtDateOfEvent)
                .HasPrecision(0);

            modelBuilder.Entity<tblevents_statusChanged>()
                .Property(e => e.dSubEvent10)
                .IsUnicode(false);

            modelBuilder.Entity<tblevents_statusChanged>()
                .Property(e => e.dSubEvent11)
                .IsUnicode(false);

            modelBuilder.Entity<tblprioritycover>()
                .Property(e => e.Priority1_cod)
                .IsUnicode(false);

            modelBuilder.Entity<tblprioritycover>()
                .Property(e => e.Priority2_cod)
                .IsUnicode(false);

            modelBuilder.Entity<tblprioritycover>()
                .Property(e => e.Priority3_cod)
                .IsUnicode(false);

            modelBuilder.Entity<tblprioritycover>()
                .Property(e => e.Priority4_cod)
                .IsUnicode(false);

            modelBuilder.Entity<tblpriorityhoney>()
                .Property(e => e.Id_Ola)
                .IsUnicode(false);

            modelBuilder.Entity<tblpriorityhoney>()
                .Property(e => e.strCodHoney)
                .IsUnicode(false);

            modelBuilder.Entity<tblprioritylath>()
                .Property(e => e.Priority1_cod)
                .IsUnicode(false);

            modelBuilder.Entity<tblprioritylath>()
                .Property(e => e.Priority2_cod)
                .IsUnicode(false);

            modelBuilder.Entity<tblprioritylath>()
                .Property(e => e.Priority3_cod)
                .IsUnicode(false);

            modelBuilder.Entity<tblprioritylath>()
                .Property(e => e.Priority4_cod)
                .IsUnicode(false);

            modelBuilder.Entity<tbltodo>()
                .Property(e => e.ID_Ola)
                .IsUnicode(false);

            modelBuilder.Entity<tbltodo>()
                .Property(e => e.ID_Fase)
                .IsUnicode(false);

            modelBuilder.Entity<tbltodo>()
                .Property(e => e.dtDateOfModify)
                .HasPrecision(0);

            modelBuilder.Entity<tbltodo>()
                .Property(e => e.dtDateOfDelivery)
                .HasPrecision(0);

            modelBuilder.Entity<tbltodo>()
                .Property(e => e.dtDateStartWork)
                .HasPrecision(0);

            modelBuilder.Entity<tbltodo>()
                .Property(e => e.dtDateEndWork)
                .HasPrecision(0);

            modelBuilder.Entity<tbltodo>()
                .Property(e => e.strCode)
                .IsUnicode(false);

            modelBuilder.Entity<tbltodo>()
                .Property(e => e.strDescription)
                .IsUnicode(false);

            modelBuilder.Entity<tbltodo>()
                .Property(e => e.strCodStrip1)
                .IsUnicode(false);

            modelBuilder.Entity<tbltodo>()
                .Property(e => e.strCodStrip2)
                .IsUnicode(false);

            modelBuilder.Entity<tbltodo>()
                .Property(e => e.strCodStrip3)
                .IsUnicode(false);

            modelBuilder.Entity<tbltodo>()
                .Property(e => e.strCodStrip4)
                .IsUnicode(false);

            modelBuilder.Entity<tbltodo>()
                .Property(e => e.strCodStrip5)
                .IsUnicode(false);

            modelBuilder.Entity<tbltodo>()
                .Property(e => e.strCodStrip6)
                .IsUnicode(false);

            modelBuilder.Entity<tbltodo>()
                .Property(e => e.strCodStrip7)
                .IsUnicode(false);

            modelBuilder.Entity<tbltodo>()
                .Property(e => e.strCodStrip8)
                .IsUnicode(false);

            modelBuilder.Entity<tbltodo>()
                .Property(e => e.strCodStrip9)
                .IsUnicode(false);

            modelBuilder.Entity<tbltodo>()
                .Property(e => e.strCoverUpCode)
                .IsUnicode(false);

            modelBuilder.Entity<tbltodo>()
                .Property(e => e.strCoverDwCode)
                .IsUnicode(false);

            modelBuilder.Entity<tbltodo>()
                .Property(e => e.strCodProd_Pos_1_1)
                .IsUnicode(false);

            modelBuilder.Entity<tbltodo>()
                .Property(e => e.strCodProd_Pos_1_2)
                .IsUnicode(false);

            modelBuilder.Entity<tbltodo>()
                .Property(e => e.strCodProd_Pos_1_3)
                .IsUnicode(false);

            modelBuilder.Entity<tbltodo>()
                .Property(e => e.strCodProd_Pos_1_4)
                .IsUnicode(false);

            modelBuilder.Entity<tbltodo>()
                .Property(e => e.strCodProd_Pos_1_5)
                .IsUnicode(false);

            modelBuilder.Entity<tbltodo>()
                .Property(e => e.strCodProd_Pos_2_1)
                .IsUnicode(false);

            modelBuilder.Entity<tbltodo>()
                .Property(e => e.strCodProd_Pos_2_2)
                .IsUnicode(false);

            modelBuilder.Entity<tbltodo>()
                .Property(e => e.strCodProd_Pos_2_3)
                .IsUnicode(false);

            modelBuilder.Entity<tbltodo>()
                .Property(e => e.strCodProd_Pos_2_4)
                .IsUnicode(false);

            modelBuilder.Entity<tbltodo>()
                .Property(e => e.strCodProd_Pos_2_5)
                .IsUnicode(false);

            modelBuilder.Entity<tbltodo>()
                .Property(e => e.strCodHoney)
                .IsUnicode(false);

            modelBuilder.Entity<tbltodo>()
                .Property(e => e.Wik_Name)
                .IsUnicode(false);

            modelBuilder.Entity<tbltodo_storico>()
                .Property(e => e.ID_OLA)
                .IsUnicode(false);

            modelBuilder.Entity<tbltodo_storico>()
                .Property(e => e.strCodProd_Pos_1_3)
                .IsUnicode(false);

            modelBuilder.Entity<tbltodo_storico>()
                .Property(e => e.strCodProd_Pos_2_3)
                .IsUnicode(false);

            modelBuilder.Entity<tbltodo_storico>()
                .Property(e => e.utente)
                .IsUnicode(false);

            modelBuilder.Entity<tbltodo_storico>()
                .Property(e => e.InsertOrUpdate)
                .IsUnicode(false);

            modelBuilder.Entity<tbludcexit>()
                .Property(e => e.Key_General)
                .IsUnicode(false);

            modelBuilder.Entity<tbludcproduce>()
                .Property(e => e.ID_OLA)
                .IsUnicode(false);

            modelBuilder.Entity<tbludcproduce>()
                .Property(e => e.ID_Fase)
                .IsUnicode(false);

            modelBuilder.Entity<tbludcproduce>()
                .Property(e => e.Key_General)
                .IsUnicode(false);

            modelBuilder.Entity<tbludcproduce>()
                .Property(e => e.Data_Ora)
                .HasPrecision(0);

            modelBuilder.Entity<C_cvm_sez_todo_001_old>()
                .Property(e => e.ID_OLA)
                .IsUnicode(false);

            modelBuilder.Entity<C_cvm_sez_todo_001_old>()
                .Property(e => e.ID_Fase)
                .IsUnicode(false);

            modelBuilder.Entity<C_cvm_sez_todo_001_old>()
                .Property(e => e.strCodProd_Pos_1_1)
                .IsUnicode(false);

            modelBuilder.Entity<C_cvm_sez_todo_001_old>()
                .Property(e => e.strCodProd_Pos_1_2)
                .IsUnicode(false);

            modelBuilder.Entity<C_cvm_sez_todo_001_old>()
                .Property(e => e.strCodProd_Pos_1_3)
                .IsUnicode(false);

            modelBuilder.Entity<C_cvm_sez_todo_001_old>()
                .Property(e => e.strCodProd_Pos_1_4)
                .IsUnicode(false);

            modelBuilder.Entity<C_cvm_sez_todo_001_old>()
                .Property(e => e.strCodProd_Pos_1_5)
                .IsUnicode(false);

            modelBuilder.Entity<C_cvm_sez_todo_001_old>()
                .Property(e => e.strCodProd_Pos_2_1)
                .IsUnicode(false);

            modelBuilder.Entity<C_cvm_sez_todo_001_old>()
                .Property(e => e.strCodProd_Pos_2_2)
                .IsUnicode(false);

            modelBuilder.Entity<C_cvm_sez_todo_001_old>()
                .Property(e => e.strCodProd_Pos_2_3)
                .IsUnicode(false);

            modelBuilder.Entity<C_cvm_sez_todo_001_old>()
                .Property(e => e.strCodProd_Pos_2_4)
                .IsUnicode(false);

            modelBuilder.Entity<C_cvm_sez_todo_001_old>()
                .Property(e => e.strCodProd_Pos_2_5)
                .IsUnicode(false);

            modelBuilder.Entity<C_mov_LabelParams_obsoleta>()
                .Property(e => e.ParamName)
                .IsUnicode(false);

            modelBuilder.Entity<logaut_udciningresso_storico>()
                .Property(e => e.UDC)
                .IsUnicode(false);

            modelBuilder.Entity<logaut_udciningresso_storico>()
                .Property(e => e.Stato)
                .IsUnicode(false);

            modelBuilder.Entity<logaut_udciningresso_storico>()
                .Property(e => e.DataModifica)
                .HasPrecision(0);

            modelBuilder.Entity<logaut_udciningresso_storico>()
                .Property(e => e.UtenteModifica)
                .IsUnicode(false);

            modelBuilder.Entity<mac_tipo_evento>()
                .Property(e => e.descr_evento)
                .IsUnicode(false);

            modelBuilder.Entity<mov_UDCQtyChangeEvents>()
                .Property(e => e.KeyCode)
                .IsFixedLength();

            modelBuilder.Entity<mov_UDCQtyChangeEvents>()
                .Property(e => e.Note)
                .IsFixedLength();

            modelBuilder.Entity<par_tblprojectdefaultparameters>()
                .Property(e => e.ProjectCode)
                .IsUnicode(false);

            modelBuilder.Entity<par_tblprojectdefaultparameters>()
                .Property(e => e.CodArt)
                .IsUnicode(false);

            modelBuilder.Entity<par_tblprojectdefaultparameters>()
                .Property(e => e.DesArt)
                .IsUnicode(false);

            modelBuilder.Entity<par_tblprojectdefaultparameters>()
                .Property(e => e.Variant)
                .IsUnicode(false);

            modelBuilder.Entity<par_tblprojectdefaultparameters>()
                .Property(e => e.BladeThickness1)
                .HasPrecision(18, 6);

            modelBuilder.Entity<par_tblprojectdefaultparameters>()
                .Property(e => e.BladeThickness2)
                .HasPrecision(18, 6);

            modelBuilder.Entity<par_tblprojectdefaultparameters>()
                .Property(e => e.BladeThickness3)
                .HasPrecision(18, 6);

            modelBuilder.Entity<par_tblprojectdefaultparameters>()
                .Property(e => e.BladeThickness4)
                .HasPrecision(18, 6);

            modelBuilder.Entity<par_tblprojectdefaultparameters>()
                .Property(e => e.MovableChipperPosition)
                .HasPrecision(18, 6);

            modelBuilder.Entity<stato_ordini_001_StatusChange>()
                .Property(e => e.ID_Ola)
                .IsUnicode(false);

            modelBuilder.Entity<stato_ordini_001_StatusChange>()
                .Property(e => e.ID_Fase)
                .IsUnicode(false);

            modelBuilder.Entity<stato_ordini_001_StatusChange>()
                .Property(e => e.Data_Ultima_Modifica)
                .HasPrecision(3);

            modelBuilder.Entity<stato_ordini_001_StatusChange>()
                .Property(e => e.dtDateStartWork)
                .HasPrecision(0);

            modelBuilder.Entity<stato_ordini_001_StatusChange>()
                .Property(e => e.dtDateEndWord)
                .HasPrecision(0);

            modelBuilder.Entity<tblelectric>()
                .Property(e => e.dtDateOfEvent)
                .HasPrecision(0);

            modelBuilder.Entity<tblelectric>()
                .Property(e => e.sLine)
                .IsUnicode(false);

            modelBuilder.Entity<tblparameters>()
                .Property(e => e.description)
                .IsUnicode(false);

            modelBuilder.Entity<mac_consumi_001_view>()
                .Property(e => e.ID_OLA)
                .IsUnicode(false);

            modelBuilder.Entity<mac_consumi_001_view>()
                .Property(e => e.ID_FASE)
                .IsUnicode(false);

            modelBuilder.Entity<mac_consumi_001_view>()
                .Property(e => e.dtDateOfEvent)
                .HasPrecision(0);

            modelBuilder.Entity<mac_consumi_001_view>()
                .Property(e => e.strCodArt)
                .IsUnicode(false);

            modelBuilder.Entity<mac_consumi_001_view>()
                .Property(e => e.strUDC)
                .IsUnicode(false);

            modelBuilder.Entity<mac_eventi_001_view>()
                .Property(e => e.ID_OLA)
                .IsUnicode(false);

            modelBuilder.Entity<mac_eventi_001_view>()
                .Property(e => e.ID_FASE)
                .IsUnicode(false);

            modelBuilder.Entity<mac_eventi_001_view>()
                .Property(e => e.dtDateOfEvent)
                .HasPrecision(0);

            modelBuilder.Entity<vw_cvm_sez_todo_001>()
                .Property(e => e.ID_Ola)
                .IsUnicode(false);

            modelBuilder.Entity<vw_cvm_sez_todo_001>()
                .Property(e => e.ID_Fase)
                .IsUnicode(false);

            modelBuilder.Entity<vw_cvm_sez_todo_001>()
                .Property(e => e.strCodProd_Pos_1_1)
                .IsUnicode(false);

            modelBuilder.Entity<vw_cvm_sez_todo_001>()
                .Property(e => e.strCodProd_Pos_1_2)
                .IsUnicode(false);

            modelBuilder.Entity<vw_cvm_sez_todo_001>()
                .Property(e => e.strCodProd_Pos_1_3)
                .IsUnicode(false);

            modelBuilder.Entity<vw_cvm_sez_todo_001>()
                .Property(e => e.strCodProd_Pos_1_4)
                .IsUnicode(false);

            modelBuilder.Entity<vw_cvm_sez_todo_001>()
                .Property(e => e.strCodProd_Pos_1_5)
                .IsUnicode(false);

            modelBuilder.Entity<vw_cvm_sez_todo_001>()
                .Property(e => e.strCodProd_Pos_2_1)
                .IsUnicode(false);

            modelBuilder.Entity<vw_cvm_sez_todo_001>()
                .Property(e => e.strCodProd_Pos_2_2)
                .IsUnicode(false);

            modelBuilder.Entity<vw_cvm_sez_todo_001>()
                .Property(e => e.strCodProd_Pos_2_3)
                .IsUnicode(false);

            modelBuilder.Entity<vw_cvm_sez_todo_001>()
                .Property(e => e.strCodProd_Pos_2_4)
                .IsUnicode(false);

            modelBuilder.Entity<vw_cvm_sez_todo_001>()
                .Property(e => e.strCodProd_Pos_2_5)
                .IsUnicode(false);

            modelBuilder.Entity<vw_cvm_sez_todo_001>()
                .Property(e => e.ID_Ola_Master)
                .IsUnicode(false);

            modelBuilder.Entity<vw_cvm_sez_todo_001>()
                .Property(e => e.PesoUnitario_1_1)
                .HasPrecision(18, 3);

            modelBuilder.Entity<vw_cvm_sez_todo_001>()
                .Property(e => e.PesoUnitario_1_2)
                .HasPrecision(18, 3);

            modelBuilder.Entity<vw_cvm_sez_todo_001>()
                .Property(e => e.PesoUnitario_1_3)
                .HasPrecision(18, 3);

            modelBuilder.Entity<vw_cvm_sez_todo_001>()
                .Property(e => e.PesoUnitario_1_4)
                .HasPrecision(18, 3);

            modelBuilder.Entity<vw_cvm_sez_todo_001>()
                .Property(e => e.PesoUnitario_1_5)
                .HasPrecision(18, 3);

            modelBuilder.Entity<vw_cvm_sez_todo_001>()
                .Property(e => e.PesoUnitario_2_1)
                .HasPrecision(18, 3);

            modelBuilder.Entity<vw_cvm_sez_todo_001>()
                .Property(e => e.PesoUnitario_2_2)
                .HasPrecision(18, 3);

            modelBuilder.Entity<vw_cvm_sez_todo_001>()
                .Property(e => e.PesoUnitario_2_3)
                .HasPrecision(18, 3);

            modelBuilder.Entity<vw_cvm_sez_todo_001>()
                .Property(e => e.PesoUnitario_2_4)
                .HasPrecision(18, 3);

            modelBuilder.Entity<vw_cvm_sez_todo_001>()
                .Property(e => e.PesoUnitario_2_5)
                .HasPrecision(18, 3);

            modelBuilder.Entity<vw_LabelData>()
                .Property(e => e.C19)
                .IsFixedLength();

            modelBuilder.Entity<vw_mac_consumi_001_WIP>()
                .Property(e => e.ID_OLA)
                .IsUnicode(false);

            modelBuilder.Entity<vw_mov_DestinationCode>()
                .Property(e => e.DestinationCodeCVM)
                .IsFixedLength();

            modelBuilder.Entity<vw_mov_Destinationgroupdestinationstatus>()
                .Property(e => e.DestinationCodeCVM)
                .IsFixedLength();

            modelBuilder.Entity<vw_mov_DestinationPackaging>()
                .Property(e => e.trackingcode)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<vw_mov_DestinationPackaging>()
                .Property(e => e.UnitWeight)
                .HasPrecision(18, 3);

            modelBuilder.Entity<vw_mov_DestinationPackaging>()
                .Property(e => e.ItemCode)
                .IsFixedLength();

            modelBuilder.Entity<vw_mov_Destinationstatus>()
                .Property(e => e.DestinationCodeCVM)
                .IsFixedLength();

            modelBuilder.Entity<vw_mov_SlotOccupati>()
                .Property(e => e.Destinazione)
                .IsUnicode(false);

            modelBuilder.Entity<vw_mov_SlotOccupatiDettaglio>()
                .Property(e => e.Destinazione)
                .IsUnicode(false);

            modelBuilder.Entity<vw_mov_SlotOccupatiDettaglio>()
                .Property(e => e.trackingcode)
                .IsUnicode(false);

            modelBuilder.Entity<vw_mov_SlotOccupatiDettaglio>()
                .Property(e => e.key_gene)
                .IsUnicode(false);

            modelBuilder.Entity<vw_mov_UDCDetailDestinationGroup>()
                .Property(e => e.ItemCode)
                .IsFixedLength();

            modelBuilder.Entity<vw_mov_UDCDetailDestinationGroup>()
                .Property(e => e.ParentUdc)
                .IsUnicode(false);

            modelBuilder.Entity<vw_mov_UDCDetailDestinationGroup>()
                .Property(e => e.rfidApplicato)
                .IsUnicode(false);

            modelBuilder.Entity<vw_mov_UDCDetailDestinationGroup>()
                .Property(e => e.trackingcode)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<vw_mov_UDCDetailDestinationGroup>()
                .Property(e => e.trackingcode_dest)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<vw_mov_UDCDetailDestinationGroup>()
                .Property(e => e.OriginalDestination)
                .IsUnicode(false);

            modelBuilder.Entity<vw_mov_UDCDetailDestinationGroup>()
                .Property(e => e.DestinationCodeCVM)
                .IsFixedLength();

            modelBuilder.Entity<vw_mov_UDCDetailDestinationGroup>()
                .Property(e => e.PesoUnitario)
                .HasPrecision(18, 3);

            modelBuilder.Entity<vw_mov_UDCMagDetail>()
                .Property(e => e.trackingcode)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<vw_mov_UDCMagDetail>()
                .Property(e => e.Destination)
                .IsFixedLength();

            modelBuilder.Entity<vw_mov_UDCMagDetail>()
                .Property(e => e.cfiller1)
                .IsUnicode(false);

            modelBuilder.Entity<vw_mov_UDCMagDetail>()
                .Property(e => e.cfiller2)
                .IsUnicode(false);

            modelBuilder.Entity<vw_mov_UDCMagDetail>()
                .Property(e => e.cfiller3)
                .IsUnicode(false);

            modelBuilder.Entity<vw_mov_UDCMagDetail>()
                .Property(e => e.cfiller4)
                .IsUnicode(false);

            modelBuilder.Entity<vw_mov_UDCMagDetail>()
                .Property(e => e.cfiller5)
                .IsUnicode(false);

            modelBuilder.Entity<vw_mov_UDCMagDetail>()
                .Property(e => e.PesoUnitario)
                .HasPrecision(18, 3);

            modelBuilder.Entity<vw_mov_UDCQuantity>()
                .Property(e => e.KeyCode)
                .IsFixedLength();

            modelBuilder.Entity<vw_ProduzioniCalandra>()
                .Property(e => e.ItemUnitWeigth)
                .HasPrecision(18, 3);

            modelBuilder.Entity<vw_ProduzioniCalandra>()
                .Property(e => e.MaterialUnitWeigth)
                .HasPrecision(18, 3);

            modelBuilder.Entity<vw_ProduzioniLevigatrice>()
                .Property(e => e.ItemUnitWeigth)
                .HasPrecision(18, 3);

            modelBuilder.Entity<vw_ProduzioniLevigatrice>()
                .Property(e => e.MaterialUnitWeigth)
                .HasPrecision(18, 3);

            modelBuilder.Entity<vw_ProduzioniSezionatrice1>()
                .Property(e => e.ItemUnitWeigth)
                .HasPrecision(18, 3);

            modelBuilder.Entity<vw_ProduzioniSezionatrice1>()
                .Property(e => e.MaterialUnitWeigth)
                .HasPrecision(18, 3);
        }
    }
}
