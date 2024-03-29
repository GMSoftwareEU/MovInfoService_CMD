namespace MovInfoService_CMD.MODEL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class mov_UDCRequest
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

        [StringLength(50)]
        public string ErpCodicePallet { get; set; }

        public int? Sequenza { get; set; }

        [StringLength(50)]
        public string ParentUdc { get; set; }

        [StringLength(50)]
        public string rfidApplicato { get; set; }

        public bool? flprocessed { get; set; }

        public DateTime? dtInsertDate { get; set; }

        public DateTime? DtProcessingDate { get; set; }
    }
}
