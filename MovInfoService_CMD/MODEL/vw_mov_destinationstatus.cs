namespace MovInfoService_CMD.MODEL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class vw_mov_Destinationstatus
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(5)]
        public string DestinationCode { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(250)]
        public string DestinationDescription { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(2)]
        public string StatusCode { get; set; }

        [StringLength(5)]
        public string DestinationCodeCVM { get; set; }
    }
}
