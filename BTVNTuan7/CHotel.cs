using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTVNTuan7
{
    internal class CHotel:CCompanyBDS, IPhiKinhDoanh
    {
        private double Sosao;

        public CHotel()
        {

        }

        public CHotel(string maso, double chieudai, double chieurong, double sosao) : base(maso, chieudai, chieurong)
        {
            this.Sosao = sosao;
        }

        public override void inTT()
        {
            base.xuatTT();
            Console.Write($"{Sosao, -7} {KinhPhiKD()} {PThucTinhGT()}");
        }

        public double KinhPhiKD()
        {
            return Chieurong * 5000;
        }

        public override double PThucTinhGT()
        {
            return Dientich() * 100000 + Sosao * 50000;
        }
    }
}
