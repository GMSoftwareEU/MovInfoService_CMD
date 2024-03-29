namespace MovInfoService_CMD.MODEL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class ola_messages
    {
        public int ID { get; set; }

        [StringLength(50)]
        public string message { get; set; }

        public int? parameter { get; set; }

        public int? executed { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? modified { get; set; }
    }
}
