using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test_27
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Event trong c#:");
            Console.WriteLine("-------------");

            even_test a = new even_test(5);
            a.setvalue(4);
            a.setvalue(4);
            Console.ReadKey();
        }
    }
}
