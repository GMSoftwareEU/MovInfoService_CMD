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
        [Column("1", Order = 0)]
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

        [Key]
        [Column("34", Order = 1)]
        [StringLength(1)]
        public string C34 { get; set; }

        [Key]
        [Column("35", Order = 2)]
        [StringLength(1)]
        public string C35 { get; set; }

        [Key]
        [Column("36", Order = 3)]
        [StringLength(1)]
        public string C36 { get; set; }

        [Key]
        [Column("37", Order = 4)]
        [StringLength(1)]
        public string C37 { get; set; }

        [Key]
        [Column("38", Order = 5)]
        [StringLength(1)]
        public string C38 { get; set; }

        [Key]
        [Column("39", Order = 6)]
        [StringLength(1)]
        public string C39 { get; set; }

        [Key]
        [Column("40", Order = 7)]
        [StringLength(1)]
        public string C40 { get; set; }

        [Key]
        [Column("41", Order = 8)]
        [StringLength(1)]
        public string C41 { get; set; }

        [Key]
        [Column("42", Order = 9)]
        [StringLength(1)]
        public string C42 { get; set; }

        [Key]
        [Column("43", Order = 10)]
        [StringLength(1)]
        public string C43 { get; set; }

        [Key]
        [Column("44", Order = 11)]
        [StringLength(1)]
        public string C44 { get; set; }

        [Key]
        [Column("45", Order = 12)]
        [StringLength(1)]
        public string C45 { get; set; }

        [Key]
        [Column("46", Order = 13)]
        [StringLength(1)]
        public string C46 { get; set; }

        [Key]
        [Column("47", Order = 14)]
        [StringLength(1)]
        public string C47 { get; set; }

        [Key]
        [Column("48", Order = 15)]
        [StringLength(1)]
        public string C48 { get; set; }

        [Key]
        [Column("49", Order = 16)]
        [StringLength(1)]
        public string C49 { get; set; }

        [Key]
        [Column("50", Order = 17)]
        [StringLength(1)]
        public string C50 { get; set; }

        [Key]
        [Column("51", Order = 18)]
        [StringLength(1)]
        public string C51 { get; set; }

        [Key]
        [Column("52", Order = 19)]
        [StringLength(1)]
        public string C52 { get; set; }

        [Key]
        [Column("53", Order = 20)]
        [StringLength(1)]
        public string C53 { get; set; }

        [Key]
        [Column("54", Order = 21)]
        [StringLength(1)]
        public string C54 { get; set; }

        [Column("55")]
        [StringLength(100)]
        public string C55 { get; set; }

        [Column("56")]
        [StringLength(100)]
        public string C56 { get; set; }

        [Column("57")]
        [StringLength(100)]
        public string C57 { get; set; }

        [Column("58")]
        [StringLength(100)]
        public string C58 { get; set; }

        [Column("59")]
        [StringLength(100)]
        public string C59 { get; set; }

        [Column("60")]
        [StringLength(100)]
        public string C60 { get; set; }

        [Column("61")]
        [StringLength(100)]
        public string C61 { get; set; }

        [Column("62")]
        [StringLength(100)]
        public string C62 { get; set; }

        [Column("63")]
        [StringLength(100)]
        public string C63 { get; set; }

        [Column("64")]
        [StringLength(100)]
        public string C64 { get; set; }

        [Column("65")]
        [StringLength(100)]
        public string C65 { get; set; }

        [Column("66")]
        [StringLength(100)]
        public string C66 { get; set; }

        [Column("67")]
        [StringLength(100)]
        public string C67 { get; set; }

        [Column("68")]
        [StringLength(100)]
        public string C68 { get; set; }

        [Column("69")]
        [StringLength(100)]
        public string C69 { get; set; }

        [Column("70")]
        [StringLength(100)]
        public string C70 { get; set; }
    }
}
