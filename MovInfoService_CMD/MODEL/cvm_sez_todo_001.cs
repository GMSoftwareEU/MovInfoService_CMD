namespace MovInfoService_CMD.MODEL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class cvm_sez_todo_001
    {
        public int ID { get; set; }

        [Required]
        [StringLength(8)]
        public string ID_OLA { get; set; }

        [Required]
        [StringLength(8)]
        public string ID_Fase { get; set; }

        public float rWidthPos_1_1 { get; set; }

        public float rWidthPos_1_2 { get; set; }

        public float rWidthPos_1_3 { get; set; }

        public float rWidthPos_1_4 { get; set; }

        public float rWidthPos_1_5 { get; set; }

        public float rWidthPos_2_1 { get; set; }

        public float rWidthPos_2_2 { get; set; }

        public float rWidthPos_2_3 { get; set; }

        public float rWidthPos_2_4 { get; set; }

        public float rWidthPos_2_5 { get; set; }

        public float rLengthPos_1_1 { get; set; }

        public float rLengthPos_1_2 { get; set; }

        public float rLengthPos_1_3 { get; set; }

        public float rLengthPos_1_4 { get; set; }

        public float rLengthPos_1_5 { get; set; }

        public float rLengthPos_2_1 { get; set; }

        public float rLengthPos_2_2 { get; set; }

        public float rLengthPos_2_3 { get; set; }

        public float rLengthPos_2_4 { get; set; }

        public float rLengthPos_2_5 { get; set; }

        [Required]
        [StringLength(50)]
        public string strCodProd_Pos_1_1 { get; set; }

        [Required]
        [StringLength(50)]
        public string strCodProd_Pos_1_2 { get; set; }

        [Required]
        [StringLength(50)]
        public string strCodProd_Pos_1_3 { get; set; }

        [Required]
        [StringLength(50)]
        public string strCodProd_Pos_1_4 { get; set; }

        [Required]
        [StringLength(50)]
        public string strCodProd_Pos_1_5 { get; set; }

        [Required]
        [StringLength(50)]
        public string strCodProd_Pos_2_1 { get; set; }

        [Required]
        [StringLength(50)]
        public string strCodProd_Pos_2_2 { get; set; }

        [Required]
        [StringLength(50)]
        public string strCodProd_Pos_2_3 { get; set; }

        [Required]
        [StringLength(50)]
        public string strCodProd_Pos_2_4 { get; set; }

        [Required]
        [StringLength(50)]
        public string strCodProd_Pos_2_5 { get; set; }

        public float rPanelThickness { get; set; }

        public DateTime dtInsertDate { get; set; }

        public int StackQty { get; set; }
    }
}
