using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using TeknikServis.DataAccessLayer.Context;

namespace TeknikServis.Forms
{
    public partial class FrmBrandsStats : Form
    {
        public FrmBrandsStats()
        {
            InitializeComponent();
        }

        TeknikServisContext db = new TeknikServisContext();

        private void FrmBrandsStats_Load(object sender, EventArgs e)
        {
            var values = db.Products.OrderBy(x => x.ProductBrand).GroupBy(y => y.ProductBrand).Select(z => new
            {
                Brand = z.Key,
                Total = z.Count()
            }).ToList();
            grcBrandsList.DataSource = values;

            lblTotalProductStat.Text = db.Products.Count().ToString();
            lblTotalBrandsStat.Text = db.Products.Select(x => x.ProductBrand).Distinct().Count().ToString();
            lblMostStockedBrandStat.Text = db.Products.GroupBy(x => x.ProductBrand).OrderByDescending(y => y.Count()).Select(z => z.Key).FirstOrDefault();
            lblMostPricedProductBrandStat.Text = db.Products.OrderByDescending(x => x.ProductSalePrice).Select(y => y.ProductBrand).FirstOrDefault();

            chartControl1.Series["Series 1"].Points.AddPoint("SIEMENS",4);
            chartControl1.Series["Series 1"].Points.AddPoint("ARÇELİK", 6);
            chartControl1.Series["Series 1"].Points.AddPoint("BEKO", 8);
            chartControl1.Series["Series 1"].Points.AddPoint("BOSCH", 12);
            chartControl1.Series["Series 1"].Points.AddPoint("VESTEL", 10);
            chartControl1.Series["Series 1"].Points.AddPoint("LG", 14);
            chartControl1.Series["Series 1"].Points.AddPoint("PHILIPS", 16);
            chartControl1.Series["Series 1"].Points.AddPoint("SAMSUNG", 18);

            chartControl2.Series["Categories"].Points.AddPoint("Home Appliance", 4);
            chartControl2.Series["Categories"].Points.AddPoint("Electronic", 6);
            chartControl2.Series["Categories"].Points.AddPoint("Small Appliance", 3);
            chartControl2.Series["Categories"].Points.AddPoint("Computer", 10);
            chartControl2.Series["Categories"].Points.AddPoint("Mobile Phone", 10);
            chartControl2.Series["Categories"].Points.AddPoint("TV", 9);
        }
    }
}
