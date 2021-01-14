using EcoScooter.Services;
using System;
using System.Collections;
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
    public partial class RentScooter : EcoScooterFormBase
    {
        UserPanel father;

        public RentScooter(IEcoScooterService serv, UserPanel f) : base(serv)
        {
            father = f;

            InitializeComponent();
            List<EcoScooter.Entities.Station> stations = Service.getStationList().ToList();

            /* ERA PER PROVAR SI AFEGIA BE LES IDS
            EcoScooter.Entities.Station prova = new Entities.Station("hola", "124", 123, 42);
            comboBoxIDStation.Items.Add(prova.Id);
            */

            foreach (EcoScooter.Entities.Station var in stations)
            {
                if (var.HasScooters()) { comboBoxIDStation.Items.Add(var.Id); }
            }

            if (stations.Count == 0)
            {
                labelErrorRent.Text = "No hi ha estacions.";
                labelErrorRent.Visible = true;
            }
            else {
                labelErrorRent.Visible = false;
            }

            if (comboBoxIDStation.Items.Count == 0) {
                labelErrorRent.Text = "No hi ha cap estació amb scooters.";
                labelErrorRent.Visible = true;
            }
        }

        

        private void llogaPatinet(object sender, EventArgs e)
        {
            if (comboBoxIDStation.Text == "")
            {
                labelErrorRent.Text = "Falten camps per omplir.";
                labelErrorRent.Visible = true;
            }
            else {
                try
                {
                    Service.RentScooter(comboBoxIDStation.Text);
                    //modifica aspectes visuals
                    father.RentVSReturn();
                    //////////////////////////
                    DialogResult answer = MessageBox.Show(this,
                                "Scooter llogat correctament.",
                                "Lloguer",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);

                    Exit(sender, null); this.Close();
                }
                catch (ServiceException ex)
                {
                    labelErrorRent.Text = ex.Message;
                    labelErrorRent.Visible = true;
                }
            }            
        }

        private void Exit(object sender, FormClosedEventArgs e)
        {
            Dispose();
        }
    }
}
