using System;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;

namespace TeknikServis.Forms
{
    public partial class FrmCustomerCityStats : Form
    {
        public FrmCustomerCityStats()
        {
            InitializeComponent();
        }

        TeknikServisDBEntitiesLaptop db = new TeknikServisDBEntitiesLaptop();

        SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-OHO9G30\SQLEXPRESS;Initial Catalog=TeknikServisDB;Integrated Security=True");
        
        private void FrmCustomerCityStats_Load(object sender, EventArgs e)
        {
            //chartControl1.Series["Series 1"].Points.AddPoint("Ankara", 4);
            //chartControl1.Series["Series 1"].Points.AddPoint("İstanbul", 8);
            //chartControl1.Series["Series 1"].Points.AddPoint("İzmir", 2);
            //chartControl1.Series["Series 1"].Points.AddPoint("Adana", 5);

            grcCustomerCityList.DataSource = db.Customer.OrderBy(x => x.CustomerCity).GroupBy(y => y.CustomerCity).Select(z => new
            {
                City = z.Key,
                Total = z.Count()
            }).ToList();

            connection.Open();
            SqlCommand command = new SqlCommand("select CustomerCity, count(*) from Customer group by CustomerCity", connection);
            SqlDataReader dr = command.ExecuteReader();
            while (dr.Read())
            {
                chartControl1.Series["Series 1"].Points.AddPoint(Convert.ToString(dr[0]), int.Parse(dr[1].ToString()));
            }
            connection.Close();
        }
    }
}
