namespace MovInfoService_CMD.MODEL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class mov_UDCLoadLocationRequest
    {
        [Key]
        [Column(Order = 0)]
        public int idLoadLocationRequest { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(50)]
        public string UDCCode { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(10)]
        public string Destination { get; set; }

        public DateTime? DtProcessingDate { get; set; }
    }
}
