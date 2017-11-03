using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test_12
{
    class Program
    {
        struct books
        {
            public string tensach;
            public string tacgia;
            public string theloai;
            public int id;
        };
        static void Main(string[] args)
        {
            Console.WriteLine("Struct trong c#:");
            Console.WriteLine("----------------");
            books a, b;

            a.tensach = "Dai so";
            a.tacgia = "Kirito";
            a.theloai = "Toan";
            a.id = 01;

            b.tensach = "Hinh hoc";
            b.tacgia = "Asuna";
            b.theloai = "Toan";
            b.id = 02;

            Console.WriteLine("Thong tin sach a:");
            Console.WriteLine("Ten sach: {0}", a.tensach);
            Console.WriteLine("Tac gia: {0}", a.tacgia);
            Console.WriteLine("The loai:{0}", a.theloai);
            Console.WriteLine("ID: {0}", a.id);

            Console.WriteLine("Thong tin sach b:");
            Console.WriteLine("Ten sach: {0}", b.tensach);
            Console.WriteLine("Tac gia: {0}", b.tacgia);
            Console.WriteLine("The loai: {0}", b.theloai);
            Console.WriteLine("ID:{0}", b.id);
            Console.ReadKey();
        }
    }
}
