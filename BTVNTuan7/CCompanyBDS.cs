using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTVNTuan7
{
    internal abstract class CCompanyBDS
    {
        protected string Maso;
        protected double Chieudai;
        protected double Chieurong;

        protected CCompanyBDS()
        {

        }

        protected CCompanyBDS(string maso, double chieudai, double chieurong)
        {
            Maso = maso;
            Chieudai = chieudai;
            Chieurong = chieurong;
        }

        public virtual void xuatTT()
        {
            Console.Write($"{Maso, -5} {Chieudai, -7} {Chieurong, -7}");
        }

        public double Dientich()
        {
            return Chieudai * Chieurong;
        }

        public abstract double PThucTinhGT();
        public abstract void inTT();
    }
}
