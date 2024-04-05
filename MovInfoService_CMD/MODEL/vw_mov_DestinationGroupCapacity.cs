namespace MovInfoService_CMD.MODEL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class vw_mov_DestinationGroupCapacity
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(20)]
        public string codice { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(50)]
        public string descrizione { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int SlotMassimi { get; set; }

        [Key]
        [Column(Order = 3)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int SlotOccupati { get; set; }

        [Key]
        [Column(Order = 4)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int SlotLivelloSaturazione { get; set; }

        public int? SlotDisponibili { get; set; }
    }
}
