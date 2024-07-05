namespace MovInfoService_CMD.MODEL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class vw_mov_SlotOccupatiDettaglio
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(50)]
        public string Destinazione { get; set; }

        public int? DestCVM { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(50)]
        public string trackingcode { get; set; }

        [StringLength(50)]
        public string key_gene { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int col { get; set; }

        [Key]
        [Column(Order = 3)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int riga { get; set; }

        [Key]
        [Column(Order = 4)]
        [StringLength(50)]
        public string pos_attuale { get; set; }
    }
}
