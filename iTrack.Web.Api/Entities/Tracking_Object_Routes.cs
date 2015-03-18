namespace iTrack.Web.Api.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Tracking_Object_Routes
    {
        [Key]
        public long Routes_ID { get; set; }

        public long? Customer_ID { get; set; }

        public long? Trackin_Object_ID { get; set; }

        public long? GPS_Tracker_ID { get; set; }

        [StringLength(50)]
        public string Account { get; set; }

        public long? Start_Receive_ID { get; set; }

        public DateTime? Start_Date_Time { get; set; }

        [StringLength(50)]
        public string Start_Latitude { get; set; }

        [StringLength(50)]
        public string Start_Longitude { get; set; }

        [StringLength(50)]
        public string Start_Address { get; set; }

        public long? Stop_Receive_ID { get; set; }

        public DateTime? Stop_Date_Time { get; set; }

        [StringLength(50)]
        public string Stop_Latitude { get; set; }

        [StringLength(50)]
        public string Stop_Longitude { get; set; }

        [StringLength(50)]
        public string Stop_Address { get; set; }

        public long? Distance { get; set; }

        public long? Drive_time { get; set; }

        public long? Rest_Time { get; set; }
    }
}
