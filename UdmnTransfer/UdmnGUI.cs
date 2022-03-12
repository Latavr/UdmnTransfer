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

        public Udmn()
        {
            InitializeComponent();
        }
        
        // ���� ��� ������ ��������� COM ������
        private void ListCOMPorts_Load(object sender, EventArgs e)
        {
            listCOMPorts.Items.Clear();
            listCOMPorts.Items.AddRange(comPorts.PortsNames());
            listCOMPorts.SelectedIndex = 0;
        }

        /*
        private void CheckCOMPort_Click(object sender, EventArgs e)
        {
            int i = 0;
            while (listCOMPorts.SelectedIndex != i)
            {
                i++;
            }
        }
        */

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
            int i = 0;
            while (listTypePackage.SelectedIndex != i)
            {
                i++;
            }
            packageRequest.Text += (Convert.ToString(typePack[i].ToString("X2")) + ".");
            typePackToDevice = typePack[i];
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
            int i = 0;
            while (listTypeData.SelectedIndex != i)
            {
                i++;
            }
            packageRequest.Text += Convert.ToString(typeDataInterface[i].ToString("X2"));
            typeDataInterfaceToDevice = typeDataInterface[i];
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
            int i = 0;
            while (listIndex.SelectedIndex != i)
            {
                i++;
            }
            listDataRequest.Text += Convert.ToString(indexValue[i].ToString("X2"));
            indexValueToDevice = indexValue[i];
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
            byte[] sizeData = new byte[2] { 0x00, 0x00 };
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