using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using TeknikServis.DataAccessLayer.Context;
using TeknikServis.EntityLayer.ConcreteModels;

namespace TeknikServis.Forms
{
    public partial class FrmNewEmployee : Form
    {
        public FrmNewEmployee()
        {
            InitializeComponent();
            FillLookUpEditDepartments();
        }

        TeknikServisContext db = new TeknikServisContext();

        private void btnNewCategorySave_Click(object sender, EventArgs e)
        {
            Employee employee = new Employee();
            AssignEmployeeInfo(employee);
            db.Employees.Add(employee);
            db.SaveChanges();
            MessageBox.Show("Employee added successfully");
            this.Close();
        }

        private void btnNewCategoryQuit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #region Exracted Methods

        private void FillLookUpEditDepartments()
        {
            var departmentsList = db.Departments.Select(x => new
            {
                x.DepartmentId,
                x.DepartmentName
            }).ToList();
            lueEmployeeDepartments.Properties.DataSource = departmentsList;
        }

        private void AssignEmployeeInfo(Employee employee)
        {
            employee.EmployeeFirstName = txtEmployeeFirstName.Text;
            employee.EmployeeLastName = txtEmployeeLastName.Text;
            employee.EmployeeMail = txtEmployeeEmail.Text;
            employee.EmployeePhoneNumber = txtEmployeePhoneNumber.Text;
            employee.EmployeeProfilePhoto = txtEmployeePhoto.Text;
            employee.Department = byte.Parse(lueEmployeeDepartments.EditValue.ToString());
        }

        #endregion
    }
}
