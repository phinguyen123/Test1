using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test_17
{
    class Program
    {
        void print(int i)
        {
            Console.WriteLine("So nguyen :{0}", i);
        }
        void print(double j)
        {
            Console.WriteLine("So thuc:{0}", j);
        }
        void print(string a)
        {
            Console.WriteLine("Chuoi: {0}", a);
        }


        static void Main(string[] args)
        {
            Console.WriteLine("tinh da hinh trong c#:");
            Console.WriteLine("----------");

            Program a = new Program();
            a.print(5);
            a.print(5.8);
            a.print("TEST SUCCESSFUL");
            Console.ReadKey();

        }
    }
}

