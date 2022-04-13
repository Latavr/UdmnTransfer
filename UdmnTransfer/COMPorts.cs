using System.IO.Ports;

namespace UdmnTransfer
{
    public class COMPorts
    {
        
        public SerialPort port = default!;
        //public delegate void TransferDelegate();
        //public TransferDelegate transferPortsDelegate = default!;

        public void Property(string portName)
        {
            port.PortName = portName;
            port.BaudRate = 9600;
            port.Parity = Parity.None;
            port.DataBits = 8;
            port.StopBits = StopBits.One;
            port.WriteTimeout = 10;
            port.ReadTimeout = 10;
        }
    }
}
