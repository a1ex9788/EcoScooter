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
    public partial class RegisterIncident : EcoScooterFormBase
    {
        public RegisterIncident(IEcoScooterService serv) : base(serv)
        {
            InitializeComponent();

            labelError.Visible = false;
        }

        private void Registrar(object sender, EventArgs e)
        {
            if (textBoxHora.Text.Equals("") || textBoxMinuts.Text.Equals("")
                || textBoxDescripcio.Text.Equals(""))
            {
                labelError.Text = "Falten camps per omplir.";
                labelError.Visible = true;
            }
            else if (Convert.ToInt32(textBoxHora.Text) < 0 || Convert.ToInt32(textBoxHora.Text) > 24) {
                labelError.Text = "Hora incorrecta.";
                labelError.Visible = true;
            }
            else if (Convert.ToInt32(textBoxMinuts.Text) < 0 || Convert.ToInt32(textBoxMinuts.Text) > 60)
            {
                labelError.Text = "Minuts icorrectes.";
                labelError.Visible = true; ;
            }
            else
            {
                try
                {
                    Service.RegisterIncident(textBoxDescripcio.Text,
                        new DateTime(DateTime.Today.Year, DateTime.Today.Month, DateTime.Today.Day, Convert.ToInt32(textBoxHora.Text), Convert.ToInt32(textBoxMinuts.Text), 0),
                        ((User)((EcoScooterService)Service).loggedPerson).GetLastRental().Id);
                    DialogResult answer = MessageBox.Show(this,
                            "Incident registrat correctament.",
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

        private void Exit(object sender, FormClosedEventArgs e)
        {
            Dispose();
        }

        private void ControlMinHora(object sender, KeyPressEventArgs e)
        {
            if (((TextBox) sender).TextLength < 2)
            {
                if (Char.IsDigit(e.KeyChar) || Char.IsControl(e.KeyChar))
                {
                    e.Handled = false;
                }
                else
                {
                    e.Handled = true;
                }
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }
    }
}
