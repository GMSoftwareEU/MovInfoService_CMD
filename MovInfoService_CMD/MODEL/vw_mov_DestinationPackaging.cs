namespace MovInfoService_CMD.MODEL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class vw_mov_DestinationPackaging
    {
        [StringLength(50)]
        public string UDCCode { get; set; }

        [StringLength(17)]
        public string trackingcode { get; set; }

        [Key]
        [Column(TypeName = "numeric")]
        public decimal UnitWeight { get; set; }

        [StringLength(10)]
        public string Destination { get; set; }

        public int? Qty { get; set; }

        public int? StackQty { get; set; }

        [StringLength(50)]
        public string ItemCode { get; set; }

        public int? ErpOrderId { get; set; }

        public int? ErpRigaPianoCaricoID { get; set; }

        public int? ManualExtractionId { get; set; }
    }
}
