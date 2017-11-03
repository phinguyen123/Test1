#define pi
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test_20
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Tien xu li trong c#:");
            Console.WriteLine("-----------------");
#if (pi)
                Console.WriteLine("pi da duoc dinh nghia");

#else     
            Console.WriteLine("pi khong duoc dinh nghia");
#endif
            Console.ReadKey();
   }
            }
            }
