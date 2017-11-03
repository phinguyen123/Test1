using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test_27
{
    class even_test
    {
        private int value;
        public delegate void number();
        public event number changenum;
        protected void onnumchange()
        {
            if (changenum != null)
                changenum();
            else
                Console.WriteLine("kich hoat su kien");
        }
        public even_test (int n)
        {
            setvalue(n);
        }
        public void setvalue(int n)
        {
            if (value != n)
            {
                value = n;
                onnumchange();
            }
        }
    }
}//event la cac thao tac,hanh dong cua nguoi dung ,la property cua delegate (delegate thường là 1 field ) ,muon co event thi phai co delegate ,dung de kiem tra, giam sat chuong trinh khi co su thay doi 
