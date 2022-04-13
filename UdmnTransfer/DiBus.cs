using System.Numerics;
using System.Buffers.Binary;

namespace UdmnTransfer
{
    public class DiBus
    {
        public string CalculateCRC(string headOrData)
        {
            string[] headOrDataSplit = headOrData.Split(' ');
            string resultCalculateCRC = "";
            uint CRC = 0;
            int index = 0;

            if (((headOrDataSplit.Length - 1) % 2 == 1) || headOrDataSplit.Length == 1)
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
            string reversCRC = Convert.ToString(CRC, 16);

            for (int i = 0; i < (reversCRC.Length - 1); i += 2)
            {
                resultCalculateCRC += ("" + reversCRC[i] + reversCRC[i + 1] + " ");
            }
            //reverCRC = reverCRC.Replace(" ", string.Empty);
            //resultCalculateCRC = String.Join(" ", reverCRC.ToCharArray());
            return resultCalculateCRC;
        }
    }
}
