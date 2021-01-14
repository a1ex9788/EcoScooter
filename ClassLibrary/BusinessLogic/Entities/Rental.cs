using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcoScooter.Entities
{
    public partial class Rental
    {
        public Rental() {
            TrackPoints = new List<TrackPoint>();
        }

        public Rental(DateTime? ed, Decimal p, DateTime sd,
            Station os, Scooter s, User u) : this()
        {
            EndDate = ed;
            Price = p;
            StartDate = sd;
            Scooter = s;
            OriginStation = os;
            User = u;
        }

        public bool IsInInterval(DateTime startDate, DateTime endDate) {
            return StartDate.CompareTo(startDate) >= 0 && EndDate.Value.CompareTo(endDate) <= 0;
        }

        public double CalculateTime()
        {
            return EndDate.Value.Subtract(StartDate).TotalMinutes;
        }

        public bool VerifyId(int id) {
            return Id == id;
        }

        public bool WasReturned() {
            return EndDate != null;
        }

        public void Finish(Station station, double fare, double discountYounger) {
            Scooter.Return();
            station.AddRentalBeingDestination(this);

            EndDate = DateTime.Now;
            DestinationStation = station;

            Price = (decimal)(CalculateTime() * fare);
            if (User.IsYoung()) { Price = (decimal)(1 - discountYounger / 100) * Price; }
        }
    }
}
