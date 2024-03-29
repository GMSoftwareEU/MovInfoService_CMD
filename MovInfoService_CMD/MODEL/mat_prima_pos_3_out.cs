namespace MovInfoService_CMD.MODEL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class mat_prima_pos_3_out
    {
        public int ID { get; set; }

        [Required]
        [StringLength(20)]
        public string Testo_UDC { get; set; }

        [Required]
        [StringLength(50)]
        public string strMaterialCode { get; set; }

        public int TypeMoviment { get; set; }

        public float iQuantita { get; set; }

        public float rWidthNido { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime dtInsertDate { get; set; }

        public int iProcessingStatus { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime dtProcessingDate { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? dDataInvioImag { get; set; }

        public int? iMaterialCod { get; set; }
    }
}
