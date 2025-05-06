using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bulanik_mantik
{
    class Output
    {
        public DonusHizi donusHizi;
        public Sure sure;
        public Deterjan deterjan;

        public Output(DonusHizi donusHizi, Sure sure, Deterjan deterjan)
        {
            this.donusHizi = donusHizi;
            this.sure = sure;
            this.deterjan = deterjan;
        }

        public double sonuclar()
        {
            return donusHizi.DonusHiziHesaplama();
        }
    }
}
