using EcoScooter.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EcoScooter.GUI
{
    public partial class EmployeePanel : EcoScooterFormBase
    {
        public EmployeePanel(IEcoScooterService serv) : base(serv)
        {
            InitializeComponent();

            labelWelcome.Text = "Benvingut/da " + ((EcoScooterService)Service).loggedPerson.Name.Split(' ')[0];
        }

        private void pictureAddStation(object sender, EventArgs e)
        {
            EcoScooterFormBase regStat = new RegisterStation(Service);
            regStat.ShowDialog();
        }

        private void pictureAddScooter(object sender, EventArgs e)
        {
            EcoScooterFormBase regScooter = new RegisterScooter(Service);
            regScooter.ShowDialog();
        }

        private void pictureLogout_Click(object sender, EventArgs e)
        {
            Exit(sender, null);
        }

        private void Exit(object sender, FormClosedEventArgs e)
        {
            Service.ExitUser();

            (new EcoScooterApp(Service)).Show();

            this.Dispose();
        }
    }
}
