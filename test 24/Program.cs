using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test_24
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Reflection trong c#:");
            Console.WriteLine("------------------");
            rectangle a = new rectangle(4.5,7.5);
            a.display();
            Type type = typeof(rectangle);
            foreach(object attribute in type.GetCustomAttributes(false))
            {
                debuginfo debug = (debuginfo)attribute;
                if(null!=debug)
                {
                    Console.WriteLine("bug no:{0}", debug.Bugno);
                    Console.WriteLine("developer:{0}", debug.Developer);
                    Console.WriteLine("last review:{0}", debug.Lastreview);
                    Console.WriteLine("message:{0}", debug.Message);
                }

            }
            Console.ReadKey();
        }
    }
}
