using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test_15_1
{
    class demostatic
    {
        public static int num; //Su dung bien static: neu dung bien static thi ket qua num tra ve la cac phuong thuc duoc goi lan luot (giong nhu chi dung 1 object mac du khai bao nhieu object khac nhau va ket qua tra ve la object chung do ,chu khong phai la tung cai object cu the )vi static dung chung k can tao object va k phu thuoc object ,con neu k dung static thi in ra ket qua tung doi tuong cu the
        public void count()
        {
            num++;
        }
        public void sub()
        {
            num--;
        }
        public static int get() //Su dung ham static : neu dung ham static thi can phai khai bao bien static (vi ham static chi dung cho bien static) va khi goi phuong thuc thi chi dung ten class khong can dung ten object cu the vi dung chung ,con neu khong dung static thi su dung binh thuong (goi ten object cho cac phuong thuc) va dung nhu bien static o tren( co the su dung in ra ket qua chung neu dung bien static va in ra ket qua cu the tung cai khi khong dung bien static)
        {
            return num;
        }
    }
    public class test
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Static trong c#:");
            Console.WriteLine("-------------");

            demostatic a = new demostatic();
            demostatic b = new demostatic();
            demostatic c = new demostatic();
            //thuc hien lenh count
            a.count();
            a.count();
            a.count();
            b.count();
            b.sub();
            b.count();//Cac phuong thuc tuy do cac object khac nhau thuc thi nhung khi dung static thi chi co 1 object duy nhat duoc thuc thi tat ca cac phuong thuc ma doi tuong duoc goi 
            c.count();
            c.count();
            c.count();
            c.count();          
            //Console.WriteLine("Ket qua:{0} va {1} va {2}", a.get(),b.get(),c.get());// neu bien num duoc khai bao static thi ket qua la 9 vi chi dung chung 1 object de thuc hien cac phuong thuc + va - (du ta khai bao 3 object a,b,c) ,con neu k dung static thi ket qua se in ra cu the cho tung object a,b,c 
           Console.WriteLine("Ket qua:{0}", demostatic.get());
            Console.ReadKey();
            //co the hieu static dung chung 1 doi tuong cu the ma khong can phai tao object ,ket qua la ket qua chung cua cac object nho (neu ta tao van duoc) (tao object thi dung new)
        }
    }
}
