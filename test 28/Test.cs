using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test_28
{
    class Test
    {
        static void Main(string [] args)
        {
            Console.WriteLine("Test generic trong c#:");
            Console.WriteLine("---------------");

            Program<int> array = new Program<int>(5);

            for(int i=0;i<5;i++)
            {
                array.set(i, i * 5);
            }

            for (int i=0;i<5;i++)
            {
                Console.WriteLine(array.get(i));
            }

            Console.WriteLine();

            Program<char> array1 = new Program<char>(10);

            for (int j=0;j<10;j++)
            {
                array1.set(j, (char)(j + 97));
            }

            for (int j=0;j<10;j++)
            {
                Console.WriteLine(array1.get(j) + " ");
            }

            Console.ReadKey();
        }
    }
}
