using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test_18
{
    class box
    {
        private int chieudai;
        private int chieurong;
        private int chieucao;

        public int tinhthetich()
        {
            return chieucao * chieurong * chieudai;
        }
        public void setchieudai(int a)
        {
            chieudai = a;
        }
        public void setchieurong( int b)
        {
            chieurong = b;
        }
        public void setchieucao (int c)
        {
            chieucao = c;
        }

        public static box operator +(box a,box b)
        {
            box c = new box();
            c.chieucao = a.chieucao + b.chieucao;
            c.chieudai = a.chieudai + b.chieudai;
            c.chieurong = a.chieurong + b.chieurong;
            return c;
        }
    }
}
