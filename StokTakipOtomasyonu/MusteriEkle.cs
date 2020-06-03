using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StokTakipOtomasyonu
{
    public partial class MusteriEkle : Form
    {
        public MusteriEkle()
        {
            InitializeComponent();
        }

        DBConnection connection = new DBConnection();

        public static string durum;
        LoadingForm bekle = new LoadingForm();

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            try
            {
                if ((txtMusAdi.Text != "") || (txtMusSoyad.Text == ""))
                {
                    if (txtMusTC.Text != "")
                    {

                        SqlCommand cmd = new SqlCommand("Execute sp_InsertMusteriler @MusteriAdi,@MusteriSoyadi,@MusteriTCKimlik,@Cinsiyet", connection.baglanti());
                        cmd.Parameters.AddWithValue("@MusteriAdi", txtMusAdi.Text);
                        cmd.Parameters.AddWithValue("@MusteriSoyadi", txtMusSoyad.Text);
                        cmd.Parameters.AddWithValue("@MusteriTCKimlik", txtMusTC.Text);
                        cmd.Parameters.AddWithValue("@Cinsiyet", txtMusCinsiyet.Text);
                        int id = cmd.ExecuteNonQuery();
                        connection.baglanti().Close();
                        durum = "success";
                        bekle.ShowDialog();
                    }
                    else
                    {
                        MessageBox.Show("Doldurulması zorunlu alanları doldurunuz.", "Hata Mesajı", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk);
                    }
                }
            }
            catch (Exception)
            {
                durum = "error";
                bekle.ShowDialog();
            }
        }
    }
}
