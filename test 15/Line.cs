using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test_15
{
    class Line
    {
        private double chieudai;
        Line()
        {
            Console.WriteLine("Doi tuong duoc khoi tao");
        }
        ~Line()
        {
            Console.WriteLine("doi tuong da bi xoa");
        }
        public void setchieudai(double a)
        {
            chieudai = a;
        }
        public double getchieudai()
        {
            return chieudai;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Constructor trong c#:");
            Console.WriteLine("------------");

            Line a = new Line();
            a.chieudai = 5;
            Console.WriteLine("Chieu dai Line:{0}", a.chieudai);
            a.setchieudai(6.7);
            Console.WriteLine("Chieu dai luc sau:{0}", a.getchieudai());
            Console.ReadKey();
        }
    }
}
