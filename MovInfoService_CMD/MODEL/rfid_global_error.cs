namespace MovInfoService_CMD.MODEL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class rfid_global_error
    {
        public int ID { get; set; }

        [Required]
        [StringLength(50)]
        public string codice_rfid { get; set; }

        public int Error_Code { get; set; }

        public short cod_macchina { get; set; }

        public short? Zona_Macchina { get; set; }
    }
}
