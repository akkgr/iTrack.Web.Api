using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace iTrack.Web.Api.Models
{
    public class Route
    {
        [Key]
        public long ID { get; set; }

        public long VechicleID { get; set; }

        private DateTime? _dateFrom;
        public DateTime? dateFrom
        {
            get
            {
                if (_dateFrom.HasValue)
                {
                    return _dateFrom.Value.ToLocalTime();
                }
                else return _dateFrom;
            }
            set
            {
                _dateFrom = value;
            }
        }

        public string LonFrom { get; set; }

        public string LatFrom { get; set; }

        public long? ReceiveIdFrom { get; set; }

        private DateTime? _dateTo;
        public DateTime? dateTo
        {
            get
            {
                if (_dateTo.HasValue)
                {
                    return _dateTo.Value.ToLocalTime();
                }
                else return _dateTo;
            }
            set
            {
                _dateTo = value;
            }
        }

        public string LonTo { get; set; }

        public string LatTo { get; set; }

        public long? ReceiveIdTo { get; set; }

        private double? _distance;
        public double? Distance
        {
            get
            {
                return _distance;
            }
            set
            {
                _distance = value / 1000;
                if (_distance != null)
                    _distance = Math.Round(_distance.Value, 2);
            }
        }

        public string DriveTimeS { get; set; }

        private long? _drivetime;
        public long? DriveTime
        {
            get
            {
                return _drivetime;
            }
            set
            {
                _drivetime = value;
                if (_drivetime.HasValue)
                {
                    long sec;
                    long min;
                    long hr;

                    hr = Math.DivRem(_drivetime.Value, 3600, out sec);
                    min = Math.DivRem(sec, 60, out sec);
                    DriveTimeS = hr.ToString("00") + ":" + min.ToString("00") + ":" + sec.ToString("00");
                }
            }
        }

        public string RestTimeS { get; set; }

        private long? _resttime;
        public long? RestTime
        {
            get
            {
                return _resttime;
            }
            set
            {
                _resttime = value;
                if (_resttime.HasValue)
                {
                    long sec;
                    long min;
                    long hr;

                    hr = Math.DivRem(_resttime.Value, 3600, out sec);
                    min = Math.DivRem(sec, 60, out sec);
                    RestTimeS = hr.ToString("00") + ":" + min.ToString("00") + ":" + sec.ToString("00");
                }
            }
        }
    }
}