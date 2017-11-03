using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test_30_3
{
    class Program
    {
         public unsafe static void Main(string[] args)
        {
            Console.WriteLine("Unsafe code trong c#");
            Console.WriteLine("Truy cap phan tu mang su dung con tro");
            Console.WriteLine("-----------------");

            int[] list = { 10, 20, 30 };
            fixed (int* p = list) 
            //mang dia chi trong con tro

            for (int i=0;i<3;i++)
            {
                Console.WriteLine("dia chi cua list[{0}]={1}", i, (int)(p + i));
                Console.WriteLine("gia tri cua list [{0}]={1}", i, *(p + i));

            }
            Console.ReadKey();
        }//unsafe code ám chỉ một khối code dùng con trỏ , khi dùng khai báo từ khóa unsafe ở class hoặc hàm main , dieu chinh property cua solution (build -> unsafe code) ctrl+s (save))
    }
}
