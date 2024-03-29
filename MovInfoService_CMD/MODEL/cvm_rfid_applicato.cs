namespace MovInfoService_CMD.MODEL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class cvm_rfid_applicato
    {
        public int ID { get; set; }

        [Required]
        [StringLength(50)]
        public string Key_General { get; set; }

        [Required]
        [StringLength(50)]
        public string codice_rfid { get; set; }

        public int Riga_applicazione { get; set; }

        public int Colonna_applicazione { get; set; }

        public DateTime? dtProcessingDate { get; set; }

        [StringLength(17)]
        public string trackingcode { get; set; }
    }
}
