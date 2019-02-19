using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NTFS
{
    class PartionTable
    {
        Dictionary<string, int> table = new Dictionary<string, int>();

        public PartionTable()
        {
            table.Add("EMPTY", 0x00);
            table.Add("FAT12", 0x01);
            table.Add("FAT16", 0x04);
            table.Add("MS Extended-1", 0x05);
            table.Add("FAT16-1", 0x06);
            table.Add("NTFS", 0x07);
            table.Add("FAT32-1", 0x0b);
            table.Add("FAT32-2", 0x0c);
            table.Add("FAT16-2", 0x0e);
            table.Add("MS Extended-2", 0x0f);
            table.Add("Linux", 0x83);
            table.Add("Linux Extended", 0x85);
            table.Add("FreeBSD", 0xa5);
            table.Add("MACOSX", 0xa8);
            table.Add("MAC OSX Boot", 0xab);
            table.Add("EFI GTP DISK", 0xee);
        }
    }
}
