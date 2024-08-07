namespace MovInfoService_CMD.MODEL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class anag_articoli
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int iCodProd { get; set; }

        [Required]
        [StringLength(50)]
        public string strCodProd { get; set; }

        [StringLength(100)]
        public string strDesProd { get; set; }

        [Column(TypeName = "numeric")]
        public decimal peso { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? lunghezza { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? larghezza { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? spessore { get; set; }
    }
}
