using System.Numerics;
using System.Buffers.Binary;
using System.Text;

namespace UdmnTransfer
{
    public class DiBus
    {
        public string CalculateCRC(string headOrData)
        {
            string[] headOrDataSplit = headOrData.Split(' ');
            string reverCRC = "";
            string resultCalculateCRC = "";
            uint CRC = 0;
            int index = 0;

            if ((headOrDataSplit.Length - 1) % 2 == 1)
            {
                CRC ^= (uint)Convert.ToInt32(headOrDataSplit[index], 16);
                index++;
            }
            while (index < (headOrDataSplit.Length - 1))
            {
                CRC = BitOperations.RotateLeft(CRC, 5);
                CRC ^= (((uint)Convert.ToInt32(headOrDataSplit[index], 16) << 8) + (uint)Convert.ToInt32(headOrDataSplit[index + 1], 16));
                index += 2;
            }
            CRC = BinaryPrimitives.ReverseEndianness(CRC);
            reverCRC = Convert.ToString(CRC, 16);

            for (int i = 0; i < (reverCRC.Length - 1); i += 2)
            {
                resultCalculateCRC += ("" + reverCRC[i] + reverCRC[i + 1] + " ");
            }
            //reverCRC = reverCRC.Replace(" ", string.Empty);
            //resultCalculateCRC = String.Join(" ", reverCRC.ToCharArray());
            return resultCalculateCRC;
        }
        public string UdmnDevice(byte[] addressRecipient, byte[] addressSender, byte typePack, byte typeDataInterface, byte indexValue)
        {
            byte[] addressRecip = new byte[3];
            byte[] addressSend = new byte[] { 0x05, 0x08, 0x69};
            string typePackage;
            string typeDataInterf;
            byte indexVal;
            string addressR = "";
            string result = "";
            string errors = "Неверный адрес или тип пакета";
            //string response = "";

            for(int i = 0; i < addressRecipient.Length; i++)
            {
                addressR += Convert.ToString(addressRecipient[i]);
            }

            typePackage = new string(Convert.ToString(typePack));
            typeDataInterf = new string(Convert.ToString(typeDataInterface));

            if (addressR == "255255255" && typePackage == "6")
            {
                typePackage = "7";
                result += "Заголовок ответа: ";
                for (int i = 0; i < addressSender.Length; i++)
                {
                    addressRecip[i] = addressSender[i];
                    //result += (Convert.ToString(addressRecip[i]) + ".");
                    //result += (Convert.ToString(addressSend[i]) + ".");
                }

                result += (typePackage + ".");
                result += (typeDataInterf + "\n" + "Ответ: ");
            }
            else
            {
                result = errors;
            }
            indexVal = indexValue;

            return result;
        }
    }
}
