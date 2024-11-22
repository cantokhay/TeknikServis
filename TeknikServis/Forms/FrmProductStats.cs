using System;
using System.Linq;
using System.Windows.Forms;

namespace TeknikServis.Forms
{
    public partial class FrmProductStats : Form
    {
        public FrmProductStats()
        {
            InitializeComponent();
        }

        TeknikServisDBEntitiesLaptop db = new TeknikServisDBEntitiesLaptop();

        private void FrmProductStats_Load(object sender, System.EventArgs e)
        {
            lblTotalProductStat.Text = db.Product.Count().ToString();
            lblTotalCategoriesStat.Text = db.Category.Count().ToString();
            lblTotalStockStat.Text = db.Product.Sum(x => x.Stock).ToString();
            lblCritLevelStat.Text = db.Product.Count(x => x.Stock <= 20).ToString();
            //lblTodaySoldProductsStat
            lblMaxStockProductStat.Text = db.Product.OrderByDescending(x => x.Stock).Select(y => y.ProductName).FirstOrDefault();
            lblMinStockProductStat.Text = db.Product.OrderBy(x => x.Stock).Select(y => y.ProductName).FirstOrDefault();
            lblMostProductCategoryStat.Text = db.Category.Where(x => x.CategoryId == db.Product.GroupBy(y => y.Category).OrderByDescending(z => z.Count()).Select(a => a.Key).FirstOrDefault()).Select(b => b.CategoryName).FirstOrDefault();
            lblMaxPricedProductStat.Text = db.Product.OrderByDescending(x => x.ProductSalePrice).Select(y => y.ProductName).FirstOrDefault();
            lblMinPricedProductStat.Text = db.Product.OrderBy(x => x.ProductSalePrice).Select(y => y.ProductName).FirstOrDefault();
            lblTotalBrandsStat.Text = db.Product.Select(x => x.ProductBrand).Distinct().Count().ToString();
            lblMostStockedBrandStat.Text = db.Product.GroupBy(x => x.ProductBrand).OrderByDescending(y => y.Count()).Select(z => z.Key).FirstOrDefault();
            //lblFaultyProductsStat
            //lblProductsUnderRepairStat
            //lblTodayFaultyProductsStat
            lblTotalApplianceStat.Text = db.Product.Where(x => x.Category == 84).Sum(x => x.Stock).ToString();
            lblTotalComputersStat.Text = db.Product.Where(x => x.Category == 82).Sum(x => x.Stock).ToString();
            lblTotalGamingStat.Text = db.Product.Where(x => x.Category == 100).Sum(x => x.Stock).ToString();
            //lblProductsAfterRepairStat
            //lblProductsReadyCargoStat
        }
    }
}