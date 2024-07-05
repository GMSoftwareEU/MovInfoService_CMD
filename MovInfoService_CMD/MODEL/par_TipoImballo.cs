namespace MovInfoService_CMD.MODEL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class par_TipoImballo
    {
        [Key]
        [StringLength(10)]
        public string CodiceTipoImballo { get; set; }

        [Required]
        [StringLength(20)]
        public string TipoMateriale { get; set; }

        public bool listelli { get; set; }

        public bool reggiatura { get; set; }

        public int tensione { get; set; }

        public bool cartoneup { get; set; }

        public bool cartonedown { get; set; }

        public bool angolariup { get; set; }

        public bool angolaridown { get; set; }

        [Required]
        [StringLength(20)]
        public string tipocolla { get; set; }
    }
}
