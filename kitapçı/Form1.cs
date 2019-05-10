using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
namespace kitapçı
{
    public partial class Form1 : Form
    {
        MySqlConnection  baglan=new MySqlConnection("server=localhost;user id=root;password=123456;database=deneme");
        MySqlCommand komut = new MySqlCommand();
        DataTable satis = new DataTable();

        public Form1()
        {
            InitializeComponent();
        }
        private void Listele()
        {
            satis.Clear();
            MySqlDataAdapter adtr = new MySqlDataAdapter
            ("Select * From satis", baglan);
            adtr.Fill(satis);
            dataGridView1.DataSource = satis;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            double sonuc = 0;
            int t = 0;
            string kitap = "";
            string durum = "";
            if (checkBox1.Checked == true)
            {
                kitap = checkBox1.Text;
                t = t + 40;
            }

            if (checkBox2.Checked == true)
            {
                kitap = checkBox2.Text;
                t = t + 30;
            }

            if (checkBox3.Checked == true)
            {
                kitap = checkBox3.Text;
                t = t + 60;
            }

            if (radioButton1.Checked)
            {
                durum = radioButton1.Text;
                sonuc = t - (t * 0.1);
            }

            if (radioButton2.Checked)
            {
                durum = radioButton2.Text;
                sonuc += t;
            }

            textBox1.Text = sonuc.ToString();

            baglan.Open();
            komut.Connection = baglan;
            komut.CommandText = @"Insert Into satis(KitapAdi,Durum,Tutar) 
            VALUES ('" + kitap + "','" + durum + "','" + textBox1.Text + "')";
            komut.ExecuteNonQuery();
            baglan.Close();
            Listele();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MySqlDataAdapter verial;
            DataSet al;
            string baglanti, sorgu;
            baglanti = //bağlanti cümlesi;
            sorgu = "Select * from  satis";
            baglan = new MySqlConnection(baglanti);
            verial = new MySqlDataAdapter(sorgu, baglan);
            al = new DataSet();
            verial.Fill(al, "satis");
            dataGridView1.DataSource = al.Tables[0];
        }
    }
}
