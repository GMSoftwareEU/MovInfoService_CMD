namespace MovInfoService_CMD.MODEL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class vw_parameters_IMBA_TODELETE
    {
        public int? Priority { get; set; }

        public int? Year { get; set; }

        public long? Num { get; set; }

        [StringLength(50)]
        public string ProductionJobOrder { get; set; }

        public int? ErpId { get; set; }

        public int? ErpPhaseid { get; set; }

        public int? ItemId { get; set; }

        [StringLength(50)]
        public string ItemCode { get; set; }

        [StringLength(250)]
        public string ItemDescription { get; set; }

        public int? QtaOP { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? LarghArticolo { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? LunghArticolo { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? SpessoreArticolo { get; set; }

        [Key]
        [Column(Order = 0)]
        [StringLength(10)]
        public string CodiceTipoImballo { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(20)]
        public string TipoMateriale { get; set; }

        [Key]
        [Column(Order = 2)]
        public bool listelli { get; set; }

        [Key]
        [Column(Order = 3)]
        public bool reggiatura { get; set; }

        [Key]
        [Column(Order = 4)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int tensione { get; set; }

        [Key]
        [Column(Order = 5)]
        public bool cartoneup { get; set; }

        [Key]
        [Column(Order = 6)]
        public bool cartonedown { get; set; }

        [Key]
        [Column(Order = 7)]
        public bool angolariup { get; set; }

        [Key]
        [Column(Order = 8)]
        public bool angolaridown { get; set; }

        [Key]
        [Column(Order = 9)]
        [StringLength(20)]
        public string tipocolla { get; set; }

        public int? Qty4Pallet { get; set; }
    }
}
