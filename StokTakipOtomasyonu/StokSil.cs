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
	public partial class StokSil : Form
	{
		public StokSil()
		{
			InitializeComponent();
		}

        //DBConnection connection = new DBConnection();
        

        public static string durum;
        LoadingForm bekle = new LoadingForm();

        StokTakipOtomasyonuDataSet2TableAdapters.UrunlerTableAdapter dt = new StokTakipOtomasyonuDataSet2TableAdapters.UrunlerTableAdapter();

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            try
            {
               if(txtUrunId.Text != "")
                {
                    dt.UrunSil(int.Parse(txtUrunId.Text));
                    //SqlCommand cmd = new SqlCommand("delete urunler where UrunId = @id", connection.baglanti());
                    //cmd.Parameters.AddWithValue("@id", txtUrunId.Text);
                    //int id = cmd.ExecuteNonQuery();
                    //connection.baglanti().Close();
                    durum = "success";
                    bekle.ShowDialog();
                }
               else
                {
                    MessageBox.Show("Doldurulması zorunlu alanları doldurunuz.", "Hata Mesajı", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk);
                }
            }
            catch(Exception)
            {
                durum = "error";
                bekle.ShowDialog();
            }
        }

        private void StokSil_Load(object sender, EventArgs e)
        {
            
        }
    }
}
