using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using TeknikServis.DataAccessLayer.Context;
using TeknikServis.EntityLayer.ConcreteModels;

namespace TeknikServis.Forms
{
    public partial class FrmNewProduct : Form
    {
        public FrmNewProduct()
        {
            InitializeComponent();
            FillLookUpEditCategories();
        }

        private void btnNewProductQuit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnNewProductSave_Click(object sender, EventArgs e)
        {
            TeknikServisContext db = new TeknikServisContext();
            Product product = new Product();
            AssignProductInfo(product);
            product.ProductStatus = false;
            db.Products.Add(product);
            db.SaveChanges();
            MessageBox.Show("Product added successfully");
            this.Close();
        }

        #region Exracted Methods

        private void AssignProductInfo(Product product)
        {
            product.ProductName = txtProductName.Text;
            product.ProductBrand = txtProductBrand.Text;
            product.ProductSalePrice = decimal.Parse(txtSalePrice.Text);
            product.ProductPurchasePrice = decimal.Parse(txtPurchasePrice.Text);
            product.Stock = short.Parse(txtStock.Text);
            product.Category = byte.Parse(lueProductCategories.EditValue.ToString());
        }

        private void FillLookUpEditCategories()
        {
            TeknikServisContext db = new TeknikServisContext();
            var categoriesList = from c in db.Categories
                                 select new
                                 {
                                     c.CategoryId,
                                     c.CategoryName
                                 }; //TODO : This comes with categoryid but categoryid should be hidden and only name should be shown.
            lueProductCategories.Properties.DataSource = categoriesList.ToList();
        }

        #endregion
    }
}
