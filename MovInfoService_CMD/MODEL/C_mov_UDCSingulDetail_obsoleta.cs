namespace MovInfoService_CMD.MODEL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("_mov_UDCSingulDetail_obsoleta")]
    public partial class C_mov_UDCSingulDetail_obsoleta
    {
        [Key]
        public int UDCSingulDetailId { get; set; }

        [StringLength(50)]
        public string UDCCode { get; set; }

        [StringLength(50)]
        public string Key_General { get; set; }

        public int? Riga_applicazione { get; set; }

        public int? Colonna_applicazione { get; set; }

        public int? OrderId { get; set; }

        [StringLength(50)]
        public string SubUDCCode { get; set; }

        public float? SDLength { get; set; }

        public float? SDWidth { get; set; }

        public float? SDThickness { get; set; }
    }
}
