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
    public partial class UserPanel : EcoScooterFormBase
    {
        public UserPanel(IEcoScooterService serv) : base(serv)
        {
            InitializeComponent();

            labelWelcome.Text = "Benvingut/da " + ((EcoScooterService) Service).loggedPerson.Name.Split(' ')[0];

            RentVSReturn();
        }

        public void RentVSReturn() {
            if (((User)((EcoScooterService)Service).loggedPerson).HasActiveRental())
            {
                pictureTorna.Visible = true;
                pictureRent.Visible = false;
            }
            else
            {
                pictureTorna.Visible = false;
                pictureRent.Visible = true;
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void UserPanel_Load(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

       /* private void pictureRent(object sender, EventArgs e)
        {
            Form rentForm = new RentScooter();
            rentForm.ShowDialog();
        }


        private void pictureTorna(object sender, EventArgs e)
        {
            //Activar la tornada del patinet
            //Donara visibilitat al boto de tornar patinet

        }

    */
       

                   
        private void Exit(object sender, EventArgs e)
        {
            Service.ExitUser();

            (new EcoScooterApp(Service)).Show();

            this.Dispose();
        }

       
        private void rentScooter(object sender, EventArgs e)
        {
            EcoScooterFormBase llogaForm = new RentScooter(Service, this);
            llogaForm.ShowDialog();
        }

        private void tornaPatinet(object sender, EventArgs e)
        {
            EcoScooterFormBase tornaForm = new ReturnScooter(Service, this);
            tornaForm.ShowDialog();
        }

        private void retornaRecorreguts(object sender, EventArgs e)
        {
            EcoScooterFormBase recoForm = new GetRoutes(Service);
            recoForm.ShowDialog();
        }
    }
}
