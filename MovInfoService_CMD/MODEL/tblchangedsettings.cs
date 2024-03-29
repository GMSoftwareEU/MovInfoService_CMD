namespace MovInfoService_CMD.MODEL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tblchangedsettings
    {
        public int ID { get; set; }

        public int? INum { get; set; }

        [StringLength(8)]
        public string ID_OLA { get; set; }

        public decimal? rOldValue { get; set; }

        public decimal? rNewValue { get; set; }

        public DateTime? dtDateofEvent { get; set; }
    }
}
