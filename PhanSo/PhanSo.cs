using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PhanSo
{
    public class PhanSo
    {
        private int tuSo, mauSo;//tu so, mauso

        public PhanSo(int t, int m)
        {
            if (m == 0)
                throw new ArgumentException("SAI DU LIEU");

            this.tuSo = t;
            this.mauSo = m;
        }

        public static bool soSanh(PhanSo p1, PhanSo p2)
        {
            int t1 = p1.tuSo * p2.mauSo;
            int t2 = p1.mauSo * p2.tuSo;

            return t1 == t2;
        }
    }
}
