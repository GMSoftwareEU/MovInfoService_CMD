namespace MovInfoService_CMD.MODEL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class mac_manut_storico
    {
        public int ID { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? data_ora { get; set; }

        public short cod_macchina { get; set; }

        [Required]
        [StringLength(50)]
        public string DESCR { get; set; }
    }
}
