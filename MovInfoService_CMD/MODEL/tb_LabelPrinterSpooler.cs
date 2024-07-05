namespace MovInfoService_CMD.MODEL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tb_LabelPrinterSpooler
    {
        public int id { get; set; }

        public int idLabel { get; set; }

        public int tentativiresidui { get; set; }

        public DateTime DataOraInserimento { get; set; }

        public DateTime? DataOraElaborazione { get; set; }

        [StringLength(20)]
        public string PrinterName { get; set; }

        public string LastError { get; set; }

        public virtual mov_Label mov_Label { get; set; }

        public virtual tb_LabelPrinterSpooler tb_LabelPrinterSpooler1 { get; set; }

        public virtual tb_LabelPrinterSpooler tb_LabelPrinterSpooler2 { get; set; }

        public virtual tb_LabelPrinterSpooler tb_LabelPrinterSpooler11 { get; set; }

        public virtual tb_LabelPrinterSpooler tb_LabelPrinterSpooler3 { get; set; }
    }
}
