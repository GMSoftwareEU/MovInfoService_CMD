namespace MovInfoService_CMD.MODEL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class MachineParameters
    {
        public int Id { get; set; }

        [StringLength(50)]
        public string MachineCode { get; set; }

        public int? OrderId { get; set; }

        [StringLength(100)]
        public string ParamKey { get; set; }

        [StringLength(250)]
        public string ParamValue { get; set; }
    }
}
