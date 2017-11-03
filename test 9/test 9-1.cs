using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test_9
{
    class test_9_1
    {
        static void Main (string[] args)
        {
            Console.WriteLine("kiem tra ?? trong C#:");
            Console.WriteLine("--------------------");

            double ?num1 = 5.3;
            double ?num2 = null;
            double num3;
            num3 = num1 ?? 6.5;
            Console.WriteLine("gia tri cua num3 la:{0}", num3);
            num3 = num2 ?? 4;
            Console.WriteLine("gia tri cua num3 la:{0}", num3);
            Console.ReadLine();
            Console.ReadKey();
        }
    }
}
