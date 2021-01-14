using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcoScooter.Entities
{
    public partial class User : Person
    {
        const double DAYS_PER_YEAR = 365.25;

        public User() : base() {
            Rentals = new List<Rental>();
        }

        public User(DateTime birthdate, String dni, String email, String
       name, int telephon, int cvv, DateTime ed, String l, int n,
       String p) : base(birthdate, dni, email, name, telephon) {
            Cvv = cvv;
            ExpirationDate = ed;
            Login = l;
            Number = n;
            Password = p;
            Rentals = new List<Rental>();
        }

        public bool VerifyLogin(string login) {
            return Login.Equals(login);
        }

        public bool VerifyPassword(string password)
        {
            return Password.Equals(password);
        }

        public bool IsUnder16() {
            return DateTime.Now.Subtract(Birthdate).TotalDays / DAYS_PER_YEAR < 16;
        }

        public bool IsYoung()
        {
            return !IsUnder16() && DateTime.Now.Subtract(Birthdate).Days / DAYS_PER_YEAR < 25;
        }

        public void AddRental(Rental rental) {
            Rentals.Add(rental);
        }

        public Rental GetLastRental() {
            return Rentals.Count > 0 ? Rentals.Last() : null;
        }

        public bool HasActiveRental() {
            return GetLastRental() != null ? !GetLastRental().WasReturned() : false;
        }
    }
}
