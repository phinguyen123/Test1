using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test_22_1
{
    class tempiszeroexception : ApplicationException
    {
        public tempiszeroexception(string mess) : base(mess)
        { }
    }
}
