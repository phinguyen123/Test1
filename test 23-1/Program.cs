using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test_23_1
{
    class Program
    {
        [Obsolete("dung su dung phuong thuc 1,ban nen su dung phuong thuc 2")]
        static void phuongthuc1()
        {
            Console.WriteLine("day la phuong thuc 1");
        }
        static void phuongthuc2()
        {
            Console.WriteLine("day la phuong thuc 2");
        }
        static void Main(string[] args)
        {
            Console.WriteLine("obselete trong c#:");
            Console.WriteLine("-----------");

            phuongthuc1();
            
        }
    }
}
