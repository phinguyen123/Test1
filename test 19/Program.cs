using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test_19
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Interface trong c#:");
            Console.WriteLine("-------------");

            giao_dich_hh a = new giao_dich_hh("A01", "23 / 7 / 2012", 45);

            Console.WriteLine("Thong tin:");
            a.hienthithongtin();

            Console.ReadKey();
        }
    }
}
