namespace MovInfoService_CMD.MODEL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class mov_Label
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public mov_Label()
        {
            tb_LabelPrinterSpooler = new HashSet<tb_LabelPrinterSpooler>();
        }

        [Key]
        public int IdLabel { get; set; }

        [StringLength(30)]
        public string LabelType { get; set; }

        [StringLength(30)]
        public string UDCCode { get; set; }

        public int? NrProductionOrder { get; set; }

        [Column(TypeName = "date")]
        public DateTime? DateProductionOrder { get; set; }

        [StringLength(50)]
        public string ItemCode { get; set; }

        [StringLength(250)]
        public string ItemDescription { get; set; }

        [StringLength(50)]
        public string BarcodeItemCode { get; set; }

        public float? ItemLenght { get; set; }

        public float? ItemWidth { get; set; }

        public float? ItemThickness { get; set; }

        public float? ItemWeight { get; set; }

        [StringLength(50)]
        public string CustomerItemCode { get; set; }

        [StringLength(250)]
        public string CustomerItemDescription { get; set; }

        [StringLength(50)]
        public string ModelCustomerItemCode { get; set; }

        [StringLength(50)]
        public string BarcodeCustomerItemCode { get; set; }

        [StringLength(10)]
        public string TagVoice { get; set; }

        [StringLength(10)]
        public string UM { get; set; }

        [StringLength(10)]
        public string Quantity { get; set; }

        public int? NrSalesOrder { get; set; }

        [Column(TypeName = "date")]
        public DateTime? DateSalesOrder { get; set; }

        [StringLength(50)]
        public string CustomerSalesOrder { get; set; }

        [Column(TypeName = "date")]
        public DateTime? DateCustomerSalesOrder { get; set; }

        [StringLength(50)]
        public string CompanyName { get; set; }

        [StringLength(250)]
        public string Address { get; set; }

        [StringLength(50)]
        public string City { get; set; }

        [StringLength(50)]
        public string Province { get; set; }

        [StringLength(10)]
        public string PostalCode { get; set; }

        [StringLength(25)]
        public string Country { get; set; }

        [StringLength(10)]
        public string DeliveryZone { get; set; }

        public float? UDCVolume { get; set; }

        public float? UDCWeight { get; set; }

        public DateTime? dtInsertDate { get; set; }

        [StringLength(100)]
        public string ngtechinfo01 { get; set; }

        [StringLength(100)]
        public string ngtechinfo02 { get; set; }

        [StringLength(100)]
        public string ngtechinfo03 { get; set; }

        [StringLength(100)]
        public string ngtechinfo04 { get; set; }

        [StringLength(100)]
        public string ngtechinfo05 { get; set; }

        [StringLength(100)]
        public string ngtechinfo06 { get; set; }

        [StringLength(100)]
        public string ngtechinfo07 { get; set; }

        [StringLength(100)]
        public string ngtechinfo08 { get; set; }

        [StringLength(100)]
        public string ngtechinfo09 { get; set; }

        [StringLength(100)]
        public string ngtechinfo10 { get; set; }

        [StringLength(100)]
        public string ngtechinfo11 { get; set; }

        [StringLength(100)]
        public string ngtechinfo12 { get; set; }

        [StringLength(100)]
        public string ngtechinfo13 { get; set; }

        [StringLength(100)]
        public string ngtechinfo14 { get; set; }

        [StringLength(100)]
        public string ngtechinfo15 { get; set; }

        [StringLength(100)]
        public string ngtechinfo16 { get; set; }

        [StringLength(100)]
        public string ngtechinfo17 { get; set; }

        [StringLength(100)]
        public string ngtechinfo18 { get; set; }

        [StringLength(100)]
        public string ngtechinfo19 { get; set; }

        [StringLength(100)]
        public string ngtechinfo20 { get; set; }

        [StringLength(100)]
        public string ngtechinfo21 { get; set; }

        [StringLength(100)]
        public string ngtechinfo22 { get; set; }

        [StringLength(100)]
        public string ngtechinfo23 { get; set; }

        [StringLength(100)]
        public string ngtechinfo24 { get; set; }

        [StringLength(100)]
        public string ngtechinfo25 { get; set; }

        [StringLength(100)]
        public string ngtechinfo26 { get; set; }

        [StringLength(100)]
        public string ngtechinfo27 { get; set; }

        [StringLength(100)]
        public string ngtechinfo29 { get; set; }

        [StringLength(100)]
        public string ngtechinfo30 { get; set; }

        [StringLength(100)]
        public string ngtechinfo31 { get; set; }

        [StringLength(100)]
        public string ngtechinfo32 { get; set; }

        [StringLength(100)]
        public string ngtechinfo33 { get; set; }

        [StringLength(100)]
        public string ngtechinfo34 { get; set; }

        [StringLength(100)]
        public string ngtechinfo35 { get; set; }

        [StringLength(100)]
        public string ngtechinfo36 { get; set; }

        [StringLength(100)]
        public string ngtechinfo37 { get; set; }

        [StringLength(100)]
        public string ngtechinfo38 { get; set; }

        [StringLength(100)]
        public string ngtechinfo39 { get; set; }

        [StringLength(100)]
        public string ngtechinfo40 { get; set; }

        [StringLength(100)]
        public string ngtechinfo28 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tb_LabelPrinterSpooler> tb_LabelPrinterSpooler { get; set; }
    }
}
