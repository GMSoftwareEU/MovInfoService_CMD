namespace MovInfoService_CMD.MODEL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class mac_tipo_evento
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public short tipo_evento { get; set; }

        [StringLength(50)]
        public string descr_evento { get; set; }
    }
}
