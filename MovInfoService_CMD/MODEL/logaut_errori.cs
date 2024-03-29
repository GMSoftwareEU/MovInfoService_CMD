namespace MovInfoService_CMD.MODEL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class logaut_errori
    {
        public int ID { get; set; }

        [StringLength(500)]
        public string Descrizione { get; set; }
    }
}
