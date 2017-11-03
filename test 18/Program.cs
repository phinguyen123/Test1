using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test_18
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("nap chong toan tu trong c#:");
            Console.WriteLine("--------------");

            box a = new box();
            box b = new box();
            box c = new box();

            a.setchieucao(5);
            a.setchieurong(6);
            a.setchieudai(7);

            b.setchieucao(3);
            b.setchieudai(4);
            b.setchieurong(5);

            int d=a.tinhthetich();
            Console.WriteLine("Dien tich a:{0}", a.tinhthetich());

            int e = b.tinhthetich();
            Console.WriteLine("Dien tich b:{0}", e);

            c = a + b;

            Console.WriteLine("Dien tich c:{0}", c.tinhthetich());
            Console.ReadKey();
        }
    }
}
