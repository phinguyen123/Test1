using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
delegate T number<T>(T n);
namespace test_28_2
{
    class Program
    {
        static int n = 10;
        public static int add(int a)
        {
            return n += a;
        }
        public static int mul(int b)
        {
            return n *= b;
        }
        public static int get()
        {
            return n;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("GENERIC trong c#:");
            Console.WriteLine("------------");

            number<int> a = new number<int>(add);
            number<int> b = new number<int>(mul);
            a(25);
            Console.WriteLine("Gia tri :{0}", get());
            b(5);
            Console.WriteLine("gia tri:{0}", get());

            Console.ReadKey();
        }
    }
}
