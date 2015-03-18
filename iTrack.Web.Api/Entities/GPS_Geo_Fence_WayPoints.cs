namespace iTrack.Web.Api.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class GPS_Geo_Fence_WayPoints
    {
        [Key]
        public long AA_WayPoint { get; set; }

        [StringLength(50)]
        public string TrackerID { get; set; }

        [StringLength(15)]
        public string Waypoint_1_Lattitude { get; set; }

        [StringLength(10)]
        public string Waypoint_2_Lattitude { get; set; }

        [StringLength(10)]
        public string Waypoint_3_Lattitude { get; set; }

        [StringLength(10)]
        public string Waypoint_4_Lattitude { get; set; }

        [StringLength(10)]
        public string Waypoint_5_Lattitude { get; set; }

        [StringLength(10)]
        public string Waypoint_6_Lattitude { get; set; }

        [StringLength(10)]
        public string Waypoint_7_Lattitude { get; set; }

        [StringLength(10)]
        public string Waypoint_8_Lattitude { get; set; }

        [StringLength(10)]
        public string Waypoint_1_Longitude { get; set; }

        [StringLength(10)]
        public string Waypoint_2_Longitude { get; set; }

        [StringLength(10)]
        public string Waypoint_3_Longitude { get; set; }

        [StringLength(10)]
        public string Waypoint_4_Longitude { get; set; }

        [StringLength(10)]
        public string Waypoint_5_Longitude { get; set; }

        [StringLength(10)]
        public string Waypoint_6_Longitude { get; set; }

        [StringLength(10)]
        public string Waypoint_7_Longitude { get; set; }

        [StringLength(10)]
        public string Waypoint_8_Longitude { get; set; }

        [StringLength(10)]
        public string Radius1 { get; set; }

        [StringLength(10)]
        public string Radius2 { get; set; }

        [StringLength(10)]
        public string Radius3 { get; set; }

        [StringLength(10)]
        public string Radius4 { get; set; }

        [StringLength(10)]
        public string Radius5 { get; set; }

        [StringLength(10)]
        public string Radius6 { get; set; }

        [StringLength(10)]
        public string Radius7 { get; set; }

        [StringLength(10)]
        public string Radius8 { get; set; }

        public bool? InAlarm1 { get; set; }

        public bool? InAlarm2 { get; set; }

        public bool? InAlarm3 { get; set; }

        public bool? InAlarm4 { get; set; }

        public bool? InAlarm5 { get; set; }

        public bool? InAlarm6 { get; set; }

        public bool? InAlarm7 { get; set; }

        public bool? InAlarm8 { get; set; }

        public bool? OutAlarm1 { get; set; }

        public bool? OutAlarm2 { get; set; }

        public bool? OutAlarm3 { get; set; }

        public bool? OutAlarm4 { get; set; }

        public bool? OutAlarm5 { get; set; }

        public bool? OutAlarm6 { get; set; }

        public bool? OutAlarm7 { get; set; }

        public bool? OutAlarm8 { get; set; }

        public bool? HasChanged { get; set; }
    }
}
