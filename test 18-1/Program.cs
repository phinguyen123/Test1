using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test_18_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("NAP CHONG TOAN TU TRONG C#:");
            Console.WriteLine("-----------------");

            box a = new box();
            box b = new box();
            box c = new box();

            a.setchieudai(5);
            a.setchieurong(4);
            a.setchieucao(3);

            b.setchieudai(9);
            b.setchieurong(8);
            b.setchieucao(7);

            Console.WriteLine("Dien tich a:{0}", a.tinhdientich());
            Console.WriteLine("Dien tich b:{0}", b.tinhdientich());
            //+
            c = a + b;
            Console.WriteLine("Dien tich c:{0}", c.tinhdientich());
            //sosanh
            Console.WriteLine("TEST >");
            if (a > b)
                Console.WriteLine("a lon hon b");
            else
                Console.WriteLine("a nho hon b");
            Console.WriteLine("TEST <");
            if (a < b)
                Console.WriteLine("a nho hon b");
            else
                Console.WriteLine("a lon hon b");

            Console.WriteLine("TEST ==");
            if (a == b)
                Console.WriteLine("a bang b");

            Console.WriteLine("TEST !=");
            if (a != b)
                Console.WriteLine("a khac b");

            Console.ReadKey();
             


        }
    }
}
