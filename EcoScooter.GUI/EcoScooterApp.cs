using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EcoScooter.Entities;
using EcoScooter.Services;

namespace EcoScooter.GUI
{
    public partial class EcoScooterApp : EcoScooterFormBase
    {
        RegisterUser Registrarse;
        RegisterEmployee RegistrarEmployee;
        UserPanel LoginUser;
        EmployeePanel LoginEmployee;

        public EcoScooterApp(IEcoScooterService serv) : base(serv)
        {
            InitializeComponent();

            //Se oculta el mensaje de error al cargar la interfaz
            labelErrorLogin.Visible = false;
        }

        private void LogIn(object sender, EventArgs e)
        {
            if (textBoxUsuari.Text.Equals("admin") && textBoxContrassenya.Text.Equals("admin")) {
                RegistrarEmployee = new RegisterEmployee(Service);
                RegistrarEmployee.Show();

                Visible = false;
            } else {
                try
                {
                    if (Service.isLoggedAsUserByLogin(textBoxUsuari.Text))
                    {
                        Service.LoginUser(textBoxUsuari.Text, textBoxContrassenya.Text);
                        LoginUser = new UserPanel(Service);
                        LoginUser.Show();

                        Visible = false;
                    }
                    else if (Service.isLoggedAsEmployeeByLogin(textBoxUsuari.Text))
                    {
                        Service.LoginEmployee(textBoxUsuari.Text, int.Parse(textBoxContrassenya.Text));
                        LoginEmployee = new EmployeePanel(Service);
                        LoginEmployee.Show();

                        Visible = false;
                    }
                    else
                    {
                        labelErrorLogin.Visible = true;
                        labelErrorLogin.Text = "Usuari o contrassenya incorrecte/a";
                    }
                }
                catch (ServiceException ex)
                {
                    labelErrorLogin.Text = ex.Message;
                    labelErrorLogin.Visible = true;
                }
            }           
        }

        private void RegisterUser(object sender, EventArgs e)
        {
            Registrarse = new RegisterUser(Service);
            Registrarse.Show();

            Visible = false;
        }

        private void ControlEnter(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter)) { LogIn(sender, e); }
        }

        private void Exit(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }










        //MÈTODOS INÚTILS

        private void InicioToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }       

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void labelErrorLogin_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
