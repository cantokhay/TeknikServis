using System.Linq;
using System.Windows.Forms;

namespace TeknikServis.Forms
{
    public partial class FrmCustomerList : Form
    {
        public FrmCustomerList()
        {
            InitializeComponent();
        }

        TeknikServisDBEntitiesLaptop db = new TeknikServisDBEntitiesLaptop();

        private void FrmCustomerList_Load(object sender, System.EventArgs e)
        {
            CustomerList();
            FillLookUpEditCitiesandDistricts();
            ClearCustomerInfo();
        }

        private void gvwCustomers_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            txtCustomerId.Text = gvwCustomers.GetFocusedRowCellValue("CustomerId").ToString();
            txtCustomerFirstName.Text = gvwCustomers.GetFocusedRowCellValue("CustomerFirstName").ToString();
            txtCustomerLastName.Text = gvwCustomers.GetFocusedRowCellValue("CustomerLastName").ToString();
            txtEmail.Text = gvwCustomers.GetFocusedRowCellValue("CustomerEmail").ToString();
            txtPhoneNumber.Text = gvwCustomers.GetFocusedRowCellValue("CustomerPhoneNumber").ToString();
            txtAddress.Text = gvwCustomers.GetFocusedRowCellValue("CustomerAddress").ToString();
            txtStatus.Text = gvwCustomers.GetFocusedRowCellValue("CustomerStatus").ToString();
            txtTaxNumber.Text = gvwCustomers.GetFocusedRowCellValue("CustomerTaxNumber").ToString();
            txtTaxOffice.Text = gvwCustomers.GetFocusedRowCellValue("CustomerTaxOffice").ToString();
            txtBank.Text = gvwCustomers.GetFocusedRowCellValue("CustomerBank").ToString();
        }

        private void btnSave_Click(object sender, System.EventArgs e)
        {
            Customer customer = new Customer();
            AssignCustomerInfo(customer);
            db.Customer.Add(customer);
            db.SaveChanges();
            MessageBox.Show("Customer Added Successfully", "INFO", MessageBoxButtons.OK, MessageBoxIcon.Information);
            ClearCustomerInfo();
        }

        private void btnDelete_Click(object sender, System.EventArgs e)
        {
            int id = int.Parse(txtCustomerId.Text);
            var customer = db.Customer.Find(id);
            db.Customer.Remove(customer);
            db.SaveChanges();
            MessageBox.Show("Customer Deleted", "INFO", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            ClearCustomerInfo();
        }

        private void btnUpdate_Click(object sender, System.EventArgs e)
        {
            int id = int.Parse(txtCustomerId.Text);
            var customer = db.Customer.Find(id);
            if (customer != null)
            {
                AssignCustomerInfo(customer);
                db.SaveChanges();
                MessageBox.Show("Customer Updated", "INFO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                ClearCustomerInfo();
            }
            else
            {
                MessageBox.Show("Customer Not Found", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            ClearCustomerInfo();
        }

        private void bntRefresh_Click(object sender, System.EventArgs e)
        {
            CustomerList();
            ClearCustomerInfo();
        }

        #region Extracted Methods

        private void ClearCustomerInfo()
        {
            txtCustomerId.Text = string.Empty;
            txtCustomerFirstName.Text = string.Empty;
            txtCustomerLastName.Text = string.Empty;
            txtEmail.Text = string.Empty;
            txtAddress.Text = string.Empty;
            txtPhoneNumber.Text = string.Empty;
            txtStatus.Text = string.Empty;
            txtTaxNumber.Text = string.Empty;
            txtTaxOffice.Text = string.Empty;
            txtBank.Text = string.Empty;
        }

        private void FillLookUpEditCitiesandDistricts()
        {

        }

        private void CustomerList()
        {
            var customerList = db.Customer.Select(c => new
            {
                c.CustomerId,
                c.CustomerFirstName,
                c.CustomerLastName,
                c.CustomerEmail,
                c.CustomerPhoneNumber,
                c.CustomerAddress,
                c.CustomerStatus,
                c.CustomerTaxNumber,
                c.CustomerTaxOffice,
                c.CustomerBank
            }).ToList();
            grcCustomerList.DataSource = customerList;
        }

        private void AssignCustomerInfo(Customer customer)
        {
            customer.CustomerFirstName = txtCustomerFirstName.Text;
            customer.CustomerLastName = txtCustomerLastName.Text;
            customer.CustomerEmail = txtEmail.Text;
            customer.CustomerPhoneNumber = txtPhoneNumber.Text;
            customer.CustomerAddress = txtAddress.Text;
            customer.CustomerStatus = txtStatus.Text;
            customer.CustomerTaxNumber = txtTaxNumber.Text;
            customer.CustomerTaxOffice = txtTaxOffice.Text;
            customer.CustomerBank = txtBank.Text;
        }

        #endregion
    }
}
