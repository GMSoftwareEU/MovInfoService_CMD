namespace MovInfoService_CMD.MODEL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tbludcproduce")]
    public partial class tbludcproduce
    {
        public int ID { get; set; }

        [StringLength(8)]
        public string ID_OLA { get; set; }

        [Required]
        [StringLength(8)]
        public string ID_Fase { get; set; }

        public short? iProgUDC { get; set; }

        public short? iDestination { get; set; }

        public long iQuantita_Pezzi { get; set; }

        [Required]
        [StringLength(50)]
        public string Key_General { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? Data_Ora { get; set; }

        public int? Fl_UltimaPila { get; set; }
    }
}
