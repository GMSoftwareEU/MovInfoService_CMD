namespace MovInfoService_CMD.MODEL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class rfid_global
    {
        public int ID { get; set; }

        [Required]
        [StringLength(8)]
        public string ID_Ola { get; set; }

        [Required]
        [StringLength(8)]
        public string ID_Fase { get; set; }

        [Required]
        [StringLength(50)]
        public string codice_rfid { get; set; }

        public int? iCodProdotto { get; set; }

        public int? iDestFaseSuccessiva { get; set; }

        public int iPieceQuantity { get; set; }

        [Column("ssma$rowid")]
        public Guid ssma_rowid { get; set; }
    }
}
