namespace iTrack.Web.Api.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class GPS_Commands
    {
        [Key]
        public long AA_Command { get; set; }

        [StringLength(50)]
        public string SMS_Command { get; set; }

        [StringLength(50)]
        public string GPRS_Command { get; set; }

        [StringLength(150)]
        public string Command { get; set; }

        [StringLength(150)]
        public string Description { get; set; }

        [StringLength(50)]
        public string SMS_Example { get; set; }

        [StringLength(50)]
        public string GPS_Track_Model { get; set; }
    }
}
