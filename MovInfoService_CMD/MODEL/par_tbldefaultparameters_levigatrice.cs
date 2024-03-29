namespace MovInfoService_CMD.MODEL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class par_tbldefaultparameters_levigatrice
    {
        public int Id { get; set; }

        public int? ID_CodArt { get; set; }

        [StringLength(50)]
        public string CodArt { get; set; }

        [StringLength(100)]
        public string DesArt { get; set; }

        public int? IdRicetta { get; set; }

        public bool flDftPar { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime dtInsertDate { get; set; }
    }
}
