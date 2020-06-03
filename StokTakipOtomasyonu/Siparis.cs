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
    public partial class Siparis : Form
    {
        public Siparis()
        {
            InitializeComponent();
        }

        DBConnection connection = new DBConnection();
        SiparislerDataSetTableAdapters.SiparislerTableAdapter dt = new SiparislerDataSetTableAdapters.SiparislerTableAdapter();
        

        private void Siparis_Load(object sender, EventArgs e)
        {

            dataGridView2.DataSource = dt.GetData();
            dataGridView2.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            dataGridView2.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(20, 25, 72);
            dataGridView2.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            this.dataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
    }
}
