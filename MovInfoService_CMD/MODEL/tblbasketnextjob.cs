namespace MovInfoService_CMD.MODEL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tblbasketnextjob")]
    public partial class tblbasketnextjob
    {
        public int ID { get; set; }

        [StringLength(50)]
        public string ID_OLA { get; set; }

        public float? Line1_length { get; set; }

        public float? Line1_width { get; set; }

        public float? Line1_thickness { get; set; }

        [StringLength(50)]
        public string Line1_cod { get; set; }

        public int? Line1_mat { get; set; }

        public int? Line1_lathsForPanel { get; set; }

        public int? Line1_totalLaths { get; set; }

        public float? Line2_length { get; set; }

        public float? Line2_width { get; set; }

        public float? Line2_thickness { get; set; }

        [StringLength(50)]
        public string Line2_cod { get; set; }

        public int? Line2_mat { get; set; }

        public int? Line2_lathsForPanel { get; set; }

        public int? Line2_totalLaths { get; set; }

        public float? Line3_length { get; set; }

        public float? Line3_width { get; set; }

        public float? Line3_thickness { get; set; }

        [StringLength(50)]
        public string Line3_cod { get; set; }

        public int? Line3_mat { get; set; }

        public int? Line3_lathsForPanel { get; set; }

        public int? Line3_totalLaths { get; set; }

        public float? Line4_length { get; set; }

        public float? Line4_width { get; set; }

        public float? Line4_thickness { get; set; }

        [StringLength(50)]
        public string Line4_cod { get; set; }

        public int? Line4_mat { get; set; }

        public int? Line4_lathsForPanel { get; set; }

        public int? Line4_totalLaths { get; set; }

        public DateTime? DataInvioImag { get; set; }

        public DateTime? dtInsertDate { get; set; }
    }
}
