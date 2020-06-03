using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace StokTakipOtomasyonu
{
	public class DBConnection
	{
		public SqlConnection baglanti()
		{
			SqlConnection conn = new SqlConnection("Data Source=yoursource;Initial Catalog=StokTakipOtomasyonu;Persist Security Info=True;User ID=yourid;Password=yourpass");
			conn.Open();
			return conn;
		}
	}
}
