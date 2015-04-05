using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Globalization;
using System.Linq;
using System.Web;

namespace iTrack.Web.Api.Models
{
    public class Track
    {
        [Key]
        public long ID { get; set; }

        public string Title { get; set; }
        public long CompanyID { get; set; }
        public long VehicleID { get; set; }

        private DateTime? _datetime;
        public DateTime? datetime
        {
            get
            {
                if (_datetime.HasValue)
                {
                    return _datetime.Value.ToLocalTime();
                }
                else return _datetime;
            }
            set
            {
                _datetime = value;
            }
        }

        public string Longitude { get; set; }

        public string Latitude { get; set; }

        public decimal[] Coordinates
        {
            get
            {
                var ci = new CultureInfo("en-US", false);
                decimal lat = 0;
                decimal lng = 0;
                decimal.TryParse(this.Latitude, NumberStyles.AllowDecimalPoint, ci, out lat);
                decimal.TryParse(this.Longitude, NumberStyles.AllowDecimalPoint, ci, out lng);
                return new decimal[]{lng,lat};
            }
        }

        public string Speed { get; set; }

        public string Heading { get; set; }

        public int? Altitude { get; set; }

        public int? GSMsingal { get; set; }

        public int? Satelites { get; set; }

        public Boolean? Alarm { get; set; }

        public string AlarmType { get; set; }

        public bool isSelected { get; set; }

        public int orderNum { get; set; }

        public bool EngineOn { get; set; }

        public bool gpsOn { get; set; }

        public bool gprsOff { get; set; }

        public bool alarmOff { get; set; }

        private string _color;
        public string Color
        {
            get
            {
                if (string.IsNullOrEmpty(_color))
                {
                    if (alarmOff || gprsOff || !gpsOn) _color = "red";
                    else if (EngineOn) _color = "green";
                    else _color = "blue";
                }
                return _color;
            }
            set
            {
                _color = value;
            }
        }

        public Track()
        {
        }
    }
}