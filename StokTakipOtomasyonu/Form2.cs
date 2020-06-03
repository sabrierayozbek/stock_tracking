using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace StokTakipOtomasyonu
{
	public partial class Form2 : DevExpress.XtraEditors.XtraForm
	{
		public Form2()
		{
			InitializeComponent();
		}

		private bool IsFormActivated(Form form)
		{
				foreach (var item in MdiChildren)
				{
					if (item.Name == form.Name)
					{
						item.Activate();
					    return true;
					}
					
				}
			return false;
			}
			
		private void toolStripMenuItem3_Click(object sender, EventArgs e)
		{
            Stokİslemleri stokİslemleri = new Stokİslemleri();
            if (IsFormActivated(stokİslemleri)) return;
            stokİslemleri.MdiParent = this;
            stokİslemleri.Show();
        }

		private void toolStripTextBox5_Click(object sender, EventArgs e)
		{
			
		}

		private void toolStripTextBox6_Click(object sender, EventArgs e)
		{
			
		}

		private void Stokİslemleri_Click(object sender, EventArgs e)
		{
			
		}

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void toolStripTextBox1_Click(object sender, EventArgs e)
        {
            StokEkle stokEkle = new StokEkle();
            if (IsFormActivated(stokEkle)) return;
            stokEkle.ShowDialog();
        }

        private void toolStripTextBox2_Click(object sender, EventArgs e)
        {
            StokSil stokSil = new StokSil();
            if (IsFormActivated(stokSil)) return;
            stokSil.MdiParent = this;
            stokSil.Show();
        }

        private void toolStripTextBox3_Click(object sender, EventArgs e)
        {
            StokGuncelle stokGuncelle = new StokGuncelle();
            if (IsFormActivated(stokGuncelle)) return;
            stokGuncelle.ShowDialog();
        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            Siparis siparis = new Siparis();
            if (IsFormActivated(siparis)) return;
            siparis.MdiParent = this;
            siparis.Show();
        }

        private void toolStripMenuItem5_Click(object sender, EventArgs e)
        {
            Musteri musteri = new Musteri();
            if (IsFormActivated(musteri)) return;
            musteri.MdiParent = this;
            musteri.Show();
        }

        private void toolStripMenuItem12_Click(object sender, EventArgs e)
        {
            Kullanici kullanici = new Kullanici();
            if (IsFormActivated(kullanici)) return;
            kullanici.MdiParent = this;
            kullanici.Show();
        }

        private void toolStripMenuItem6_Click(object sender, EventArgs e)
        {
            MusteriEkle stokEkle = new MusteriEkle();
            if (IsFormActivated(stokEkle)) return;
            stokEkle.ShowDialog();
        }
    }
}