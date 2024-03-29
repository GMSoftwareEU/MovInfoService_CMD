namespace MovInfoService_CMD.MODEL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tblparameters
    {
        public int ID { get; set; }

        public float? value { get; set; }

        public string description { get; set; }
    }
}
