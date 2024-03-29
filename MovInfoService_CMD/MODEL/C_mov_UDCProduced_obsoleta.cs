namespace MovInfoService_CMD.MODEL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("_mov_UDCProduced obsoleta")]
    public partial class C_mov_UDCProduced_obsoleta
    {
        [Key]
        public int UDCProduceId { get; set; }

        [StringLength(50)]
        public string UDCCode { get; set; }

        public int? Qty { get; set; }

        public int? OrderId { get; set; }

        [StringLength(20)]
        public string WorkCenter { get; set; }

        public DateTime? DtInsertDate { get; set; }

        public DateTime? DtProcessingDate { get; set; }
    }
}
