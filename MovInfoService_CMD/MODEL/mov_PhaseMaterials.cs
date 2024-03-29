namespace MovInfoService_CMD.MODEL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class mov_PhaseMaterials
    {
        [Key]
        public int PhaseMaterialsId { get; set; }

        public int ErpPhaseId { get; set; }

        [StringLength(150)]
        public string MaterialItemCode { get; set; }

        [StringLength(250)]
        public string MaterialItemDescription { get; set; }

        public int? Qty { get; set; }

        [StringLength(10)]
        public string UM { get; set; }

        [StringLength(50)]
        public string Position { get; set; }

        public DateTime? dtInsertDate { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? MaterialItemCodeLenght { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? MaterialItemCodeWidth { get; set; }

        [StringLength(10)]
        public string MaterialItemCodeType { get; set; }

        public int? MaterialItemId { get; set; }
    }
}
