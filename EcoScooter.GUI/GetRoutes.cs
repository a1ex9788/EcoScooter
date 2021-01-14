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
    public partial class GetRoutes : EcoScooterFormBase
    {
        public GetRoutes(IEcoScooterService serv) : base(serv)
        {
            InitializeComponent();
            
        }

        private void ObtindreRutes(object sender, EventArgs e)
        {

            try
            {
                //exemple cutre
                //dataGridViewRutes.Rows.Add(1, 2, 3, 4, 5);

                string[] aux = new string[6];
                List<String> routes = Service.GetUserRoutes(dateTimePicker1.Value, dateTimePicker2.Value).ToList();
                

                foreach (string var in routes)
                {
                    aux = var.Split(',');
                    dataGridViewRutes.Rows.Add(aux[0], aux[1], aux[2] + "," + aux[3] + " €", aux[4], aux[5]);
                }

                button1.Enabled = false;

            }
            catch (ServiceException ex)
            {
                labelError.Text = ex.Message;
                labelError.Visible = true;
            }

        }









        //METOEDS INUTILS

        private void labelCognoms_Click(object sender, EventArgs e)
        {

        }

        private void bottoEnable(object sender, EventArgs e)
        {
            dataGridViewRutes.Rows.Clear();
            button1.Enabled = true;
        }
    }
}
