using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EcoScooter.Services;

namespace EcoScooter.GUI
{
    public partial class EcoScooterFormBase : Form
    {
        protected IEcoScooterService Service;
        public EcoScooterFormBase()
        {
            InitializeComponent();
        }

        public EcoScooterFormBase(IEcoScooterService serv) : this() {
            Service = serv;
        }
    }
}
