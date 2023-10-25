using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTVNTuan7
{
    internal class CBietthu : CCompanyBDS, IPhiKinhDoanh
    {
        public override void inTT()
        {
            base.xuatTT();
            Console.Write($"{KinhPhiKD(), -8}, {PThucTinhGT()}");
        }

        public double KinhPhiKD()
        {
            return Dientich() * 1000;
        }

        public override double PThucTinhGT()
        {
            return Dientich() * 400000;
        }
    }
}
