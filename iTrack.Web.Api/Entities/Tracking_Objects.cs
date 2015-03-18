namespace iTrack.Web.Api.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Tracking_Objects
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Tracking_Objects()
        {
            GPS_GPS_Objects = new HashSet<GPS_GPS_Objects>();
        }

        [Key]
        public long Trackin_Object_ID { get; set; }

        [StringLength(50)]
        public string Category { get; set; }

        [StringLength(50)]
        public string Name { get; set; }

        [StringLength(50)]
        public string Plate { get; set; }

        [StringLength(50)]
        public string Colour { get; set; }

        [StringLength(50)]
        public string Fuel { get; set; }

        public int? CylinderCapacity { get; set; }

        [StringLength(50)]
        public string Model { get; set; }

        [StringLength(50)]
        public string Factory { get; set; }

        public long? Last_Track_ID { get; set; }

        [Column(TypeName = "date")]
        public DateTime? Start_Subscription { get; set; }

        [Column(TypeName = "date")]
        public DateTime? Stop_Subscription { get; set; }

        public long? GPS_Tracker_ID { get; set; }

        public bool? SMS_on_event { get; set; }

        public bool? Engine_start { get; set; }

        public long? Customer_ID { get; set; }

        public bool? Object_Lost { get; set; }

        public bool? Object_Alarm { get; set; }

        public bool? Object_GPS_Valid { get; set; }

        public virtual Customer Customer { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<GPS_GPS_Objects> GPS_GPS_Objects { get; set; }
    }
}
