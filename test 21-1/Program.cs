using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace test_21_1
{
    class Program
    {
        private static void showmatch(string a,string b)
        {
            Console.WriteLine("Expression:" + b);
            MatchCollection mc = Regex.Matches(a, b);
            foreach (Match m in mc)
            {
                Console.WriteLine(m);
            }
        }
        static void Main (string [] args)
        {
            Console.WriteLine("Regular expression trong c#:");
            Console.WriteLine("----------------");

            string str = "Sao hom nay lai thay sao suyen son sang";

            Console.WriteLine("so khop voi tu bat dau bang s va ket thuc bang n");
            showmatch(str, @"\bs\S*n\b");
            Console.ReadKey();
        }
    }
}
