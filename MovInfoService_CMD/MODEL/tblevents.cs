namespace MovInfoService_CMD.MODEL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tblevents
    {
        [StringLength(8)]
        public string ID_OLA { get; set; }

        [StringLength(8)]
        public string ID_Fase { get; set; }

        [Key]
        public int idRecord { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? dtDateOfEvent { get; set; }

        public int dEvent { get; set; }

        public int dSubEvent1 { get; set; }

        public int dSubEvent2 { get; set; }

        public int dSubEvent3 { get; set; }

        public int dSubEvent4 { get; set; }

        public int dSubEvent5 { get; set; }

        public int dSubEvent6 { get; set; }

        public int dSubEvent7 { get; set; }

        public int dSubEvent8 { get; set; }

        public int dSubEvent9 { get; set; }

        [StringLength(50)]
        public string dSubEvent10 { get; set; }

        [StringLength(50)]
        public string dSubEvent11 { get; set; }
    }
}
