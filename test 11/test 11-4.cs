using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test_11
{
    class test_11_4
    {
        static void Main(string [] args)
        {
            Console.WriteLine("noi chuoi trong C#");
            Console.WriteLine("-----------");
            string[] array = { "we don't talk any more", "don't let me down", "faded" };
            string a = String.Join(",", array);
            Console.WriteLine("ket qua la :{0}", a);
            Console.ReadKey();
        }
    }
}
