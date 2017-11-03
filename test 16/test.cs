using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test_16
{
    class test
    {
        public static void Main(string [] args)
        {
            Console.WriteLine("Test tinh ke thua trong c#:");
            Console.WriteLine("-------------");

            hinh_chu_nhat a = new hinh_chu_nhat();

            a.setchieudai(5);
            a.setchieurong(3.5);

            Console.WriteLine("Dien tich la:{0}", a.tinhdientich());
            Console.ReadKey();
        }
    }
}
