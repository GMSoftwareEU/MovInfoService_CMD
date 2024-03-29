namespace MovInfoService_CMD.MODEL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class logaut_udciningresso_storico
    {
        public int ID { get; set; }

        public int? Posizione { get; set; }

        [StringLength(50)]
        public string UDC { get; set; }

        public int? Destinazione { get; set; }

        [StringLength(1)]
        public string Stato { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? DataModifica { get; set; }

        [StringLength(50)]
        public string UtenteModifica { get; set; }
    }
}
