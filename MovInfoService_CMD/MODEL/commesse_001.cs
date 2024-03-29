namespace MovInfoService_CMD.MODEL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class commesse_001
    {
        public int ID { get; set; }

        public int ID_Ola { get; set; }

        public int ID_Fase { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime dtDateOfModify { get; set; }

        public int iPriority { get; set; }

        public int iProductionJobOrder { get; set; }

        public int iProductionJobYear { get; set; }

        public int iOrderNumber { get; set; }

        public short iRecordState { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime dtDateOfDelivery { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? dtDateStartWork { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? dtDateEndWork { get; set; }

        [Required]
        [StringLength(30)]
        public string strCode { get; set; }

        [Required]
        [StringLength(100)]
        public string strDescription { get; set; }

        public float rPanelLength { get; set; }

        public float rPanelWidth { get; set; }

        public float rPanelThickness { get; set; }

        public float rStripThickness { get; set; }

        public float rWidthStrip1 { get; set; }

        public float rWidthStrip2 { get; set; }

        public float rWidthStrip3 { get; set; }

        public float rWidthStrip4 { get; set; }

        public float rWidthStrip5 { get; set; }

        public float rWidthStrip6 { get; set; }

        public float rWidthStrip7 { get; set; }

        public float rWidthStrip8 { get; set; }

        public float rWidthStrip9 { get; set; }

        public float rPosStrip1 { get; set; }

        public float rPosStrip2 { get; set; }

        public float rPosStrip3 { get; set; }

        public float rPosStrip4 { get; set; }

        public float rPosStrip5 { get; set; }

        public float rPosStrip6 { get; set; }

        public float rPosStrip7 { get; set; }

        public float rPosStrip8 { get; set; }

        public float rPosStrip9 { get; set; }

        public int? iCodStrip1 { get; set; }

        public int? iCodStrip2 { get; set; }

        public int? iCodStrip3 { get; set; }

        public int? iCodStrip4 { get; set; }

        public int? iCodStrip5 { get; set; }

        public int? iCodStrip6 { get; set; }

        public int? iCodStrip7 { get; set; }

        public int? iCodStrip8 { get; set; }

        public int? iCodStrip9 { get; set; }

        [Required]
        [StringLength(50)]
        public string strCodStrip1 { get; set; }

        [Required]
        [StringLength(50)]
        public string strCodStrip2 { get; set; }

        [Required]
        [StringLength(50)]
        public string strCodStrip3 { get; set; }

        [Required]
        [StringLength(50)]
        public string strCodStrip4 { get; set; }

        [Required]
        [StringLength(50)]
        public string strCodStrip5 { get; set; }

        [Required]
        [StringLength(50)]
        public string strCodStrip6 { get; set; }

        [Required]
        [StringLength(50)]
        public string strCodStrip7 { get; set; }

        [Required]
        [StringLength(50)]
        public string strCodStrip8 { get; set; }

        [Required]
        [StringLength(50)]
        public string strCodStrip9 { get; set; }

        public float rHoneyThickness { get; set; }

        public float rCoverLength { get; set; }

        public float rCoverWidth { get; set; }

        public float rCoverThicknessUp { get; set; }

        public float rCoverThicknessDw { get; set; }

        public int? iCoverUpCode { get; set; }

        public int? iCoverDwCode { get; set; }

        [Required]
        [StringLength(50)]
        public string strCoverUpCode { get; set; }

        [Required]
        [StringLength(50)]
        public string strCoverDwCode { get; set; }

        public int iCoverGlueType { get; set; }

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

        public short? iStackQuantity { get; set; }

        public long dQuantityToProduce { get; set; }

        public short? dQuantityProduced { get; set; }

        public int numRecipeWikoma { get; set; }

        public long? iCodHoney { get; set; }

        [Required]
        [StringLength(50)]
        public string strCodHoney { get; set; }

        public float rRawHoneyThickness { get; set; }

        public long iCoverUpMaterial { get; set; }

        public long iCoverDwMaterial { get; set; }

        public int iMaterialStrip1 { get; set; }

        public int iMaterialStrip2 { get; set; }

        public int iMaterialStrip3 { get; set; }

        public int iMaterialStrip4 { get; set; }

        public int iMaterialStrip5 { get; set; }

        public int iMaterialStrip6 { get; set; }

        public int iMaterialStrip7 { get; set; }

        public int iMaterialStrip8 { get; set; }

        public int iMaterialStrip9 { get; set; }

        public float? BladeThickness1 { get; set; }

        public float? BladeThickness2 { get; set; }

        public float? BladeThickness3 { get; set; }

        public float? BladeThickness4 { get; set; }

        public float? MovableChipperPosition { get; set; }

        public int? Job_State { get; set; }

        public float? iHoney_Qty_mc { get; set; }

        public float? iHoney_Qty_ml { get; set; }

        public int iSequence { get; set; }

        public float? rPressOffset { get; set; }

        public float? rUpWorkPosH1 { get; set; }

        public float rDwWorkPosH1 { get; set; }

        public float rUpWorkPosH2 { get; set; }

        public float rDwWorkPosH2 { get; set; }

        public float rUpWorkPosL { get; set; }

        public float rDwWorkPosL { get; set; }

        public float Wik_GuidesPos { get; set; }

        public float? Oven_TempL { get; set; }

        public float? Oven_TempCUp { get; set; }

        public float? Oven_TempCDw { get; set; }

        public float? Wik_PaperBeltReduct { get; set; }

        public int? BladeType { get; set; }

        public float? PolyGlue_EdgeDistance { get; set; }

        [StringLength(50)]
        public string ProjectCode { get; set; }

        public int? ID_CodArt { get; set; }

        [StringLength(50)]
        public string CodArt { get; set; }

        public float rPosHoneycomb1 { get; set; }

        public float rPosHoneycomb2 { get; set; }

        public float rPosHoneycomb3 { get; set; }

        public float rPosHoneycomb4 { get; set; }

        public float rPosHoneycomb5 { get; set; }

        public float rPosHoneycomb6 { get; set; }

        public float rPosHoneycomb7 { get; set; }

        public float rPosHoneycomb8 { get; set; }

        public float rWidthHoneycomb1 { get; set; }

        public float rWidthHoneycomb2 { get; set; }

        public float rWidthHoneycomb3 { get; set; }

        public float rWidthHoneycomb4 { get; set; }

        public float rWidthHoneycomb5 { get; set; }

        public float rWidthHoneycomb6 { get; set; }

        public float rWidthHoneycomb7 { get; set; }

        public float rWidthHoneycomb8 { get; set; }
    }
}
