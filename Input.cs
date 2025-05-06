using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bulanik_mantik
{
    class Input
    {
        Hassaslik hassaslik;
        Miktar miktar;
        Kirlilik kirlilik;

        public Input(Hassaslik hassaslik,Miktar miktar,Kirlilik kirlilik)
        {
            this.hassaslik = hassaslik;
            this.miktar = miktar;
            this.kirlilik = kirlilik;
        }
    }
}
