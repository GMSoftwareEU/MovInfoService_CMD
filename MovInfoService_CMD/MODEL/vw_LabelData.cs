namespace MovInfoService_CMD.MODEL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class vw_LabelData
    {
        [Key]
        [Column("1")]
        public int C1 { get; set; }

        [Column("2")]
        [StringLength(30)]
        public string C2 { get; set; }

        [Column("3")]
        [StringLength(30)]
        public string C3 { get; set; }

        [Column("4")]
        public int? C4 { get; set; }

        [Column("5", TypeName = "date")]
        public DateTime? C5 { get; set; }

        [Column("6")]
        [StringLength(50)]
        public string C6 { get; set; }

        [Column("7")]
        [StringLength(250)]
        public string C7 { get; set; }

        [Column("8")]
        [StringLength(50)]
        public string C8 { get; set; }

        [Column("9")]
        public float? C9 { get; set; }

        [Column("10")]
        public float? C10 { get; set; }

        [Column("11")]
        public float? C11 { get; set; }

        [Column("12")]
        public float? C12 { get; set; }

        [Column("13")]
        [StringLength(50)]
        public string C13 { get; set; }

        [Column("14")]
        [StringLength(250)]
        public string C14 { get; set; }

        [Column("15")]
        [StringLength(50)]
        public string C15 { get; set; }

        [Column("16")]
        [StringLength(50)]
        public string C16 { get; set; }

        [Column("17")]
        [StringLength(10)]
        public string C17 { get; set; }

        [Column("18")]
        [StringLength(10)]
        public string C18 { get; set; }

        [Column("19")]
        [StringLength(10)]
        public string C19 { get; set; }

        [Column("20")]
        public int? C20 { get; set; }

        [Column("21", TypeName = "date")]
        public DateTime? C21 { get; set; }

        [Column("22")]
        [StringLength(50)]
        public string C22 { get; set; }

        [Column("23", TypeName = "date")]
        public DateTime? C23 { get; set; }

        [Column("24")]
        [StringLength(50)]
        public string C24 { get; set; }

        [Column("25")]
        [StringLength(250)]
        public string C25 { get; set; }

        [Column("26")]
        [StringLength(50)]
        public string C26 { get; set; }

        [Column("27")]
        [StringLength(50)]
        public string C27 { get; set; }

        [Column("28")]
        [StringLength(10)]
        public string C28 { get; set; }

        [Column("29")]
        [StringLength(25)]
        public string C29 { get; set; }

        [Column("30")]
        [StringLength(10)]
        public string C30 { get; set; }

        [Column("31")]
        public float? C31 { get; set; }

        [Column("32")]
        public float? C32 { get; set; }

        [Column("33")]
        public DateTime? C33 { get; set; }
    }
}
