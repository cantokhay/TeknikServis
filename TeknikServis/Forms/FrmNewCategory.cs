using System.Windows.Forms;
using TeknikServis.DataAccessLayer.Context;
using TeknikServis.EntityLayer.ConcreteModels;

namespace TeknikServis.Forms
{
    public partial class FrmNewCategory : Form
    {
        public FrmNewCategory()
        {
            InitializeComponent();
        }

        private void btnNewCategorySave_Click(object sender, System.EventArgs e)
        {
            TeknikServisContext db = new TeknikServisContext();
            Category category = new Category();
            AssignCategoryInfo(category);
            db.Categories.Add(category);
            db.SaveChanges();
            MessageBox.Show("Category added succesfully");
            this.Close();
        }
        private void btnNewCategoryQuit_Click(object sender, System.EventArgs e)
        {
            this.Close();
        }

        #region Extracted Methods
        private void AssignCategoryInfo(Category category)
        {
            category.CategoryName = txtCategoryName.Text;
        }
        #endregion
    }
}
