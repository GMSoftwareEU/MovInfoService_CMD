namespace MovInfoService_CMD.MODEL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class aree_macchine
    {
        public int ID { get; set; }

        public short cod_macchina { get; set; }

        public short? Zona_Macchina { get; set; }

        [StringLength(60)]
        public string Descrittivo { get; set; }
    }
}
