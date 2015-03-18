namespace iTrack.Web.Api.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class GPS_Event_Flags_To_Report
    {
        [Key]
        public long AA_EventFlagsToReport { get; set; }

        [StringLength(50)]
        public string TrackerID { get; set; }

        public bool? Input1Active { get; set; }

        public bool? Input2Active { get; set; }

        public bool? Input3Active { get; set; }

        public bool? Input4Active { get; set; }

        public bool? Input5Active { get; set; }

        public bool? Input1Inactive { get; set; }

        public bool? Input2Inactive { get; set; }

        public bool? Input3Inactive { get; set; }

        public bool? Input4Inactive { get; set; }

        public bool? Input5Inactive { get; set; }

        public bool? LowBattery { get; set; }

        public bool? LowExternalPower { get; set; }

        public bool? Speeding { get; set; }

        public bool? EnterGeoFence { get; set; }

        public bool? ExitGeoFence { get; set; }

        public bool? ExternalPowerOn { get; set; }

        public bool? ExternalPowerOff { get; set; }

        public bool? NoGPS_Signal { get; set; }

        public bool? GetGPS_Signal { get; set; }

        public bool? EnterSleep { get; set; }

        public bool? ExitSleep { get; set; }

        public bool? GPS_AntennaCut { get; set; }

        public bool? DeviceReboot { get; set; }

        public bool? Impact { get; set; }

        public bool? HeartbeatReport { get; set; }

        public bool? HeadingChangeReport { get; set; }

        public bool? DistanceIntervalReport { get; set; }

        public bool? TowAlarm { get; set; }

        public bool? RFID { get; set; }

        public bool? HasChanged { get; set; }
    }
}
