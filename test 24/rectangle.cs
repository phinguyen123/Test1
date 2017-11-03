using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test_24
{


    [debuginfo(45, "tran hao nam", "21/2/2012", message = "kieu tra ve khong hop le")]
    [debuginfo(49, "tran quoc tuan", "23/3/2010", message = "kieu du lieu khong hop le")]
    class rectangle
    {
        protected double chieudai;
        protected double chieurong;
        public rectangle(double a, double b)
        {
            chieudai = a;
            chieurong = b;
        }
        [debuginfo(55, "nguyen van a", "12/2/2019", message = "kieu tra ve khong hop le")]
        public double tinhdientich()
        {
            return chieurong * chieudai;
        }
        [debuginfo(34, "nguyen phuc a", "23/4/2005", message = "kieu tra ve khong hop le")]

        public void display()
        {
            Console.WriteLine("chieu dai:{0}", chieudai);
            Console.WriteLine("chieu rong :{0}", chieurong);
            Console.WriteLine("dien tich:{0}", tinhdientich());
        }
    }
}
