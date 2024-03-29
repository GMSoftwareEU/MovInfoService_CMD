namespace MovInfoService_CMD.MODEL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tblpriorityhoney")]
    public partial class tblpriorityhoney
    {
        public int ID { get; set; }

        [Required]
        [StringLength(8)]
        public string Id_Ola { get; set; }

        [Required]
        [StringLength(50)]
        public string strCodHoney { get; set; }

        public float iHoney_Qty_ml { get; set; }

        public DateTime? dtInsertDate { get; set; }
    }
}
