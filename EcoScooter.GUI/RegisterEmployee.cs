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
    public partial class RegisterEmployee : EcoScooterFormBase
    {
        public RegisterEmployee(IEcoScooterService serv) : base(serv)
        {
            InitializeComponent();
        }


        private void RegistrarEmployee(object sender, EventArgs e)
        {
            if (textBoxNom.Text.Equals("") || textBoxDNI.Text.Equals("") || textBoxTelefon.Text.Equals("")
                || dateTimePickerDataDeNaixement.Text.Equals("") || textBoxCorreu.Text.Equals("")
                || textBoxPIN.Text.Equals("") || textBoxRepeteixPIN.Text.Equals("")
                || textBoxPosicio.Text.Equals("") || textBoxSalari.Text.Equals("")
                || textBoxIBAN.Text.Equals(""))
            {
                labelErrorRegister.Text = "Falten camps per omplir.";
                labelErrorRegister.Visible = true;
            } else
            {
                if (!textBoxPIN.Text.Equals(textBoxRepeteixPIN.Text))
                {
                    labelErrorRegister.Text = "El segon PIN no correspon amb el primer.";
                    labelErrorRegister.Visible = true;
                }
                else
                {
                    try
                    {
                        Service.RegisterEmployee(dateTimePickerDataDeNaixement.Value, textBoxDNI.Text, textBoxCorreu.Text, textBoxNom.Text, int.Parse(textBoxTelefon.Text), textBoxIBAN.Text,
                             int.Parse(textBoxPIN.Text), textBoxPosicio.Text, decimal.Parse(textBoxSalari.Text));

                        DialogResult answer = MessageBox.Show(this,
                            "Empleat registrat correctament.",
                            "Registrament",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                        if (answer == DialogResult.OK) { Exit(sender, null); this.Close(); }
                    }
                    catch (ServiceException ex)
                    {
                        labelErrorRegister.Text = ex.Message;
                        labelErrorRegister.Visible = true;
                    }

                }
            }            
        }



        private void ControlTelephone(object sender, KeyPressEventArgs e)
        {
            if (textBoxTelefon.TextLength < 9)
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


        private void ControlNoNumbers(object sender, KeyPressEventArgs e)
        {
            if (Char.IsLetter(e.KeyChar) || Char.IsControl(e.KeyChar) || Char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }


        private void ControlIBAN(object sender, KeyPressEventArgs e)
        {
            if (textBoxIBAN.TextLength < 8)
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
























        //METODES INUTILS
        private void Exit(object sender, FormClosedEventArgs e)
        {
            (new EcoScooterApp(Service)).Show();

            Dispose();
        }

        private void labelNomUsuari_Click(object sender, EventArgs e)
        {

        }

        private void textBoxNomUsuari_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void ControlSalari(object sender, KeyPressEventArgs e)
        {
            if (textBoxSalari.TextLength < 8)
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
