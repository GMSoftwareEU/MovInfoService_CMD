namespace MovInfoService_CMD.MODEL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class mac_manut_disp
    {
        public int ID { get; set; }

        [Required]
        [StringLength(1)]
        public string abilitato { get; set; }

        public short? cod_macchina { get; set; }

        [Required]
        [StringLength(50)]
        public string zona { get; set; }

        public short cod_dispositivo { get; set; }

        public short cod_plc_dispositivo { get; set; }

        [StringLength(50)]
        public string seriale { get; set; }

        [StringLength(50)]
        public string descrizione { get; set; }

        public float? metri_Cicli_complessivi { get; set; }

        public float? metri_Cicli_manut { get; set; }

        public short? aggiorna { get; set; }

        [Column("ssma$rowid")]
        public Guid ssma_rowid { get; set; }
    }
}
