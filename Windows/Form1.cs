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
        
        public w1()
        {
            InitializeComponent();
        }

        private void btnPaws_Click(object sender, EventArgs e)
        {
            this.Hide();
            w2 windowPaws = new w2(sp);
            windowPaws.Owner = this;
            windowPaws.Show();

         }

        private void btnHexapod_Click(object sender, EventArgs e)
        {
            this.Hide();
            w3 windowMoves = new w3();
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
