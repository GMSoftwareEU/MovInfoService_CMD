namespace MovInfoService_CMD.MODEL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class mac_produzioni
    {
        public int ID { get; set; }

        [Required]
        [StringLength(8)]
        public string ID_Ola { get; set; }

        [Required]
        [StringLength(8)]
        public string ID_Fase { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime Data_Ultima_Modifica { get; set; }

        public int Quantità_Prodotta { get; set; }

        public int Quantità_Scarto { get; set; }

        public int iTypeMoviment { get; set; }

        public int Centro_Lavoro { get; set; }
    }
}
