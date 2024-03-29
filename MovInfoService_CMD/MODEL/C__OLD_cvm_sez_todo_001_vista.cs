namespace MovInfoService_CMD.MODEL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("__OLD_cvm_sez_todo_001_vista")]
    public partial class C__OLD_cvm_sez_todo_001_vista
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
        public float rPanelThickness { get; set; }
    }
}
