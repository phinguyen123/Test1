using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test_25
{
    class Program
    {
        private string[] namelist = new string[size];
        static public int size = 10;
        public Program()
        {
            for (int i = 0; i < size; i++)
                namelist[i] = "N/A";
        }
        public string this [int index]
        {
            get
            {
                string tmp;
                if (index >= 0 && index <= size - 1)
                    tmp = namelist[index];
                else
                    tmp = " ";

                return tmp;
            }
            set
            {
                if (index >= 0 && index <= size - 1)
                    namelist[index] = value;
            }

        }
        static void Main(string[] args)
        {
            Console.WriteLine("INDERDEX trong c#:");
            Console.WriteLine("--------------");

            Program a = new Program();
            a[0] = "nguyen";
            a[1] = "phuc ";
            a[2] = "phi";

            for(int i=0;i<Program.size;i++)
            {
                Console.WriteLine(a[i]);

            }
            Console.ReadKey();
        }
    }
}
