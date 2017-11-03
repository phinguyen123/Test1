using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test_6
{
    class rectangle
    {
   
        public double length;
        public double width;

        public double getarea()
        {
            return length * width;
        }

        public void display()
        {
            Console.WriteLine("length: {0}", length);
            Console.WriteLine("width: {0}", width);
            Console.WriteLine("dien tich: {0}", getarea());
        }
        }
    }
