namespace iTrack.Web.Api.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class GPS_Problems
    {
        [Key]
        public long ProblemID { get; set; }

        [Column(TypeName = "date")]
        public DateTime? Date { get; set; }

        public long? GPS_IΜΕΙ { get; set; }

        [StringLength(150)]
        public string Problem { get; set; }

        [StringLength(150)]
        public string Solution { get; set; }
    }
}
