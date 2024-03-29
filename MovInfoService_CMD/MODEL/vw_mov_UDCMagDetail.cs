namespace MovInfoService_CMD.MODEL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class vw_mov_UDCMagDetail
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int UDCMagDetailId { get; set; }

        public int? ErpOrderId { get; set; }

        [StringLength(50)]
        public string UDCCode { get; set; }

        [StringLength(50)]
        public string ItemCode { get; set; }

        public int? Qty { get; set; }

        [StringLength(10)]
        public string Origin { get; set; }

        [StringLength(17)]
        public string trackingcode { get; set; }

        public float? PanelLength { get; set; }

        public float? PanelWidth { get; set; }

        public float? PanelThickness { get; set; }

        public int? Sequenza { get; set; }

        [StringLength(10)]
        public string Destination { get; set; }

        [StringLength(50)]
        public string ErpCodicePallet { get; set; }

        public int? nfiller1 { get; set; }

        public int? nfiller2 { get; set; }

        public int? nfiller3 { get; set; }

        public int? nfiller4 { get; set; }

        public int? nfiller5 { get; set; }

        [StringLength(200)]
        public string cfiller1 { get; set; }

        [StringLength(200)]
        public string cfiller2 { get; set; }

        [StringLength(200)]
        public string cfiller3 { get; set; }

        [StringLength(200)]
        public string cfiller4 { get; set; }

        [StringLength(200)]
        public string cfiller5 { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? dfiller1 { get; set; }
    }
}
