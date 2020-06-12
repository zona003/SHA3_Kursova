using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KursSha3
{
	internal static class Utils
	{
        public static byte[] SubArray(this IReadOnlyList<byte> byteArray, int position, int length)
        {
            var subArray = new byte[length];
            for (var i = 0; i < length; ++i)
            {
                subArray[i] = byteArray[i + position];
            }
            return subArray;
        }

        public static HEX ToHex(this byte[] b)
        {
            return new HEX(b);
        }

        public static byte[] ToByteArray(this string str)
        {
            string temp = str.Replace("\r", "");
            var r = Encoding.UTF8.GetBytes(temp);
            return r;
        }
    }
}
