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
    public partial class RegisterUser : EcoScooterFormBase
    {
        public RegisterUser(IEcoScooterService serv) : base(serv)
        {
            InitializeComponent();
        }

        private void RegistrarUser(object sender, EventArgs e)
        {
            if (textBoxNom.Text.Equals("") || textBoxDNI.Text.Equals("") || textBoxTelefon.Text.Equals("")
                || dateTimePickerDataDeNaixement.Text.Equals("") || textBoxCorreu.Text.Equals("")
                || textBoxNomUsuari.Text.Equals("") || textBoxContrasenya.Text.Equals("")
                || textBoxRepeteixContrasenya.Text.Equals("") || textBoxIBAN.Text.Equals("")
                || textBoxCVV.Text.Equals("") || comboBoxMesCaducitatTargeta.Text.Equals("Mes")
                || comboBoxAnyCaducitatTargeta.Text.Equals("Any"))
            {
                labelErrorRegister.Text = "Falten camps per omplir.";
                labelErrorRegister.Visible = true;
            }
            else
            {
                if (!textBoxContrasenya.Text.Equals(textBoxRepeteixContrasenya.Text)) 
                {
                    labelErrorRegister.Text = "La segona contrasenya no correspon amb la primera.";
                    labelErrorRegister.Visible = true;
                }
                else 
                {
                    try
                    {
                        DateTime unirData = new DateTime(int.Parse(comboBoxAnyCaducitatTargeta.Text), int.Parse(comboBoxMesCaducitatTargeta.Text), 1);

                        Service.RegisterUser(dateTimePickerDataDeNaixement.Value, textBoxDNI.Text, textBoxCorreu.Text, textBoxNom.Text, int.Parse(textBoxTelefon.Text), int.Parse(textBoxCVV.Text), unirData,
                           textBoxNomUsuari.Text, int.Parse(textBoxIBAN.Text), textBoxContrasenya.Text);

                        DialogResult answer = MessageBox.Show(this,
                            "Usuari registrat correctament.",
                            "Registrament",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                        //if (answer == DialogResult.OK) { Exit(sender, null); this.Close(); }
                        Exit(sender, null); this.Close(); //no fa falta el if

                        /*labelErrorRegister.Text = "Usuari registrat correctament";
                        labelErrorRegister.ForeColor = Color.Green;
                        labelErrorRegister.Visible = true;*/
                    }
                    catch (ServiceException ex)
                    {
                        labelErrorRegister.Text = ex.Message;
                        labelErrorRegister.Visible = true;
                    }
                }                
            }
        }

        private void comboBoxAnyCaducitatTargeta_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBoxIBAN_TextChanged(object sender, EventArgs e)
        {

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
            } else if (Char.IsControl(e.KeyChar)) {
                e.Handled = false;
            }
            else {
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

        private void ControlCVV(object sender, KeyPressEventArgs e)
        {
            if (textBoxCVV.TextLength < 3)
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

        private void Exit(object sender, FormClosedEventArgs e)
        {
            (new EcoScooterApp(Service)).Show();

            Dispose();
        }
    }

}

