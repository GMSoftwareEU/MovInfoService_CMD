namespace MovInfoService_CMD.MODEL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class par_tblprojectdefaultparameters
    {
        [Key]
        [Column(Order = 0)]
        public int Id { get; set; }

        [Key]
        [Column(Order = 1)]
        public bool flDftPar { get; set; }

        [StringLength(50)]
        public string ProjectCode { get; set; }

        public int? ID_CodArt { get; set; }

        [StringLength(30)]
        public string CodArt { get; set; }

        [StringLength(200)]
        public string DesArt { get; set; }

        [StringLength(30)]
        public string Variant { get; set; }

        [Key]
        [Column(Order = 2)]
        public float rPressOffset { get; set; }

        [Key]
        [Column(Order = 3)]
        public decimal BladeThickness1 { get; set; }

        [Key]
        [Column(Order = 4)]
        public decimal BladeThickness2 { get; set; }

        [Key]
        [Column(Order = 5)]
        public decimal BladeThickness3 { get; set; }

        [Key]
        [Column(Order = 6)]
        public decimal BladeThickness4 { get; set; }

        [Key]
        [Column(Order = 7)]
        public decimal MovableChipperPosition { get; set; }

        [Key]
        [Column(Order = 8)]
        public float rUpWorkPosH1 { get; set; }

        [Key]
        [Column(Order = 9)]
        public float rDwWorkPosH1 { get; set; }

        [Key]
        [Column(Order = 10)]
        public float rUpWorkPosH2 { get; set; }

        [Key]
        [Column(Order = 11)]
        public float rDwWorkPosH2 { get; set; }

        [Key]
        [Column(Order = 12)]
        public float rUpWorkPosL { get; set; }

        [Key]
        [Column(Order = 13)]
        public float rDwWorkPosL { get; set; }

        [Key]
        [Column(Order = 14)]
        public float Wik_GuidesPos { get; set; }

        [Key]
        [Column(Order = 15)]
        public float Oven_TempL { get; set; }

        [Key]
        [Column(Order = 16)]
        public float Oven_TempCUp { get; set; }

        [Key]
        [Column(Order = 17)]
        public float Oven_TempCDw { get; set; }

        [Key]
        [Column(Order = 18)]
        public float Wik_PaperBeltReduct { get; set; }

        [Key]
        [Column(Order = 19)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int BladeType { get; set; }

        [Key]
        [Column(Order = 20)]
        public float PolyGlue_EdgeDistance { get; set; }

        [Key]
        [Column(Order = 21, TypeName = "datetime2")]
        public DateTime dtInsertDate { get; set; }
    }
}
