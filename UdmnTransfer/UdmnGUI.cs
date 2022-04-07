using System.IO.Ports;
using System.Buffers.Binary;

namespace UdmnTransfer
{
    public partial class Udmn : System.Windows.Forms.Form
    {
        DiBus dibus = new DiBus();
        COMPorts comPorts = new COMPorts();

        private byte[] addressRecipient = new byte[] { 0xFF, 0xFF, 0xFF };
        private byte[] addressSender = new byte[] { 0x01, 0x01, 0x01 };
        private byte[] typePack = new byte[] { 0x00, 0x01, 0x02, 0x03, 0x04, 0x05, 0x06, 0x07, 0x08, 0x09, 0x0A, 0x0B, 0x0C };
        private byte[] typeDataInterface = new byte[] { 0x03, 0x19, 0x21, 0x7D };
        private byte[] indexValue = new byte[] { 0x54, 0x55, 0x90, 0xFA, 0xFB, 0xFD };
        //private byte typePackToDevice;
        //private byte typeDataInterfaceToDevice;
        //private byte indexValueToDevice;
        private string[] portName = new string[20];
        private string sendDataFromDevice = "";

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
            //AddedInPanel(rightPanel, comPorts.port.ReadByte().ToString("X") + " ");
            sendDataFromDevice = comPorts.port.ReadExisting();
        }

        private void AddedInPanel(RichTextBox RichTextBox, string Text)
        {
            var StartIndex = RichTextBox.TextLength;
            RichTextBox.AppendText(Text);
            var EndIndex = RichTextBox.TextLength;
            RichTextBox.Select(StartIndex, EndIndex - StartIndex);
        }


        // Поле для выбора доступных COM портов
        private void ListCOMPorts_Load(object sender, EventArgs e)
        {
            listCOMPorts.Items.Clear();
            portName = SerialPort.GetPortNames();
            listCOMPorts.Items.AddRange(portName);
            listCOMPorts.SelectedIndex = 0;
        }

