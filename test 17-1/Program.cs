using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test_17_1
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("tinh da hinh (dung abstract) trong c#:");
            Console.WriteLine("------------");

            hinhchunhat a = new hinhchunhat(5,6.5);

            Console.WriteLine("ket qua: {0}",a.tinhdientich());
            Console.ReadKey();

        }
    }
}
