using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bulanik_mantik
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            DgwDoldur();

            // Chartlar için gerekli düzenlemeler
            var chartOne = chart1.ChartAreas[0];
            chartOne.AxisX.Minimum = 0;
            chartOne.AxisX.Maximum = 10;
            chartOne.AxisX.Interval = 1;
            chartOne.AxisY.Maximum = 0;
            chartOne.AxisY.Maximum = 1.2;

            var chartTwo = chart2.ChartAreas[0];
            chartTwo.AxisX.Minimum = 0;
            chartTwo.AxisX.Maximum = 10;
            chartTwo.AxisX.Interval = 1;
            chartTwo.AxisY.Maximum = 0;
            chartTwo.AxisY.Maximum = 1.2;

            var chartThree = chart3.ChartAreas[0];
            chartThree.AxisX.Minimum = 0;
            chartThree.AxisX.Maximum = 10;
            chartThree.AxisX.Interval = 1;
            chartThree.AxisY.Maximum = 0;
            chartThree.AxisY.Maximum = 1.2;


        }
        private System.Windows.Forms.ListBox lstAktifKurallar;


        // DataGridView'da gösterilecek veriler
        public void DgwDoldur()
        {
            dgw_Veriler.Rows.Add(1, "Hassas", "Küçük", "Küçük", "Hassas", "Kısa", "Çok Az");
            dgw_Veriler.Rows.Add(2, "Hassas", "Küçük", "Orta", "Normal Hassas", "Kısa", "Az");
            dgw_Veriler.Rows.Add(3, "Hassas", "Küçük", "Büyük", "Orta", "Normal Kısa", "Orta");

            dgw_Veriler.Rows.Add(4, "Hassas", "Orta", "Küçük", "Hassas", "Kısa", "Orta");
            dgw_Veriler.Rows.Add(5, "Hassas", "Orta", "Orta", "Normal Hassas", "Normal Kısa", "Orta");
            dgw_Veriler.Rows.Add(6, "Hassas", "Orta", "Büyük", "Orta", "Orta", "Fazla");

            dgw_Veriler.Rows.Add(7, "Hassas", "Büyük", "Küçük", "Normal Hassas", "Normal Kısa", "Orta");
            dgw_Veriler.Rows.Add(8, "Hassas", "Büyük", "Orta", "Normal Hassas", "Orta", "Fazla");
            dgw_Veriler.Rows.Add(9, "Hassas", "Büyük", "Büyük", "Orta", "Normal Uzun", "Fazla");

            dgw_Veriler.Rows.Add(10, "Orta", "Küçük", "Küçük", "Normal Hassas", "Normal Kısa", "Az");
            dgw_Veriler.Rows.Add(11, "Orta", "Küçük", "Orta", "Orta", "Kısa", "Orta");
            dgw_Veriler.Rows.Add(12, "Orta", "Küçük", "Büyük", "Normal Güçlü", "Orta", "Fazla");

            dgw_Veriler.Rows.Add(13, "Orta", "Orta", "Küçük", "Normal Hassas", "Normal Kısa", "Orta");
            dgw_Veriler.Rows.Add(14, "Orta", "Orta", "Orta", "Orta", "Orta", "Orta");
            dgw_Veriler.Rows.Add(15, "Orta", "Orta", "Büyük", "Hassas", "Uzun", "Fazla");

            dgw_Veriler.Rows.Add(16, "Orta", "Büyük", "Küçük", "Hassas", "Orta", "Orta");
            dgw_Veriler.Rows.Add(17, "Orta", "Büyük", "Orta", "Hassas", "Normal Uzun", "Fazla");
            dgw_Veriler.Rows.Add(18, "Orta", "Büyük", "Büyük", "Hassas", "Uzun", "Çok Fazla");

            dgw_Veriler.Rows.Add(19, "Sağlam", "Küçük", "Küçük", "Hassas", "Kısa", "Az");
            dgw_Veriler.Rows.Add(20, "Sağlam", "Küçük", "Orta", "Hassas", "Kısa", "Orta");
            dgw_Veriler.Rows.Add(21, "Sağlam", "Küçük", "Büyük", "Güçlü", "Normal Uzun", "Fazla");

            dgw_Veriler.Rows.Add(22, "Sağlam", "Orta", "Küçük", "Orta", "Orta", "Orta");
            dgw_Veriler.Rows.Add(23, "Sağlam", "Orta", "Orta", "Normal Güçlü", "Normal Uzun", "Orta");
            dgw_Veriler.Rows.Add(24, "Sağlam", "Orta", "Büyük", "Güçlü", "Orta", "Çok Fazla");

            dgw_Veriler.Rows.Add(25, "Sağlam", "Büyük", "Küçük", "Normal Güçlü", "Normal Uzun", "Fazla");
            dgw_Veriler.Rows.Add(26, "Sağlam", "Büyük", "Orta", "Normal Güçlü", "Uzun", "Fazla");
            dgw_Veriler.Rows.Add(27, "Sağlam", "Büyük", "Büyük", "Güçlü", "Uzun", "Çok Fazla");
        }

        

        private void nud_Hassaslik_ValueChanged(object sender, EventArgs e)
        {
            // Kullanıcıdan almış olduğum değerleri alıyoruz
            Hassaslik hassaslik = new Hassaslik((double)nud_Hassaslik.Value);
            Miktar miktar = new Miktar((double)nud_Miktar.Value);
            Kirlilik kirlilik = new Kirlilik((double)nud_Kirlilik.Value);

            FuzzyLogic fuzzyLogic = new FuzzyLogic(hassaslik,miktar,kirlilik);

            // Sonuçların Gösterilmesi
            label13.Text = fuzzyLogic.sonuclar[0].ToString();
            label14.Text = fuzzyLogic.sonuclar[1].ToString();
            label15.Text = fuzzyLogic.sonuclar[2].ToString();

            
            for(int i = 0; i < 27; i++)
            {
                dgw_Veriler.Rows[i].Selected = false;
            }
            // Datagridviewda işaretleme
            for (int i = 0; i < Kurallar.dgwId.Count; i++)
            {
                dgw_Veriler.Rows[Kurallar.dgwId[i] - 1].Selected = true;
            }

            lbl_Hassaslik.Text = hassaslik.HassasDurum();
            lbl_Miktar.Text = miktar.MiktarDurum();
            lbl_Kirlilik.Text = kirlilik.KirlilikDurum();
        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void chart2_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void lbl_Miktar_Click(object sender, EventArgs e)
        {

        }

        private void lbl_Hassaslik_Click(object sender, EventArgs e)
        {

        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void lbl_Kirlilik_Click(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void dgw_Veriler_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
