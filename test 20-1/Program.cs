#define a
#define b
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test_20_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Tien xu li trong c#:");
            Console.WriteLine("------------");

#if (a && !b)
            Console.WriteLine("a duoc dinh nghia");
#elif (b && !a)
            Console.WriteLine ("b duoc dinh nghia");
#elif (b && a)
            Console.WriteLine("a va b duoc dinh nghia");
#else
            Console.WriteLine("a va b khong duoc dinh nghia");
#endif
            Console.ReadKey();
        }
    }
}
