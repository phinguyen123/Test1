using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test_5_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("hang so trong c#:");
            Console.WriteLine("----------------");

            const double pi= 3.14;

            double e;
            Console.WriteLine("nhap ban kinh");
            e = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("ket qua :{0}",pi*e*e);
            Console.ReadLine();
            Console.ReadKey();
            
        }
    }
}
