using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO.Ports;

namespace _0409
{

    public class Serie
    {
        SerialPort port;

        public void openPort()
        {
            port = new SerialPort("COM6", 9600, Parity.None, 8, StopBits.One);
            port.Open();
        }
        public void write(string instruction)
        {
            port.Write(instruction);
        }
        public void closePort()
        {
            port.Close();
        }
        public string readExisting()
        {
            return port.ReadExisting();
        }
        public void wait()
        {

        }
    }
}
