
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EcoScooter.Entities;
using EcoScooter.Persistence;

namespace EcoScooter.Services
{
    public class EcoScooterService : IEcoScooterService
    {
        private readonly IDAL dal;
        private EcoScooter.Entities.EcoScooter ecoScooter;
        //Hay que mantener una referencia al usuario con la sesión actualmente iniciada. Se debe declarar bajo esta línea.
        public Person loggedPerson = null;
        public Boolean hayIncidente = false;
        public String descIncidente = "";
        public EcoScooterService(IDAL dal)
        {
            this.dal = dal;
            try
            {
                ecoScooter = dal.GetAll<EcoScooter.Entities.EcoScooter>().First();
            }
            catch (InvalidOperationException)
            {
                ecoScooter = new Entities.EcoScooter();
                UpdateEcoScooterData(10, 15, 30); //15 en lugar de 0.015 para una simulación más conveniente.
                dal.Insert<EcoScooter.Entities.EcoScooter>(ecoScooter);
                saveChanges();
            }
        }

        /// <summary>
        /// Updates fare, discount and maxspeed of the system 
        /// </summary>
        /// <param name="discountYounger"></param>
        /// <param name="fare"></param>
        /// <param name="maxSpeed"></param>
        public void UpdateEcoScooterData(double discountYounger, double fare, double maxSpeed)
        {
            ecoScooter.DiscountYounger = discountYounger;
            ecoScooter.Fare = fare;
            ecoScooter.MaxSpeed = maxSpeed;
        }
        public void removeAllData()
        {
            dal.Clear<Entities.EcoScooter>();
            dal.Clear<Employee>();
            dal.Clear<Maintenance>();
            dal.Clear<Incident>();
            dal.Clear<Person>();
            dal.Clear<PlanningWork>();
            dal.Clear<Rental>();
            dal.Clear<Scooter>();
            dal.Clear<Station>();
            dal.Clear<TrackPoint>();
            dal.Clear<User>();
            saveChanges();
        }

        public void RegisterUser(DateTime birthDate, string dni, string email, string name, int telephon, int cvv, DateTime expirationDate, string login, int number, string password)
        {
            if (ecoScooter.IsUnder16(birthDate))
            {
                throw new ServiceException("L'usuari no pot tindre menys de 16 anys.");
            }
            else if (!ecoScooter.IsAValidCreditCard(number, cvv, expirationDate))
            {
                throw new ServiceException("Targeta de crèdit no vàlida.");
            }
            else if (ecoScooter.IsLoginInUse(login))
            {
                throw new ServiceException("Ja hi ha algú utilitzant aquest login.");
            }
            else if (ecoScooter.IsDniInUse(dni))
            {
                throw new ServiceException("Ja hi ha algú utilitzant aquest dni.");
            }
            else if (!ecoScooter.NomICognom(name))
            {
                throw new ServiceException("Ha de possar el nom i com a mínim un cognom.");
            }
            else if (!ecoScooter.TelefonCorrecte(telephon))
            {
                throw new ServiceException("El número de telèfon ha de tindre 9 nombres.");
            }
            else if (!ecoScooter.CorreuCorrecte(email))
            {
                throw new ServiceException("Comprova si el correu té el format exemple@servei.extensió");
            }
            else
            {
                dal.Insert<User>(ecoScooter.NewUser(birthDate, dni, email, name, telephon, cvv, expirationDate, login, number, password));
                saveChanges();
            }
        }

        public void RegisterEmployee(DateTime birthDate, String dni, String email, String name, int telephon, String iban, int pin, String position, Decimal salary)
        {
            if (ecoScooter.IsUnder16(birthDate))
            {
                throw new ServiceException("L'empleat no pot tindre menys de 16 anys.");
            }
            else if (ecoScooter.IsDniInUse(dni))
            {
                throw new ServiceException("Ja hi ha algú utilitzant aquest dni.");
            }
            else if (!ecoScooter.NomICognom(name))
            {
                throw new ServiceException("Ha de possar el nom i com a mínim un cognom.");
            }
            else if (!ecoScooter.TelefonCorrecte(telephon))
            {
                throw new ServiceException("El número de telèfon ha de tindre 9 nombres.");
            }
            else if (!ecoScooter.CorreuCorrecte(email))
            {
                throw new ServiceException("Comprova si el correu té el format exemple@servei.extensió");
            }
            else
            {
                dal.Insert<Employee>(ecoScooter.NewEmployee(birthDate, dni, email, name, telephon, iban, pin, position, salary));
                saveChanges();
            }
        }

