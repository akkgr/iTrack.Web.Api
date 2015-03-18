namespace iTrack.Web.Api.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SIMS")]
    public partial class SIM
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public SIM()
        {
            GPS_GPS_Objects = new HashSet<GPS_GPS_Objects>();
        }

        [Key]
        public long idSIM { get; set; }

        [StringLength(14)]
        public string PhoneNumber { get; set; }

        [StringLength(50)]
        public string Company { get; set; }

        [Column("SIM")]
        [StringLength(20)]
        public string SIM1 { get; set; }

        [StringLength(50)]
        public string Program { get; set; }

        [StringLength(50)]
        public string PIN1 { get; set; }

        [StringLength(50)]
        public string PIN2 { get; set; }

        [StringLength(50)]
        public string PUK1 { get; set; }

        [StringLength(50)]
        public string PUK2 { get; set; }

        [Column(TypeName = "date")]
        public DateTime? StartDate { get; set; }

        [StringLength(150)]
        public string Description { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<GPS_GPS_Objects> GPS_GPS_Objects { get; set; }
    }
}
