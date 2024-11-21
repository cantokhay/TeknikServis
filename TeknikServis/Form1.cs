using System.Windows.Forms;

namespace TeknikServis
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnProductListForm_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Forms.FrmProductList frmProductList = new Forms.FrmProductList();
            frmProductList.MdiParent = this;
            frmProductList.Show();
        }

        private void btnCategoryListForm_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Forms.FrmCategoryList frmCategoryList = new Forms.FrmCategoryList();
            frmCategoryList.MdiParent = this;
            frmCategoryList.Show();
        }

        private void btnNewProduct_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Forms.FrmNewProduct frmProductList = new Forms.FrmNewProduct();
            frmProductList.Show();
        }

        private void btnProductStats_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Forms.FrmProductStats frmProductStats = new Forms.FrmProductStats();
            frmProductStats.MdiParent = this;
            frmProductStats.Show();
        }

        private void btnBrandStats_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Forms.FrmBrandsStats frmBrandsStats = new Forms.FrmBrandsStats();
            frmBrandsStats.MdiParent = this;
            frmBrandsStats.Show();
        }
    }
}
