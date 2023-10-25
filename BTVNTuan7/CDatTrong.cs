using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTVNTuan7
{
    internal class CDatTrong : CCompanyBDS
    {
        public CDatTrong(string maso, double chieudai, double chieurong) : base(maso, chieudai, chieurong)
        {

        }

        public override void inTT()
        {
            base.xuatTT();
            Console.Write($"{PThucTinhGT(), -10}");
        }

        public override double PThucTinhGT()
        {
            return Dientich() * 10000;
        }
    }
}
