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
    public partial class w2 : Form
    {
        List<CheckBox> lista1 = new List<CheckBox>();
        List<CheckBox> lista2 = new List<CheckBox>();
        List<CheckBox> lista3 = new List<CheckBox>();
        List<CheckBox> lista4 = new List<CheckBox>();
        List<CheckBox> lista5 = new List<CheckBox>();
        List<CheckBox> lista6 = new List<CheckBox>();


        private SerialPort sp;
        private List<Leg> legs;
        public w2()
        {
            InitializeComponent();
            initTbar();
            cfgServos();
        }

        public w2(SerialPort sp, List<Leg> legs)
        {
            InitializeComponent();
            initTbar();
            cfgServos();
            this.sp = sp;
            this.legs = legs;
        }

        private void pbxHome_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Owner.Show();
        }

        private void pbxInfo_Click(object sender, EventArgs e)
        {
            Form2 windowData = new Form2();
            windowData.Show();
        }

        private void cbxServo1a_CheckedChanged(object sender, EventArgs e)
        {
            
        }
        public void initTbar()
        {
            tbr1Paw1.Value = 1500;
            tbr1Paw2.Value = 1500;
            tbr1Paw3.Value = 1500;
            tbr1Paw4.Value = 1500;
            tbr1Paw5.Value = 1500;
            tbr1Paw6.Value = 1500;
        }

        public bool isChecked(CheckBox checkbox)
        {
            return checkbox.CheckState == CheckState.Checked ? true : false;
        }

        public void cfgServos()
        {
            lista1.Add(cbxServo1a);
            lista1.Add(cbxServo1b);
            lista1.Add(cbxServo1c);
            lista2.Add(cbxServo2a);
            lista2.Add(cbxServo2b);
            lista2.Add(cbxServo2c);
            lista3.Add(cbxServo3a);
            lista3.Add(cbxServo3b);
            lista3.Add(cbxServo3c);
            lista4.Add(cbxServo4a);
            lista4.Add(cbxServo4b);
            lista4.Add(cbxServo4c);
            lista5.Add(cbxServo5a);
            lista5.Add(cbxServo5b);
            lista5.Add(cbxServo5c);
            lista6.Add(cbxServo6a);
            lista6.Add(cbxServo6b);
            lista6.Add(cbxServo6c);
        }

        private void tbr1Paw1_Scroll(object sender, EventArgs e)
        {
            int pwm = tbr1Paw1.Value;
            checkCBoxes(legs[0], lista1, pwm);
            legs[0].Speed = tbr2Paw1.Value.ToString();
            legs[0].Time = tbr3Paw1.Value.ToString();
            string command = legs[0].moveS();
            Console.WriteLine(command);
            sp.Write(command);
            Thread.Sleep(50);
        }

        private void tbr1Paw2_Scroll(object sender, EventArgs e)
        {
            int pwm = tbr1Paw2.Value;
            checkCBoxes(legs[1], lista2, pwm);
            legs[1].Speed = tbr2Paw2.Value.ToString();
            legs[1].Time = tbr3Paw2.Value.ToString();
            string command = legs[1].moveS();
            Console.WriteLine(command);
            sp.Write(command);
            Thread.Sleep(50);
        }

        private void tbr1Paw3_Scroll(object sender, EventArgs e)
        {
            int pwm = tbr1Paw3.Value;
            checkCBoxes(legs[2], lista3, pwm);
            legs[2].Speed = tbr2Paw3.Value.ToString();
            legs[2].Time = tbr3Paw3.Value.ToString();
            string command = legs[2].moveS();
            Console.WriteLine(command);
            sp.Write(command);
            Thread.Sleep(50);
        }

        private void tbr1Paw4_Scroll(object sender, EventArgs e)
        {
            int pwm = tbr1Paw4.Value;
            checkCBoxes(legs[3], lista4, pwm);
            legs[3].Speed = tbr2Paw4.Value.ToString();
            legs[3].Time = tbr3Paw4.Value.ToString();
            string command = legs[3].moveS();
            Console.WriteLine(command);
            sp.Write(command);
            Thread.Sleep(50);
        }

        private void tbr1Paw5_Scroll(object sender, EventArgs e)
        {
            int pwm = tbr1Paw5.Value;
            checkCBoxes(legs[4], lista5, pwm);
            legs[4].Speed = tbr2Paw5.Value.ToString();
            legs[4].Time = tbr3Paw5.Value.ToString();
            string command = legs[4].moveS();
            Console.WriteLine(command);
            sp.Write(command);
            Thread.Sleep(50);
        }

        private void tbr1Paw6_Scroll(object sender, EventArgs e)
        {
            int pwm = tbr1Paw6.Value;
            checkCBoxes(legs[5], lista6, pwm);
            legs[5].Speed = tbr2Paw6.Value.ToString();
            legs[5].Time = tbr3Paw6.Value.ToString();
            string command = legs[5].moveS();
            Console.WriteLine(command);
            sp.Write(command);
            Thread.Sleep(50);
        }

        public void checkCBoxes(Leg leg,List<CheckBox> Lista, int valorPWM)
        {
            int index;
            foreach (CheckBox cb in Lista)
            {
                index = Lista.IndexOf(cb);
                if (isChecked(cb))
                {
                    if (index == 0)
                    {
                        leg.PositionS1 = valorPWM;
                    }
                    else if (index == 1)
                    {
                        leg.PositionS2 = valorPWM;
                    }
                    else if (index == 2)
                    {
                        leg.PositionS3 = valorPWM;
                    }
                }
                else
                {
                    if (index == 0)
                    {
                        leg.PositionS1 = 0;
                    }
                    else if (index == 1)
                    {
                        leg.PositionS2 = 0;
                    }
                    else
                    {
                        leg.PositionS3 = 0;
                    }
                }
            }
        }

        private void Port_DataReceived(object sender, SerialDataReceivedEventArgs e, Form2 windowData)
        {
            string mensaje = sp.ReadExisting();
            Invoke(new MethodInvoker(delegate
            {
                windowData.SetTextForLabel(mensaje);
            }));
        }
        private void Calibrar()
        {
            foreach (Leg leg in legs)
            {
                leg.calibrateHex(sp);
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            Calibrar();
            initTbar();
        }

        private void w2_FormClosing(object sender, FormClosingEventArgs e)
        {
            Owner.Show();
        }
    }
}
