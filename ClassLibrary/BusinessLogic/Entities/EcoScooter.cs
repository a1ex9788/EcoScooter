using EcoScooter.Persistence;
using EcoScooter.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcoScooter.Entities
{
    public partial class EcoScooter
    {
        public EcoScooter()
        {
            Employees = new List<Employee>();
            People = new List<Person>();
            Scooters = new List<Scooter>();
            Stations = new List<Station>();
        }
        public EcoScooter(double dy, double f, double ms, Employee e) : this()
        {
            DiscountYounger = dy;
            Fare = f;
            MaxSpeed = ms;
            Employees.Add(e);
            People.Add(e);
        }

        public bool IsLoginInUse(string login) {
            bool res = false;

            foreach (Person p in People) {
                try
                {
                    User u = (User)p;
                    if (u.VerifyLogin(login)) { res = true; break; }
                } catch (Exception) { }
            }

            return res;
        }
        public bool IsDniInUse(string dni)
        {
            bool res = false;

            foreach (Person p in People)
            {
                if (p.VerifyDni(dni)) { res = true; break; }
            }

            return res;
        }

        public bool NomICognom(string nom)
        {
            bool res = true;

            if(nom.Split(' ').Count() < 2) { res = false; }

            return res;
        }

        public bool TelefonCorrecte(int tlf)
        {
            bool res = true;

            if (tlf.ToString().Length != 9) { res = false; }

            return res;
        }

        public bool CorreuCorrecte(string email)
        {
            bool res = false;

            if (email.Contains("@")) { res = true; }

            return res;
        }

        public User FindUserByLogin(string login) {
            User res = null;

            foreach (Person p in People) {
                try
                {
                    User u = (User)p;
                    if (u.VerifyLogin(login)) { res = u; break; }
                } catch (Exception) { }
            }

            return res;
        }

        public User FindUserByDni(string dni)
        {
            User res = null;

            foreach (Person p in People)
            {
                try
                {
                    User u = (User)p;
                    if (u.VerifyDni(dni)) { res = u; break; }
                }
                catch (Exception) { }
            }

            return res;
        }

        public Employee FindEmployeeByDni(string dni) {
            Employee res = null;

            foreach (Employee e in Employees)
            {
                if (e.VerifyDni(dni)) { res = e; break; }
            }

            return res;
        }

        public Station FindStationById(string id)
        {
            Station res = null;

            foreach (Station s in Stations)
            {
                if (s.VerifyId(id)) { res = s; break; }
            }

            return res;
        }

        public bool IsUnder16(DateTime birthdate) {
            User u = new User();
            u.Birthdate = birthdate;
            return u.IsUnder16();
        }

        public bool IsLatitudeCorrect(double latitude) {
            return -90 <= latitude && latitude <= 90;
        }

        public bool IsLongitudeCorrect(double longitude)
        {
            return -180 <= longitude && longitude <= 180;
        }

        public bool IsAValidCreditCard(int number, int cvv, DateTime ed)
        {
            return cvv.ToString().Length == 3 && number.ToString().Length == 8
                && ed.CompareTo(DateTime.Now) > 0;
        }

        public bool IsFutureDate(DateTime date) {
            return date.CompareTo(DateTime.Now) > 0;
        }

        public User NewUser(DateTime birthDate, string dni, string email, string name, int telephon, int cvv, DateTime expirationDate, string login, int number, string password) {
            User u = new User(birthDate, dni, email, name, telephon, cvv, expirationDate, login, number, password);

            People.Add(u);

            return u;
        }

        public Employee NewEmployee(DateTime birthDate, String dni, String email, String name, int telephon, String iban, int pin, String position, Decimal salary)
        {
            Employee e = new Employee(birthDate, dni, email, name, telephon, iban, pin, position, salary);

            Employees.Add(e);
            People.Add(e);

            return e;
        }

        public Rental FindRentalById(int id) {
            Rental res = null;

            foreach (Scooter s in Scooters) {
                foreach (Rental r in s.Rentals)
                {
                    if (r.VerifyId(id)) { res = r; break; }
                }
            }

            return res;
        }

        public List<Rental> GetAllRentals() {
            List<Rental> res = new List<Rental>();

            foreach (Scooter s in Scooters)
            {
                foreach (Rental r in s.Rentals)
                {
                    res.Add(r);
                }
            }

            return res;
        }

        public Scooter NewScooter(DateTime registerDate, ScooterState state, string stationId) {
            if (state == ScooterState.inUse)
            {
                throw new ServiceException("L'estat no pot ser 'inUse'");
            }
            else {
                Scooter s = new Scooter(registerDate, state);

                if (state == ScooterState.available)
                {
                    Station station = FindStationById(stationId);
                    if (station == null)
                    {
                        throw new ServiceException("L'estació amb id " + stationId + " no existeix");
                    }
                    else
                    {
                        Scooter scooter = new Scooter(registerDate, state);
                        scooter.Station = station;

                        station.Scooters.Add(scooter);
                        Scooters.Add(scooter);
                    }
                }
                else if (state == ScooterState.inMaintenance)
                {
                    Scooter scooter = new Scooter(registerDate, state);

                    Scooters.Add(scooter);
                }

                return s;
            }
        }

        public Incident NewIncident(string description, DateTime timeStamp, Rental rental) {
            Incident i = new Incident(description, timeStamp);

            rental.Incident = i;

            return i;
        }

        public Station NewStation(string address, double latitude, double longitude, string stationId) {
            Station s = new Station(address, stationId, latitude, longitude);

            s.Id = stationId;

            Stations.Add(s);

            return s;
        }

        public Rental RentScooter(Scooter scooter, Station station, User user) {
            Rental r = new Rental(null, 0, DateTime.Now, station, scooter, user);
            scooter.Rent(r);

            user.AddRental(r);
            station.AddRentalBeingOrigin(r);

            return r;
        }

        public bool AreCorrectDates(DateTime sd, DateTime ed) {
            return sd.CompareTo(ed) >= 0;
        }
    }
}
 