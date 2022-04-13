using System.IO.Ports;
using System.Buffers.Binary;

namespace UdmnTransfer
{
    public partial class Udmn : Form
    {
        DiBus dibus = new();
        COMPorts comPorts = new();

        private byte[] _packageForSend = new byte[19];
        private byte[] _addressRecipient = new byte[] { 0xFF, 0xFF, 0xFF };
        private byte[] _addressSender = new byte[] { 0x01, 0x01, 0x01 };
        private byte[] _typePackage = new byte[] { 0x00, 0x01, 0x02, 0x03, 0x04, 0x05, 0x06, 0x07, 0x08, 0x09, 0x0A, 0x0B, 0x0C };
        private byte[] _typeDataInterface = new byte[] { 0x03, 0x19, 0x21, 0x7D };
        private byte[] _indexValue = new byte[] { 0x54, 0x55, 0x90, 0xFA, 0xFB, 0xFD };
        private string[] _portName = new string[20];
        private string _dataFromDevice = "";



        public Udmn()
        {
            InitializeComponent();
            comPorts.port = new SerialPort();
            comPorts.port.DataReceived += new SerialDataReceivedEventHandler(DataRecievedHandler);
            //comPorts.transferPortsDelegate = EnterReceived;

        }

        private void DataRecievedHandler(object sender, SerialDataReceivedEventArgs e)
        {
            //rightPanel.Invoke(comPorts.transferPortsDelegate);
            //this.Invoke(new EventHandler());
            this.Invoke(EnterReceived);
        }

        public void EnterReceived()
        {
            byte[] getDataFromPort = new byte[comPorts.port.BytesToRead];
            comPorts.port.Read(getDataFromPort, 0, getDataFromPort.Length);

            for(int i = 0; i < getDataFromPort.Length; i++)
            {
                _dataFromDevice += (getDataFromPort[i].ToString("X2") + " ");
            }
        }
        
        // Поле для выбора доступных COM портов
        private void ListCOMPorts_Load(object sender, EventArgs e)
        {
            listCOMPorts.Items.Clear();
            _portName = SerialPort.GetPortNames();
            listCOMPorts.Items.AddRange(_portName);
            listCOMPorts.SelectedIndex = 0;
        }

