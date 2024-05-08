namespace MovInfoService_CMD.MODEL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class vw_ProduzioniLevigatrice
    {
        public int? ErpId { get; set; }

        public int? Year { get; set; }

        public long? Num { get; set; }

        [StringLength(20)]
        public string WorkCenter { get; set; }

        [StringLength(20)]
        public string Machine { get; set; }

        public int? PhaseOrder { get; set; }

        [StringLength(150)]
        public string MaterialItemCode { get; set; }

        [StringLength(250)]
        public string MaterialItemDescription { get; set; }

        public int? QtyMP { get; set; }

        [StringLength(10)]
        public string UM { get; set; }

        [StringLength(50)]
        public string Position { get; set; }

        [StringLength(50)]
        public string ItemCode { get; set; }

        public int? Qty { get; set; }

        public int? Priority { get; set; }

        [StringLength(250)]
        public string ItemDescription { get; set; }

        public DateTime? ProductionDate { get; set; }

        [StringLength(50)]
        public string ProductionJobOrder { get; set; }

        public int? ItemId { get; set; }

        [Key]
        [Column(Order = 0, TypeName = "numeric")]
        public decimal ItemUnitWeigth { get; set; }

        [Key]
        [Column(Order = 1, TypeName = "numeric")]
        public decimal MaterialUnitWeigth { get; set; }
    }
}
