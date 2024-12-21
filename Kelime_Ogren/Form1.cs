using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Kelime_Ogren
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-F1A12T8\KORAY;Initial Catalog=KelimeOgren;Integrated Security=True");
        Random rast = new Random();
        public string kisiad;
        int sure = 90;
        int dogrusayi = 0;
        int yanlissayi = 0;

        void getir()
        {
            int sayi;
            sayi = rast.Next(1, 32);

            baglanti.Open();
            SqlCommand komut = new SqlCommand("Select * from SOZLUK where ID=@p1", baglanti);
            komut.Parameters.AddWithValue("@p1", sayi);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                TxtIng.Text = dr[1].ToString();
                LblCevap.Text = dr[2].ToString();
                LblCevap.Text = LblCevap.Text.ToLower();
            }
            baglanti.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            getir();
            TxtTr.Focus();
            timer1.Start();
        }

        private void TxtTr_TextChanged(object sender, EventArgs e)
        {
            //if (TxtTr.Text == LblCevap.Text)
            //{
            //    dogrusayi++;
            //    LblDogruS.Text = dogru.ToString();
            //    getir();
            //    TxtTr.Clear();
            //}
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            sure--;
            LblSure.Text = sure.ToString();
            if (sure == 0)
            {
                TxtTr.Enabled = false;
                TxtIng.Enabled = false;
                timer1.Stop();

                baglanti.Open();
                SqlCommand komut = new SqlCommand("Insert Into KISILER (KisiAd, DogruSayisi, YanlisSayisi) Values (@p1, @p2, @p3)", baglanti);
                komut.Parameters.AddWithValue("@p1", kisiad);
                komut.Parameters.AddWithValue("@p2", LblDogruS.Text);
                komut.Parameters.AddWithValue("@p3", LblYanlisS.Text);
                komut.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("Sayın " + kisiad + " " + "Doğru Sayısı : " + LblDogruS.Text + " " + "Yanlış Sayısı : " + LblYanlisS.Text + " ", "Sonuç", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Application.Exit();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (TxtTr.Text == LblCevap.Text)
            {
                dogrusayi++;
                LblDogruS.Text = dogrusayi.ToString();
                getir();
                TxtTr.Clear();
            }
            else
            {
                yanlissayi++;
                LblYanlisS.Text = yanlissayi.ToString();
                getir();
                TxtTr.Clear();
            }
        }
    }
}
