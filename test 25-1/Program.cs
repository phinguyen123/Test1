using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test_25_1
{
    class Program
    {
        private string[] name = new string[size];
       static public int size = 10;
        public Program()
        {
            for (int i=0;i<size;i++)
            {
                name[i] = "n/a";
            }
        }
        public string this [int index]
        {
            get
            {
                string tmp;
                if (index >= 0 && index <= size - 1)
                {
                    tmp = name[index];
                }
                else
                    tmp = " ";

                return tmp;
            }
            set
            {
                if (index >= 0 && index <= size - 1)
                    name[index] = value;
            }
        }
        public int this [string a]
        {
            get
            {
                int b = 0;
                while(b<size)
                {
                    if (name[b] == a)
                    {
                        return b;
                    }
                    b++;
                }
                return b;
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Inderdex trong c#:");
            Console.WriteLine("------");

            Program a = new Program();
            a[0] = "nguyen";
            a[1] = "phuc";
            a[2] = "phi";
            a[3] = "kirito";
            for (int i = 0; i < size; i++)
            {
                Console.WriteLine(a[i]);
            }
            //test dieu kien
            Console.WriteLine(a["kirito"]);
            Console.ReadKey();
        }
    }  //chuc nang inderdex chu yeu dung trong mang ,de rut gon khong can goi ten phuong thuc hay ten mang chi can goi ten class la du 
}
