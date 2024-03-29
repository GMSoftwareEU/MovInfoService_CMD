namespace MovInfoService_CMD.MODEL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class par_tbldefaultrecipes_levigatrice
    {
        [Key]
        public int IdRicetta { get; set; }

        [StringLength(10)]
        public string Ricetta { get; set; }

        [StringLength(100)]
        public string Zona1 { get; set; }

        [StringLength(100)]
        public string Z1Velocita { get; set; }

        [StringLength(100)]
        public string Z1Velocita_Min { get; set; }

        [StringLength(100)]
        public string Z1Velocita_Max { get; set; }

        [StringLength(100)]
        public string Z1Velocita_Nota { get; set; }

        [StringLength(100)]
        public string Z1GestioneSettori { get; set; }

        [StringLength(100)]
        public string Z1GestioneSettori_Min { get; set; }

        [StringLength(100)]
        public string Z1GestioneSettori_Max { get; set; }

        [StringLength(100)]
        public string Z1GestioneSettori_Nota { get; set; }

        [StringLength(100)]
        public string Z1AntRitMotoriTamponi { get; set; }

        [StringLength(100)]
        public string Z1AntRitMotoriTamponi_Min { get; set; }

        [StringLength(100)]
        public string Z1AntRitMotoriTamponi_Max { get; set; }

        [StringLength(100)]
        public string Z1AntRitMotoriTamponi_Nota { get; set; }

        [StringLength(100)]
        public string Z1PressTamponi { get; set; }

        [StringLength(100)]
        public string Z1PressTamponi_Min { get; set; }

        [StringLength(100)]
        public string Z1PressTamponi_Max { get; set; }

        [StringLength(100)]
        public string Z1PressTamponi_Nota { get; set; }

        public bool? Z1InnalzSuppGrafite { get; set; }

        [StringLength(100)]
        public string Z1InnalzSuppGrafite_Nota { get; set; }

        [StringLength(100)]
        public string Zona2 { get; set; }

        [StringLength(100)]
        public string Z2Velocita { get; set; }

        [StringLength(100)]
        public string Z2Velocita_Min { get; set; }

        [StringLength(100)]
        public string Z2Velocita_Max { get; set; }

        [StringLength(100)]
        public string Z2Velocita_Nota { get; set; }

        [StringLength(100)]
        public string Z2GestioneSettori { get; set; }

        [StringLength(100)]
        public string Z2GestioneSettori_Min { get; set; }

        [StringLength(100)]
        public string Z2GestioneSettori_Max { get; set; }

        [StringLength(100)]
        public string Z2GestioneSettori_Nota { get; set; }

        [StringLength(100)]
        public string Z2AntRitMotoriTamponi { get; set; }

        [StringLength(100)]
        public string Z2AntRitMotoriTamponi_Min { get; set; }

        [StringLength(100)]
        public string Z2AntRitMotoriTamponi_Max { get; set; }

        [StringLength(100)]
        public string Z2AntRitMotoriTamponi_Nota { get; set; }

        [StringLength(100)]
        public string Z2PressTamponi { get; set; }

        [StringLength(100)]
        public string Z2PressTamponi_Min { get; set; }

        [StringLength(100)]
        public string Z2PressTamponi_Max { get; set; }

        [StringLength(100)]
        public string Z2PressTamponi_Nota { get; set; }

        [StringLength(100)]
        public string Zona3 { get; set; }

        [StringLength(100)]
        public string Z3Velocita { get; set; }

        [StringLength(100)]
        public string Z3Velocita_Min { get; set; }

        [StringLength(100)]
        public string Z3Velocita_Max { get; set; }

        [StringLength(100)]
        public string Z3Velocita_Nota { get; set; }

        [StringLength(100)]
        public string Z3GestioneSettori { get; set; }

        [StringLength(100)]
        public string Z3GestioneSettori_Min { get; set; }

        [StringLength(100)]
        public string Z3GestioneSettori_Max { get; set; }

        [StringLength(100)]
        public string Z3GestioneSettori_Nota { get; set; }

        [StringLength(100)]
        public string Z3AntRitMotoriTamponi { get; set; }

        [StringLength(100)]
        public string Z3AntRitMotoriTamponi_Min { get; set; }

        [StringLength(100)]
        public string Z3AntRitMotoriTamponi_Max { get; set; }

        [StringLength(100)]
        public string Z3AntRitMotoriTamponi_Nota { get; set; }

        [StringLength(100)]
        public string Z3PressTamponi { get; set; }

        [StringLength(100)]
        public string Z3PressTamponi_Min { get; set; }

        [StringLength(100)]
        public string Z3PressTamponi_Max { get; set; }

        [StringLength(100)]
        public string Z3PressTamponi_Nota { get; set; }

        public bool? Z3InnalzSuppGrafite { get; set; }

        [StringLength(100)]
        public string Z3InnalzSuppGrafite_Nota { get; set; }

        [StringLength(100)]
        public string Zona4 { get; set; }

        [StringLength(100)]
        public string Z4Velocita { get; set; }

        [StringLength(100)]
        public string Z4Velocita_Min { get; set; }

        [StringLength(100)]
        public string Z4Velocita_Max { get; set; }

        [StringLength(100)]
        public string Z4Velocita_Nota { get; set; }

        [StringLength(100)]
        public string Z4GestioneSettori { get; set; }

        [StringLength(100)]
        public string Z4GestioneSettori_Min { get; set; }

        [StringLength(100)]
        public string Z4GestioneSettori_Max { get; set; }

        [StringLength(100)]
        public string Z4GestioneSettori_Nota { get; set; }

        [StringLength(100)]
        public string Z4AntRitMotoriTamponi { get; set; }

        [StringLength(100)]
        public string Z4AntRitMotoriTamponi_Min { get; set; }

        [StringLength(100)]
        public string Z4AntRitMotoriTamponi_Max { get; set; }

        [StringLength(100)]
        public string Z4AntRitMotoriTamponi_Nota { get; set; }

        [StringLength(100)]
        public string Z4PressTamponi { get; set; }

        [StringLength(100)]
        public string Z4PressTamponi_Min { get; set; }

        [StringLength(100)]
        public string Z4PressTamponi_Max { get; set; }

        [StringLength(100)]
        public string Z4PressTamponi_Nota { get; set; }

        public bool? Z4InnalzSuppGrafite { get; set; }

        [StringLength(100)]
        public string Z4InnalzSuppGrafite_Nota { get; set; }

        [StringLength(100)]
        public string Zona5 { get; set; }

        [StringLength(100)]
        public string Z5Velocita { get; set; }

        [StringLength(100)]
        public string Z5Velocita_Min { get; set; }

        [StringLength(100)]
        public string Z5Velocita_Max { get; set; }

        [StringLength(100)]
        public string Z5Velocita_Nota { get; set; }

        [StringLength(100)]
        public string Z5GestioneSettori { get; set; }

        [StringLength(100)]
        public string Z5GestioneSettori_Min { get; set; }

        [StringLength(100)]
        public string Z5GestioneSettori_Max { get; set; }

        [StringLength(100)]
        public string Z5GestioneSettori_Nota { get; set; }

        [StringLength(100)]
        public string Z5AntRitMotoriTamponi { get; set; }

        [StringLength(100)]
        public string Z5AntRitMotoriTamponi_Min { get; set; }

        [StringLength(100)]
        public string Z5AntRitMotoriTamponi_Max { get; set; }

        [StringLength(100)]
        public string Z5AntRitMotoriTamponi_Nota { get; set; }

        [StringLength(100)]
        public string Z5PressTamponi { get; set; }

        [StringLength(100)]
        public string Z5PressTamponi_Min { get; set; }

        [StringLength(100)]
        public string Z5PressTamponi_Max { get; set; }

        [StringLength(100)]
        public string Z5PressTamponi_Nota { get; set; }

        [StringLength(100)]
        public string Zona6 { get; set; }

        [StringLength(100)]
        public string Z6Velocita { get; set; }

        [StringLength(100)]
        public string Z6Velocita_Min { get; set; }

        [StringLength(100)]
        public string Z6Velocita_Max { get; set; }

        [StringLength(100)]
        public string Z6Velocita_Nota { get; set; }

        [StringLength(100)]
        public string Z6GestioneSettori { get; set; }

        [StringLength(100)]
        public string Z6GestioneSettori_Min { get; set; }

        [StringLength(100)]
        public string Z6GestioneSettori_Max { get; set; }

        [StringLength(100)]
        public string Z6GestioneSettori_Nota { get; set; }

        [StringLength(100)]
        public string Z6AntRitMotoriTamponi { get; set; }

        [StringLength(100)]
        public string Z6AntRitMotoriTamponi_Min { get; set; }

        [StringLength(100)]
        public string Z6AntRitMotoriTamponi_Max { get; set; }

        [StringLength(100)]
        public string Z6AntRitMotoriTamponi_Nota { get; set; }

        [StringLength(100)]
        public string Z6PressTamponi { get; set; }

        [StringLength(100)]
        public string Z6PressTamponi_Min { get; set; }

        [StringLength(100)]
        public string Z6PressTamponi_Max { get; set; }

        [StringLength(100)]
        public string Z6PressTamponi_Nota { get; set; }

        public bool? Z6InnalzSuppGrafite { get; set; }

        [StringLength(100)]
        public string Z6InnalzSuppGrafite_Nota { get; set; }

        public bool? Spazzolatrice { get; set; }

        public bool flDftPar { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime dtInsertDate { get; set; }
    }
}
