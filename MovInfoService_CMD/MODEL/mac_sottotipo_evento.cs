namespace MovInfoService_CMD.MODEL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class mac_sottotipo_evento
    {
        public int ID { get; set; }

        public short cod_macchina { get; set; }

        public short? sottotipo_evento { get; set; }

        [StringLength(70)]
        public string descr_sottotipo_evento { get; set; }

        public short? Diretto_Indiretto { get; set; }

        public short? Tempo_Max_Evento_Min { get; set; }
    }
}
