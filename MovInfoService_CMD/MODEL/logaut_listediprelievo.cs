namespace MovInfoService_CMD.MODEL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class logaut_listediprelievo
    {
        public int ID { get; set; }

        [StringLength(50)]
        public string NumeroLista { get; set; }

        [StringLength(50)]
        public string UDC { get; set; }

        public int? Priorita { get; set; }

        public int? Destinazione { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? DataOraInserimento { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? DataOraElaborazione { get; set; }

        public int? Esito { get; set; }

        public DateTime? dtProcessingDate { get; set; }
    }
}
