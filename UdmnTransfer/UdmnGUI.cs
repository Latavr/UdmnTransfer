using System.IO.Ports;

namespace UdmnTransfer
{
    public partial class Udmn : Form
    {
        public string[] ports = SerialPort.GetPortNames();
        public byte[] typePack = new byte[] { 0x00, 0x01, 0x02, 0x03, 0x04, 0x05, 0x06, 0x07, 0x08, 0x09, 0x0A, 0x0B, 0x0C };
        public byte[] addressRecipient = new byte[] { 0xFF, 0xFF, 0xFF };
        public byte[] addressSender = new byte[] { 0x01, 0x01, 0x01 };
        public byte[] typeDataInterface = new byte[] { 0x03, 0x19, 0x7D };

        public Udmn()
        {
            InitializeComponent();
        }
        
        private void ListCOMPorts_Load(object sender, EventArgs e)
        {
            listCOMPorts.Items.Clear();
            for (int i = 0; i < ports.Length; i++)
            {
                listCOMPorts.Items.Add(ports[i].ToString());
            }
            listCOMPorts.SelectedIndex = 0;
        }

        private void ListTypePackage_Load(object sender, EventArgs e)
        {
            typePackage.Items.Clear();
            for (int i = 0; i < typePack.Length; i++)
            {
                typePackage.Items.Add(Convert.ToString(typePack[i].ToString("X2")));
            }
            typePackage.SelectedIndex = 0;
        }
        /*
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
        */
        private void CheckTypePackage_Click(object sender, EventArgs e)
        {
            int i = 0;
            while(typePackage.SelectedIndex != i)
            {
                i++;
            }
            packageRequest.Text += (Convert.ToString(typePack[i].ToString("X2")) + ".");
        }

        private void TypePackageRequest_Load(object sender, EventArgs e)
        {
            packageRequest.Text = (new string(Convert.ToHexString(addressRecipient)) + ".");
            packageRequest.Text += (new string(Convert.ToHexString(addressSender)) + ".");
        }

        private void ListTypeData_Load(object sender, EventArgs e)
        {
            listTypeData.Items.Clear();
            for (int i = 0; i < typeDataInterface.Length; i++)
            {
                listTypeData.Items.Add(Convert.ToString(typeDataInterface[i].ToString("X2")));
            }
            listTypeData.SelectedIndex = 0;
        }

        private void CheckTypeData_Click(object sender, EventArgs e)
        {
            int i = 0;
            while (listTypeData.SelectedIndex != i)
            {
                i++;
            }
            packageRequest.Text += Convert.ToString(typeDataInterface[i].ToString("X2"));
        }

        private void SendRequest_Click(object sender, EventArgs e)
        {
            leftPanel.Text += (packageRequest.Text + "\n");
            packageRequest.Clear();
            TypePackageRequest_Load(sendRequest, e);
        }
    }
}