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
    public partial class ReturnScooter : EcoScooterFormBase
    {
        UserPanel father;

        public ReturnScooter(IEcoScooterService serv, UserPanel f) : base(serv)
        {
            father = f;

            InitializeComponent();

            List<EcoScooter.Entities.Station> stations = Service.getStationList().ToList();
            foreach (EcoScooter.Entities.Station var in stations)
            {
                comboBoxIDStation.Items.Add(var.Id);
            }

            if (stations.Count == 0)
            {
                labelErrorRent.Text = "No hi ha estacions.";
                labelErrorRent.Visible = true;
            }
            else
            {
                labelErrorRent.Visible = false;
            }
        }

        private void Exit(object sender, FormClosedEventArgs e)
        {
            Dispose();
        }

        private void TornaScooter(object sender, EventArgs e)
        {
            if (comboBoxIDStation.Text == "")
            {
                labelErrorRent.Text = "Falten camps per omplir.";
                labelErrorRent.Visible = true;
            }
            else
            {
                try
                {
                    Service.ReturnScooter(comboBoxIDStation.Text);
                    father.RentVSReturn();
                    DialogResult answer2 = MessageBox.Show(this,
                                "Ha ocorregut algun incident?.",
                                "Incident",
                                MessageBoxButtons.YesNo,
                                MessageBoxIcon.Question);

                    if (answer2 == DialogResult.Yes) {
                        RegisterIncident r = new RegisterIncident(Service);
                        r.ShowDialog();
                    }
                    else
                    {
                        DialogResult answer = MessageBox.Show(this,
                                "Scooter tornat correctament.",
                                "Devolució",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
                        Exit(sender, null); this.Close();
                    }

                    //Console.WriteLine(Service.getStationList().ToString());

                    Exit(sender, null); this.Close();
                }
                catch (ServiceException ex)
                {
                    Console.WriteLine(ex.Message);
                    labelErrorRent.Text = ex.Message;
                    labelErrorRent.Visible = true;
                }
            }
        }
    }
}
