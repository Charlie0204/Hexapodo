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

        Leg Pierna1 = new Leg();
        Leg Pierna2 = new Leg();
        Leg Pierna3 = new Leg();
        Leg Pierna4 = new Leg();
        Leg Pierna5 = new Leg();
        Leg Pierna6 = new Leg();

        private SerialPort sp;

        public w2()
        {
            InitializeComponent();
            initTbar();
            cfgServos();
        }

        public w2(SerialPort sp)
        {
            InitializeComponent();
            initTbar();
            cfgServos();
            this.sp = sp;
        }

        private void pbxHome_Click(object sender, EventArgs e)
        {
            this.Hide();
            w1 windowHome = new w1();
            windowHome.Show();
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

            Pierna1.NumM1 = "24";
            Pierna1.NumM2 = "25";
            Pierna1.NumM3 = "26";

            Pierna2.NumM1 = "20";
            Pierna2.NumM2 = "21";
            Pierna2.NumM3 = "22";

            Pierna3.NumM1 = "18";
            Pierna3.NumM2 = "17";
            Pierna3.NumM3 = "16";

            Pierna4.NumM1 = "0";
            Pierna4.NumM2 = "1";
            Pierna4.NumM3 = "2";

            Pierna5.NumM1 = "4";
            Pierna5.NumM2 = "5";
            Pierna5.NumM3 = "6";

            Pierna6.NumM1 = "8";
            Pierna6.NumM2 = "9";
            Pierna6.NumM3 = "10";
        }

        private void tbr1Paw1_Scroll(object sender, EventArgs e)
        {
            string pwm = tbr1Paw1.Value.ToString();
            checkCBoxes(Pierna1, lista1, pwm);
            Pierna1.Speed = tbr2Paw1.Value.ToString();
            Pierna1.Time = tbr3Paw1.Value.ToString();
            string command = Pierna1.moveS();
            Console.WriteLine(command);
            sp.Write(command);
            Thread.Sleep(50);
        }

        private void tbr1Paw2_Scroll(object sender, EventArgs e)
        {
            string pwm = tbr1Paw2.Value.ToString();
            checkCBoxes(Pierna2, lista2, pwm);
            Pierna2.Speed = tbr2Paw2.Value.ToString();
            Pierna2.Time = tbr3Paw2.Value.ToString();
            string command = Pierna2.moveS();
            Console.WriteLine(command);
            sp.Write(command);
            Thread.Sleep(50);
        }

        private void tbr1Paw3_Scroll(object sender, EventArgs e)
        {
            string pwm = tbr1Paw3.Value.ToString();
            checkCBoxes(Pierna3, lista3, pwm);
            Pierna3.Speed = tbr2Paw3.Value.ToString();
            Pierna3.Time = tbr3Paw3.Value.ToString();
            string command = Pierna3.moveS();
            Console.WriteLine(command);
            sp.Write(command);
            Thread.Sleep(50);
        }

        private void tbr1Paw4_Scroll(object sender, EventArgs e)
        {
            string pwm = tbr1Paw4.Value.ToString();
            checkCBoxes(Pierna4, lista4, pwm);
            Pierna4.Speed = tbr2Paw4.Value.ToString();
            Pierna4.Time = tbr3Paw4.Value.ToString();
            string command = Pierna4.moveS();
            Console.WriteLine(command);
            sp.Write(command);
            Thread.Sleep(50);
        }

        private void tbr1Paw5_Scroll(object sender, EventArgs e)
        {
            string pwm = tbr1Paw1.Value.ToString();
            checkCBoxes(Pierna5, lista5, pwm);
            Pierna5.Speed = tbr2Paw5.Value.ToString();
            Pierna5.Time = tbr3Paw5.Value.ToString();
            string command = Pierna5.moveS();
            Console.WriteLine(command);
            sp.Write(command);
            Thread.Sleep(50);
        }

        private void tbr1Paw6_Scroll(object sender, EventArgs e)
        {
            string pwm = tbr1Paw1.Value.ToString();
            checkCBoxes(Pierna6, lista6, pwm);
            Pierna6.Speed = tbr2Paw6.Value.ToString();
            Pierna6.Time = tbr3Paw6.Value.ToString();
            string command = Pierna6.moveS();
            Console.WriteLine(command);
            sp.Write(command);
            Thread.Sleep(50);
        }

        public void checkCBoxes(Leg leg,List<CheckBox> Lista, string valorPWM)
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
                        leg.PositionS1 = "";
                    }
                    else if (index == 1)
                    {
                        leg.PositionS2 = "";
                    }
                    else
                    {
                        leg.PositionS3 = "";
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
            Pierna1.calibrateHex(sp);
            Pierna2.calibrateHex(sp);
            Pierna3.calibrateHex(sp);
            Pierna4.calibrateHex(sp);
            Pierna5.calibrateHex(sp);
            Pierna6.calibrateHex(sp);
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
