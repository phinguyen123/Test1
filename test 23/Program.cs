using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test_23
{
    class Program
    {
        static void function1 ()
        {
            test_attribute.message("trong function 1");
            function2();
        }
        static void function2()
        {
            test_attribute.message("trong function 2");
        }
          public  static void Main(string[] args)
        {
            Console.WriteLine("attribute trong c#:");
            Console.WriteLine("-----------------");

            test_attribute.message("trong ham main");
            function1();
            Console.ReadKey();
        }
    }
}
