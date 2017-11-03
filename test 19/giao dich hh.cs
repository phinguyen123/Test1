using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test_19
{
    class giao_dich_hh:giao_dich
    {
        private string mahh;
        private string ngay;
        private double sl;

        public giao_dich_hh()
        {
            mahh = "";
            ngay = "";
            sl = 0.0;
        }
        public giao_dich_hh(string a,string b,double c)
        {
            mahh = a;
            ngay = b;
            sl = c;
        }
        public double laysl()
        {
            return sl;
        }
        public void hienthithongtin()
        {
            Console.WriteLine("Mahh :{0}", mahh);
            Console.WriteLine("Ngay :{0}", ngay);
            Console.WriteLine("So luong: {0}", sl);
        }

    }
}
