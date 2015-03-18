namespace iTrack.Web.Api.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class GPS_GPS_Objects
    {
        [Key]
        public long GPS_Tracker_ID { get; set; }

        [StringLength(50)]
        public string GPS_Track_Model { get; set; }

        [StringLength(50)]
        public string SN { get; set; }

        [StringLength(50)]
        public string IMEI { get; set; }

        [StringLength(50)]
        public string TrackerID { get; set; }

        public long? Tracking_Object_ID { get; set; }

        public long? IdSIM { get; set; }

        [StringLength(3)]
        public string GPRS { get; set; }

        public int? GPRS_Interval { get; set; }

        public int? GPRS_Report_Times { get; set; }

        [StringLength(50)]
        public string IP { get; set; }

        public int? Port { get; set; }

        [StringLength(50)]
        public string Secondary_IP { get; set; }

        public int? Secondare_s_IP_Port { get; set; }

        [StringLength(50)]
        public string APN { get; set; }

        [StringLength(50)]
        public string APN_Username { get; set; }

        [StringLength(50)]
        public string APN_Password { get; set; }

        [StringLength(50)]
        public string Protocol { get; set; }

        [StringLength(50)]
        public string SMS_Time_Zone { get; set; }

        [StringLength(50)]
        public string GPRS_Time_Zone { get; set; }

        [StringLength(50)]
        public string Distance_Interval { get; set; }

        [StringLength(50)]
        public string Heading_Change_Report { get; set; }

        [StringLength(50)]
        public string Speeding_Alarm { get; set; }

        [StringLength(50)]
        public string Low_External_Power { get; set; }

        [StringLength(50)]
        public string Heartbeat_Interval { get; set; }

        [StringLength(50)]
        public string Log_Interval { get; set; }

        [StringLength(50)]
        public string GPS_Sleep_Mode { get; set; }

        [StringLength(50)]
        public string Power_Down { get; set; }

        [StringLength(50)]
        public string Tow_ALarm { get; set; }

        public bool? LED_Off { get; set; }

        public bool? Buzzer_OFF { get; set; }

        public virtual SIM SIM { get; set; }

        public virtual Tracking_Objects Tracking_Objects { get; set; }
    }
}
