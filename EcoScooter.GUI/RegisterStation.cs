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
    public partial class RegisterStation : EcoScooterFormBase
    {
        public RegisterStation(IEcoScooterService serv) : base(serv)
        {
            InitializeComponent();

            labelError.Visible = false;
        }

        private void ControlNumero(object sender, KeyPressEventArgs e)
        {
            if (textBoxNumero.TextLength < 4)
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

        private void Registrar(object sender, EventArgs e)
        {
            if (textBoxCarrer.Text.Equals("") || textBoxNumero.Text.Equals("") || textBoxCiutat.Text.Equals("")
                || textBoxLatitud.Text.Equals("") || textBoxLongitud.Text.Equals("") || textBoxID.Text.Equals("")) {
                labelError.Text = "Falten camps per omplir.";
                labelError.Visible = true;
            } else {
                try
                {
                    Service.RegisterStation(textBoxCarrer.Text + " " + textBoxNumero.Text + " " + textBoxCiutat, Convert.ToDouble(textBoxLatitud.Text), Convert.ToDouble(textBoxLongitud.Text), textBoxID.Text);
                    DialogResult answer = MessageBox.Show(this,
                            "Estació registrada correctament.",
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

        private void ControlLatLong(object sender, KeyPressEventArgs e)
        {
            if (((TextBox) sender).TextLength < 3)
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
