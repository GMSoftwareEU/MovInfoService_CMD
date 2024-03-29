namespace MovInfoService_CMD.MODEL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("_mov_LabelParams_obsoleta")]
    public partial class C_mov_LabelParams_obsoleta
    {
        [Key]
        [Column(Order = 0)]
        public int UID { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ParamID { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(100)]
        public string ParamName { get; set; }
    }
}
