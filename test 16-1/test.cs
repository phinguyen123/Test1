using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test_16_1
{
    class test
    {
        static void Main (string [] args)
        {
            Console.WriteLine("Tinh ke thua trong c#:");
            Console.WriteLine("-------------");

            chiphixaydung a = new chiphixaydung(5,4.5);
            Console.WriteLine("Thong tin:\n");
            a.hienthithongtin();
            Console.ReadKey();
        }
    }
}
