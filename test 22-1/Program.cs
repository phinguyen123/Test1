using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test_22_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Test regular expression trong c#:");
            Console.WriteLine("------------------");

            Temperature a = new Temperature();
            try
            {
                a.showtemp();
            }
            catch(tempiszeroexception e)
            {
                Console.WriteLine("Tempiszeroexception: {0}", e.Message);
            }
            Console.ReadKey();
        }
    }
}
