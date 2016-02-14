using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Insert_Fonksiyonu
{
    public partial class Form1 : Form
    {
        string[] verilerdizisi = null;
        Db_Sinifi db = new Db_Sinifi("datalar", "Northwind.sl3");
        Db_Sinifi proje = new Db_Sinifi();
        int sayi = 1;
        DataTable dt = null;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            radioButton2.Checked = true;
            radioButton1.Checked = false;
        }


        private void btnekle_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtverigirisi.Text.Trim()))
            {
                lstliste.Items.Add(txtverigirisi.Text);
                txtverigirisi.Text = "";
            }
            else
            {
                MessageBox.Show("veri girişi alanını doldurunuz");
            }

        }

        private void btnkaydet_Click(object sender, EventArgs e)
        {
            if (lstliste.Items.Count > 0 && !string.IsNullOrEmpty(txttabloisim.Text.Trim()))
            {
                btnverilerigetir_Click(null, null);
                if (dt != null)
                {
                    if (dt.Columns.Count == lstliste.Items.Count)
                    {
                        int sayac = 0;
                        verilerdizisi = new string[lstliste.Items.Count]; // dizi boyutu belirlendi..
                        foreach (string item in lstliste.Items) // dizi doldurulıyor..
                        {
                            verilerdizisi[sayac] = item;
                            sayac++;
                        }
                        int sonuc;
                        if (sayi == 1)
                        {
                            sonuc = db.db_kayit(txttabloisim.Text, verilerdizisi);
                        }
                        else
                            sonuc = proje.db_kayit(txttabloisim.Text, verilerdizisi);

                        if (sonuc > 0)
                        {
                            MessageBox.Show("Kaydetme işlemi başarılı..");
                            btnverilerigetir_Click(null, null);
                        }

                        else
                            MessageBox.Show("Kaydetme işlemi başarısız...");

                        Temizle();

                    }
                    else
                        MessageBox.Show("Lütfen " + dt.Columns.Count + " adet veri girişi yapınız.");
                }
            }
            else
                MessageBox.Show("Lütfen veri girişlerini ve tablo ismi kısımlarını doldurunuz.");
        }

        private void Temizle()
        {
            lstliste.Items.Clear();

            if (verilerdizisi != null)
            {
                for (int i = 0; i < verilerdizisi.Length; i++)
                {
                    verilerdizisi[i] = null;
                }
            }
        }

        public void btnverilerigetir_Click(object sender, EventArgs e)  // datagridview de veriler görüntülenecek...
        {
            dt = null;
            if (!string.IsNullOrEmpty(txttabloisim.Text.Trim()))
            {
                SQLiteDataAdapter da = new SQLiteDataAdapter();
                if (sayi == 1)
                {
                    da = db.verigetir(txttabloisim.Text);
                }

                else
                {
                    da = proje.verigetir(txttabloisim.Text);
                }

                DataSet ds = new DataSet();
                try
                {
                    da.Fill(ds);
                    dt = ds.Tables[0];
                    dataGridView1.DataSource = dt;

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

            else
                MessageBox.Show("Tablo ismini giriniz.");

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e) // northwind
        {
            if (radioButton1.Checked)
                sayi = 1;
            else
                sayi = 2;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e) // proje
        {
            if (radioButton2.Checked)
                sayi = 2;
            else
                sayi = 1;
        }

        private void btncikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btntemizle_Click(object sender, EventArgs e)
        {
            Temizle();
        }
    }
}
