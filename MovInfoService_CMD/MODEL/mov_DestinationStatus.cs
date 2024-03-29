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
        [StringLength(5)]
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
        public string DestinazionGroupCapacity { get; set; }

        [StringLength(20)]
        public string PrinterNameAutomaticIn { get; set; }

        [StringLength(20)]
        public string PrinterNameAutomaticOut { get; set; }

        [StringLength(50)]
        public string ErpCdl { get; set; }

        [StringLength(5)]
        public string DestinationCodeCVM { get; set; }

        public int? ErpLocationCVM { get; set; }

        public virtual mov_DestinazionGroupCapacity mov_DestinazionGroupCapacity { get; set; }
    }
}
