namespace MovInfoService_CMD.MODEL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class mac_consumi_001_view
    {
        [StringLength(8)]
        public string ID_OLA { get; set; }

        [StringLength(8)]
        public string ID_FASE { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? dtDateOfEvent { get; set; }

        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int dEvent { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int dQuantity { get; set; }

        [StringLength(50)]
        public string strCodArt { get; set; }

        [StringLength(50)]
        public string strUDC { get; set; }
    }
}
