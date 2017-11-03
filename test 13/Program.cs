using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test_13
{
    class Program
    {
        enum days { Mon,Tue,Wed,Thu,Fri,Sat,Sun};
        static void Main(string[] args)
        {
            Console.WriteLine("Enum trong c#:");
            Console.WriteLine("-------------");

            int dautuan = (int)days.Mon;
            double cuoituan = (double)days.Sun;

            Console.WriteLine("Ngay thu 2:{0}", dautuan);
            Console.WriteLine("Ngay chu nhat:{0}", cuoituan);

            Console.ReadKey();

        }
    }
}
