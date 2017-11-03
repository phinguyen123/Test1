using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("khai bao va khoi tao bien trong c#:");
            Console.WriteLine("---------------------------------");
            int i;
            float d;
            double e;
            //khoi tao bien
            i = 5;
            d = 7.6f;
            e = i + d;
            Console.WriteLine("i= {0},d= {1} ,e={2}", i, d, e);
            Console.ReadLine();

            Console.ReadKey();

        }
    }
}
