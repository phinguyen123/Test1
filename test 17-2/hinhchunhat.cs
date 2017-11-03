using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test_17_2
{
    class hinhchunhat:Shape
    {
        public hinhchunhat (double a,double b): base(a,b)
        {

        }
        public override double tinhdientich()
        {
            Console.WriteLine("Dien tich hinh chu nhat la:");
            return (chieudai * chieurong);
        }

    }
}
