namespace MovInfoService_CMD.MODEL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class cvm_pos_1_in
    {
        public int ID { get; set; }

        [Required]
        [StringLength(50)]
        public string Key_General { get; set; }

        public short? iDestination { get; set; }

        public short Stato { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? DateModify { get; set; }

        public long? QtyValidatedPieces { get; set; }

        public long? QtyDiscardedPieces { get; set; }
    }
}
