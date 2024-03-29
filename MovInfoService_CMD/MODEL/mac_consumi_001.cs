namespace MovInfoService_CMD.MODEL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class mac_consumi_001
    {
        public int ID { get; set; }

        [StringLength(8)]
        public string ID_Ola { get; set; }

        [StringLength(8)]
        public string ID_Fase { get; set; }

        public int Codice_Macchina { get; set; }

        public int Codice_Udc { get; set; }

        [Required]
        [StringLength(20)]
        public string Testo_Udc { get; set; }

        [Required]
        [StringLength(50)]
        public string strMaterialCode { get; set; }

        public int QT_Utilizzata { get; set; }

        public int Type_Moviment { get; set; }

        public int? iNum_Uscita { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? data_ora_evento { get; set; }
    }
}
