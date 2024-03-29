namespace MovInfoService_CMD.MODEL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class anag_macchine
    {
        public int ID { get; set; }

        public short? cod_macchina { get; set; }

        [StringLength(50)]
        public string desc_macchina { get; set; }

        [StringLength(6)]
        public string s_cod_macchina { get; set; }
    }
}
