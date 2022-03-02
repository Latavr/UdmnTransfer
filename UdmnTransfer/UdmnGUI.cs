using System.IO.Ports;

namespace UdmnTransfer
{
    public partial class Udmn : Form
    {
        public Udmn()
        {
            InitializeComponent();
        }
        private void CheckCOMPort_Click(object sender, EventArgs e)
        {
            string[] ports = SerialPort.GetPortNames();

            ListCOMPorts.Items.Clear();
            for(int i = 0; i < ports.Length; i++)
            {
                ListCOMPorts.Items.Add(ports[i].ToString());
            }
            ListCOMPorts.SelectedIndex = 0;
        }
    }
}