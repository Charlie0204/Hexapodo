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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void lbxData_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        public void SetTextForLabel(string text)
        {
            this.lbxData.Items.Add(text);
        }
    }
}
