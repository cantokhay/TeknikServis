using System;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;
using TeknikServis.DataAccessLayer.Context;

namespace TeknikServis.Forms
{
    public partial class FrmCustomerCityStats : Form
    {
        public FrmCustomerCityStats()
        {
            InitializeComponent();
        }

        TeknikServisContext db = new TeknikServisContext();

        SqlConnection connection = new SqlConnection(@"Data Source=CAN-TOKHAY-MASA\CANTOKHAY;Initial Catalog=TeknikServisDB;Integrated Security=True");
        
        private void FrmCustomerCityStats_Load(object sender, EventArgs e)
        {
            grcCustomerCityList.DataSource = db.Customers.OrderBy(x => x.CustomerCity).GroupBy(y => y.CustomerCity).Select(z => new
            {
                City = z.Key,
                Total = z.Count()
            }).ToList();

            connection.Open();
            SqlCommand command = new SqlCommand("select CustomerCity, count(*) from Customers group by CustomerCity", connection);
            SqlDataReader dr = command.ExecuteReader();
            while (dr.Read())
            {
                chartControl1.Series["Series 1"].Points.AddPoint(Convert.ToString(dr[0]), int.Parse(dr[1].ToString()));
            }
            connection.Close();
        }
    }
}
