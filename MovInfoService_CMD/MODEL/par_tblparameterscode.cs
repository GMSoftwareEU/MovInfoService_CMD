namespace MovInfoService_CMD.MODEL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class par_tblparameterscode
    {
        public int ID { get; set; }

        [Required]
        public string code { get; set; }

        [Required]
        public string description { get; set; }

        [Required]
        [StringLength(20)]
        public string WorkCenter { get; set; }

        [Required]
        [StringLength(20)]
        public string Machine { get; set; }

        public string Note { get; set; }
    }
}
