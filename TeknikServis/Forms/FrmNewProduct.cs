using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            TeknikServisDBEntities db = new TeknikServisDBEntities();
            Product product = new Product();
            AssignProductInfo(product);
            product.ProductStatus = false;
            db.Product.Add(product);
            db.SaveChanges();
            MessageBox.Show("Product Added Successfully");
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
            TeknikServisDBEntities db = new TeknikServisDBEntities();
            var categoriesList = from c in db.Category
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
