namespace MovInfoService_CMD.MODEL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class mov_PackagingInfo
    {
        [Key]
        [Column(Order = 0)]
        public int id { get; set; }

        public int? ErpOrderId { get; set; }

        public int? ErpRigaPianoCaricoID { get; set; }

        public int? ManualExtractionId { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(10)]
        public string TipoImballo { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(50)]
        public string ItemCode { get; set; }
    }
}
