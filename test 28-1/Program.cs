using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test_28_1
{
    class Program
    {
        static void swap <T>(ref T a,ref T b)
        {
            T temp;
            temp = a;
            a = b;
            b = temp;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Generic trong c#:");
            Console.WriteLine("-----------");

            int a, b;
            char c, d;
            a = 4;
            b = 5;
            c = 'A';
            d = 'C';

            Console.WriteLine("Cac gia tri truoc khi swap:");
            Console.WriteLine("a={0},b={1}", a, b);
            Console.WriteLine("Cac gia tri truoc khi swap");
            Console.WriteLine("c={0},d={1}", c, d);

            swap<int>(ref a,ref b);
            swap<char>(ref c, ref d);

            Console.WriteLine("Cac gia tri sau khi swap");
            Console.WriteLine("a={0},b={1}", a, b);
            Console.WriteLine("Cac gia tri sau khi swap");
            Console.WriteLine("c={0},d={1}", c, d);

            Console.ReadKey();
        }
    }//generic như là 1 kiểu dữ liệu chung bao gồm int,double ,char,... có thể chuyển đổi qua lại lẫn nhau , tối ưu code 
}
