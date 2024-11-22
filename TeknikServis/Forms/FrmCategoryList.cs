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
    public partial class FrmCategoryList : Form
    {
        public FrmCategoryList()
        {
            InitializeComponent();
        }

        TeknikServisDBEntitiesLaptop db = new TeknikServisDBEntitiesLaptop();

        private void FrmCategoryList_Load(object sender, EventArgs e)
        {
            CategoryList();
            ClearCategoryInfo();
        }

        private void gvwCategories_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            txtCategoryId.Text = gvwCategories.GetFocusedRowCellValue("CategoryId").ToString();
            txtCategoryName.Text = gvwCategories.GetFocusedRowCellValue("CategoryName").ToString();
        }

        private void bntRefresh_Click(object sender, EventArgs e)
        {
            CategoryList();
            ClearCategoryInfo();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Category category = new Category();
            AssignCategoryInfo(category);
            db.Category.Add(category);
            db.SaveChanges();
            MessageBox.Show("Category Added Successfully", "INFO", MessageBoxButtons.OK, MessageBoxIcon.Information);
            ClearCategoryInfo();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtCategoryId.Text);
            var category = db.Category.Find(id);
            db.Category.Remove(category);
            db.SaveChanges();
            MessageBox.Show("Category Deleted", "INFO", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            ClearCategoryInfo();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtCategoryId.Text);
            var category = db.Category.Find(id);

            if (category != null)
            {
                AssignCategoryInfo(category);
                db.SaveChanges();
                MessageBox.Show("Category Updated", "INFO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                MessageBox.Show("Category Not Found", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            ClearCategoryInfo();
        }

        #region Extracted Methods

        private void CategoryList()
        {
            var values = from x in db.Category
                         select new
                         {
                             x.CategoryId,
                             x.CategoryName
                         };
            grcCategoryList.DataSource = values.ToList();
        }

        private void ClearCategoryInfo()
        {
            txtCategoryId.Text = string.Empty;
            txtCategoryName.Text = string.Empty;
        }

        private void AssignCategoryInfo(Category category)
        {
            category.CategoryName = txtCategoryName.Text;
        }

        #endregion
    }
}
