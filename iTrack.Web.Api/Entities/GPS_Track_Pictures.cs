namespace iTrack.Web.Api.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class GPS_Track_Pictures
    {
        [Key]
        public long AA { get; set; }

        [StringLength(50)]
        public string TrackObjectID { get; set; }

        [StringLength(50)]
        public string Picture_Name { get; set; }

        [StringLength(2)]
        public string Month { get; set; }

        [StringLength(2)]
        public string Date { get; set; }

        public TimeSpan? Time { get; set; }

        [StringLength(1)]
        public string Camera { get; set; }

        [StringLength(2)]
        public string Event { get; set; }

        [Column(TypeName = "image")]
        public byte[] Picture { get; set; }
    }
}