        // Выбрать COM порт и установить/разорвать соединение
        private void CheckCOMPort_Click(object sender, EventArgs e)
        {
            int index = listCOMPorts.SelectedIndex;

            if(comPorts.port.IsOpen)
            {
                comPorts.port.Close();
                checkCOMPort.BackColor = Color.Red;
                checkCOMPort.Text = "Подключить";
                rightPanel.Text += "Соединение разорвано \n";
                leftPanel.Text += "\n";
            }
            else
            {
                try
                {
                    comPorts.Property(_portName[index]);
                    comPorts.port.Open();
                    checkCOMPort.BackColor = Color.Green;
                    checkCOMPort.Text = "Отключить";
                    rightPanel.Text += ("Соединение установлено" + "\t" + DateTime.Now.ToString("T") + "\n");
                    leftPanel.Text += "\n";
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
            for (int i = 0; i < _typePackage.Length; i++)
            {
                listTypePackage.Items.Add(Convert.ToString(_typePackage[i].ToString("X2")));
            }
            listTypePackage.SelectedIndex = 0;
        }

        // Выбор типа пакета
        private void CheckTypePackage_Click(object sender, EventArgs e)
        {
            int index = listTypePackage.SelectedIndex;
            packageRequest.Text += (Convert.ToString(_typePackage[index].ToString("X2")) + " ");
        }


        // Поле для выбора типа данных - п. 1.3 в описании протокола DiBus
        private void ListTypeData_Load(object sender, EventArgs e)
        {
            listTypeData.Items.Clear();
            for (int i = 0; i < _typeDataInterface.Length; i++)
            {
                listTypeData.Items.Add(Convert.ToString(_typeDataInterface[i].ToString("X2")));
            }
            listTypeData.SelectedIndex = 0;
        }

        // Выбор типа данных
        private void CheckTypeData_Click(object sender, EventArgs e)
        {
            int index = listTypeData.SelectedIndex;
            packageRequest.Text += Convert.ToString(_typeDataInterface[index].ToString("X2") + " ");
        }

        // Добавление в поле "Заголовок запроса" адресов получателя и отправителя
        private void TypePackageRequest_Load()
        {
            string address = "";
            for (int i = 0; i < _addressRecipient.Length; i++)
            {
                address += Convert.ToString(_addressRecipient[i].ToString("X2") + " ");
            }
            packageRequest.Text = address;
            address = "";
            for (int i = 0; i < _addressSender.Length; i++)
            {
                address += Convert.ToString(_addressSender[i].ToString("X2") + " ");
            }
            packageRequest.Text += address;
            //packageRequest.Text = (new string(Convert.ToHexString(addressRecipient)) + " ");
        }

        // Поле индекса данных - таблица А.1 в руководстве по эксплуатации УДМН-100
        private void Index_Load(object sender, EventArgs e)
        {
            listIndex.Items.Clear();
            for(int i = 0; i < _indexValue.Length; i++)
            {
                listIndex.Items.Add(Convert.ToString(_indexValue[i].ToString("X2")));
            }
            listIndex.SelectedIndex = 0;
        }

        // Выбор индекса данных
        private void ListIndex_Click(object sender, EventArgs e)
        {
            int index = listIndex.SelectedIndex;
            listDataRequest.Text += Convert.ToString(_indexValue[index].ToString("X2"));            
        }

        // Расчёт размера данных и контрольной суммы
        private void CalcSizeDataAndCRC()
        {
            ushort sizeData = BinaryPrimitives.ReverseEndianness(SizeData(listDataRequest.Text));
            packageRequest.Text += ((sizeData >> 8).ToString("X2") + " " + (sizeData & 0xFF).ToString("X2") + " ");
            packageRequest.Text += dibus.CalculateCRC(packageRequest.Text);
            packageRequest.Text += (listDataRequest.Text + " ");
            packageRequest.Text += (dibus.CalculateCRC(listDataRequest.Text));
        }

        // Кнопка "Сформировать запрос" распределяющая выбранные параметры
        // запроса по полям "Заголовок запроса" и "Данные запроса"
        private void GenerateRequest_Click(object sender, EventArgs e)
        {
            listDataRequest.Clear();
            TypePackageRequest_Load();
            CheckTypePackage_Click(generateRequest, e);
            CheckTypeData_Click(generateRequest, e);
            ListIndex_Click(generateRequest, e);
            CalcSizeDataAndCRC();
        }

        private byte[] ConvertStringDataToByte()
        {
            string[] tempData = packageRequest.Text.Split(' ');
            for (int i = 0; i < (tempData.Length - 1); i++)
            {
                _packageForSend[i] = (byte)Convert.ToInt32(tempData[i], 16);
            }
            return _packageForSend;
        }
        // Кнопка "Послать запрос"
        private void SendRequest_Click(object sender, EventArgs e)
        {
            try
            {
                if (comPorts.port.IsOpen == true)
                {
                    Thread transferData = new Thread(new ThreadStart(TransferData));
                    transferData.Start();
                }
                else throw new Exception("Попробуйте воспользоваться кнопкой \"Подключить\"");
            }
            catch (Exception exc)
            {
                if (comPorts.port.IsOpen == false)
                {
                    MessageBox.Show("Соединение не установленно или отсутствует!\n" + exc.Message);
                }
            }
        }

        private void TransferData()
        {
            int count = 0;
            while (count < Convert.ToInt32(setCount.Text))
            {
                comPorts.port.Write(ConvertStringDataToByte(), 0, ConvertStringDataToByte().Length);
                leftPanel.Text += (packageRequest.Text + "\t" + DateTime.Now.ToString("T") + "\n");
                rightPanel.Text += (_dataFromDevice + " " + DateTime.Now.ToString("T") + "\n");
                _dataFromDevice = "";
                Thread.Sleep(1000);
                count++;
            }
            rightPanel.SaveFile("Результаты измерений.txt", RichTextBoxStreamType.PlainText);
            rightPanel.LoadFile("Результаты измерений.txt", RichTextBoxStreamType.PlainText);

        }

        // Размер данных
        private static ushort SizeData(string sizeHead)
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