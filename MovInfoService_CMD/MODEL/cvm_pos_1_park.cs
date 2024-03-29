namespace MovInfoService_CMD.MODEL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class cvm_pos_1_park
    {
        public int ID { get; set; }

        [Required]
        [StringLength(8)]
        public string ID_Ola { get; set; }

        [Required]
        [StringLength(8)]
        public string ID_Fase { get; set; }

        public long iQuantita_Pezzi_Prod { get; set; }

        public long iQuantita_Pezzi_Scarto { get; set; }

        [Required]
        [StringLength(50)]
        public string Causale { get; set; }

        [Required]
        [StringLength(50)]
        public string Key_General { get; set; }

        public short iOperation { get; set; }

        [StringLength(50)]
        public string ErroreSagoma { get; set; }

        public int? Eseguito { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? DataModifica { get; set; }
    }
}
