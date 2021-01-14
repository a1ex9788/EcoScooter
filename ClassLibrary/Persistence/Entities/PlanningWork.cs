using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace EcoScooter.Entities
{
    public partial class PlanningWork
    {
        [Key]
        public int Id
        {
            get;
            set;
        }
        public String Description
        {
            get;
            set;
        }
        public int WorkingTime
        {
            get;
            set;
        }

        /*Relaciones*/
        public virtual Maintenance Maintenance
        {
            get;
            set;
        }
        public virtual Scooter Scooter
        { 
            get;
            set;
        }
    }
}
