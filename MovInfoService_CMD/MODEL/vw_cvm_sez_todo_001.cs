namespace MovInfoService_CMD.MODEL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class vw_cvm_sez_todo_001
    {
        [StringLength(8)]
        public string ID_Ola { get; set; }

        [StringLength(8)]
        public string ID_Fase { get; set; }

        public float? rWidthPos_1_1 { get; set; }

        public float? rWidthPos_1_2 { get; set; }

        public float? rWidthPos_1_3 { get; set; }

        public float? rWidthPos_1_4 { get; set; }

        public float? rWidthPos_1_5 { get; set; }

        public float? rWidthPos_2_1 { get; set; }

        public float? rWidthPos_2_2 { get; set; }

        public float? rWidthPos_2_3 { get; set; }

        public float? rWidthPos_2_4 { get; set; }

        public float? rWidthPos_2_5 { get; set; }

        public float? rLengthPos_1_1 { get; set; }

        public float? rLengthPos_1_2 { get; set; }

        public float? rLengthPos_1_3 { get; set; }

        public float? rLengthPos_1_4 { get; set; }

        public float? rLengthPos_1_5 { get; set; }

        public float? rLengthPos_2_1 { get; set; }

        public float? rLengthPos_2_2 { get; set; }

        public float? rLengthPos_2_3 { get; set; }

        public float? rLengthPos_2_4 { get; set; }

        public float? rLengthPos_2_5 { get; set; }

        [StringLength(50)]
        public string strCodProd_Pos_1_1 { get; set; }

        [StringLength(50)]
        public string strCodProd_Pos_1_2 { get; set; }

        [StringLength(50)]
        public string strCodProd_Pos_1_3 { get; set; }

        [StringLength(50)]
        public string strCodProd_Pos_1_4 { get; set; }

        [StringLength(50)]
        public string strCodProd_Pos_1_5 { get; set; }

        [StringLength(50)]
        public string strCodProd_Pos_2_1 { get; set; }

        [StringLength(50)]
        public string strCodProd_Pos_2_2 { get; set; }

        [StringLength(50)]
        public string strCodProd_Pos_2_3 { get; set; }

        [StringLength(50)]
        public string strCodProd_Pos_2_4 { get; set; }

        [StringLength(50)]
        public string strCodProd_Pos_2_5 { get; set; }

        public int? iDestFaseSucc_1_1 { get; set; }

        public int? iDestFaseSucc_1_2 { get; set; }

        public int? iDestFaseSucc_1_3 { get; set; }

        public int? iDestFaseSucc_1_4 { get; set; }

        public int? iDestFaseSucc_1_5 { get; set; }

        public int? iDestFaseSucc_2_1 { get; set; }

        public int? iDestFaseSucc_2_2 { get; set; }

        public int? iDestFaseSucc_2_3 { get; set; }

        public int? iDestFaseSucc_2_4 { get; set; }

        public int? iDestFaseSucc_2_5 { get; set; }

        [Key]
        [Column(Order = 0)]
        public float rPanelThickness { get; set; }

        public int? StackQty { get; set; }

        [StringLength(8)]
        public string ID_Ola_Master { get; set; }

        public int? iCodProd_Pos_1_1 { get; set; }

        public int? iCodProd_Pos_1_2 { get; set; }

        public int? iCodProd_Pos_1_3 { get; set; }

        public int? iCodProd_Pos_1_4 { get; set; }

        public int? iCodProd_Pos_1_5 { get; set; }

        public int? iCodProd_Pos_2_1 { get; set; }

        public int? iCodProd_Pos_2_2 { get; set; }

        public int? iCodProd_Pos_2_3 { get; set; }

        public int? iCodProd_Pos_2_4 { get; set; }

        public int? iCodProd_Pos_2_5 { get; set; }

        [Key]
        [Column(Order = 1, TypeName = "numeric")]
        public decimal PesoUnitario_1_1 { get; set; }

        [Key]
        [Column(Order = 2, TypeName = "numeric")]
        public decimal PesoUnitario_1_2 { get; set; }

        [Key]
        [Column(Order = 3, TypeName = "numeric")]
        public decimal PesoUnitario_1_3 { get; set; }

        [Key]
        [Column(Order = 4, TypeName = "numeric")]
        public decimal PesoUnitario_1_4 { get; set; }

        [Key]
        [Column(Order = 5, TypeName = "numeric")]
        public decimal PesoUnitario_1_5 { get; set; }

        [Key]
        [Column(Order = 6, TypeName = "numeric")]
        public decimal PesoUnitario_2_1 { get; set; }

        [Key]
        [Column(Order = 7, TypeName = "numeric")]
        public decimal PesoUnitario_2_2 { get; set; }

        [Key]
        [Column(Order = 8, TypeName = "numeric")]
        public decimal PesoUnitario_2_3 { get; set; }

        [Key]
        [Column(Order = 9, TypeName = "numeric")]
        public decimal PesoUnitario_2_4 { get; set; }

        [Key]
        [Column(Order = 10, TypeName = "numeric")]
        public decimal PesoUnitario_2_5 { get; set; }
    }
}
