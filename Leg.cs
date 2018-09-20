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
        string positionS1;
        string positionS2;
        string positionS3;
        string speed;
        string time;
        string instruccionF;
        string numM1;
        string numM2;
        string numM3;

        public Leg(string numM1 = "", string numM2 = "", string numM3 = "", string positionS1 = "", string positionS2 = "", string positionS3 = "", string speed = "", string time = "")
        {

        }

        public string PositionS1 { get => positionS1; set => positionS1 = value; }
        public string PositionS2 { get => positionS2; set => positionS2 = value; }
        public string PositionS3 { get => positionS3; set => positionS3 = value; }
        public string Speed { get => speed; set => speed = value; }
        public string Time { get => time; set => time = value; }
        public string NumM1 { get => numM1; set => numM1 = value; }
        public string NumM2 { get => numM2; set => numM2 = value; }
        public string NumM3 { get => numM3; set => numM3 = value; }


        public string moveS()
        {
            return concatenatedStr();
        }

        public void calibrateHex(SerialPort sp)
        {
            sp.Write($"#{this.numM1}P1500S750\r");
            Thread.Sleep(200);
            sp.Write($"#{this.numM2}P1500S750\r");
            Thread.Sleep(200);
            sp.Write($"#{this.numM3}P1500S750\r");
            Thread.Sleep(200);
        }

        private string concatenatedStr()
        {
            instruccionF = "";

            if (this.positionS1 != "")
            {
                instruccionF += "#"+numM1 + "P"+positionS1;
            }
            if (this.positionS2 != "")
            {
                instruccionF += "#"+numM2 + "P"+positionS2;
            }
            if (this.positionS3 != "")
            {
                instruccionF += "#"+numM3 + "P"+positionS3;
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
