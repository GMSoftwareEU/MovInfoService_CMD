namespace MovInfoService_CMD.MODEL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class vw_mov_status
    {
        [Key]
        [StringLength(2)]
        public string StatusCode { get; set; }

        [StringLength(250)]
        public string StatusDescription { get; set; }

        public bool? InServizio { get; set; }
    }
}
