using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using TeknikServis.DataAccessLayer.Context;
using TeknikServis.EntityLayer.ConcreteModels;

namespace TeknikServis.Forms
{
    public partial class FrmNewSale : Form
    {
        public FrmNewSale()
        {
            InitializeComponent();
            FillLookUpEditProductCustomerEmployee();
        }

        TeknikServisContext db = new TeknikServisContext();

        private void btnNewSaleSave_Click(object sender, EventArgs e)
        {
            Sale sale = new Sale();
            AssignSaleInfo(sale);
            db.Sales.Add(sale);
            db.SaveChanges();
            MessageBox.Show("Sale added successfully");
            this.Close();
        }

        private void btnNewSaleQuit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #region Extracted Methods

        private void FillLookUpEditProductCustomerEmployee()
        {
            var productsList = db.Products.Select(x => new
            {
                x.ProductId,
                x.ProductName
            }).ToList();
            lueProducts.Properties.DataSource = productsList;

            var customersList = db.Customers.Select(x => new
            {
                x.CustomerId,
                Customer = x.CustomerFirstName + " " + x.CustomerLastName,
            }).ToList();
            lueCustomers.Properties.DataSource = customersList;

            var employeesList = db.Employees.Select(x => new
            {
                x.EmployeeId,
                Employee = x.EmployeeFirstName + " " + x.EmployeeLastName
            }).ToList();
            lueEmployees.Properties.DataSource = employeesList;
        }

        private void AssignSaleInfo(Sale sale)
        {
            sale.Product = int.Parse(lueProducts.EditValue.ToString());
            sale.Customer = int.Parse(lueCustomers.EditValue.ToString());
            sale.Employee = short.Parse(lueEmployees.EditValue.ToString());
            sale.SaleDate = DateTime.Parse(dtpSaleDate.Text);
            sale.SaleQuantity = short.Parse(numSaleQuantity.Text);
            sale.SaleTotalPrice = decimal.Parse(txtSalePrice.Text);
            sale.ProductSerialNumber = txtProductSerialNumber.Text;
        }

        #endregion
    }
}
