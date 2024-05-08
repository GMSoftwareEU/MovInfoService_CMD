namespace MovInfoService_CMD.MODEL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class vw_mov_SlotOccupati
    {
        [Key]
        [StringLength(50)]
        public string Destinazione { get; set; }

        public int? DestCVM { get; set; }

        public int? SlotOccupati { get; set; }
    }
}
