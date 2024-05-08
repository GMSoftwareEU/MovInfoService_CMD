namespace MovInfoService_CMD.MODEL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class mov_ProductionOrders
    {
        [Key]
        public int OrderId { get; set; }

        public int? Year { get; set; }

        public long? Num { get; set; }

        public int? ErpId { get; set; }

        [StringLength(50)]
        public string ItemCode { get; set; }

        [StringLength(50)]
        public string ProductionJobOrder { get; set; }

        public int? Qty { get; set; }

        public DateTime? ProductionDate { get; set; }

        public int? Priority { get; set; }

        [StringLength(250)]
        public string ItemDescription { get; set; }

        [StringLength(5)]
        public string ErpOrderType { get; set; }

        [StringLength(50)]
        public string ErpCodicePallet { get; set; }

        public DateTime? dtInsertDate { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? ItemCodeLenght { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? ItemCodeWidth { get; set; }

        public int? ItemId { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? ItemCodeThickness { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? PesoUnitario { get; set; }

        public bool attivo { get; set; }
    }
}
