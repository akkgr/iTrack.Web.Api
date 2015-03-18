using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace iTrack.Web.Api.Models
{
    public class Vehicle
    {
        [Key]
        public long ID { get; set; }
        public long? CompanyID { get; set; }
        public string Title { get; set; }
        public long? LastTrackID { get; set; }
        public bool isSelected { get; set; }
        public Vehicle()
        {
        }
    }
}