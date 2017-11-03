using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test_6
{
    class rectangle_1
    {
        //khai bao bien thanh vien
        private double length;
        private double width;

        //cac phuong thuc
        public void acceptdetails()
        {
            Console.WriteLine("nhap chieu dai:");
            length = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("nhap chieu rong:");
            width = Convert.ToDouble(Console.ReadLine());

        }
        public double getarea()
        {
            return length * width;
        }
        public void display()
        {
            Console.WriteLine("chieu dai:{0}", length);
            Console.WriteLine("chieu rong: {0}", width);
            Console.WriteLine("dien tich: {0}", getarea());
        }
    }
}
