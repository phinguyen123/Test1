using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test_1_1
{
        class excuterectangle
        {
            static void main(string[] args)
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
