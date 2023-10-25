using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTVNTuan7
{
    internal class CNhao:CCompanyBDS
    {
        private int Solau;

        public CNhao()
        {

        }

        public CNhao(string maso, double chieudai, double chieurong, int Solau) : base(maso, chieudai, chieurong)
        {
            this.Solau = Solau;
        }

        public override void inTT()
        {
            base.xuatTT();
            Console.Write($"{Solau, -7} {PThucTinhGT()}");
        }

        public override double PThucTinhGT()
        {
            return Dientich() * 1000 * Solau * 100000;
        }
    }
}
