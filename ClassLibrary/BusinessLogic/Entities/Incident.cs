using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcoScooter.Entities
{
    public partial class Incident
    {
        public Incident() { }

        public Incident(String d, DateTime ts)
        {
            Description = d;
            TimeStamp = ts;
        }
    }
}
