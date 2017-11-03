using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test_24
{
    [AttributeUsage(AttributeTargets.Class |
        AttributeTargets.Constructor |
        AttributeTargets.Field |
        AttributeTargets.Method |
        AttributeTargets.Property,
        AllowMultiple = true)]
    class debuginfo : System.Attribute
    {
        private int bugno;
        private string developer;
        private string lastreview;
        public string message;

        public debuginfo(int a, string b, string c)
        {
            bugno = a;
            developer = b;
            lastreview = c;
        }
        public int Bugno
        {
            get
            {
                return bugno;
            }
        }
        public string Developer
        {
            get
            {
                return developer;
            }
        }
        public string Lastreview
        {
            get
            {
                return lastreview;
            }
        }
        public string Message
        {
            get
            {
                return message;
            }
            set
            {
                message = value;
            }
        }
    }
}
