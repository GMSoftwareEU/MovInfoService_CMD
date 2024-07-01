namespace MovInfoService_CMD.MODEL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class mov_Phases
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int PhaseId { get; set; }

        public int? ErpPhaseid { get; set; }

        public int? ErpId { get; set; }

        [StringLength(20)]
        public string PhaseCode { get; set; }

        public int? PhaseOrder { get; set; }

        public int? Qty4Pallet { get; set; }

        [StringLength(20)]
        public string WorkCenter { get; set; }

        [StringLength(20)]
        public string Machine { get; set; }

        public DateTime? dtInsertDate { get; set; }

        [StringLength(20)]
        public string TipoImballo { get; set; }
    }
}
