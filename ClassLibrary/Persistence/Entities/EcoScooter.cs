﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace EcoScooter.Entities
{
    public partial class EcoScooter
    {
        [Key]
        public int Id
        {
            get;
            set;
        }
        public double DiscountYounger
        {
            get;
            set;
        }
        public double Fare
        {
            get;
            set;
        }
        public double MaxSpeed
        {
            get;
            set;
        }
        /*Relaciones*/
        public virtual ICollection<Person> People
        {
            get;
            set;
        }

        public virtual ICollection<Employee> Employees
        {
            get;
            set;
        }
        public virtual ICollection<Scooter> Scooters
        {
            get;
            set;
        }
        public virtual ICollection<Station> Stations
        {
            get;
            set;
        }
    }
}
