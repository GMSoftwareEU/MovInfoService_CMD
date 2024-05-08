namespace MovInfoService_CMD.MODEL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class mov_UDCMagDetail
    {
        [Key]
        public int UDCMagDetailId { get; set; }

        public int? ErpOrderId { get; set; }

        [StringLength(50)]
        public string UDCCode { get; set; }

        public int? Qty { get; set; }

        [StringLength(50)]
        public string ItemCode { get; set; }

        [StringLength(10)]
        public string Origin { get; set; }

        public bool? Fl_LastUDC { get; set; }

        public bool? Fl_LostUDC { get; set; }

        public DateTime? dtInsertDate { get; set; }

        public DateTime? DtProcessingDate { get; set; }

        [StringLength(17)]
        public string trackingcode { get; set; }

        public int? IdDettUDC { get; set; }

        public bool flSendToImag { get; set; }

        public bool? flConfirmedSendToImag { get; set; }

        public bool flReceivedFromImag { get; set; }

        [StringLength(10)]
        public string Destination { get; set; }
    }
}
