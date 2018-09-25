using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;

namespace _0409
{

    public partial class w3 : Form
    {
        SerialPort puerto;
        public w3(SerialPort sp)
        {
            puerto = sp;
            InitializeComponent();
        }

        private void pbxGoInfo_Click(object sender, EventArgs e)
        {
            Form2 windowData = new Form2();
            windowData.Show();
        }

        private void pbxGoHome_Click(object sender, EventArgs e)
        {
            this.Hide();
            w1 windowHome = new w1();
            windowHome.Show();
        }

        private void btnWalk_Click(object sender, EventArgs e)
        {

        }


        private void caminar(string apertura, string giro, List<Leg>listaPiernas1, List<Leg> listaPiernas2)
        {
            step(listaPiernas1, apertura);
            step(listaPiernas2, apertura);
        }

        private void returnToNormal(List<Leg> listaPiernas)
        {
            foreach(Leg pierna in listaPiernas)
            {
                pierna.PositionS2 = "1500";
                puerto.Write(pierna.moveS());

                pierna.PositionS3 = "1500";
                puerto.Write(pierna.moveS());
            }
        }
        private void step(List<Leg> listaPiernas, string apertura)
        {
            foreach (Leg pierna in listaPiernas)
            {
                pierna.PositionS2 = apertura;
                puerto.Write(pierna.moveS());
            }
            foreach (Leg pierna in listaPiernas)
            {
                pierna.PositionS3 = apertura;
                puerto.Write(pierna.moveS());
            }
            returnToNormal(listaPiernas);
        }
    }
}
