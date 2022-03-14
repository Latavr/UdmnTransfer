using System.IO.Ports;

namespace UdmnTransfer
{
    public class COMPorts
    {
        
        public SerialPort port;
        public delegate void Delegat1();
        public Delegat1 delegat1;

        public void Property(string portName)
        {
            port.PortName = portName;
            port.BaudRate = 9600;
            port.Parity = Parity.None;
            port.DataBits = 8;
            port.StopBits = StopBits.One;
            port.WriteTimeout = 500;
            port.ReadTimeout = 500;
        }
        
        /*
            port.DataReceived += new SerialDataReceivedEventHandler(port_DataReceived);
        }

        public void port_DataReceived(object sender, SerialDataReceivedEventArgs eg)
        {
            Thread.Sleep(100);

            this.Invoke((EventHandler)delegate// Асинхронное выполнение одного потока
            {
                if (!rbnHex.Checked)// Если элемент управления с именем rbnHex не выбран
                {
                    //tbxRecvData.Text += port.ReadLine();
                    StringBuilder sb = new StringBuilder();
                    long rec_count = 0;
                    int num = port.BytesToRead;
                    byte[] recbuf = new byte[num];
                    rec_count += num;

                    port.Read(recbuf, 0, num);
                    sb.Clear();

                    try
                    {
                        Invoke((EventHandler)(delegate
                        {
                            sb.Append(Encoding.ASCII.GetString(recbuf));  // Декодировать весь массив в массив ASCII
                            tbxRecvData.AppendText(sb.ToString());
                        }
                        )
                        );
                    }

                    catch
                    {
                        MessageBox.Show("Пожалуйста, проверьте разрыв строки", "Сообщение об ошибке");
                    }
                }
                else if (rbnHex.Checked)// Если выбрано
                {
                    Byte[] ReceivedData = new Byte[port.BytesToRead];
                    port.Read(ReceivedData, 0, ReceivedData.Length);

                    String RecvDataText = null;

                    for (int i = 0; i < ReceivedData.Length; i++)
                    {
                        RecvDataText += (ReceivedData[i].ToString("X2") + " ");// Данные, полученные в массиве, преобразуются в шестнадцатеричное
                    }
                    tbxRecvData.Text += RecvDataText;
                }
                port.DiscardInBuffer();
            });
        }*/
    }
}
