namespace iTrack.Web.Api.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Customer
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Customer()
        {
            Tracking_Objects = new HashSet<Tracking_Objects>();
        }

        [Key]
        public long Customer_ID { get; set; }

        [StringLength(150)]
        public string Company_Name { get; set; }

        [StringLength(50)]
        public string Fisrt_Name { get; set; }

        [StringLength(50)]
        public string Last_Name { get; set; }

        public long? ReportTo { get; set; }

        [StringLength(50)]
        public string Address { get; set; }

        [StringLength(50)]
        public string City { get; set; }

        [StringLength(10)]
        public string TK { get; set; }

        [StringLength(50)]
        public string Country { get; set; }

        [StringLength(50)]
        public string Phone { get; set; }

        [StringLength(50)]
        public string Mobile { get; set; }

        [StringLength(50)]
        public string Fax { get; set; }

        [StringLength(50)]
        public string Email { get; set; }

        public bool? Active { get; set; }

        [StringLength(50)]
        public string UserName { get; set; }

        [StringLength(200)]
        public string Password { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Tracking_Objects> Tracking_Objects { get; set; }
    }
}
