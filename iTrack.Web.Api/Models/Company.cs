using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace iTrack.Web.Api.Models
{
    public class Company
    {
        [Key]
        public long ID { get; set; }
        public string Title { get; set; }

        public Company()
        {
        }
    }
}