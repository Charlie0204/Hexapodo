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
using System.Threading;

namespace _0409
{

    public partial class w3 : Form
    {
        SerialPort sp;
        List<Leg> legs = new List<Leg>();


        public w3(SerialPort sp, List<Leg> legs)
        {
            this.legs = legs;
            this.sp = sp;
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
            this.Owner.Show();
        }

        private void btnWalk_Click(object sender, EventArgs e)
        {
            caminar("1900");
        }


        private void caminar(string apertura)
        {
            step(apertura);
        }

        private void step(string apertura)
        {
            List<Leg> even = new List<Leg> { legs[0], legs[2], legs[4] };
            List<Leg> odd = new List<Leg> { legs[1], legs[3], legs[5] };

            raiseLeg(even);
            moveLeg(even, 1850);
            Thread.Sleep(300);
            lowerLeg(even);
            Thread.Sleep(300);
            raiseLeg(odd);
            moveLeg(even, 1600);
            Thread.Sleep(300);
            moveLeg(odd, 1850);
            lowerLeg(odd);
            Thread.Sleep(300);
            raiseLeg(even);
            Thread.Sleep(100);
            moveLeg(odd, 1600);
            Thread.Sleep(300);
        }

        private void raiseLeg(List<Leg> leglist)
        {
            foreach (Leg leg in leglist)
            {
                leg.PositionS2 = 1800;
                sp.Write(leg.moveS());

            }
        }

        private void lowerLeg(List<Leg> leglist)
        {
            foreach (Leg leg in leglist)
            {
                leg.PositionS2 = 1500;
                sp.Write(leg.moveS());

            }
        }

        private void moveLeg(List<Leg> leglist, int pos)
        {
            foreach(Leg leg in leglist)
            {
                leg.PositionS3 = pos;
                sp.Write(leg.moveS());
            }
        }

        private void w3_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Owner.Show();
        }
    }
}