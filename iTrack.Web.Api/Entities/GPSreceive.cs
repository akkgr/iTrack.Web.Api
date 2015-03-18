namespace iTrack.Web.Api.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("GPSreceive")]
    public partial class GPSreceive
    {
        [Key]
        public long Receive_ID { get; set; }

        public long? Customer_ID { get; set; }

        public long? Trackin_Object_ID { get; set; }

        public long? GPS_Tracker_ID { get; set; }

        [StringLength(50)]
        public string Account { get; set; }

        public DateTime? DateTime { get; set; }

        public bool? GPSstatus { get; set; }

        [StringLength(50)]
        public string Latitude { get; set; }

        [StringLength(50)]
        public string Longitude { get; set; }

        [StringLength(50)]
        public string Speed { get; set; }

        [StringLength(50)]
        public string Heading { get; set; }

        public bool? Alarm { get; set; }

        [StringLength(50)]
        public string TypeOfAlarm { get; set; }

        [StringLength(50)]
        public string ReceiverID { get; set; }

        [Column(TypeName = "timestamp")]
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        [MaxLength(8)]
        public byte[] TimeStamp { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public DbGeography Location { get; set; }

        [StringLength(50)]
        public string Command { get; set; }

        public int? EventCode { get; set; }

        public int? Satelites { get; set; }

        public int? GSMsignal { get; set; }

        public double? HDOP { get; set; }

        public int? Altitude { get; set; }

        public int? Journay { get; set; }

        public int? Runtime { get; set; }

        [StringLength(50)]
        public string BaseID { get; set; }

        [StringLength(3)]
        public string MCC { get; set; }

        [StringLength(3)]
        public string MNC { get; set; }

        [StringLength(4)]
        public string LAC { get; set; }

        [StringLength(4)]
        public string CI { get; set; }

        [StringLength(50)]
        public string StateIO { get; set; }

        [StringLength(50)]
        public string AD { get; set; }

        [StringLength(50)]
        public string RFID { get; set; }

        [StringLength(50)]
        public string PictureFile { get; set; }

        public bool? EngineStart { get; set; }
    }
}
