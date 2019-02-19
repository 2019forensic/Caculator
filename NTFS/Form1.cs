using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NTFS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }        

        public byte[] stringTohex(string hexstring)
        {
            /*
            Hex string to Hex
            Another Method is https://stackoverflow.com/questions/17637950/convert-string-of-hex-to-string-of-little-endian-in-c-sharp
            */
            int len = hexstring.Length;
            byte[] bytes = new byte[len / 2];

            for (int i = 0; i < len; i += 2)
            {
                bytes[i / 2] = Convert.ToByte(hexstring.Substring(i, 2), 16);
            }

            return bytes;
        }

        public string intTohex_littleendian(int number)
        {
            string snumber = "";
            byte[] bytes = BitConverter.GetBytes(number);

            foreach (byte b in bytes)
                // Convert Int To Hex
                snumber += b.ToString("X2"); 

            return snumber;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            /*
            Event for Caculating next NTFS
            bitconverter: https://docs.microsoft.com/ko-kr/dotnet/csharp/programming-guide/types/how-to-convert-a-byte-array-to-an-int
            */
            //Address of VBR
            int iVBR = Convert.ToInt32(VBRText.Text);
            //Total of Sector
            byte[] bSector = stringTohex(SectorText.Text);
            int iSector = BitConverter.ToInt32(bSector, 0);

            //Caculate Next NTFS address
            int nextNTFS = iVBR + iSector + 1;
            nextNTFSText.Text = Convert.ToString(nextNTFS);

            //Caculate Hex Array
            //Boot flag
            String PartitionTableArray = "80";
            PartitionTableArray += "000000";
            //NTFS
            PartitionTableArray += "07"; 
            PartitionTableArray += "000000";
            PartitionTableArray += intTohex_littleendian(iVBR);
            PartitionTableArray += intTohex_littleendian(iSector + 1);

            PartitionTableText.Text = PartitionTableArray;
        }
    }    
}
