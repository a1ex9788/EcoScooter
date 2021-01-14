using EcoScooter.Entities;
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
    public partial class RegisterScooter : EcoScooterFormBase
    {
        public RegisterScooter(IEcoScooterService serv) : base(serv)
        {
            InitializeComponent();

            List<EcoScooter.Entities.Station> stations = Service.getStationList().ToList();

            foreach (EcoScooter.Entities.Station var in stations)
            {
                comboBoxID.Items.Add(var.Id);
            }

            if (stations.Count == 0)
            {
                labelError.Text = "No hi ha estacions";
                labelError.Visible = true;
            }
            else
            {
                labelError.Visible = false;
            }
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void comboBoxLatitud_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void labelNom_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void labelCognoms_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Exit(object sender, FormClosedEventArgs e)
        {
            Dispose();
        }

        private void Registrar(object sender, EventArgs e)
        {
            if (dateTimePickerData.Text.Equals("") || comboBoxEstat.Text.Equals("")
                || comboBoxID.Text.Equals(""))
            {
                labelError.Text = "Falten camps per omplir.";
                labelError.Visible = true;
            }
            else
            {
                try
                {
                    Service.RegisterScooter(dateTimePickerData.Value,
                        comboBoxEstat.Text.Equals("Lliure") ? ScooterState.available : ScooterState.inMaintenance,
                        comboBoxID.Text);

                    DialogResult answer = MessageBox.Show(this,
                            "Scooter registrat correctament.",
                            "Registrament",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                    Exit(sender, null); this.Close();
                }
                catch (ServiceException ex)
                {
                    labelError.Text = ex.Message;
                    labelError.Visible = true;
                }
            }
        }
    }
}
