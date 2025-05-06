using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bulanik_mantik

{
    class Miktar
    {
        double miktarSayisi;

        public List<string> miktarDurumu = new List<string>();

        public List<double> miktarMamdani = new List<double>();

        public Miktar(double miktarSayisi)
        {
            this.miktarSayisi = miktarSayisi;
        }

        public void MiktarDurumlari()
        {
            miktarDurumu.Clear();

            if (miktarSayisi >= 0 && miktarSayisi <= 4)
            {
                miktarDurumu.Add("Küçük");
                MiktarYamukSekil(-4.5, -2.5, 2, 4.5);
            }

            if (miktarSayisi >= 3 && miktarSayisi <= 7)
            {
                miktarDurumu.Add("Orta");
                MiktarUcgenSekil(3, 5, 7);
            }

            if (miktarSayisi >= 5.5 && miktarSayisi <= 10)
            {
                miktarDurumu.Add("Büyük");
                MiktarYamukSekil(5.5, 8, 12.5, 15);
            }
        }

        private void MiktarUcgenSekil(double x1, double x2, int x3)
        {
            if (miktarSayisi == x2)
            {
                miktarMamdani.Add(1);
            }
            if (miktarSayisi >= x1 && miktarSayisi <= x2)
            {
                miktarMamdani.Add((miktarSayisi - x1) / (x2 - x1));
            }
            if (miktarSayisi >= x2 && miktarSayisi <= x3)
            {
                miktarMamdani.Add((x3 - miktarSayisi) / (x3 - x2));
            }
        }

        private void MiktarYamukSekil(double x1, double x2, double x3, double x4)
        {
            if (miktarSayisi >= x1 && miktarSayisi <= x2)
            {
                miktarMamdani.Add((miktarSayisi - x1) / (x2 - x1));
            }
            if (miktarSayisi >= x3 && miktarSayisi <= x4)
            {
                 miktarMamdani.Add((x3 - miktarSayisi) / (x3 - x2));
            }
            else
            {
                miktarMamdani.Add(1);
            }
        }

        string durumu;

        public string MiktarDurum()
        {
            foreach (string durum in miktarDurumu)
            {
                durumu += durum + " ";
            }
            return durumu;
        }
    }
}
