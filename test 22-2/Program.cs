using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace test_22_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Minh hoa su dung I/O trong c#:");
            Console.WriteLine("-------------");

            FileStream f = new FileStream("binary.dat", FileMode.OpenOrCreate, FileAccess.ReadWrite);
           for (int i=1;i<=20;i++)
            {
                f.WriteByte((byte)i);
            }
            f.Position = 0;
            for (int i=0;i<=20;i++)
            {
                Console.WriteLine(f.ReadByte() + " ");
            }
            f.Close();

            Console.ReadKey();
        }
    }
}
