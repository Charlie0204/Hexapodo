using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;
using System.Threading;

namespace _0409
{
    public class Leg
    {
        int positionS1;
        int positionS2;
        int positionS3;
        string speed = "1000";
        string time = "200";
        string instruccionF;
        string numM1;
        string numM2;
        string numM3;


        public Leg(string v1, string v2, string v3)
        {
            this.numM1 = v1;
            this.numM2 = v2;
            this.numM3 = v3;
        }

        public int PositionS1 { get => positionS1; set => positionS1 = value; }
        public int PositionS2 { get => positionS2; set => positionS2 = value; }
        public int PositionS3 { get => positionS3; set => positionS3 = value; }
        public string Speed { get => speed; set => speed = value; }
        public string Time { get => time; set => time = value; }
        public string NumM1 { get => numM1; set => numM1 = value; }
        public string NumM2 { get => numM2; set => numM2 = value; }
        public string NumM3 { get => numM3; set => numM3 = value; }

        public void calibrateHex(SerialPort sp)
        {
            sp.Write($"#{this.numM1}P1500S750\r");
            Thread.Sleep(200);
            sp.Write($"#{this.numM2}P1500S750\r");
            Thread.Sleep(200);
            sp.Write($"#{this.numM3}P1500S750\r");
            Thread.Sleep(200);
        }

        public string moveS()
        {
            instruccionF = "";
            int pos2 = positionS2;
            int pos3 = positionS3;
            if(numM1 == "10" || numM1 == "6" || numM1 == "2")
            {
                if(positionS2 != 0)
                pos2 = Math.Abs(positionS2 - 3000);
                if(positionS3 !=0)
                pos3 = Math.Abs(positionS3 - 3000);

            }


            if (this.positionS1 > 0)
            {
                instruccionF += "#"+numM1 + "P"+1500.ToString();
            }
            if (this.positionS2 >0 )
            {
                instruccionF += "#"+numM2 + "P"+pos2.ToString();
            }
            if (this.positionS3 > 0)
            {
                instruccionF += "#"+numM3 + "P"+pos3.ToString();
            }

            if (instruccionF != "")
            {
                instruccionF += "S"+speed + "T"+time + "\r";
                return (instruccionF);
            }
            else
            {
                return "";
            }
        }
    }
}