        // Выбрать COM порт и установить/разорвать соединение
        private void CheckCOMPort_Click(object sender, EventArgs e)
        {
            int index = listCOMPorts.SelectedIndex;

            if(comPorts.port.IsOpen)
            {
                comPorts.port.Close();
                rightPanel.Text += "Соединение разорвано \n";
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
                    rightPanel.Text += "Соединение установлено \n";
                    SendRequest_Click(generateRequest, e);
                    //comPorts.port.Write("Hay I did it!");
                }
                catch (Exception exc)
                {
                    MessageBox.Show("Ошибка подключения: \n" + exc.Message);
                }
            }
        }

        private void ChangeColorButton(object sender, EventArgs e)
        {
            checkCOMPort.BackColor = Color.Green;
        }

        // Поле для выбора типа пакета - п. 1.2 в описании протокола DiBus
        private void ListTypePackage_Load(object sender, EventArgs e)
        {
            listTypePackage.Items.Clear();
            for (int i = 0; i < typePack.Length; i++)
            {
                listTypePackage.Items.Add(Convert.ToString(typePack[i].ToString("X2")));
            }
            listTypePackage.SelectedIndex = 0;
        }

        // Выбор типа пакета
        private void CheckTypePackage_Click(object sender, EventArgs e)
        {
            int index = listTypePackage.SelectedIndex;
            packageRequest.Text += (Convert.ToString(typePack[index].ToString("X2")) + " ");
            //typePackToDevice = typePack[index];
        }


        // Поле для выбора типа данных - п. 1.3 в описании протокола DiBus
        private void ListTypeData_Load(object sender, EventArgs e)
        {
            listTypeData.Items.Clear();
            for (int i = 0; i < typeDataInterface.Length; i++)
            {
                listTypeData.Items.Add(Convert.ToString(typeDataInterface[i].ToString("X2")));
            }
            listTypeData.SelectedIndex = 0;
        }

        // Выбор типа данных
        private void CheckTypeData_Click(object sender, EventArgs e)
        {
            int index = listTypeData.SelectedIndex;
            packageRequest.Text += Convert.ToString(typeDataInterface[index].ToString("X2") + " ");
            //typeDataInterfaceToDevice = typeDataInterface[index];
        }

        // Добавление в поле "Заголовок запроса" адресов получателя и отправителя
        private void TypePackageRequest_Load()
        {
            string address = "";
            for (int i = 0; i < addressRecipient.Length; i++)
            {
                address += Convert.ToString(addressRecipient[i].ToString("X2") + " ");
            }
            packageRequest.Text = address;
            address = "";
            for (int i = 0; i < addressSender.Length; i++)
            {
                address += Convert.ToString(addressSender[i].ToString("X2") + " ");
            }
            packageRequest.Text += address;
            //packageRequest.Text = (new string(Convert.ToHexString(addressRecipient)) + " ");
            //packageRequest.Text += (new string(Convert.ToHexString(addressSender)) + " ");
        }

        // Поле индекса данных - таблица А.1 в руководстве по эксплуатации УДМН-100
        private void Index_Load(object sender, EventArgs e)
        {
            listIndex.Items.Clear();
            for(int i = 0; i < indexValue.Length; i++)
            {
                listIndex.Items.Add(Convert.ToString(indexValue[i].ToString("X2")));
            }
            listIndex.SelectedIndex = 0;
        }

        // Выбор индекса данных
        private void ListIndex_Click(object sender, EventArgs e)
        {
            int index = listIndex.SelectedIndex;
            listDataRequest.Text += Convert.ToString(indexValue[index].ToString("X2"));
            //indexValueToDevice = indexValue[index];
        }

        // Кнопка "Сформировать запрос" распределяющая выбранные параметры
        // запроса по полям "Заголовок запроса" и "Данные запроса"
        private void GenerateRequest_Click(object sender, EventArgs e)
        {
            ushort sizeData = 0;

            TypePackageRequest_Load();
            CheckTypePackage_Click(generateRequest, e);
            CheckTypeData_Click(generateRequest, e);
            ListIndex_Click(generateRequest, e);
            sizeData = BinaryPrimitives.ReverseEndianness(SizeData(listDataRequest.Text));
            packageRequest.Text += ((sizeData >> 8).ToString("X2") + " " + (sizeData & 0xFF).ToString("X2") + " ");
            packageRequest.Text += dibus.CalculateCRC(packageRequest.Text);
        }

        // Кнопка "Послать запрос"
        private void SendRequest_Click(object sender, EventArgs e)
        {
            leftPanel.Text += ("Заголовок: " + packageRequest.Text + "\t" + DateTime.Now.ToString("T") + "\n");
            leftPanel.Text += ("Данные: " + listDataRequest.Text + "\n");
            //packageRequest.Clear();
            //TypePackageRequest_Load(sendRequest, e);
            //rightPanel.Text += dibus.UdmnDevice(addressRecipient, addressSender, typePackToDevice, typeDataInterfaceToDevice, indexValueToDevice, SizeData());
            //rightPanel.Text += comPorts.port.Read();
            comPorts.port.Write(packageRequest.Text);
            rightPanel.Text += (sendDataFromDevice + "\n");
            leftPanel.SaveFile("Результаты измерений.txt", RichTextBoxStreamType.PlainText);
            leftPanel.Clear();
            leftPanel.LoadFile("Результаты измерений.txt", RichTextBoxStreamType.PlainText);
        }

        // Размер данных
        private ushort SizeData(string sizeHead)
        {
            ushort sizeData = 0;
            for (int i = 0; i < sizeHead.Length; i++)
            {
                if (sizeHead[i] == ' ')
                {
                    i++;
                }
                sizeData++;
            }
            return sizeData /= 2;
        }        
    }
}