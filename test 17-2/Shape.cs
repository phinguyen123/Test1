using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test_17_2
{
    class Shape
    {
        protected double chieudai, chieurong;
        public Shape (double a=0,double b=0)
        {
            chieudai = a;
            chieurong = b;
        }
        public virtual double tinhdientich()
        {
            Console.WriteLine("DT lop cha:");
            return 0;
        }
    }
}
