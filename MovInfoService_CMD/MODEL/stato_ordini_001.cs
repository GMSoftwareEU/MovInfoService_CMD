namespace MovInfoService_CMD.MODEL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class stato_ordini_001
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

        public int Centro_Lavoro { get; set; }

        public int Stato_Avanzamento { get; set; }

        public int dQuantityProduced { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime dtDateStartWork { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime dtDateEndWord { get; set; }
    }
}
