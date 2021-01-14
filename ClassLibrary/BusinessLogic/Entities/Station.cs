using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcoScooter.Entities
{
    public partial class Station
    {
        public Station() {
            Scooters = new List<Scooter>();
            DestinationRentals = new List<Rental>();
            OriginRentals = new List<Rental>();
        }

        public Station(String a, String id, double la, double lo) : this() {
            Address = a;
            Id = id;
            Latitude = la;
            Longitude = lo;
        }

        public Scooter GetAvaliableScooter() {
            Scooter res = null;

            if (Scooters.Count() > 0) {
                res = Scooters.First<Scooter>();
                Scooters.Remove(res);
            }

            return res;
        }

        public bool VerifyId(string id)
        {
            return this.Id.Equals(id);
        }

        public void AddRentalBeingOrigin(Rental rental) {
            OriginRentals.Add(rental);
        }

        public void AddRentalBeingDestination(Rental rental)
        {
            DestinationRentals.Add(rental);
        }

        public bool HasScooters() {
            return Scooters.Count > 0;
        }
    }
}
