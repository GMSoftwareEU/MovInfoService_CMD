namespace MovInfoService_CMD.MODEL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class vw_AnagArticoli
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int iCodProd { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(50)]
        public string strCodProd { get; set; }

        [StringLength(100)]
        public string strDesProd { get; set; }

        [Key]
        [Column(Order = 2, TypeName = "numeric")]
        public decimal pesoUni { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? lunghezza { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? larghezza { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? spessore { get; set; }
    }
}
