using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test_30
{
    class Program
    {
        static unsafe void Main(string[] args)
        {
            Console.WriteLine("Con tro trong c#:");
            Console.WriteLine("-------------");

            int var = 20;
            int* p = &var;

            Console.WriteLine("Gia tri:{0}", var);
            Console.WriteLine("Dia chi:{0}", (int)p);

            Console.ReadKey();
        }
    }
}
