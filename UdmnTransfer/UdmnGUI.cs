using System.IO.Ports;


namespace UdmnTransfer
{
    public partial class Udmn : System.Windows.Forms.Form
    {
        DiBus dibus = new DiBus();
        COMPorts comPorts = new COMPorts();

        private byte[] addressRecipient = new byte[] { 0xFF, 0xFF, 0xFF };
        private byte[] addressSender = new byte[] { 0x01, 0x01, 0x01 };
        private byte[] typePack = new byte[] { 0x00, 0x01, 0x02, 0x03, 0x04, 0x05, 0x06, 0x07, 0x08, 0x09, 0x0A, 0x0B, 0x0C };
        private byte[] typeDataInterface = new byte[] { 0x03, 0x19, 0x7D };
        private byte[] indexValue = new byte[] { 0x54, 0x55, 0x90, 0xFA, 0xFB, 0xFD };
        private byte typePackToDevice;
        private byte typeDataInterfaceToDevice;
        private byte indexValueToDevice;
        private string[] portName = new string[20];

        public Udmn()
        {
            InitializeComponent();
            comPorts.port = new SerialPort();
            comPorts.port.DataReceived += new SerialDataReceivedEventHandler(DataRecievedHandler);
            comPorts.delegat1 = EnterReceived;

        }

        private void DataRecievedHandler(object sender, SerialDataReceivedEventArgs e)
        {
            rightPanel.Invoke(comPorts.delegat1);
        }

        public void EnterReceived()
        {
            AddedInPanel(rightPanel, comPorts.port.ReadByte().ToString("X") + " ");
        }

        private void AddedInPanel(RichTextBox RichTextBox, string Text)
        {
            var StartIndex = RichTextBox.TextLength;
            RichTextBox.AppendText(Text);
            var EndIndex = RichTextBox.TextLength;
            RichTextBox.Select(StartIndex, EndIndex - StartIndex);
        }


        // ���� ��� ������ ��������� COM ������
        private void ListCOMPorts_Load(object sender, EventArgs e)
        {
            listCOMPorts.Items.Clear();
            portName = SerialPort.GetPortNames();
            listCOMPorts.Items.AddRange(portName);
            listCOMPorts.SelectedIndex = 0;
        }

        // ������� COM ���� � ����������/��������� ����������
        private void CheckCOMPort_Click(object sender, EventArgs e)
        {
            int index = listCOMPorts.SelectedIndex;

            if(comPorts.port.IsOpen)
            {
                comPorts.port.Close();
                rightPanel.Text += "���������� ��������� \n";
            }
            else
            {
                try
                {
                    comPorts.Property(portName[index]);
                    /*
                    comPorts.port.PortName = portName[index];
                    comPorts.port.BaudRate = 9600;
                    comPorts.port.Parity = Parity.None;
                    comPorts.port.DataBits = 8;
                    comPorts.port.StopBits = StopBits.One;
                    comPorts.port.WriteTimeout = 500;
                    comPorts.port.ReadTimeout = 500;
                    */
                    comPorts.port.Open();
                    rightPanel.Text += "���������� ����������� \n";
                    comPorts.port.Write("��� ����������!");
                }
                catch (Exception exc)
                {
                    MessageBox.Show("������ �����������: \n" + exc.Message);
                }
            }
        }

        // ���� ��� ������ ���� ������ - �. 1.2 � �������� ��������� DiBus
        private void ListTypePackage_Load(object sender, EventArgs e)
        {
            listTypePackage.Items.Clear();
            for (int i = 0; i < typePack.Length; i++)
            {
                listTypePackage.Items.Add(Convert.ToString(typePack[i].ToString("X2")));
            }
            listTypePackage.SelectedIndex = 0;
        }

        // ����� ���� ������
        private void CheckTypePackage_Click(object sender, EventArgs e)
        {
            int index = listTypePackage.SelectedIndex;
            packageRequest.Text += (Convert.ToString(typePack[index].ToString("X2")) + ".");
            typePackToDevice = typePack[index];
        }


        // ���� ��� ������ ���� ������ - �. 1.3 � �������� ��������� DiBus
        private void ListTypeData_Load(object sender, EventArgs e)
        {
            listTypeData.Items.Clear();
            for (int i = 0; i < typeDataInterface.Length; i++)
            {
                listTypeData.Items.Add(Convert.ToString(typeDataInterface[i].ToString("X2")));
            }
            listTypeData.SelectedIndex = 0;
        }

        // ����� ���� ������
        private void CheckTypeData_Click(object sender, EventArgs e)
        {
            int index = listTypeData.SelectedIndex;
            packageRequest.Text += Convert.ToString(typeDataInterface[index].ToString("X2"));
            typeDataInterfaceToDevice = typeDataInterface[index];
        }

        // ���������� � ���� "��������� �������" ������� ���������� � �����������
        private void TypePackageRequest_Load(object sender, EventArgs e)
        {
            packageRequest.Text = (new string(Convert.ToHexString(addressRecipient)) + ".");
            packageRequest.Text += (new string(Convert.ToHexString(addressSender)) + ".");
        }

        // ���� ������� ������ - ������� �.1 � ����������� �� ������������ ����-100
        private void Index_Load(object sender, EventArgs e)
        {
            listIndex.Items.Clear();
            for(int i = 0; i < indexValue.Length; i++)
            {
                listIndex.Items.Add(Convert.ToString(indexValue[i].ToString("X2")));
            }
            listIndex.SelectedIndex = 0;
        }

        // ����� ������� ������
        private void ListIndex_Click(object sender, EventArgs e)
        {
            int index = listIndex.SelectedIndex;
            listDataRequest.Text += Convert.ToString(indexValue[index].ToString("X2"));
            indexValueToDevice = indexValue[index];
        }

        // ������ "������������ ������" �������������� ��������� ���������
        // ������� �� ����� "��������� �������" � "������ �������"
        private void GenerateRequest_Click(object sender, EventArgs e)
        {
            TypePackageRequest_Load(generateRequest, e);
            CheckTypePackage_Click(generateRequest, e);
            CheckTypeData_Click(generateRequest, e);
            ListIndex_Click(generateRequest, e);        
        }

        // ������ "������� ������"
        private void SendRequest_Click(object sender, EventArgs e)
        {
            leftPanel.Text += ("���������: " + packageRequest.Text + "." + SizeData() + "\t" + DateTime.Now.ToString("T") + "\n");
            leftPanel.Text += ("������: " + listDataRequest.Text + "\n");
            //packageRequest.Clear();
            //TypePackageRequest_Load(sendRequest, e);
            rightPanel.Text += dibus.UdmnDevice(addressRecipient, addressSender, typePackToDevice, typeDataInterfaceToDevice, indexValueToDevice);
            leftPanel.SaveFile("���������� ���������.txt", RichTextBoxStreamType.PlainText);
            leftPanel.Clear();
            leftPanel.LoadFile("���������� ���������.txt", RichTextBoxStreamType.PlainText);
        }

        // ������ ������
        private string SizeData()
        {
            byte[] sizeData = new byte[] { 0x00, 0x00 };
            byte index = 0;
            string result = "";
            for (int i = 0; i < listDataRequest.Text.Length; i++)
            {
                index++;
            }
            index /= 2;
            result = Convert.ToString(index.ToString("X4"));
            return result;
        }
    }
}