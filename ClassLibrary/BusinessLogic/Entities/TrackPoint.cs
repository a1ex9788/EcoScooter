using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcoScooter.Entities
{
    public partial class TrackPoint
    {
        public TrackPoint() { }

        public TrackPoint(double bl, double la, double lo, double s, DateTime ts) {
            BatteryLevel = bl;
            Latitude = la;
            Longitude = lo;
            Speed = s;
            Timestamp = ts;
        }
    }
}
