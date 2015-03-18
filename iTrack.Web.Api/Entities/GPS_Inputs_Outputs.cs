namespace iTrack.Web.Api.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class GPS_Inputs_Outputs
    {
        public long ID { get; set; }

        [StringLength(50)]
        public string Account { get; set; }

        public bool? Input1 { get; set; }

        public bool? Input2 { get; set; }

        public bool? Input3 { get; set; }

        public bool? Output1 { get; set; }

        public bool? Output2 { get; set; }

        public bool? Output3 { get; set; }

        [StringLength(50)]
        public string Analog1 { get; set; }

        [StringLength(50)]
        public string Analog2 { get; set; }

        [StringLength(50)]
        public string Analog3 { get; set; }

        [StringLength(50)]
        public string In1Description { get; set; }

        [StringLength(50)]
        public string In2Description { get; set; }

        [StringLength(50)]
        public string In3Description { get; set; }

        [StringLength(50)]
        public string Out1Description { get; set; }

        [StringLength(50)]
        public string Out2Description { get; set; }

        [StringLength(50)]
        public string Out3Description { get; set; }

        [StringLength(50)]
        public string An1Description { get; set; }

        [StringLength(50)]
        public string An2Description { get; set; }

        [StringLength(50)]
        public string An3Description { get; set; }
    }
}
