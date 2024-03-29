namespace MovInfoService_CMD.MODEL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class logaut_movimenti
    {
        public int ID { get; set; }

        public long? Numero { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? DataOra { get; set; }

        [StringLength(1)]
        public string Tipo { get; set; }

        [StringLength(50)]
        public string UDC { get; set; }

        [StringLength(50)]
        public string ErroreSagoma { get; set; }

        [StringLength(50)]
        public string NumeroLista { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? DataOraInserimento { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? DataOraElaborazione { get; set; }

        public int? Esito { get; set; }

        [StringLength(50)]
        public string Posizione { get; set; }

        public int? Destinazione { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? DtProcessingDate { get; set; }
    }
}
