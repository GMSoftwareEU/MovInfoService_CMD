namespace MovInfoService_CMD.MODEL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class par_tbldefaultparameters_calandra
    {
        public int Id { get; set; }

        public int? ID_CodArt { get; set; }

        [StringLength(50)]
        public string CodArt { get; set; }

        [StringLength(100)]
        public string DesArt { get; set; }

        [StringLength(100)]
        public string PressioneSpazzolatrice { get; set; }

        [StringLength(100)]
        public string IncollatricePann { get; set; }

        [StringLength(100)]
        public string Accoppiatore { get; set; }

        [StringLength(100)]
        public string Spintore { get; set; }

        [StringLength(100)]
        public string TipoRivestSup { get; set; }

        [StringLength(100)]
        public string TipoRivestInf { get; set; }

        [StringLength(100)]
        public string DistribuzioneCollaSup { get; set; }

        [StringLength(100)]
        public string DistribuzioneCollaInf { get; set; }

        [StringLength(100)]
        public string TipoCollaInf { get; set; }

        [StringLength(100)]
        public string TipoCollaSup { get; set; }

        [StringLength(100)]
        public string VelocitaMassima { get; set; }

        [StringLength(100)]
        public string PosizioneTaglioSeparazione { get; set; }

        [StringLength(100)]
        public string TempRulliAccoppiatoreSup { get; set; }

        [StringLength(100)]
        public string TempRulliAccoppiatoreInf { get; set; }

        [StringLength(100)]
        public string TempForno1LatoInfPann { get; set; }

        [StringLength(100)]
        public string TempForno1LatoSupPann { get; set; }

        [StringLength(100)]
        public string TempForno2LatoSupPann { get; set; }

        [StringLength(100)]
        public string TempForno2LatoInfPann { get; set; }

        [StringLength(100)]
        public string RiscaldRivestSup { get; set; }

        [StringLength(100)]
        public string RiscaldRivestInf { get; set; }

        [StringLength(100)]
        public string QtaCollaBobinaSup { get; set; }

        [StringLength(100)]
        public string QtaCollaLatoSupPann { get; set; }

        [StringLength(100)]
        public string QtaCollaBobinaInf { get; set; }

        [StringLength(100)]
        public string QtaCollaLatoInfPann { get; set; }

        public bool flDftPar { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime dtInsertDate { get; set; }
    }
}
