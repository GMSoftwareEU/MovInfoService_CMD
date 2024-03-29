namespace MovInfoService_CMD.MODEL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("_mov_Cdl_obsoleta")]
    public partial class C_mov_Cdl_obsoleta
    {
        [Key]
        [Column(Order = 0)]
        public int IdCdl { get; set; }

        [StringLength(10)]
        public string CodeCdl { get; set; }

        [StringLength(50)]
        public string DesCdl { get; set; }

        [Key]
        [Column(Order = 1)]
        public bool flCreateUdc { get; set; }
    }
}
