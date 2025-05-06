using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bulanik_mantik
{
    class Kurallar
    {
        Hassaslik hassaslik;
        Miktar miktar;
        Kirlilik kirlilik;

        public static List<int> dgwId = new List<int>();

        List<double> mamdani = new List<double>();

        List<Input> input = new List<Input>();
        List<Output> output = new List<Output>();

        DonusHizi donusHizi;
        Sure sure;
        Deterjan deterjan;

        public Kurallar(Hassaslik hassaslik, Miktar miktar, Kirlilik kirlilik)
        {
            this.hassaslik = hassaslik;
            this.miktar = miktar;
            this.kirlilik = kirlilik;

            this.donusHizi = new DonusHizi() ;
            this.sure = new Sure();
            this.deterjan = new Deterjan();

            List<double> derece = new List<double>();
            dgwId.Clear();
            if ( hassaslik.hassaslikDurumu.Contains("Hassas") && 
                miktar.miktarDurumu.Contains("Küçük") &&
                kirlilik.kirlilikDurumu.Contains("Küçük") )
            {
                //1
                List<double> tempMamdani = mamdaniTemp();

                donusHizi.BulanikKumeEkle("Hassas", tempMamdani[0]);
                sure.BulanikKumeEkle("Kısa", tempMamdani[0]);
                deterjan.BulanikKumeEkle("ÇokAz", tempMamdani[0]);

                Output cikti = new Output(donusHizi, sure, deterjan);
                output.Add(cikti);

                dgwId.Add(1);
            }


            if (hassaslik.hassaslikDurumu.Contains("Hassas") &&
                miktar.miktarDurumu.Contains("Küçük") &&
                kirlilik.kirlilikDurumu.Contains("Orta"))
            {
                //2
                List<double> tempMamdani = mamdaniTemp();

                donusHizi.BulanikKumeEkle("NormalHassas", tempMamdani[0]);
                sure.BulanikKumeEkle("Kısa", tempMamdani[0]);
                deterjan.BulanikKumeEkle("Az", tempMamdani[0]);

                Output cikti = new Output(donusHizi, sure, deterjan);
                output.Add(cikti);
                dgwId.Add(2);
            }

            if (hassaslik.hassaslikDurumu.Contains("Hassas") &&
                miktar.miktarDurumu.Contains("Küçük") &&
                kirlilik.kirlilikDurumu.Contains("Büyük"))
            {
                //3
                List<double> tempMamdani = mamdaniTemp();

                donusHizi.BulanikKumeEkle("Orta", tempMamdani[0]);
                sure.BulanikKumeEkle("NormalKısa", tempMamdani[0]);
                deterjan.BulanikKumeEkle("Orta", tempMamdani[0]);

                Output cikti = new Output(donusHizi, sure, deterjan);
                output.Add(cikti);
                dgwId.Add(3);
            }

            if (hassaslik.hassaslikDurumu.Contains("Hassas") &&
                miktar.miktarDurumu.Contains("Orta") &&
                kirlilik.kirlilikDurumu.Contains("Küçük"))
            {
                //4
                List<double> tempMamdani = mamdaniTemp();

                donusHizi.BulanikKumeEkle("Hassas", tempMamdani[0]);
                sure.BulanikKumeEkle("Kısa", tempMamdani[0]);
                deterjan.BulanikKumeEkle("Orta", tempMamdani[0]);

                Output cikti = new Output(donusHizi, sure, deterjan);
                output.Add(cikti);
                dgwId.Add(4);
            }

            if (hassaslik.hassaslikDurumu.Contains("Hassas") &&
                miktar.miktarDurumu.Contains("Orta") &&
                kirlilik.kirlilikDurumu.Contains("Orta"))
            {
                //5
                List<double> tempMamdani = mamdaniTemp();

                donusHizi.BulanikKumeEkle("NormalHassas", tempMamdani[0]);
                sure.BulanikKumeEkle("NormalKısa", tempMamdani[0]);
                deterjan.BulanikKumeEkle("Orta", tempMamdani[0]);

                Output cikti = new Output(donusHizi, sure, deterjan);
                output.Add(cikti);
                dgwId.Add(5);
            }
            else
            {
                if (dgwId.Contains(5))
                {
                    dgwId.RemoveAt(5);
                }
            }

            if (hassaslik.hassaslikDurumu.Contains("Hassas") &&
                miktar.miktarDurumu.Contains("Orta") &&
                kirlilik.kirlilikDurumu.Contains("Büyük"))
            {
                // 6
                List<double> tempMamdani = mamdaniTemp();

                donusHizi.BulanikKumeEkle("Orta", tempMamdani[0]);
                sure.BulanikKumeEkle("Orta", tempMamdani[0]);
                deterjan.BulanikKumeEkle("Fazla", tempMamdani[0]);

                Output cikti = new Output(donusHizi, sure, deterjan);
                output.Add(cikti);
                dgwId.Add(6);
            }
            else
            {
                if (dgwId.Contains(5))
                {
                    dgwId.RemoveAt(5);
                }
            }

            if (hassaslik.hassaslikDurumu.Contains("Hassas") &&
                miktar.miktarDurumu.Contains("Büyük") &&
                kirlilik.kirlilikDurumu.Contains("Küçük"))
            {
                // 7
                List<double> tempMamdani = mamdaniTemp();

                donusHizi.BulanikKumeEkle("NormalHassas", tempMamdani[0]);
                sure.BulanikKumeEkle("NormalKısa", tempMamdani[0]);
                deterjan.BulanikKumeEkle("Orta", tempMamdani[0]);

                Output cikti = new Output(donusHizi, sure, deterjan);
                output.Add(cikti);
                dgwId.Add(7);
            }

            if (hassaslik.hassaslikDurumu.Contains("Hassas") &&
                miktar.miktarDurumu.Contains("Büyük") &&
                kirlilik.kirlilikDurumu.Contains("Orta"))
            {
                //8
                List<double> tempMamdani = mamdaniTemp();

                donusHizi.BulanikKumeEkle("NormalHassas", tempMamdani[0]);
                sure.BulanikKumeEkle("Orta", tempMamdani[0]);
                deterjan.BulanikKumeEkle("Fazla", tempMamdani[0]);

                Output cikti = new Output(donusHizi, sure, deterjan);
                output.Add(cikti);
                dgwId.Add(8);
            }

            if (hassaslik.hassaslikDurumu.Contains("Hassas") &&
                miktar.miktarDurumu.Contains("Büyük") &&
                kirlilik.kirlilikDurumu.Contains("Büyük"))
            {
                // 9
                List<double> tempMamdani = mamdaniTemp();

                donusHizi.BulanikKumeEkle("Orta", tempMamdani[0]);
                sure.BulanikKumeEkle("NormalUzun", tempMamdani[0]);
                deterjan.BulanikKumeEkle("Fazla", tempMamdani[0]);

                Output cikti = new Output(donusHizi, sure, deterjan);
                output.Add(cikti);
                dgwId.Add(9);
            }

            if (hassaslik.hassaslikDurumu.Contains("Orta") &&
                miktar.miktarDurumu.Contains("Küçük") &&
                kirlilik.kirlilikDurumu.Contains("Küçük"))
            {
                //10
                List<double> tempMamdani = mamdaniTemp();

                donusHizi.BulanikKumeEkle("NormalHassas", tempMamdani[0]);
                sure.BulanikKumeEkle("NormalKısa", tempMamdani[0]);
                deterjan.BulanikKumeEkle("Az", tempMamdani[0]);

                Output cikti = new Output(donusHizi, sure, deterjan);
                output.Add(cikti);
                dgwId.Add(10);
            }

            if (hassaslik.hassaslikDurumu.Contains("Orta") &&
                miktar.miktarDurumu.Contains("Küçük") &&
                kirlilik.kirlilikDurumu.Contains("Orta"))
            {
                //11
                List<double> tempMamdani = mamdaniTemp();

                donusHizi.BulanikKumeEkle("Orta", tempMamdani[0]);
                sure.BulanikKumeEkle("Kısa", tempMamdani[0]);
                deterjan.BulanikKumeEkle("Orta", tempMamdani[0]);

                Output cikti = new Output(donusHizi, sure, deterjan);
                output.Add(cikti);
                dgwId.Add(11);
            }

            if (hassaslik.hassaslikDurumu.Contains("Orta") &&
                miktar.miktarDurumu.Contains("Küçük") &&
                kirlilik.kirlilikDurumu.Contains("Büyük"))
            {
                //12
                List<double> tempMamdani = mamdaniTemp();

                donusHizi.BulanikKumeEkle("NormalGuclu", tempMamdani[0]);
                sure.BulanikKumeEkle("Orta", tempMamdani[0]);
                 deterjan.BulanikKumeEkle("Fazla", tempMamdani[0]);

                Output cikti = new Output(donusHizi, sure, deterjan);
                output.Add(cikti);
                dgwId.Add(12);
            }

            if (hassaslik.hassaslikDurumu.Contains("Orta") &&
                miktar.miktarDurumu.Contains("Orta") &&
                kirlilik.kirlilikDurumu.Contains("Küçük"))
            {
                //13
                List<double> tempMamdani = mamdaniTemp();

                donusHizi.BulanikKumeEkle("NormalHassas", tempMamdani[0]);
                sure.BulanikKumeEkle("NormalKısa", tempMamdani[0]);
                deterjan.BulanikKumeEkle("Orta", tempMamdani[0]);

                Output cikti = new Output(donusHizi, sure, deterjan);
                output.Add(cikti);
                dgwId.Add(13);
            }

            if (hassaslik.hassaslikDurumu.Contains("Orta") &&
                miktar.miktarDurumu.Contains("Orta") &&
                kirlilik.kirlilikDurumu.Contains("Orta"))
            {
                //14
                List<double> tempMamdani = mamdaniTemp();

                donusHizi.BulanikKumeEkle("Orta", tempMamdani[0]);
                sure.BulanikKumeEkle("Orta", tempMamdani[0]);
                deterjan.BulanikKumeEkle("Orta", tempMamdani[0]);

                Output cikti = new Output(donusHizi, sure, deterjan);
                output.Add(cikti);
                dgwId.Add(14);
            }

            if (hassaslik.hassaslikDurumu.Contains("Orta") &&
                miktar.miktarDurumu.Contains("Orta") &&
                kirlilik.kirlilikDurumu.Contains("Büyük"))
            {
                //15
                List<double> tempMamdani = mamdaniTemp();

                donusHizi.BulanikKumeEkle("Hassas", tempMamdani[0]);
                sure.BulanikKumeEkle("Uzun", tempMamdani[0]);
                deterjan.BulanikKumeEkle("Fazla", tempMamdani[0]);

                Output cikti = new Output(donusHizi, sure, deterjan);
                output.Add(cikti);
                dgwId.Add(15);
            }

            if (hassaslik.hassaslikDurumu.Contains("Orta") &&
                miktar.miktarDurumu.Contains("Büyük") &&
                kirlilik.kirlilikDurumu.Contains("Küçük"))
            {
                //16
                List<double> tempMamdani = mamdaniTemp();

                donusHizi.BulanikKumeEkle("Hassas", tempMamdani[0]);
                sure.BulanikKumeEkle("Orta", tempMamdani[0]);
                deterjan.BulanikKumeEkle("Orta", tempMamdani[0]);

                Output cikti = new Output(donusHizi, sure, deterjan);
                output.Add(cikti);
                dgwId.Add(16);
            }

            if (hassaslik.hassaslikDurumu.Contains("Orta") &&
                miktar.miktarDurumu.Contains("Büyük") &&
                kirlilik.kirlilikDurumu.Contains("Orta"))
            {
                //17
                List<double> tempMamdani = mamdaniTemp();

                donusHizi.BulanikKumeEkle("Hassas", tempMamdani[0]);
                sure.BulanikKumeEkle("NormalUzun", tempMamdani[0]);
                deterjan.BulanikKumeEkle("Fazla", tempMamdani[0]);

                Output cikti = new Output(donusHizi, sure, deterjan);
                output.Add(cikti);
                dgwId.Add(17);
            }

            if (hassaslik.hassaslikDurumu.Contains("Orta") &&
                miktar.miktarDurumu.Contains("Büyük") &&
                kirlilik.kirlilikDurumu.Contains("Büyük"))
            {
                //18
                List<double> tempMamdani = mamdaniTemp();

                donusHizi.BulanikKumeEkle("Hassas", tempMamdani[0]);
                sure.BulanikKumeEkle("Uzun", tempMamdani[0]);
                deterjan.BulanikKumeEkle("CokFazla", tempMamdani[0]);

                Output cikti = new Output(donusHizi, sure, deterjan);
                output.Add(cikti);
                dgwId.Add(18);
            }

            if (hassaslik.hassaslikDurumu.Contains("Sağlam") &&
                miktar.miktarDurumu.Contains("Küçük") &&
                kirlilik.kirlilikDurumu.Contains("Küçük"))
            {
                //19
                List<double> tempMamdani = mamdaniTemp();

                donusHizi.BulanikKumeEkle("Orta", tempMamdani[0]);
                sure.BulanikKumeEkle("Orta", tempMamdani[0]);
                deterjan.BulanikKumeEkle("Az", tempMamdani[0]);

                Output cikti = new Output(donusHizi, sure, deterjan);
                output.Add(cikti);
                dgwId.Add(19);
            }

            if (hassaslik.hassaslikDurumu.Contains("Sağlam") &&
                miktar.miktarDurumu.Contains("Küçük") &&
                kirlilik.kirlilikDurumu.Contains("Orta"))
            {
                //20
                List<double> tempMamdani = mamdaniTemp();

                 donusHizi.BulanikKumeEkle("NormalGuclu", tempMamdani[0]);
                 sure.BulanikKumeEkle("Orta", tempMamdani[0]);
                 deterjan.BulanikKumeEkle("Orta", tempMamdani[0]);

                Output cikti = new Output(donusHizi, sure, deterjan);
                output.Add(cikti);
                dgwId.Add(20);
            }

            if (hassaslik.hassaslikDurumu.Contains("Sağlam") &&
                miktar.miktarDurumu.Contains("Küçük") &&
                kirlilik.kirlilikDurumu.Contains("Büyük"))
            {
                //21
                List<double> tempMamdani = mamdaniTemp();

                donusHizi.BulanikKumeEkle("Guclu", tempMamdani[0]);
                sure.BulanikKumeEkle("NormalUzun", tempMamdani[0]);
                deterjan.BulanikKumeEkle("Fazla", tempMamdani[0]);

                Output cikti = new Output(donusHizi, sure, deterjan);
                output.Add(cikti);
                dgwId.Add(21);
            }

            if (hassaslik.hassaslikDurumu.Contains("Sağlam") &&
                miktar.miktarDurumu.Contains("Orta") &&
                kirlilik.kirlilikDurumu.Contains("Küçük"))
            {
                //22
                List<double> tempMamdani = mamdaniTemp();

                donusHizi.BulanikKumeEkle("Orta", tempMamdani[0]);
                sure.BulanikKumeEkle("Orta", tempMamdani[0]);
                deterjan.BulanikKumeEkle("Orta", tempMamdani[0]);

                Output cikti = new Output(donusHizi, sure, deterjan);
                output.Add(cikti);
                dgwId.Add(22);
            }

            if (hassaslik.hassaslikDurumu.Contains("Sağlam") &&
                miktar.miktarDurumu.Contains("Orta") &&
                kirlilik.kirlilikDurumu.Contains("Orta"))
            {
                //23
                List<double> tempMamdani = mamdaniTemp();

                donusHizi.BulanikKumeEkle("NormalGuclu", tempMamdani[0]);
                sure.BulanikKumeEkle("NormalUzun", tempMamdani[0]);
                deterjan.BulanikKumeEkle("Orta", tempMamdani[0]);

                Output cikti = new Output(donusHizi, sure, deterjan);
                output.Add(cikti);
                dgwId.Add(23);
            }

            if (hassaslik.hassaslikDurumu.Contains("Sağlam") &&
                miktar.miktarDurumu.Contains("Orta") &&
                kirlilik.kirlilikDurumu.Contains("Büyük"))
            {
                //24
                List<double> tempMamdani = mamdaniTemp();

                 donusHizi.BulanikKumeEkle("Guclu", tempMamdani[0]);
                 sure.BulanikKumeEkle("Orta", tempMamdani[0]);
                 deterjan.BulanikKumeEkle("CokFazla", tempMamdani[0]);

                Output cikti = new Output(donusHizi, sure, deterjan);
                output.Add(cikti);
                dgwId.Add(24);
            }

            if (hassaslik.hassaslikDurumu.Contains("Sağlam") &&
                miktar.miktarDurumu.Contains("Büyük") &&
                kirlilik.kirlilikDurumu.Contains("Küçük"))
            {
                //25
                List<double> tempMamdani = mamdaniTemp();

                 donusHizi.BulanikKumeEkle("NormalGuclu", tempMamdani[0]);
                 sure.BulanikKumeEkle("NormalUzun", tempMamdani[0]);
                 deterjan.BulanikKumeEkle("Fazla", tempMamdani[0]);

                Output cikti = new Output(donusHizi, sure, deterjan);
                output.Add(cikti);
                dgwId.Add(25);
            }

            if (hassaslik.hassaslikDurumu.Contains("Sağlam") &&
                miktar.miktarDurumu.Contains("Büyük") &&
                kirlilik.kirlilikDurumu.Contains("Orta"))
            {
                //26
                List<double> tempMamdani = mamdaniTemp();

                 donusHizi.BulanikKumeEkle("NormalGuclu", tempMamdani[0]);
                 sure.BulanikKumeEkle("Uzun", tempMamdani[0]);
                 deterjan.BulanikKumeEkle("Fazla", tempMamdani[0]);

                Output cikti = new Output(donusHizi, sure, deterjan);
                output.Add(cikti);
                dgwId.Add(26);
            }

            if (hassaslik.hassaslikDurumu.Contains("Sağlam") &&
                miktar.miktarDurumu.Contains("Büyük") &&
                kirlilik.kirlilikDurumu.Contains("Büyük"))
            {
                //27
                List<double> tempMamdani = mamdaniTemp();

                 donusHizi.BulanikKumeEkle("Guclu", tempMamdani[0]);
                 sure.BulanikKumeEkle("Uzun", tempMamdani[0]);
                 deterjan.BulanikKumeEkle("CokFazla", tempMamdani[0]);

                Output cikti = new Output(donusHizi, sure, deterjan);
                output.Add(cikti);
                dgwId.Add(27);
            }
        }
        public string GetAktifKurallarAsText()
        {
            StringBuilder sb = new StringBuilder();

            if (dgwId != null && dgwId.Count > 0)
            {
                foreach (int kuralId in dgwId)
                {
                    sb.AppendLine($"Kural {kuralId}");
                }
            }

            return sb.ToString();
        }
        public List<double> mamdaniTemp()
        {
            List<double> tempMamdani = new List<double>();

            hassaslik.HassaslikDurumlari();

            for (int i = 0; i < hassaslik.hassaslikMamdani.Count; i++)
            {
                tempMamdani.Add(hassaslik.hassaslikMamdani[i]);
            }

            miktar.MiktarDurumlari();

            for (int i = 0; i < miktar.miktarMamdani.Count; i++)
            {
                tempMamdani.Add(miktar.miktarMamdani[i]);
            }

            kirlilik.KirlilikDurumlari();

            for (int i = 0; i < kirlilik.kirlilikMamdani.Count; i++)
            {
                tempMamdani.Add(kirlilik.kirlilikMamdani[i]);
            }
            // Bütün hesaplamalardan sıralamasını yapıyoruz ve en küçüğünü alınacak
            tempMamdani.Sort();
            return tempMamdani;
        }

        public List<double> ciktilar()
        {
            List<double> cikti = new List<double>();

            cikti.Add(donusHizi.DonusHiziHesaplama());
            cikti.Add(sure.SureHesaplama());
            cikti.Add(deterjan.DeterjanHesaplama());

            return cikti;
        }

    }

}
