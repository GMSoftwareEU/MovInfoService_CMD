namespace MovInfoService_CMD.MODEL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tblprioritycover")]
    public partial class tblprioritycover
    {
        public int ID { get; set; }

        [StringLength(50)]
        public string Priority1_cod { get; set; }

        public int? Priority1_qty { get; set; }

        public float? Priority1_length { get; set; }

        public float? Priority1_width { get; set; }

        public float? Priority1_thickness { get; set; }

        public int? Priority1_mat { get; set; }

        public int? Priority1_dest { get; set; }

        [StringLength(50)]
        public string Priority2_cod { get; set; }

        public int? Priority2_qty { get; set; }

        public float? Priority2_length { get; set; }

        public float? Priority2_width { get; set; }

        public float? Priority2_thickness { get; set; }

        public int? Priority2_mat { get; set; }

        public int? Priority2_dest { get; set; }

        [StringLength(50)]
        public string Priority3_cod { get; set; }

        public int? Priority3_dest { get; set; }

        public int? Priority3_qty { get; set; }

        public float? Priority3_length { get; set; }

        public float? Priority3_width { get; set; }

        public float? Priority3_thickness { get; set; }

        public int? Priority3_mat { get; set; }

        [StringLength(50)]
        public string Priority4_cod { get; set; }

        public int? Priority4_qty { get; set; }

        public float? Priority4_length { get; set; }

        public float? Priority4_width { get; set; }

        public float? Priority4_thickness { get; set; }

        public int? Priority4_mat { get; set; }

        public int? Priority4_dest { get; set; }

        public DateTime? dtInsertDate { get; set; }
    }
}
