using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Bu kod bulanık mantık (fuzzy logic) kullanarak kirlilik seviyesini değerlendiren bir sınıf içerir
// Kirlilik seviyesi, sayısal bir değere göre "Küçük", "Orta" veya "Büyük" olarak sınıflandırılır
// Üyelik fonksiyonları olarak üçgen ve yamuk şekilleri kullanılmaktadır
namespace bulanik_mantik
{
    class Kirlilik
    {
        double kirlilikSayisi;
        public List<string> kirlilikDurumu = new List<string>();
        public List<double> kirlilikMamdani = new List<double>();

        public Kirlilik(double kirlilikSayisi)
        {
            this.kirlilikSayisi = kirlilikSayisi;
        }

        public void KirlilikDurumlari()
        {
            kirlilikDurumu.Clear();
            kirlilikMamdani.Clear(); // Mamdani değerlerini de temizleme eklendi

            if (kirlilikSayisi >= 0 && kirlilikSayisi <= 4)
            {
                kirlilikDurumu.Add("Küçük");
                KirlilikYamukSekil(-4, -1.5, 2, 4);
            }
            if (kirlilikSayisi >= 3 && kirlilikSayisi <= 7)
            {
                kirlilikDurumu.Add("Orta");
                KirlilikUcgenSekil(3, 5, 7);
            }
            if (kirlilikSayisi >= 5.5 && kirlilikSayisi <= 10)
            {
                kirlilikDurumu.Add("Büyük");
                KirlilikYamukSekil(5.5, 8, 12.5, 14);
            }
        }

        // Üçgen şeklinde üyelik fonksiyonu hesaplama
        private void KirlilikUcgenSekil(double x1, double x2, double x3)
        {
            if (kirlilikSayisi == x2)
            {
                kirlilikMamdani.Add(1);
            }
            else if (kirlilikSayisi >= x1 && kirlilikSayisi <= x2)
            {
                kirlilikMamdani.Add((kirlilikSayisi - x1) / (x2 - x1));
            }
            else if (kirlilikSayisi >= x2 && kirlilikSayisi <= x3)
            {
                kirlilikMamdani.Add((x3 - kirlilikSayisi) / (x3 - x2));
            }
        }

        // Yamuk şeklinde üyelik fonksiyonu hesaplama
        private void KirlilikYamukSekil(double x1, double x2, double x3, double x4)
        {
            if (kirlilikSayisi >= x1 && kirlilikSayisi <= x2)
            {
                kirlilikMamdani.Add((kirlilikSayisi - x1) / (x2 - x1));
            }
            else if (kirlilikSayisi >= x2 && kirlilikSayisi <= x3)
            {
                // x2 ile x3 arasında üyelik değeri 1 olmalı
                kirlilikMamdani.Add(1);
            }
            else if (kirlilikSayisi >= x3 && kirlilikSayisi <= x4)
            {
                // Bu kısım orijinal kodda hatalı - düzeltildi
                kirlilikMamdani.Add((x4 - kirlilikSayisi) / (x4 - x3));
            }
        }

        string durumu;
        public string KirlilikDurum()
        {
            // durumu değişkenini her çağrıda sıfırlama eklendi
            durumu = "";
            foreach (string durum in kirlilikDurumu)
            {
                durumu += durum + " ";
            }
            return durumu;
        }
    }
}