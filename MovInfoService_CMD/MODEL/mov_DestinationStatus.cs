namespace MovInfoService_CMD.MODEL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class mov_DestinationStatus
    {
        public int Id { get; set; }

        [Required]
        [StringLength(8)]
        public string DestinationCode { get; set; }

        [Required]
        [StringLength(250)]
        public string DestinationDescription { get; set; }

        [Required]
        [StringLength(2)]
        public string StatusCode { get; set; }

        public bool? ConsideraPerInfoService { get; set; }

        [StringLength(20)]
        public string PrinterName { get; set; }

        [StringLength(20)]
        public string DestinationGroupCapacity { get; set; }

        [StringLength(20)]
        public string PrinterNameAutomaticIn { get; set; }

        [StringLength(20)]
        public string PrinterNameAutomaticOut { get; set; }

        [StringLength(50)]
        public string ErpCdl { get; set; }

        [StringLength(5)]
        public string DestinationCodeCVM { get; set; }

        public int? ErpLocationCVM { get; set; }

        [StringLength(20)]
        public string LocationCodeR1C { get; set; }

        public virtual mov_DestinationGroupCapacity mov_DestinationGroupCapacity { get; set; }
    }
}
