using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
delegate int numberchange(int n);
namespace test_26_1
{
    class Program
    {
        static int b = 10;
        public static int add(int a)
        {
            b += a;
            return b;
        }
        public static int mul(int a)
        {
            b *= a;
            return b;
        }
        public static int get()
        {
            return b;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Test delegate trong c#:");
            Console.WriteLine("---------------");

            numberchange a = new numberchange(add);
            numberchange b = new numberchange(mul);
            numberchange c;

            c = a;
            c += b;

            c(5);
            Console.WriteLine("ket qua :{0}", get());
            b(5);
            Console.WriteLine("ket qua nhan:{0}", get());
            Console.ReadKey();
        }
    }//delegate dung de dai dien cac phuong thuc ,no vua la doi tuong vua la phuong thuc ,hoat dong giong nhu con tro, nó dùng để đại diện các hàm có phương thức giống nó ví dụ như trên ở delegate numberchange với hàm add (có tham số và kiểu trả về giống nhau) '' dùng để code ngắn gọn ,dễ hiểu
}
