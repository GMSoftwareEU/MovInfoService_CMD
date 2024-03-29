namespace MovInfoService_CMD.MODEL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class vw_mov_UDCQuantity
    {
        [Key]
        [StringLength(50)]
        public string KeyCode { get; set; }

        public long? Quantity { get; set; }
    }
}
