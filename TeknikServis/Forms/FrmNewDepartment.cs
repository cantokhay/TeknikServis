using System.Windows.Forms;
using TeknikServis.DataAccessLayer.Context;
using TeknikServis.EntityLayer.ConcreteModels;

namespace TeknikServis.Forms
{
    public partial class FrmNewDepartment : Form
    {
        public FrmNewDepartment()
        {
            InitializeComponent();
        }

        private void btnNewDepartmentSave_Click(object sender, System.EventArgs e)
        {
            TeknikServisContext db = new TeknikServisContext();
            Department department = new Department();
            AssignDepartmentInfo(department);
            db.Departments.Add(department);
            db.SaveChanges();
            MessageBox.Show("Department added succesfully");
            this.Close();
        }

        private void btnNewDepartmentQuit_Click(object sender, System.EventArgs e)
        {
            this.Close();
        }

        #region Extracted Methods
        private void AssignDepartmentInfo(Department departmant)
        {
            departmant.DepartmentName = txtDepartmentName.Text;
            departmant.DepartmentDescription = txtDepartmentDescription.Text;
        }
        #endregion
    }
}
