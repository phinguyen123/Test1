using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test_17_2
{
    class Program   //so sanh giua virtual va abstract ,link: http://forum.alphatek.edu.vn/threads/9283-Su-khac-nhau-cua-Abstract-class-va-Virtual-Class.html
    {
        static void Main(string[] args)
        {
            Console.WriteLine("tinh da hinh (dung virtual) trong c#:");
            Console.WriteLine("-------------");

            hinhchunhat a = new hinhchunhat(5,6.7);
            tamgiac b = new tamgiac(4, 5);

            Console.WriteLine("dien tich:{0}", a.tinhdientich());
            Console.WriteLine("dien tich: {0} ", b.tinhdientich());
            Console.ReadKey();


        }
    }
}
