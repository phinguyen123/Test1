using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test_10
{
    class test_10_3
    {
        static void Main (string [] args)
        {
            Console.WriteLine("lop array trong c#:");
            Console.WriteLine("----------------");
             int [] list= { 4,5,9,7,8};
            int[] temp = list;

            Console.WriteLine("mang ban dau: ");
            foreach (int i in list)
            {
                Console.WriteLine(i + " ");
            }
            Console.WriteLine();
            //dao chieu mang
            Array.Reverse(temp);
            Console.WriteLine("mang sau dao chieu:");
            foreach (int i in temp)
            {
                Console.WriteLine(i + ",");
            }
            Console.WriteLine();
            //sap xep mang
            Array.Sort(temp);
            Console.WriteLine("mang sau sap xep:");
            foreach (int i in temp)
            {
                Console.WriteLine(i + ",");
            }
            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
