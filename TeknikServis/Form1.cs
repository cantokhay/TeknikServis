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

        private void btnCustomerList_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Forms.FrmCustomerList frmCustomerList = new Forms.FrmCustomerList();
            frmCustomerList.MdiParent = this;
            frmCustomerList.Show();
        }

        private void btnNewCustomer_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Forms.FrmNewCustomer frmNewCustomer = new Forms.FrmNewCustomer();
            frmNewCustomer.Show();
        }

        private void btnCustomerCityStats_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Forms.FrmCustomerCityStats frmCustomerCityStats = new Forms.FrmCustomerCityStats();
            frmCustomerCityStats.MdiParent = this;
            frmCustomerCityStats.Show();
        }

        private void btnDepartmentList_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Forms.FrmDepartmentList frmDepartmentList = new Forms.FrmDepartmentList();
            frmDepartmentList.MdiParent = this;
            frmDepartmentList.Show();
        }

        private void btnNewDepartment_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Forms.FrmNewDepartment frmNewDepartment = new Forms.FrmNewDepartment();
            frmNewDepartment.Show();
        }

        private void btnNewCategory_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Forms.FrmNewCategory frmNewCategory = new Forms.FrmNewCategory();
            frmNewCategory.Show();
        }

        private void btnEmployeeList_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Forms.FrmEmployeeList frmEmployeeList = new Forms.FrmEmployeeList();
            frmEmployeeList.MdiParent = this;
            frmEmployeeList.Show();
        }

        private void btnNewEmployee_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Forms.FrmNewEmployee frmNewEmployee = new Forms.FrmNewEmployee();
            frmNewEmployee.Show();
        }

        private void btnCalculator_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            System.Diagnostics.Process.Start("calc.exe");
        }

        private void btnCurrency_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Forms.FrmCurrency frmCurrency = new Forms.FrmCurrency();
            frmCurrency.MdiParent = this;
            frmCurrency.Show();
        }

        private void btnWord_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            System.Diagnostics.Process.Start("winword");
        }

        private void btnExcel_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            System.Diagnostics.Process.Start("excel");
        }

        private void btnYoutube_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Forms.FrmYoutube frmYoutube = new Forms.FrmYoutube();
            frmYoutube.MdiParent = this;
            frmYoutube.Show();
        }

        private void btnNoteList_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Forms.FrmNoteList frmNoteList = new Forms.FrmNoteList();
            frmNoteList.MdiParent = this;
            frmNoteList.Show();
        }

        private void btnFaultyProductList_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Forms.FrmActionsList frmFaultyProductList = new Forms.FrmActionsList();
            frmFaultyProductList.MdiParent = this;
            frmFaultyProductList.Show();
        }

        private void btnNewSale_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Forms.FrmNewSale frmNewSale = new Forms.FrmNewSale();
            frmNewSale.Show();
        }

        private void btnSaleList_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Forms.FrmSaleList frmSaleList = new Forms.FrmSaleList();
            frmSaleList.MdiParent = this;
            frmSaleList.Show();
        }

        private void btnCustomerMovements_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Forms.FrmSaleList frmSaleList = new Forms.FrmSaleList();
            frmSaleList.MdiParent = this;
            frmSaleList.Show();
        }
    }
}
