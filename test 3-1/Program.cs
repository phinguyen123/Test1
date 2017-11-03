using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test_3_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("doi kieu du lieu trong c#:");
            Console.WriteLine("------------------");
            int i = 4;
            float d = 6.78f;
            double t = 5.6;

            //su dung phuong thuc tostring()
            Console.WriteLine(i.ToString());
            Console.WriteLine(d.ToString());
            Console.WriteLine(t.ToString());
            Console.ReadKey();
        }
    }
}