        public bool isLoggedAsEmployee(string dni)
        {
            return ecoScooter.FindEmployeeByDni(dni) != null;
        }

        public bool isLoggedAsEmployeeByLogin(string name)
        {
            return ecoScooter.FindEmployeeByDni(name) != null;
        }

        public bool isLoggedAsUser(string dni)
        {
            return ecoScooter.FindUserByDni(dni) != null;
        }

        public bool isLoggedAsUserByLogin(string name)
        {
            return ecoScooter.FindUserByLogin(name) != null;
        }

        public void ExitUser() {            
            loggedPerson = null;
        }

        public ICollection<Station> getStationList(){
            return ecoScooter.Stations;
        }

        public void LoginEmployee(string dni, int pin)
        {
            if (loggedPerson != null)
            { throw new ServiceException("Ja hi ha algú conectat."); }
            else
            {
                Employee e = ecoScooter.FindEmployeeByDni(dni);

                if (e != null && e.VerifyPin(pin))
                {
                    loggedPerson = e;
                }
                else
                {
                    throw new ServiceException("Dni o pin incorrecte.");
                }
            }
        }

        public void LoginUser(string login, string password)
        {
            if (loggedPerson != null)
            { throw new ServiceException("Ja hi ha algú conectat."); }
            else
            {
                User u = ecoScooter.FindUserByLogin(login);

                if (u != null && u.VerifyPassword(password))
                {
                    loggedPerson = u;
                }
                else
                {
                    throw new ServiceException("Usuari o contrassenya incorrecte/a.");
                }
            }
        }

        public void RegisterIncident(string description, DateTime timeStamp, int rentalId)
        {
            //Si l'usuari no està logejat error
            if (loggedPerson == null)
            {
                throw new ServiceException("No pots registrar un nou incident si no estàs conectat.");
            }
            else
            {
                //si l'empleat proporciona informació incorrecta
                if (description == null || timeStamp == null)
                { //podriem ficar una restrinció per a dates anteriors.
                    throw new ServiceException("Hi han arguments d'entrada incorrectes.");
                }
                else
                {
                    Rental r = ecoScooter.FindRentalById(rentalId);

                    if (r == null)
                    {
                        throw new ServiceException("El lloger " + rentalId + " no existeix.");
                    }
                    else
                    {
                        dal.Insert<Incident>(ecoScooter.NewIncident(description, timeStamp, r));
                        saveChanges();
                    }
                }
            }
        }

        public void RegisterScooter(DateTime registerDate, ScooterState state, String stationId)
        {
            //Si l'usuari no està logejat error
            if (loggedPerson == null)
            {
                throw new ServiceException("No pots registrar un nou scooter si no estàs conectat.");
            }
            else
            {
                //si l'empleat proporciona informació incorrecta
                if (ecoScooter.IsFutureDate(registerDate))
                { //podriem ficar una restrinció per a dates anteriors.
                    throw new ServiceException("Arguments d'entrada incorrectes.");
                }
                else {
                    dal.Insert<Scooter>(ecoScooter.NewScooter(registerDate, state, stationId));
                    saveChanges();
                }
            }
        }

        public void RentScooter(string stationId)
        {
            //Si l'usuari no està logejat error
            if (loggedPerson == null)
            {
                throw new ServiceException("No pots llogar un scooter si no estàs conectat.");
            }
            else {

                Station station = ecoScooter.FindStationById(stationId);
                if (station == null)
                {
                    throw new ServiceException("L'estació no existeix.");
                }
                else {
                    Scooter scooter = station.GetAvaliableScooter();

                    if (scooter == null)
                    {
                        throw new ServiceException("No hi ha cap scooter disponible en eixa estació.");
                    }
                    else
                    {
                        dal.Insert<Rental>(ecoScooter.RentScooter(scooter, station, (User) loggedPerson));
                        saveChanges();
                    }
                }
            }
            
        }

