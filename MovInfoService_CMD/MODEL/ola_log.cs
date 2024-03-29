namespace MovInfoService_CMD.MODEL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class ola_log
    {
        public int ID { get; set; }

        [StringLength(255)]
        public string DESCR { get; set; }

        [StringLength(255)]
        public string FUNC { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? LOGDT { get; set; }
    }
}
