namespace MovInfoService_CMD.MODEL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class vw_mov_DestinationCode
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
        [StringLength(20)]
        public string DestinazionGroupCode { get; set; }

        [StringLength(50)]
        public string ERPCDL { get; set; }

        [StringLength(5)]
        public string DestinationCodeCVM { get; set; }

        public int? ErpLocationCVM { get; set; }
    }
}