        public void ReturnScooter(string stationId)
        {
            if (loggedPerson == null)
            {
                throw new ServiceException("No pots registrar un lloger si no estàs conectat.");
            }
            else
            {
                Station station = ecoScooter.FindStationById(stationId);
                if (station == null)
                {
                    throw new ServiceException("L'estació no existeix.");
                }
                else
                {
                    Rental rental = ((User)loggedPerson).GetLastRental();
                    if (rental.WasReturned())
                    {
                        throw new ServiceException("Ja ha sigut retornat.");
                    }
                    else
                    {                        
                        if (hayIncidente)
                        {
                            RegisterIncident(descIncidente, DateTime.Now, rental.Id);
                        }

                        Scooter scooter = rental.Scooter;
                        scooter.Station = station;

                        station.Scooters.Add(scooter);
                        rental.Finish(station, ecoScooter.Fare, ecoScooter.DiscountYounger);
                        

                        saveChanges();
                    }
                }
            }
        }

        public void saveChanges()
        {
            dal.Commit();
        }

        public void RegisterStation(string address, double latitude, double longitude, string stationId)
        {
            //Si l'usuari no està logejat error
            if (loggedPerson == null)
            {
                throw new ServiceException("No pots registrar una nova estació si no estàs conectat.");
            }
            else
            {
                //si l'empleat proporciona informació incorrecta
                if (address == "" || stationId == "")
                {
                    throw new ServiceException("Arguments d'entrada incorrectes.");
                }
                else if (!ecoScooter.IsLatitudeCorrect(latitude))
                {
                    throw new ServiceException("La latitud ha de estar en [-90, 90].");
                }
                else if (!ecoScooter.IsLongitudeCorrect(longitude))
                {
                    throw new ServiceException("La longitud ha de estar en [-180, 180].");
                }
                //si l'empleat proporciona una estació que ja existeix
                else if (ecoScooter.FindStationById(stationId) != null)
                {
                    throw new ServiceException("L'estació ja està registrada.");
                }
                //creem la nova estació
                else
                {
                    dal.Insert<Station>(ecoScooter.NewStation(address, latitude, longitude, stationId));
                    saveChanges();
                }
            }
        }

        public ICollection<string> GetUserRoutes(DateTime startDate, DateTime endDate)
        {
            List<string> routes = new List<string>();

            foreach (string rentalId in GetUserRoutesIds(startDate, endDate))
            {
                DateTime sd, ed;
                decimal p;
                string osi, dsi;
                GetRouteDescription(Convert.ToInt32(rentalId), out sd, out ed, out p, out osi, out dsi);

                routes.Add(sd.Day.ToString() + "/" + sd.Month.ToString() + "/" + sd.Year.ToString() + " " + sd.Hour.ToString() + ":" + sd.Minute.ToString() + ":" + sd.Second.ToString() 
                        + ", " + ed.Day.ToString() + "/" + ed.Month.ToString() + "/" + ed.Year.ToString() + " " + ed.Hour.ToString() + ":" + ed.Minute.ToString() + ":" + ed.Second.ToString()
                        + ", " + Decimal.Round(p, 2) + ", " + osi + ", " + dsi);
            }

            return routes;
        }

        public ICollection<string> GetUserRoutesIds(DateTime startDate, DateTime endDate)
        {
            if (loggedPerson == null)
            {
                throw new ServiceException("No pots rebre les rutes si no estàs conectat.");
            }
            else if (ecoScooter.AreCorrectDates(startDate, endDate))
            {
                throw new ServiceException("La data d'inici ha de ser anterior a la data de fi.");
            }
            else
            {
                List<string> ids = new List<string>();

                foreach (Rental r in ecoScooter.GetAllRentals())
                {
                    if (r.WasReturned() && r.IsInInterval(startDate, endDate) && r.User.Equals(loggedPerson))
                    {
                        ids.Add(r.Id.ToString());
                    }
                }

                if (ids.Count() == 0) { throw new ServiceException("No hi han llogers en l'interval seleccionat."); }
                else { return ids; }
            }
        }

        public void GetRouteDescription(int rentalId, out DateTime startDate, out DateTime endDate, out decimal price, out String originStationId, out String destinationStationId)
        {
            if (loggedPerson == null)
            {
                throw new ServiceException("No pots rebre les descripcions de les rutes si no estàs conectat.");
            }
            else
            {
                Rental r = ecoScooter.FindRentalById(rentalId);

                startDate = r.StartDate;
                endDate = r.EndDate.Value;
                price = r.Price;
                originStationId = r.OriginStation.Id;
                destinationStationId = r.DestinationStation.Id;
            }
        }

        public User FindUserByLogin(string text)
        {
            throw new NotImplementedException();
        }
    }
}