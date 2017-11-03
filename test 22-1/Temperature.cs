using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test_22_1
{
    class Temperature
    {
        int temp = 0;
        public void showtemp()
        {
            if (temp == 0)
            {
                throw (new tempiszeroexception("muc nhiet do 0!!"));
            }
            else
                Console.WriteLine("Temparute: {0}", temp);
        }
    }
}
