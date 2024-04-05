namespace MovInfoService_CMD.MODEL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class mov_UDCDetail_todelete
    {
        [Key]
        public int IdDettUDC { get; set; }

        [StringLength(50)]
        public string UDCCode { get; set; }

        [StringLength(10)]
        public string Origin { get; set; }

        [StringLength(10)]
        public string Destination { get; set; }

        public int? ErpOrderId { get; set; }

        [StringLength(50)]
        public string Key_General { get; set; }

        public int? Colonna_applicazione { get; set; }

        public int? Riga_applicazione { get; set; }

        public int? Qty { get; set; }

        [StringLength(50)]
        public string ItemCode { get; set; }

        public float? PanelLength { get; set; }

        public float? PanelWidth { get; set; }

        public float? PanelThickness { get; set; }

        public int? Sequenza { get; set; }

        [StringLength(50)]
        public string ParentUdc { get; set; }

        [StringLength(50)]
        public string rfidApplicato { get; set; }

        public bool? flprocessed { get; set; }

        public DateTime? Dtflprocessed { get; set; }

        public DateTime? DtInsertDate { get; set; }

        public DateTime? DtProcessingDate { get; set; }

        [StringLength(17)]
        public string trackingcode { get; set; }

        public DateTime? DtProcessingMerge { get; set; }

        [StringLength(17)]
        public string trackingcode_dest { get; set; }

        public int? StackQty { get; set; }

        public bool? flsingprocessed { get; set; }

        public DateTime? DtSingProcessed { get; set; }

        public int? ErpRigaPianoCaricoID { get; set; }

        [StringLength(10)]
        public string OriginalDestination { get; set; }

        public DateTime? DtProcessingDateDestination { get; set; }

        public bool? flmagudcdetail { get; set; }
    }
}
