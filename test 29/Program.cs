using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
delegate void number(int c);
namespace test_29
{
    class Program
    {
        static int n = 10;
        public static void add(int a)
        {
            n += a;
            Console.WriteLine("Phuong thuc co ten:{0}", n);
        }
        public static void mul(int b)
        {
            n *= b;
            Console.WriteLine("Phuong thuc co ten:{0}", n);
        }
        public static int get()
        {
            return n;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Phuong thuc nac danh trong c#:");
            Console.WriteLine("---------------");

            //phuong thuc nac danh khong can ten, tu xac dinh kieu tra ve ,toi uu code hon
            number a = delegate (int x)
            {
                Console.WriteLine("phuong thuc nac danh:{0}", x);
            };

            a(5);

            a = new number(add);

            a(5);

            a = new number(mul);

            a(10);

            Console.ReadKey();

        }
    }
}
