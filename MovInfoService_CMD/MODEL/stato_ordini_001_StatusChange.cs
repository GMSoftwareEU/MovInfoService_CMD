namespace MovInfoService_CMD.MODEL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class stato_ordini_001_StatusChange
    {
        [Key]
        [Column(Order = 0)]
        public int ID { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(8)]
        public string ID_Ola { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(8)]
        public string ID_Fase { get; set; }

        [Key]
        [Column(Order = 3, TypeName = "datetime2")]
        public DateTime Data_Ultima_Modifica { get; set; }

        [Key]
        [Column(Order = 4)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Centro_Lavoro { get; set; }

        [Key]
        [Column(Order = 5)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Stato_Avanzamento { get; set; }

        [Key]
        [Column(Order = 6)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int dQuantityProduced { get; set; }

        [Key]
        [Column(Order = 7, TypeName = "datetime2")]
        public DateTime dtDateStartWork { get; set; }

        [Key]
        [Column(Order = 8, TypeName = "datetime2")]
        public DateTime dtDateEndWord { get; set; }

        [Key]
        [Column(Order = 9)]
        public bool flRead { get; set; }
    }
}
