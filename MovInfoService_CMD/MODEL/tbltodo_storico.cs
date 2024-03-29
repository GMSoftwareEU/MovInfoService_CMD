namespace MovInfoService_CMD.MODEL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tbltodo_storico
    {
        public int ID { get; set; }

        [StringLength(8)]
        public string ID_OLA { get; set; }

        public float? rWidthPos_1_3 { get; set; }

        public float? rLengthPos_1_3 { get; set; }

        public int? iCodProd_Pos_1_3 { get; set; }

        [StringLength(50)]
        public string strCodProd_Pos_1_3 { get; set; }

        public float? rWidthPos_2_3 { get; set; }

        public float? rLengthPos_2_3 { get; set; }

        public int? iCodProd_Pos_2_3 { get; set; }

        [StringLength(50)]
        public string strCodProd_Pos_2_3 { get; set; }

        [StringLength(50)]
        public string utente { get; set; }

        [StringLength(50)]
        public string InsertOrUpdate { get; set; }

        public DateTime? DataAggiornamento { get; set; }
    }
}
