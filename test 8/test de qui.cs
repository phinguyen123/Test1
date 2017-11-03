using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test_8
{
    class test_de_qui
    {
        public int tinhgiaithua (int a)
        {
            if (a == 1)
                return 1;
            else
            {
                int n = tinhgiaithua(a - 1) * a;
                return n;
            }

        }
        static void Main(string [] args)
        {
            Console.WriteLine("kiem tra tinh de qui: ");
            Console.WriteLine("--------------------");

            test_de_qui a = new test_de_qui();
            Console.WriteLine("4!= {0}", a.tinhgiaithua(4));
            Console.WriteLine("5!= {0}", a.tinhgiaithua(5));
            Console.ReadLine();

            Console.ReadKey();
        }
    }
}
