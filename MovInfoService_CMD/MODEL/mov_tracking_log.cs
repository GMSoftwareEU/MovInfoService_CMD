namespace MovInfoService_CMD.MODEL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class mov_tracking_log
    {
        public int id { get; set; }

        [StringLength(50)]
        public string Key_General { get; set; }

        public int? Riga { get; set; }

        public int? Colonna { get; set; }

        [StringLength(17)]
        public string trackingcode { get; set; }

        [StringLength(10)]
        public string Destination { get; set; }

        public DateTime? DtInsertDate { get; set; }

        public DateTime? DtProcessingDate { get; set; }
    }
}
