namespace MovInfoService_CMD.MODEL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class mov_Tracking_udc
    {
        public int id { get; set; }

        [Required]
        [StringLength(17)]
        public string trackingcode { get; set; }

        public int? ErpOrderID { get; set; }

        public int Qta { get; set; }

        [Required]
        [StringLength(50)]
        public string CdlOrigine { get; set; }

        public int Operazione { get; set; }

        public DateTime? dtInsertDate { get; set; }

        public DateTime? DtProcessingDate { get; set; }

        public string extrainfo { get; set; }

        public bool? chiusura { get; set; }

        public bool? apertura { get; set; }

        public int? ErpRigaPianoCaricoID { get; set; }
    }
}
