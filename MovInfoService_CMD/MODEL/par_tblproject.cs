namespace MovInfoService_CMD.MODEL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class par_tblproject
    {
        public int id { get; set; }

        [StringLength(50)]
        public string ProjectCode { get; set; }

        [StringLength(200)]
        public string descrizione { get; set; }

        public int? articolo_id { get; set; }

        [StringLength(50)]
        public string articolo_codice { get; set; }

        [StringLength(200)]
        public string articolo_descrizione { get; set; }

        [StringLength(200)]
        public string tipo { get; set; }

        public string note { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? lunghezza { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? larghezza { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? spessore { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? pos_list1 { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? pos_list2 { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? pos_list3 { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? pos_list4 { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? pos_list5 { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? pos_list6 { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? pos_list7 { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? pos_list8 { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? pos_list9 { get; set; }

        [StringLength(50)]
        public string tipocolla_codice { get; set; }

        [StringLength(100)]
        public string tipocolla_descrizione { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? BladeThickness1 { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? BladeThickness2 { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? BladeThickness3 { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? BladeThickness4 { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? MovableChipperPosition { get; set; }

        public int? BladeType { get; set; }

        public bool annullato { get; set; }
    }
}
