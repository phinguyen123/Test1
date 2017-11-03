using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test_17_2
{
    class tamgiac:Shape
    {
        public tamgiac(double a,double b):base(a,b)
        {

        }
        public override double tinhdientich()
        {
            Console.WriteLine("dien tich tam giac :");
            return (chieudai * chieurong / 2);
        }
    }
}
