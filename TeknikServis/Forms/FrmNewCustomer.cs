using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using TeknikServis.DataAccessLayer.Context;
using TeknikServis.EntityLayer.ConcreteModels;

namespace TeknikServis.Forms
{
    public partial class FrmNewCustomer : Form
    {
        public FrmNewCustomer()
        {
            InitializeComponent();
            FillLookUpEditCitiesAndDistricts();
        }

        private void btnNewCustomerQuit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnNewCustomerSave_Click(object sender, EventArgs e)
        {
            TeknikServisContext db = new TeknikServisContext();
            Customer customer = new Customer();
            AssignCustomerInfo(customer);
            db.Customers.Add(customer);
            db.SaveChanges();
            MessageBox.Show("Customer Added Successfully");
            this.Close();
        }

        #region Extracted Methods

        private void FillLookUpEditCitiesAndDistricts()
        {
            TeknikServisContext db = new TeknikServisContext();
            lueCustomerCity.Properties.DataSource = db.Customers.Select(c => c.CustomerCity).Distinct().ToList();
            lueCustomerDistrict.Properties.DataSource = db.Customers.Select(c => c.CustomerDistrict).Distinct().ToList();
        }

        private void AssignCustomerInfo(Customer customer)
        {
            customer.CustomerFirstName = txtCustomerFirstName.Text;
            customer.CustomerLastName = txtCustomerLastName.Text;
            customer.CustomerEmail = txtCustomerEmail.Text;
            customer.CustomerPhoneNumber = txtCustomerPhone.Text;
            customer.CustomerAddress = txtCustomerAddress.Text;
            customer.CustomerStatus = txtCustomerStatus.Text;
            customer.CustomerTaxNumber = txtCustomerTaxNumber.Text;
            customer.CustomerTaxOffice = txtCustomerTaxOffice.Text;
            customer.CustomerBank = txtCustomerBank.Text;
            customer.CustomerCity = lueCustomerCity.EditValue.ToString();
            customer.CustomerDistrict = lueCustomerDistrict.EditValue.ToString();
        }

        #endregion
    }
}
