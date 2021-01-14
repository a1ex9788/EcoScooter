using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcoScooter.Entities
{
    public partial class PlanningWork
    {
        public PlanningWork() { }

        public PlanningWork(String d, int wt, Maintenance m, Scooter s) {
            Description = d;
            WorkingTime = wt;
            Maintenance = m;
            Scooter = s;
        }
    }
}
