using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _0409
{
    public partial class w1 : Form
    {
        private SerialPort sp;
        List<Leg> legs = new List<Leg>();
        
        public w1()
        {
            InitializeComponent();
            legs.Add(new Leg("24", "25", "26"));
            legs.Add(new Leg("20", "21", "22"));
            legs.Add(new Leg("16", "17", "18"));
            legs.Add(new Leg("2", "1", "0"));
            legs.Add(new Leg("6", "5", "4"));
            legs.Add(new Leg("10", "9", "8"));
        }

        private void btnPaws_Click(object sender, EventArgs e)
        {
            this.Hide();
            w2 windowPaws = new w2(sp, legs);
            windowPaws.Owner = this;
            windowPaws.Show();

         }

        private void btnHexapod_Click(object sender, EventArgs e)
        {
            this.Hide();
            w3 windowMoves = new w3(sp, legs);
            windowMoves.Owner = this;
            windowMoves.Show();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void w1_Load(object sender, EventArgs e)
        {
            foreach (string s in System.IO.Ports.SerialPort.GetPortNames())
            {
                cbxPorts.Items.Add(s);
            }
            if (cbxPorts.Items.Count > 0)
                cbxPorts.SelectedIndex = 0;
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            sp = new SerialPort(cbxPorts.SelectedItem.ToString(), 9600, Parity.None, 8, StopBits.One);
            sp.Open();
        }

        private void w1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(sp != null && sp.IsOpen)
            sp.Close();
        }
    }
}
