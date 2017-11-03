using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
delegate int numberchange(int a);
namespace test_26
{
    class Program
    {
        static int b = 10;
      public static int add(int n)
        {
            b += n;
            return b;
        }
        public static int mul(int e)
        {
            b *= e;
            return b;
        }
        public static int get()
        {
            return b;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Delegate trong c#");
            Console.WriteLine("---------------");

            numberchange f = new numberchange(add);
            numberchange g = new numberchange(mul);

            f(5);
            Console.WriteLine("ket qua :{0}",get());
            g(7);
            Console.WriteLine("ket qua: {0}",get());
            Console.ReadKey();
        }
    }
}
