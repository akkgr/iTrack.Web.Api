namespace iTrack.Web.Api.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class User
    {
        public int UserID { get; set; }

        [StringLength(50)]
        public string FirstName { get; set; }

        [StringLength(50)]
        public string LastName { get; set; }

        [StringLength(50)]
        public string Address { get; set; }

        [StringLength(50)]
        public string TK { get; set; }

        [StringLength(50)]
        public string City { get; set; }

        [StringLength(50)]
        public string Country { get; set; }

        [StringLength(50)]
        public string HomePhone { get; set; }

        [StringLength(50)]
        public string MobilePhone { get; set; }

        [StringLength(50)]
        public string Email { get; set; }

        [StringLength(150)]
        public string CompaniesToView { get; set; }

        [StringLength(150)]
        public string ObjectsToView { get; set; }

        [Column(TypeName = "date")]
        public DateTime? ExpiresDate { get; set; }

        public bool? Valid { get; set; }

        public int? AccessLevel { get; set; }

        [StringLength(50)]
        public string username { get; set; }

        [StringLength(200)]
        public string password { get; set; }
    }
}
