using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test_16_1
{
    class chiphixaydung : hinhchunhat
    {
        private double cost;
      public chiphixaydung(double a,double b):base(a,b) { }
        public double tinhchiphi()
        {
            double c;
            c = tinhdientich() * 70;
            return c;
        }    
        public void hienthithongtin()
        {
            base.display();
            Console.WriteLine("Chi phi: {0}", tinhchiphi());
        }
            }

}
