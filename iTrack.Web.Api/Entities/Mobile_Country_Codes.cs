namespace iTrack.Web.Api.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Mobile_Country_Codes
    {
        public long ID { get; set; }

        [StringLength(3)]
        public string Country_ID { get; set; }

        [StringLength(2)]
        public string ISO_3166_1 { get; set; }

        [StringLength(50)]
        public string Country { get; set; }
    }
}
