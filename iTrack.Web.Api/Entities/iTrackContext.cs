namespace iTrack.Web.Api.Entities
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class iTrackContext : DbContext
    {
        public iTrackContext()
            : base("name=iTrackContext")
        {
        }

        public virtual DbSet<Customer> Customers { get; set; }
        public virtual DbSet<GPS_GPS_Objects> GPS_GPS_Objects { get; set; }
        public virtual DbSet<GPSreceive> GPSreceives { get; set; }
        public virtual DbSet<Mobile_Network_Codes> Mobile_Network_Codes { get; set; }
        public virtual DbSet<SIM> SIMS { get; set; }
        public virtual DbSet<Tracking_Object_Routes> Tracking_Object_Routes { get; set; }
        public virtual DbSet<Tracking_Objects> Tracking_Objects { get; set; }
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<GPS_Commands> GPS_Commands { get; set; }
        public virtual DbSet<GPS_Event_Flags_To_Report> GPS_Event_Flags_To_Report { get; set; }
        public virtual DbSet<GPS_EventFlags_To_Take_Pictures> GPS_EventFlags_To_Take_Pictures { get; set; }
        public virtual DbSet<GPS_Events_Codes> GPS_Events_Codes { get; set; }
        public virtual DbSet<GPS_Geo_Fence_WayPoints> GPS_Geo_Fence_WayPoints { get; set; }
        public virtual DbSet<GPS_Inputs_Outputs> GPS_Inputs_Outputs { get; set; }
        public virtual DbSet<GPS_Problems> GPS_Problems { get; set; }
        public virtual DbSet<GPS_Track_Pictures> GPS_Track_Pictures { get; set; }
        public virtual DbSet<Mobile_Country_Codes> Mobile_Country_Codes { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Customer>()
                .Property(e => e.Company_Name)
                .IsUnicode(false);

            modelBuilder.Entity<Customer>()
                .Property(e => e.Fisrt_Name)
                .IsUnicode(false);

            modelBuilder.Entity<Customer>()
                .Property(e => e.Last_Name)
                .IsUnicode(false);

            modelBuilder.Entity<Customer>()
                .Property(e => e.Address)
                .IsUnicode(false);

            modelBuilder.Entity<Customer>()
                .Property(e => e.City)
                .IsUnicode(false);

            modelBuilder.Entity<Customer>()
                .Property(e => e.TK)
                .IsUnicode(false);

            modelBuilder.Entity<Customer>()
                .Property(e => e.Country)
                .IsUnicode(false);

            modelBuilder.Entity<Customer>()
                .Property(e => e.Phone)
                .IsUnicode(false);

            modelBuilder.Entity<Customer>()
                .Property(e => e.Mobile)
                .IsUnicode(false);

            modelBuilder.Entity<Customer>()
                .Property(e => e.Fax)
                .IsUnicode(false);

            modelBuilder.Entity<Customer>()
                .Property(e => e.Email)
                .IsUnicode(false);

            modelBuilder.Entity<Customer>()
                .Property(e => e.UserName)
                .IsUnicode(false);

            modelBuilder.Entity<Customer>()
                .Property(e => e.Password)
                .IsUnicode(false);

            modelBuilder.Entity<GPS_GPS_Objects>()
                .Property(e => e.GPS_Track_Model)
                .IsUnicode(false);

            modelBuilder.Entity<GPS_GPS_Objects>()
                .Property(e => e.SN)
                .IsUnicode(false);

            modelBuilder.Entity<GPS_GPS_Objects>()
                .Property(e => e.IMEI)
                .IsFixedLength();

            modelBuilder.Entity<GPS_GPS_Objects>()
                .Property(e => e.TrackerID)
                .IsUnicode(false);

            modelBuilder.Entity<GPS_GPS_Objects>()
                .Property(e => e.GPRS)
                .IsUnicode(false);

            modelBuilder.Entity<GPS_GPS_Objects>()
                .Property(e => e.IP)
                .IsUnicode(false);

            modelBuilder.Entity<GPS_GPS_Objects>()
                .Property(e => e.Secondary_IP)
                .IsUnicode(false);

            modelBuilder.Entity<GPS_GPS_Objects>()
                .Property(e => e.APN)
                .IsUnicode(false);

            modelBuilder.Entity<GPS_GPS_Objects>()
                .Property(e => e.APN_Username)
                .IsUnicode(false);

            modelBuilder.Entity<GPS_GPS_Objects>()
                .Property(e => e.APN_Password)
                .IsUnicode(false);

            modelBuilder.Entity<GPS_GPS_Objects>()
                .Property(e => e.Protocol)
                .IsUnicode(false);

            modelBuilder.Entity<GPS_GPS_Objects>()
                .Property(e => e.SMS_Time_Zone)
                .IsUnicode(false);

            modelBuilder.Entity<GPS_GPS_Objects>()
                .Property(e => e.GPRS_Time_Zone)
                .IsUnicode(false);

            modelBuilder.Entity<GPS_GPS_Objects>()
                .Property(e => e.Distance_Interval)
                .IsUnicode(false);

            modelBuilder.Entity<GPS_GPS_Objects>()
                .Property(e => e.Heading_Change_Report)
                .IsUnicode(false);

            modelBuilder.Entity<GPS_GPS_Objects>()
                .Property(e => e.Speeding_Alarm)
                .IsUnicode(false);

            modelBuilder.Entity<GPS_GPS_Objects>()
                .Property(e => e.Low_External_Power)
                .IsUnicode(false);

            modelBuilder.Entity<GPS_GPS_Objects>()
                .Property(e => e.Heartbeat_Interval)
                .IsUnicode(false);

            modelBuilder.Entity<GPS_GPS_Objects>()
                .Property(e => e.Log_Interval)
                .IsUnicode(false);

            modelBuilder.Entity<GPS_GPS_Objects>()
                .Property(e => e.GPS_Sleep_Mode)
                .IsUnicode(false);

            modelBuilder.Entity<GPS_GPS_Objects>()
                .Property(e => e.Power_Down)
                .IsUnicode(false);

            modelBuilder.Entity<GPS_GPS_Objects>()
                .Property(e => e.Tow_ALarm)
                .IsUnicode(false);

            modelBuilder.Entity<GPSreceive>()
                .Property(e => e.Account)
                .IsUnicode(false);

            modelBuilder.Entity<GPSreceive>()
                .Property(e => e.Latitude)
                .IsUnicode(false);

            modelBuilder.Entity<GPSreceive>()
                .Property(e => e.Longitude)
                .IsUnicode(false);

            modelBuilder.Entity<GPSreceive>()
                .Property(e => e.TypeOfAlarm)
                .IsUnicode(false);

            modelBuilder.Entity<GPSreceive>()
                .Property(e => e.TimeStamp)
                .IsFixedLength();

            modelBuilder.Entity<GPSreceive>()
                .Property(e => e.Command)
                .IsUnicode(false);

            modelBuilder.Entity<GPSreceive>()
                .Property(e => e.BaseID)
                .IsUnicode(false);

            modelBuilder.Entity<GPSreceive>()
                .Property(e => e.MCC)
                .IsUnicode(false);

            modelBuilder.Entity<GPSreceive>()
                .Property(e => e.MNC)
                .IsUnicode(false);

            modelBuilder.Entity<GPSreceive>()
                .Property(e => e.LAC)
                .IsUnicode(false);

            modelBuilder.Entity<GPSreceive>()
                .Property(e => e.CI)
                .IsUnicode(false);

            modelBuilder.Entity<GPSreceive>()
                .Property(e => e.StateIO)
                .IsUnicode(false);

            modelBuilder.Entity<GPSreceive>()
                .Property(e => e.AD)
                .IsUnicode(false);

            modelBuilder.Entity<GPSreceive>()
                .Property(e => e.RFID)
                .IsUnicode(false);

            modelBuilder.Entity<GPSreceive>()
                .Property(e => e.PictureFile)
                .IsUnicode(false);

            modelBuilder.Entity<Mobile_Network_Codes>()
                .Property(e => e.MCC)
                .IsUnicode(false);

            modelBuilder.Entity<Mobile_Network_Codes>()
                .Property(e => e.Mobile_Network_Code)
                .IsUnicode(false);

            modelBuilder.Entity<Mobile_Network_Codes>()
                .Property(e => e.Network)
                .IsUnicode(false);

            modelBuilder.Entity<SIM>()
                .Property(e => e.PIN1)
                .IsUnicode(false);

            modelBuilder.Entity<SIM>()
                .Property(e => e.PIN2)
                .IsUnicode(false);

            modelBuilder.Entity<SIM>()
                .Property(e => e.PUK1)
                .IsUnicode(false);

            modelBuilder.Entity<SIM>()
                .Property(e => e.PUK2)
                .IsUnicode(false);

            modelBuilder.Entity<SIM>()
                .Property(e => e.Description)
                .IsUnicode(false);

            modelBuilder.Entity<Tracking_Object_Routes>()
                .Property(e => e.Account)
                .IsUnicode(false);

            modelBuilder.Entity<Tracking_Object_Routes>()
                .Property(e => e.Start_Latitude)
                .IsUnicode(false);

            modelBuilder.Entity<Tracking_Object_Routes>()
                .Property(e => e.Start_Longitude)
                .IsUnicode(false);

            modelBuilder.Entity<Tracking_Object_Routes>()
                .Property(e => e.Start_Address)
                .IsUnicode(false);

            modelBuilder.Entity<Tracking_Object_Routes>()
                .Property(e => e.Stop_Latitude)
                .IsUnicode(false);

            modelBuilder.Entity<Tracking_Object_Routes>()
                .Property(e => e.Stop_Longitude)
                .IsUnicode(false);

            modelBuilder.Entity<Tracking_Object_Routes>()
                .Property(e => e.Stop_Address)
                .IsUnicode(false);

            modelBuilder.Entity<Tracking_Objects>()
                .Property(e => e.Category)
                .IsUnicode(false);

            modelBuilder.Entity<Tracking_Objects>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<Tracking_Objects>()
                .Property(e => e.Plate)
                .IsUnicode(false);

            modelBuilder.Entity<Tracking_Objects>()
                .Property(e => e.Colour)
                .IsUnicode(false);

            modelBuilder.Entity<Tracking_Objects>()
                .Property(e => e.Fuel)
                .IsUnicode(false);

            modelBuilder.Entity<Tracking_Objects>()
                .Property(e => e.Model)
                .IsUnicode(false);

            modelBuilder.Entity<Tracking_Objects>()
                .Property(e => e.Factory)
                .IsUnicode(false);

            modelBuilder.Entity<Tracking_Objects>()
                .HasMany(e => e.GPS_GPS_Objects)
                .WithOptional(e => e.Tracking_Objects)
                .HasForeignKey(e => e.Tracking_Object_ID);

            modelBuilder.Entity<User>()
                .Property(e => e.FirstName)
                .IsUnicode(false);

            modelBuilder.Entity<User>()
                .Property(e => e.LastName)
                .IsUnicode(false);

            modelBuilder.Entity<User>()
                .Property(e => e.Address)
                .IsUnicode(false);

            modelBuilder.Entity<User>()
                .Property(e => e.TK)
                .IsUnicode(false);

            modelBuilder.Entity<User>()
                .Property(e => e.City)
                .IsUnicode(false);

            modelBuilder.Entity<User>()
                .Property(e => e.Country)
                .IsUnicode(false);

            modelBuilder.Entity<User>()
                .Property(e => e.HomePhone)
                .IsUnicode(false);

            modelBuilder.Entity<User>()
                .Property(e => e.MobilePhone)
                .IsUnicode(false);

            modelBuilder.Entity<User>()
                .Property(e => e.Email)
                .IsUnicode(false);

            modelBuilder.Entity<User>()
                .Property(e => e.CompaniesToView)
                .IsUnicode(false);

            modelBuilder.Entity<User>()
                .Property(e => e.ObjectsToView)
                .IsUnicode(false);

            modelBuilder.Entity<User>()
                .Property(e => e.username)
                .IsUnicode(false);

            modelBuilder.Entity<User>()
                .Property(e => e.password)
                .IsUnicode(false);

            modelBuilder.Entity<GPS_Commands>()
                .Property(e => e.SMS_Command)
                .IsUnicode(false);

            modelBuilder.Entity<GPS_Commands>()
                .Property(e => e.GPRS_Command)
                .IsUnicode(false);

            modelBuilder.Entity<GPS_Commands>()
                .Property(e => e.Command)
                .IsUnicode(false);

            modelBuilder.Entity<GPS_Commands>()
                .Property(e => e.Description)
                .IsUnicode(false);

            modelBuilder.Entity<GPS_Commands>()
                .Property(e => e.SMS_Example)
                .IsUnicode(false);

            modelBuilder.Entity<GPS_Commands>()
                .Property(e => e.GPS_Track_Model)
                .IsUnicode(false);

            modelBuilder.Entity<GPS_Event_Flags_To_Report>()
                .Property(e => e.TrackerID)
                .IsUnicode(false);

            modelBuilder.Entity<GPS_EventFlags_To_Take_Pictures>()
                .Property(e => e.TrackerID)
                .IsUnicode(false);

            modelBuilder.Entity<GPS_Events_Codes>()
                .Property(e => e.EventEnglish)
                .IsUnicode(false);

            modelBuilder.Entity<GPS_Events_Codes>()
                .Property(e => e.EventGreece)
                .IsUnicode(false);

            modelBuilder.Entity<GPS_Events_Codes>()
                .Property(e => e.GPS_Track_Model)
                .IsUnicode(false);

            modelBuilder.Entity<GPS_Geo_Fence_WayPoints>()
                .Property(e => e.TrackerID)
                .IsUnicode(false);

            modelBuilder.Entity<GPS_Geo_Fence_WayPoints>()
                .Property(e => e.Waypoint_1_Lattitude)
                .IsUnicode(false);

            modelBuilder.Entity<GPS_Geo_Fence_WayPoints>()
                .Property(e => e.Waypoint_2_Lattitude)
                .IsFixedLength();

            modelBuilder.Entity<GPS_Geo_Fence_WayPoints>()
                .Property(e => e.Waypoint_3_Lattitude)
                .IsFixedLength();

            modelBuilder.Entity<GPS_Geo_Fence_WayPoints>()
                .Property(e => e.Waypoint_4_Lattitude)
                .IsFixedLength();

            modelBuilder.Entity<GPS_Geo_Fence_WayPoints>()
                .Property(e => e.Waypoint_5_Lattitude)
                .IsFixedLength();

            modelBuilder.Entity<GPS_Geo_Fence_WayPoints>()
                .Property(e => e.Waypoint_6_Lattitude)
                .IsFixedLength();

            modelBuilder.Entity<GPS_Geo_Fence_WayPoints>()
                .Property(e => e.Waypoint_7_Lattitude)
                .IsFixedLength();

            modelBuilder.Entity<GPS_Geo_Fence_WayPoints>()
                .Property(e => e.Waypoint_8_Lattitude)
                .IsFixedLength();

            modelBuilder.Entity<GPS_Geo_Fence_WayPoints>()
                .Property(e => e.Waypoint_1_Longitude)
                .IsFixedLength();

            modelBuilder.Entity<GPS_Geo_Fence_WayPoints>()
                .Property(e => e.Waypoint_2_Longitude)
                .IsFixedLength();

            modelBuilder.Entity<GPS_Geo_Fence_WayPoints>()
                .Property(e => e.Waypoint_3_Longitude)
                .IsFixedLength();

            modelBuilder.Entity<GPS_Geo_Fence_WayPoints>()
                .Property(e => e.Waypoint_4_Longitude)
                .IsFixedLength();

            modelBuilder.Entity<GPS_Geo_Fence_WayPoints>()
                .Property(e => e.Waypoint_5_Longitude)
                .IsFixedLength();

            modelBuilder.Entity<GPS_Geo_Fence_WayPoints>()
                .Property(e => e.Waypoint_6_Longitude)
                .IsFixedLength();

            modelBuilder.Entity<GPS_Geo_Fence_WayPoints>()
                .Property(e => e.Waypoint_7_Longitude)
                .IsFixedLength();

            modelBuilder.Entity<GPS_Geo_Fence_WayPoints>()
                .Property(e => e.Waypoint_8_Longitude)
                .IsFixedLength();

            modelBuilder.Entity<GPS_Geo_Fence_WayPoints>()
                .Property(e => e.Radius1)
                .IsFixedLength();

            modelBuilder.Entity<GPS_Geo_Fence_WayPoints>()
                .Property(e => e.Radius2)
                .IsFixedLength();

            modelBuilder.Entity<GPS_Geo_Fence_WayPoints>()
                .Property(e => e.Radius3)
                .IsFixedLength();

            modelBuilder.Entity<GPS_Geo_Fence_WayPoints>()
                .Property(e => e.Radius4)
                .IsFixedLength();

            modelBuilder.Entity<GPS_Geo_Fence_WayPoints>()
                .Property(e => e.Radius5)
                .IsFixedLength();

            modelBuilder.Entity<GPS_Geo_Fence_WayPoints>()
                .Property(e => e.Radius6)
                .IsFixedLength();

            modelBuilder.Entity<GPS_Geo_Fence_WayPoints>()
                .Property(e => e.Radius7)
                .IsFixedLength();

            modelBuilder.Entity<GPS_Geo_Fence_WayPoints>()
                .Property(e => e.Radius8)
                .IsFixedLength();

            modelBuilder.Entity<GPS_Inputs_Outputs>()
                .Property(e => e.Account)
                .IsUnicode(false);

            modelBuilder.Entity<GPS_Inputs_Outputs>()
                .Property(e => e.Analog1)
                .IsUnicode(false);

            modelBuilder.Entity<GPS_Inputs_Outputs>()
                .Property(e => e.Analog2)
                .IsUnicode(false);

            modelBuilder.Entity<GPS_Inputs_Outputs>()
                .Property(e => e.Analog3)
                .IsUnicode(false);

            modelBuilder.Entity<GPS_Inputs_Outputs>()
                .Property(e => e.In1Description)
                .IsUnicode(false);

            modelBuilder.Entity<GPS_Inputs_Outputs>()
                .Property(e => e.In2Description)
                .IsUnicode(false);

            modelBuilder.Entity<GPS_Inputs_Outputs>()
                .Property(e => e.In3Description)
                .IsUnicode(false);

            modelBuilder.Entity<GPS_Inputs_Outputs>()
                .Property(e => e.Out1Description)
                .IsUnicode(false);

            modelBuilder.Entity<GPS_Inputs_Outputs>()
                .Property(e => e.Out2Description)
                .IsUnicode(false);

            modelBuilder.Entity<GPS_Inputs_Outputs>()
                .Property(e => e.Out3Description)
                .IsUnicode(false);

            modelBuilder.Entity<GPS_Inputs_Outputs>()
                .Property(e => e.An1Description)
                .IsUnicode(false);

            modelBuilder.Entity<GPS_Inputs_Outputs>()
                .Property(e => e.An2Description)
                .IsUnicode(false);

            modelBuilder.Entity<GPS_Inputs_Outputs>()
                .Property(e => e.An3Description)
                .IsUnicode(false);

            modelBuilder.Entity<GPS_Problems>()
                .Property(e => e.Problem)
                .IsUnicode(false);

            modelBuilder.Entity<GPS_Problems>()
                .Property(e => e.Solution)
                .IsUnicode(false);

            modelBuilder.Entity<GPS_Track_Pictures>()
                .Property(e => e.TrackObjectID)
                .IsUnicode(false);

            modelBuilder.Entity<GPS_Track_Pictures>()
                .Property(e => e.Picture_Name)
                .IsUnicode(false);

            modelBuilder.Entity<GPS_Track_Pictures>()
                .Property(e => e.Month)
                .IsUnicode(false);

            modelBuilder.Entity<GPS_Track_Pictures>()
                .Property(e => e.Date)
                .IsUnicode(false);

            modelBuilder.Entity<GPS_Track_Pictures>()
                .Property(e => e.Camera)
                .IsUnicode(false);

            modelBuilder.Entity<GPS_Track_Pictures>()
                .Property(e => e.Event)
                .IsUnicode(false);

            modelBuilder.Entity<Mobile_Country_Codes>()
                .Property(e => e.Country_ID)
                .IsUnicode(false);

            modelBuilder.Entity<Mobile_Country_Codes>()
                .Property(e => e.ISO_3166_1)
                .IsUnicode(false);

            modelBuilder.Entity<Mobile_Country_Codes>()
                .Property(e => e.Country)
                .IsUnicode(false);
        }
    }
}
