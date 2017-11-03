using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace test_21_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine ("Test regular expression trong c#:");
            Console.WriteLine("---------------");

            string a1 = "Hello world";
            string pattern = "\\s+";
            string a2 = "pp ";
            Regex b = new Regex(pattern);
            string c = b.Replace(a1, a2);

            Console.WriteLine("chuoi ban dau: " + a1);
            Console.WriteLine("chuoi sau khi thay the:" + c);
            Console.ReadKey();

        }
    }
}
