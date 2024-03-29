namespace MovInfoService_CMD.MODEL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class mov_LabelType
    {
        [Key]
        public int IdLabelType { get; set; }

        [Required]
        [StringLength(30)]
        public string LabelType { get; set; }

        [Required]
        public string SqlCode { get; set; }
    }
}
