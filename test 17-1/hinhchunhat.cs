using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test_17_1
{
    class hinhchunhat:Shape
    {
        private double chieudai;
        private double chieurong;

        public hinhchunhat (double a=0,double b=0)
        {
            chieudai = a;
            chieurong = b;
        }
        public override double tinhdientich()
        {
            Console.WriteLine("Dien tich hinh chu nhat la :");
            return (chieurong * chieudai);
        }


    }
}
