using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test_16_1
{
    class hinhchunhat
    {
        protected double chieudai;
        protected double chieurong;

        hinhchunhat()
        {

        }
        public hinhchunhat(double a,double b)
        {
            chieudai = a;
            chieurong = b;
        }
        public double tinhdientich()
        {
            return chieudai * chieurong;
        }
        public void display()
        {
            Console.WriteLine("Chieu dai ={0}", chieudai);
            Console.WriteLine("chieu rong ={0}", chieurong);
            Console.WriteLine("Dien tich ={0}", tinhdientich());
        }
    }
}
