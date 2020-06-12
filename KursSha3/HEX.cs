using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KursSha3
{
	public class HEX
	{
        private readonly string data;

        public static implicit operator HEX(string value)
        {
            return new HEX(value);
        }

        public static implicit operator string(HEX value)
        {
            return value.data;
        }

        public HEX()
        {
            data = "";
        }

        public HEX(byte[] b)
        {
            data = "";
            for (var i = 0; i < b.Length; ++i)
                data += String.Format("{0:x2}", b[i]);
        }

        public HEX(string str)
        {
            str = str.Trim();
            str = str.ToLower();
            if (str.Length % 2 == 1) str = str + "0";
            ValidateHEX(str);
            data = str;
        }

        private static void ValidateHEX(string value)
        {
            foreach (var el in value)
            {
                if (!IsHex(el))
                {
                    throw new ArgumentException("Not a HEX string.");
                }
            }
        }

        private static bool IsHex(char c)
        {
            if ((c >= '0' && c <= '9') || (c >= 'a' && c <= 'f'))
                return true;
            return false;
        }

        public byte[] ToByteArray()
        {
            var bytes = new byte[data.Length / 2];
            for (var i = 0; i < bytes.Length; ++i)
            {
                bytes[i] = byte.Parse(data.Substring(i * 2, 2), NumberStyles.HexNumber);
            }

            return bytes;
        }
    }
}
