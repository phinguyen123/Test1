using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace test_21
{
    class Program
    {
        private static void showmatch(string a,string b)
        {
            Console.WriteLine("Expressioin:" + b);
            MatchCollection mc = Regex.Matches(a, b);
            foreach(Match m in mc)
            {
                Console.WriteLine(m);
            } 
        }
        static void Main(string [] args)
        {
            Console.WriteLine("Minh hoa regular expression trong c#:");
            Console.WriteLine("--------------");

            string str = "Sao hom nay lai thay sao Suyen sang";

            Console.WriteLine("so khop voi cac tu bat dau bang chu cai S:");
            showmatch(str, @"\bS\S*");
            Console.ReadKey();
        }
    }
}
