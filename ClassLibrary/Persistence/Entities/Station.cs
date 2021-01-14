﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace EcoScooter.Entities
{
    public partial class Station
    {
        public String Address 
        {
            get;
            set;
        }
        [Key]
        public String Id
        {
            get;
            set;
        }
        public double Latitude
        {
            get;
            set;
        }
        public double Longitude
        {
            get;
            set;
        }
        /*Relaciones*/
        public virtual ICollection<Rental> DestinationRentals
        {
            get;
            set;
        }
        public EcoScooter EcoScooter
        {
            get;
            set;
        }
        public virtual ICollection<Rental> OriginRentals
        {
            get;
            set;
        }
        public virtual ICollection<Scooter> Scooters
        {
            get;
            set;
        }
        
        
    }
}
