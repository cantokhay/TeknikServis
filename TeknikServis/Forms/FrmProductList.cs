﻿using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using TeknikServis.DataAccessLayer.Context;
using TeknikServis.EntityLayer.ConcreteModels;

namespace TeknikServis.Forms
{
    public partial class FrmProductList : Form
    {
        public FrmProductList()
        {
            InitializeComponent();
        }

        TeknikServisContext db = new TeknikServisContext(); //TODO: This should be come with dependency injection.

        private void FrmProductList_Load(object sender, EventArgs e)
        {
            ProductList();
            FillLookUpEditCategories();
            ClearProductInfo();
        }

        private void btnProductSave_Click(object sender, EventArgs e)
        {
            Product product = new Product(); //TODO: This should be come with dependency injection.
            AssignProductInfo(product); //TODO: This method should check for existing product with the same name and other properties.
            product.ProductStatus = false;
            db.Products.Add(product);
            db.SaveChanges();
            MessageBox.Show("Product Added Successfully", "INFO", MessageBoxButtons.OK, MessageBoxIcon.Information);
            ClearProductInfo();
        }

        private void bntProductListRefresh_Click(object sender, EventArgs e)
        {
            ProductList();
            ClearProductInfo();
        }

        private void gvwProducts_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            txtProductId.Text = gvwProducts.GetFocusedRowCellValue("ProductId").ToString();
            txtProductName.Text = gvwProducts.GetFocusedRowCellValue("ProductName").ToString();
            txtProductBrand.Text = gvwProducts.GetFocusedRowCellValue("ProductBrand").ToString();
            txtSalePrice.Text = gvwProducts.GetFocusedRowCellValue("ProductSalePrice").ToString();
            txtPurchasePrice.Text = gvwProducts.GetFocusedRowCellValue("ProductPurchasePrice").ToString();
            txtStock.Text = gvwProducts.GetFocusedRowCellValue("Stock").ToString();
            lueProductCategories.EditValue = gvwProducts.GetFocusedRowCellValue("CategoryId");
        }

        private void btnProductDelete_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtProductId.Text);
            var product = db.Products.Find(id);
            db.Products.Remove(product);
            db.SaveChanges();
            MessageBox.Show("Product Deleted", "INFO", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            ClearProductInfo();
        }

        private void btnProductUpdate_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtProductId.Text);
            var product = db.Products.Find(id);

            if (product != null)
            {
                AssignProductInfo(product);
                db.SaveChanges();
                MessageBox.Show("Product Updated", "INFO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                MessageBox.Show("Product not found", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            ClearProductInfo();
        }

        #region Extracted Methods

        private void ClearProductInfo()
        {
            txtProductId.Text = string.Empty;
            txtProductName.Text = string.Empty;
            txtProductBrand.Text = string.Empty;
            txtSalePrice.Text = string.Empty;
            txtPurchasePrice.Text = string.Empty;
            txtStock.Text = string.Empty;
            lueProductCategories.EditValue = null;
        }

        private void FillLookUpEditCategories()
        {
            var categoriesList = from c in db.Categories
                                 select new
                                 {
                                     c.CategoryId,
                                     c.CategoryName
                                 }; //TODO : This comes with categoryid but categoryid should be hidden and only name should be shown.
            lueProductCategories.Properties.DataSource = categoriesList.ToList();
        }

        private void ProductList()
        {
            var productsList = from p in db.Products
                               join c in db.Categories on p.Category equals c.CategoryId
                               select new
                               {
                                   p.ProductId,
                                   p.ProductName,
                                   p.ProductBrand,
                                   p.ProductSalePrice,
                                   p.ProductPurchasePrice,
                                   p.Stock,
                                   c.CategoryName,
                                   c.CategoryId
                               };//TODO : This comes with categoryid but categoryid should be hidden and only name should be shown.
            grcProductList.DataSource = productsList.ToList();
        }

        private void AssignProductInfo(Product product)
        {
            product.ProductName = txtProductName.Text;
            product.ProductBrand = txtProductBrand.Text;
            product.ProductSalePrice = decimal.Parse(txtSalePrice.Text);
            product.ProductPurchasePrice = decimal.Parse(txtPurchasePrice.Text);
            product.Stock = short.Parse(txtStock.Text);
            product.Category = byte.Parse(lueProductCategories.EditValue.ToString());
        }

        #endregion
    }
}
