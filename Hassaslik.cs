/*
 * Bu kod çamaşırların hassaslık değerlerini bulanık kümelere çeviren sınıftır.
 * Girilen hassaslık değerine göre Sağlam, Orta ve Hassas üyelik fonksiyonlarını kullanarak
 * bulanık değerleri hesaplar.
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bulanik_mantik
{
    class Hassaslik
    {
        double hassaslikSayisi;
        public List<string> hassaslikDurumu = new List<string>();
        public List<double> hassaslikMamdani = new List<double>();

        public Hassaslik(double hassaslikSayisi)
        {
            this.hassaslikSayisi = hassaslikSayisi;
        }

        public void HassaslikDurumlari()
        {
            hassaslikDurumu.Clear();
            if (hassaslikSayisi >= 0 && hassaslikSayisi <= 4)
            {
                hassaslikDurumu.Add("Sağlam");
                HassaslikYamukSekil(-4, -1.5, 2, 4);
            }
            if (hassaslikSayisi >= 3 && hassaslikSayisi <= 7)
            {
                hassaslikDurumu.Add("Orta");
                HassaslikUcgenSekil(3, 5, 7);
            }
            if (hassaslikSayisi >= 5.5 && hassaslikSayisi <= 10)
            {
                hassaslikDurumu.Add("Hassas");
                HassaslikYamukSekil(5.5, 8, 12.5, 14);
            }
        }

        public void HassaslikYamukSekil(double x1, double x2, double x3, double x4)
        {
            if (hassaslikSayisi >= x1 && hassaslikSayisi <= x2)
            {
                hassaslikMamdani.Add((hassaslikSayisi - x1) / (x2 - x1));
            }
            if (hassaslikSayisi >= x3 && hassaslikSayisi <= x4)
            {
                hassaslikMamdani.Add((x3 - hassaslikSayisi) / (x3 - x2));
            }
            else
            {
                hassaslikMamdani.Add(1);
            }
        }

        public void HassaslikUcgenSekil(double x1, double x2, double x3)
        {
            if (hassaslikSayisi == x2)
            {
                hassaslikMamdani.Add(1);
            }
            if (hassaslikSayisi >= x1 && hassaslikSayisi <= x2)
            {
                hassaslikMamdani.Add((hassaslikSayisi - x1) / (x2 - x1));
            }
            if (hassaslikSayisi >= x2 && hassaslikSayisi <= x3)
            {
                hassaslikMamdani.Add((x3 - hassaslikSayisi) / (x3 - x2));
            }
        }

        string durumu;
        public string HassasDurum()
        {
            foreach (string durum in hassaslikDurumu)
            {
                durumu += durum + " ";
            }
            return durumu;
        }
    }
}