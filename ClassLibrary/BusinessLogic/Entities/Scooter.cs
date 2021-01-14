using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcoScooter.Entities
{
    public partial class Scooter
    {
        public Scooter() {
            PlanningWork = new List<PlanningWork>();
            Rentals = new List<Rental>();
        }

        public Scooter(DateTime rd, ScooterState s) : this()
        {
            RegisterDate = rd;
            State = s;
        }

        public void Rent(Rental rental) {
            State = ScooterState.inUse;
            Rentals.Add(rental);
        }

        public void Return() {
            State = ScooterState.available;
        }
    }
}
