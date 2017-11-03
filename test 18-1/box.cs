using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test_18_1
{
    class box
    {
        private double chieudai;
        private double chieurong;
        private double chieucao;

        public void setchieudai (double a)
        {
            chieudai = a;
        }
        public void setchieucao(double b)
        {
            chieucao = b;
        }
        public void setchieurong(double c)
        {
            chieurong = c;
        }

        public double tinhdientich()
        {
            return chieurong * chieucao * chieudai;
        }

     //////////////////////////////////
     // +
     public static box operator +(box a,box b)
        {
            box c = new box();
            c.chieudai = a.chieudai + b.chieudai;
            c.chieurong = a.chieurong + b.chieurong;
            c.chieucao = a.chieudai + b.chieudai;
            return c;
        }
    // ==
      public static bool operator ==(box a,box b)
        {
            bool c = false;
                if (a.chieudai == b.chieudai && a.chieucao == b.chieucao && a.chieurong == b.chieurong)
                    c = true;
            
            return c;
        }
       // !=
       public static bool operator !=(box a,box b)
        {
            bool c = false;
            if (a.chieudai != b.chieudai || a.chieucao != b.chieucao || a.chieurong != b.chieurong)
                c = true;

            return c;
        }
        // <
        public static bool operator <(box a,box b)
        {
            bool c = false;
            if (a.chieurong < b.chieurong && a.chieucao < b.chieucao && a.chieurong < b.chieurong)
                c = true;

            return c;
        }
        // >
        public static bool operator >(box a,box b)
        {
            bool c = false;
            if (a.chieurong > b.chieurong && a.chieudai > b.chieudai && a.chieucao > b.chieucao)
                c = true;

            return c;
        }
        public override string ToString()
        {
            return String.Format("[{0},{1},{2}]", chieudai, chieurong, chieucao);
        }
    }
}
