using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test_30_2
{
    class Program
    {
        public unsafe void swap(int *p,int *q)
        {
            int temp;
            temp = *p;
            *p = *q;
            *q = temp;
        }

        static unsafe void Main(string[] args)
        {
            Console.WriteLine("Con tro trong c#:");
            Console.WriteLine("Unsafe code trong c#:");
            Console.WriteLine("----------------");

            Program p = new Program();

            int var1 = 10;
            int var2 = 20;
            int *p1=&var1;
            int* p2 = &var2;

            Console.WriteLine("Truoc khi swap var1= {0},var2={1}", var1, var2);
            p.swap(p1,p2);
            Console.WriteLine("Sau khi swap var1={0},var2={1}", var1, var2);
            Console.ReadKey();
        }
    }
}
