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
	public partial class StokGuncelle : Form
	{
		public StokGuncelle()
		{
			InitializeComponent();
		}

        DBConnection connection = new DBConnection();
       
     
        public static string durum;
        LoadingForm bekle = new LoadingForm();

        private void StokGuncelle_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'stokTakipOtomasyonuDataSet12.Kategoriler' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.kategorilerTableAdapter1.Fill(this.stokTakipOtomasyonuDataSet121.Kategoriler);
            // TODO: Bu kod satırı 'stokTakipOtomasyonuDataSet11.Markalar' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.markalarTableAdapter1.Fill(this.stokTakipOtomasyonuDataSet111.Markalar);
        }



        private void btnKaydet_Click(object sender, EventArgs e)
        {
            try
            {
                if ((txtUrunAdi.Text != "") || (txtAlisFiyat.Text == ""))
                {
                    if (txtSatisFiyat.Text != "")
                    {

                        SqlCommand cmd = new SqlCommand("update Urunler set UrunAdi=@urunAdi,UrunKodu=@urunKodu,ModelAdi=@modelAdi,Marka=@markaAdi,KategoriAdi=@kategoriAdi,StokAdeti=@stokAdeti,AlisFiyati=@alisFiyati,SatisFiyati=@satisFiyati where UrunId=@id)", connection.baglanti());
                        cmd.Parameters.AddWithValue("@id", txtUrunId.Text);
                        cmd.Parameters.AddWithValue("@urunAdi", txtUrunAdi.Text);
                        cmd.Parameters.AddWithValue("@urunKodu", txtUrunKodu.Text);
                        cmd.Parameters.AddWithValue("@markaAdi", cmbMarka.SelectedValue);
                        cmd.Parameters.AddWithValue("@modelAdi", txtModel.Text);
                        cmd.Parameters.AddWithValue("@stokAdeti", numericStokAdeti.Value);
                        cmd.Parameters.AddWithValue("@kategoriAdi", cmbKategori.SelectedValue);
                        cmd.Parameters.AddWithValue("@alisFiyati", txtAlisFiyat.Text);
                        cmd.Parameters.AddWithValue("@satisFiyati", txtSatisFiyat.Text);
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
