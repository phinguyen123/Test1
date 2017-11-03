#define DEBUG
using System;
using System.Diagnostics;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test_23
{
    class test_attribute
    {
        [Conditional("DEBUG")]
        public static void message(string msg)
        {
            Console.WriteLine(msg);
        }
    }
}
