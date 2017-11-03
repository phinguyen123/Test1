using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test_14
{
    class Program
    {
        class Rectangle
        {
            public double chieudai;
            public double chieurong;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Class trong c#:");
            Console.WriteLine("----------------");

            Rectangle a = new Rectangle();

            a.chieudai = 5.4;
            a.chieurong = 7;
            double c = a.chieurong * a.chieudai;
            Console.WriteLine("Chieu dai:{0}", a.chieudai);
            Console.WriteLine("Chieu rong:{0}", a.chieurong);
            Console.WriteLine("Dien tich:{0}", c);
            Console.ReadKey();
        }
    }
}
