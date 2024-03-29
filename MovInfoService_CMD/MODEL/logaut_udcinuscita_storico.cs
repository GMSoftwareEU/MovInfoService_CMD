namespace MovInfoService_CMD.MODEL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class logaut_udcinuscita_storico
    {
        public int ID { get; set; }

        [StringLength(50)]
        public string UDC { get; set; }

        public int? Destinazione { get; set; }

        public int? Esito { get; set; }

        [StringLength(1)]
        public string Stato { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? DataModifica { get; set; }

        [StringLength(50)]
        public string UtenteModifica { get; set; }

        public DateTime? dtProcessingDate { get; set; }
    }
}
