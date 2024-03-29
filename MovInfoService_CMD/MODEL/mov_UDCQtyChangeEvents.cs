namespace MovInfoService_CMD.MODEL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class mov_UDCQtyChangeEvents
    {
        [Key]
        [Column(Order = 0)]
        public int ID { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(50)]
        public string KeyCode { get; set; }

        public DateTime? DateEvent { get; set; }

        public long? Quantity { get; set; }

        [StringLength(100)]
        public string Note { get; set; }

        public DateTime? dtProcessingDate { get; set; }

        [StringLength(50)]
        public string Extra1 { get; set; }

        [StringLength(50)]
        public string Extra2 { get; set; }
    }
}
