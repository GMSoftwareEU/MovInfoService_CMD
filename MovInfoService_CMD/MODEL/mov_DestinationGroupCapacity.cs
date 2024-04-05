namespace MovInfoService_CMD.MODEL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class mov_DestinationGroupCapacity
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public mov_DestinationGroupCapacity()
        {
            mov_DestinationStatus = new HashSet<mov_DestinationStatus>();
        }

        [Key]
        [StringLength(20)]
        public string codice { get; set; }

        [Required]
        [StringLength(50)]
        public string descrizione { get; set; }

        public int SlotMassimi { get; set; }

        public int SlotOccupati { get; set; }

        public int SlotLivelloSaturazione { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<mov_DestinationStatus> mov_DestinationStatus { get; set; }
    }
}
