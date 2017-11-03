using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test1
{
    class rectangle
    {
        //bien thanh vien
        double length;
        double width;
        //phuong thuc
        public void acceptdetails()
        {
            length = 4.5;
            width = 3.5;
        }
        //phuong thuc
        public double getarea()
        {
            return length * width;
        }
        //phuong thuc
        public void display()
        {
            Console.WriteLine("chieu dai {0}", length);
            Console.WriteLine("chieu rong {0}", width);
            Console.WriteLine("dien tich {0}", getarea());

        }

    }
}

namespace test1
{ 
    class excuterectangle
    {
        static void Main(string[] args)
        {
            Console.WriteLine("chuong trinh minh hoa:");
            Console.WriteLine("...................\n");
            //tao doi tuong
            rectangle a = new rectangle();
            //goi cac phuong thuc
            a.acceptdetails();
            a.getarea();
            a.display();
            Console.ReadLine();


            Console.ReadKey();
        }
    }
}
