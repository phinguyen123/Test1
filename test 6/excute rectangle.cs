using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test_6
{
    class excute_rectangle
    {
        static void Main (string[] args)
        {
            Console.WriteLine("tinh dong goi trong c#: ");
            Console.WriteLine("------------------");

            rectangle a = new rectangle();

            a.length = 4.5;
            a.width = 3.5;
            a.display();

            Console.ReadLine();
            Console.ReadKey();
        }
    }
}
