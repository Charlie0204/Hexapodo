using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _0409
{
    public partial class w3 : Form
    {
        public w3()
        {
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
    }
}
