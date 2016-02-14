using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Data.SQLite;

namespace Insert_Fonksiyonu
{
    class Db_Sinifi
    {

        // parametreler
        String dbName = "proje.db";
        String dbPath = "veriler";
        SQLiteConnection conn = null;

        // boş kurucu
        public Db_Sinifi()
        {
            if (conn != null)
            {
                conn.Close();
            }

            if (conn == null)
            {
                try
                {
                    conn = new SQLiteConnection("Data Source=" + dbPath + "\\" + dbName);
                    conn.Open();
                    //System.Windows.Forms.MessageBox.Show("Proje adlı veritabanına bağlantı başarılı");
                }
                catch (Exception ex)
                {
                    System.Windows.Forms.MessageBox.Show("Bağlantı Hatası : " + ex);
                }
            }
        }

        // dolu kurucu method
        public Db_Sinifi(String dbPath, String dbName)
        {

            if (conn != null)
            {
                conn.Close();
            }

            if (conn == null)
            {
                try
                {
                    conn = new SQLiteConnection("Data Source=" + dbPath + "\\" + dbName);
                    conn.Open();
                    //System.Windows.Forms.MessageBox.Show("Northwind adlı veritabanına Bağlantı Başarılı");
                }
                catch (Exception ex)
                {
                    System.Windows.Forms.MessageBox.Show("Bağlantı Hatası : " + ex);
                }
            }

        }


        #region Insert_Fonksiyonu_Odev
        //********************* ödev *******************************

        public int db_kayit(string tabloismi, string[] veriler)
        {
            int sonuc = -1;
            int rakamsay = 0;
            string degerler = "";
            char[] dizi = null;

            foreach (string item in veriler)
            {
                dizi = item.ToCharArray();
                foreach (char eleman in dizi)
                {
                    if (char.IsDigit(eleman))
                    {
                        rakamsay++;
                    }

                }

                if (rakamsay == dizi.Length)
                {
                    degerler += item + ",";  // int değer demektir
                }

                else if (string.IsNullOrEmpty(item))
                {
                    degerler += "null,";
                }

                else if (item == "null") // texte null yazıldı demektir..
                {
                    degerler += "null,";
                }

                else
                    degerler += "'" + item + "',"; // string değer demektir
            }

            string sondeger = degerler.Substring(0, degerler.Length - 1); // en sondaki , atılıyor..

            try
            {
                SQLiteCommand cm = new SQLiteCommand("insert into '" + tabloismi + "' values(" + sondeger + ") ", conn);
                sonuc = cm.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show("Yazma Hatası " + ex);
            }
            return sonuc;
        }


        public SQLiteDataAdapter verigetir(string tabloismi)
        {
            SQLiteDataAdapter da = null;
            try
            {
                SQLiteCommand cmd = new SQLiteCommand("select *from " + tabloismi, conn);
                da = new SQLiteDataAdapter(cmd);
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

            return da;
        }
        #endregion



    }
}
