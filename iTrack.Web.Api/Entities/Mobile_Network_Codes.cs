namespace iTrack.Web.Api.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Mobile_Network_Codes
    {
        public long id { get; set; }

        [StringLength(3)]
        public string MCC { get; set; }

        [StringLength(3)]
        public string Mobile_Network_Code { get; set; }

        [StringLength(50)]
        public string Network { get; set; }
    }
}
