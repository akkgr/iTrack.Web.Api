namespace iTrack.Web.Api.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class GPS_Events_Codes
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int EventCode { get; set; }

        [StringLength(50)]
        public string EventEnglish { get; set; }

        [StringLength(50)]
        public string EventGreece { get; set; }

        [StringLength(50)]
        public string GPS_Track_Model { get; set; }
    }
}
