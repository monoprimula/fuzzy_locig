using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bulanik_mantik
{
    class Sure
    {
        List<string> BulanikKumeDurumu = new List<string>();
        List<double> BulanikKumeDegeri = new List<double>();

        public void BulanikKumeEkle(string durumu, double degeri)
        {
            BulanikKumeDurumu.Add(durumu);
            BulanikKumeDegeri.Add(degeri);
        }

        double pay, payda;

        public double SureHesaplama()
        {
            List<int> hassasIndexList = new List<int>();
            List<int> normalIndexHassasList = new List<int>();
            List<int> ortaIndexList = new List<int>();
            List<int> normalIndexGucluList = new List<int>();
            List<int> gucluIndexList = new List<int>();

            hassasIndexList = bul(BulanikKumeDurumu, "Kısa");
            normalIndexHassasList = bul(BulanikKumeDurumu, "NormalKısa");
            ortaIndexList = bul(BulanikKumeDurumu, "Orta");
            normalIndexGucluList = bul(BulanikKumeDurumu, "NormalUzun");
            gucluIndexList = bul(BulanikKumeDurumu, "Uzun");

            List<double> hassasListDegerler = new List<double>();
            List<double> normalListDegerler = new List<double>();
            List<double> ortaListDegerler = new List<double>();
            List<double> normalGucluListDegerler = new List<double>();
            List<double> gucluListDegerler = new List<double>();

            hassasListDegerler = degerleriAta(hassasIndexList);
            normalListDegerler = degerleriAta(normalIndexHassasList);
            ortaListDegerler = degerleriAta(ortaIndexList);
            normalGucluListDegerler = degerleriAta(normalIndexGucluList);
            gucluListDegerler = degerleriAta(gucluIndexList);


            hassasListDegerler.Sort();
            normalListDegerler.Sort();
            ortaListDegerler.Sort();
            normalGucluListDegerler.Sort();
            gucluListDegerler.Sort();

            if (hassasListDegerler.Count > 0)
                pay += hassasListDegerler[hassasListDegerler.Count - 1] * 22.3;
            if (normalListDegerler.Count > 0)
                pay += normalListDegerler[normalListDegerler.Count - 1] * 39.9;
            if (ortaListDegerler.Count > 0)
                pay += ortaListDegerler[ortaListDegerler.Count - 1] * 57.5;
            if (normalGucluListDegerler.Count > 0)
                pay += normalGucluListDegerler[normalGucluListDegerler.Count - 1] * 75.1;
            if (gucluListDegerler.Count > 0)
                pay += gucluListDegerler[gucluListDegerler.Count - 1] * 92.7;


            if (hassasListDegerler.Count > 0)
                payda += hassasListDegerler[hassasListDegerler.Count - 1];
            if (normalListDegerler.Count > 0)
                payda += normalListDegerler[normalListDegerler.Count - 1];
            if (ortaListDegerler.Count > 0)
                payda += ortaListDegerler[ortaListDegerler.Count - 1];
            if (normalGucluListDegerler.Count > 0)
                payda += normalGucluListDegerler[normalGucluListDegerler.Count - 1];
            if (gucluListDegerler.Count > 0)
                payda += gucluListDegerler[gucluListDegerler.Count - 1];
            
            return pay / payda;
        }

        public List<int> bul(List<string> hassasList, string deger)
        {
            List<int> indexler = new List<int>();
            for (int i = 0; i < hassasList.Count; i++)
            {
                if (hassasList[i] == deger)
                {
                    indexler.Add(i);
                }
            }
            return indexler;
        }

        public List<double> degerleriAta(List<int> indexList)
        {
            List<double> degerler = new List<double>();

            for (int i = 0; i < indexList.Count; i++)
            {
                degerler.Add(BulanikKumeDegeri[indexList[i]]);
            }

            return degerler;
        }
    }
}
