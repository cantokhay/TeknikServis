using System;
using System.Linq;
using System.Windows.Forms;
using TeknikServis.DataAccessLayer.Context;
using TeknikServis.EntityLayer.ConcreteModels;

namespace TeknikServis.Forms
{
    public partial class FrmDepartmantList : Form
    {
        public FrmDepartmantList()
        {
            InitializeComponent();
        }

        TeknikServisContext db = new TeknikServisContext();

        private void FrmDepartmantList_Load(object sender, EventArgs e)
        {
            DepartmantList();
            ClearDepartmantInfo();
            ShowDepartmantListStatsByLinq();
        }

        private void gvwDepartmants_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            txtDepartmantDescription.Text = gvwDepartmants.GetFocusedRowCellValue("DepartmantDescription").ToString();
            txtDepartmantId.Text = gvwDepartmants.GetFocusedRowCellValue("DepartmantId").ToString();
            txtDepartmantName.Text = gvwDepartmants.GetFocusedRowCellValue("DepartmantName").ToString();
        }

        private void bntRefresh_Click(object sender, EventArgs e)
        {
            DepartmantList();
            ClearDepartmantInfo();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Department department = new Department();
            AssignDepartmantInfo(department);
            db.Departments.Add(department);
            db.SaveChanges();
            MessageBox.Show("Departmant Added Successfully", "INFO", MessageBoxButtons.OK, MessageBoxIcon.Information);
            ClearDepartmantInfo();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtDepartmantId.Text);
            var departmant = db.Departments.Find(id);
            db.Departments.Remove(departmant);
            db.SaveChanges();
            MessageBox.Show("Departmant Deleted", "INFO", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            ClearDepartmantInfo();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtDepartmantId.Text);
            var department = db.Departments.Find(id);

            if (department != null)
            {
                AssignDepartmantInfo(department);
                db.SaveChanges();
                MessageBox.Show("Departmant Updated", "INFO", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Departmant Not Found", "INFO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            ClearDepartmantInfo();
        }

        #region Extracted Methods

        private void ShowDepartmantListStatsByLinq()
        {
            lblTotalDepartmantStat.Text = db.Departments.Count().ToString();
            lblTotalEmployeeStat.Text = db.Employees.Count().ToString();
            lblMaxEmployeeDepartmantStat.Text = db.Employees
                .GroupBy(x => x.DepartmentNavigation.DepartmentId)
                .OrderByDescending(x => x.Count())
                .Select(x => x.FirstOrDefault().DepartmentNavigation.DepartmentName)
                .FirstOrDefault();

            lblMinEmployeeDepartmantStat.Text = db.Employees
                .GroupBy(x => x.DepartmentNavigation.DepartmentId)
                .OrderBy(x => x.Count())
                .Select(x => x.FirstOrDefault().DepartmentNavigation.DepartmentName)
                .FirstOrDefault();
        }

        private void ClearDepartmantInfo()
        {
            txtDepartmantDescription.Text = string.Empty;
            txtDepartmantId.Text = string.Empty;
            txtDepartmantName.Text = string.Empty;
        }

        private void DepartmantList()
        {
            var values = from d in db.Departments
                         select new
                         {
                             d.DepartmentId,
                             d.DepartmentName,
                             d.DepartmentDescription
                         };
            grcDepartmantList.DataSource = values.ToList();
        }

        private void AssignDepartmantInfo(Department departmant)
        {
            departmant.DepartmentName = txtDepartmantName.Text;
            departmant.DepartmentDescription = txtDepartmantDescription.Text;
        }

        #endregion

    }
}
