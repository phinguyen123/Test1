using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test_22
{
    class Program
    {
        int result;
        Program()
        {
            result = 0;
        }
        public void phepchia(int a, int b)
        {
            try
            {
                result = a / b;
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine("bat exception: {0}", e);
            }
            finally
            {
                Console.WriteLine("ket qua :{0}", result);
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Minh hoa exception trong c#:");
            Console.WriteLine("---------------");

            Program a = new Program();
            a.phepchia(25, 0);
            Console.ReadKey();
            
        }
    }
}
