using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NTFS
{
    class MBRPartionTable
    {
        byte[] table = new byte[16];        

        public void setbootflag(byte value)
        {
            table[0] = value;
        }

        public void setpartion(string value)
        {
            
        }

        // Display a byte array with a name.
        public void WriteByteArray(byte[] bytes, string name)
        {
            /*
            https://docs.microsoft.com/ko-kr/dotnet/api/system.bitconverter.tostring?view=netframework-4.7.2 
            */
            const string underLine = "--------------------------------";

            Console.WriteLine(name);
            Console.WriteLine(underLine.Substring(0,
                Math.Min(name.Length, underLine.Length)));
            Console.WriteLine(BitConverter.ToString(bytes));
            Console.WriteLine();
        }

        public void Print()
        {
            WriteByteArray(table, "aa");
        }

    }
}
