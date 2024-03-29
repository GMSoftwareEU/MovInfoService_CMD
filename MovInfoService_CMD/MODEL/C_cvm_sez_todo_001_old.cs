namespace MovInfoService_CMD.MODEL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("_cvm_sez_todo_001_old")]
    public partial class C_cvm_sez_todo_001_old
    {
        [Key]
        [Column(Order = 0)]
        public int ID { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(8)]
        public string ID_OLA { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(8)]
        public string ID_Fase { get; set; }

        [Key]
        [Column(Order = 3)]
        public float rWidthPos_1_1 { get; set; }

        [Key]
        [Column(Order = 4)]
        public float rWidthPos_1_2 { get; set; }

        [Key]
        [Column(Order = 5)]
        public float rWidthPos_1_3 { get; set; }

        [Key]
        [Column(Order = 6)]
        public float rWidthPos_1_4 { get; set; }

        [Key]
        [Column(Order = 7)]
        public float rWidthPos_1_5 { get; set; }

        [Key]
        [Column(Order = 8)]
        public float rWidthPos_2_1 { get; set; }

        [Key]
        [Column(Order = 9)]
        public float rWidthPos_2_2 { get; set; }

        [Key]
        [Column(Order = 10)]
        public float rWidthPos_2_3 { get; set; }

        [Key]
        [Column(Order = 11)]
        public float rWidthPos_2_4 { get; set; }

        [Key]
        [Column(Order = 12)]
        public float rWidthPos_2_5 { get; set; }

        [Key]
        [Column(Order = 13)]
        public float rLengthPos_1_1 { get; set; }

        [Key]
        [Column(Order = 14)]
        public float rLengthPos_1_2 { get; set; }

        [Key]
        [Column(Order = 15)]
        public float rLengthPos_1_3 { get; set; }

        [Key]
        [Column(Order = 16)]
        public float rLengthPos_1_4 { get; set; }

        [Key]
        [Column(Order = 17)]
        public float rLengthPos_1_5 { get; set; }

        [Key]
        [Column(Order = 18)]
        public float rLengthPos_2_1 { get; set; }

        [Key]
        [Column(Order = 19)]
        public float rLengthPos_2_2 { get; set; }

        [Key]
        [Column(Order = 20)]
        public float rLengthPos_2_3 { get; set; }

        [Key]
        [Column(Order = 21)]
        public float rLengthPos_2_4 { get; set; }

        [Key]
        [Column(Order = 22)]
        public float rLengthPos_2_5 { get; set; }

        [Key]
        [Column(Order = 23)]
        [StringLength(50)]
        public string strCodProd_Pos_1_1 { get; set; }

        [Key]
        [Column(Order = 24)]
        [StringLength(50)]
        public string strCodProd_Pos_1_2 { get; set; }

        [Key]
        [Column(Order = 25)]
        [StringLength(50)]
        public string strCodProd_Pos_1_3 { get; set; }

        [Key]
        [Column(Order = 26)]
        [StringLength(50)]
        public string strCodProd_Pos_1_4 { get; set; }

        [Key]
        [Column(Order = 27)]
        [StringLength(50)]
        public string strCodProd_Pos_1_5 { get; set; }

        [Key]
        [Column(Order = 28)]
        [StringLength(50)]
        public string strCodProd_Pos_2_1 { get; set; }

        [Key]
        [Column(Order = 29)]
        [StringLength(50)]
        public string strCodProd_Pos_2_2 { get; set; }

        [Key]
        [Column(Order = 30)]
        [StringLength(50)]
        public string strCodProd_Pos_2_3 { get; set; }

        [Key]
        [Column(Order = 31)]
        [StringLength(50)]
        public string strCodProd_Pos_2_4 { get; set; }

        [Key]
        [Column(Order = 32)]
        [StringLength(50)]
        public string strCodProd_Pos_2_5 { get; set; }

        [Key]
        [Column(Order = 33)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long iDestFaseSucc_1_1 { get; set; }

        [Key]
        [Column(Order = 34)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long iDestFaseSucc_1_2 { get; set; }

        [Key]
        [Column(Order = 35)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long iDestFaseSucc_1_3 { get; set; }

        [Key]
        [Column(Order = 36)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long iDestFaseSucc_1_4 { get; set; }

        [Key]
        [Column(Order = 37)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long iDestFaseSucc_1_5 { get; set; }

        [Key]
        [Column(Order = 38)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long iDestFaseSucc_2_1 { get; set; }

        [Key]
        [Column(Order = 39)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long iDestFaseSucc_2_2 { get; set; }

        [Key]
        [Column(Order = 40)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long iDestFaseSucc_2_3 { get; set; }

        [Key]
        [Column(Order = 41)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long iDestFaseSucc_2_4 { get; set; }

        [Key]
        [Column(Order = 42)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long iDestFaseSucc_2_5 { get; set; }

        [Key]
        [Column(Order = 43)]
        public float rPanelThickness { get; set; }

        [Key]
        [Column(Order = 44)]
        public DateTime dtInsertDate { get; set; }
    }
}
