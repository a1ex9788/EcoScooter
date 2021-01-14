using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace EcoScooter.Entities
{
    public partial class Scooter
    {
        [Key]
        public int Id
        {
            get;
            set;
        }

        public DateTime RegisterDate
        {
            get;
            set;
        }

        public ScooterState State 
        {
            get;
            set;
        }
        /*Relaciones*/
        public virtual ICollection<PlanningWork> PlanningWork //Hauria de ser PlanningWorks però sinò no pasa els tests
        {
            get;
            set;
        }
        public virtual Station Station
        {
            get;
            set;
        }
        public virtual ICollection<Rental> Rentals
        {
            get;
            set;
        }
        public virtual Maintenance Maintenance
        {
            get;
            set;
        }
    }
}
