using System;
using System.Linq;
using System.Windows.Forms;
using TeknikServis.DataAccessLayer.Context;

namespace TeknikServis.Forms
{
    public partial class FrmActionsList : Form
    {
        public FrmActionsList()
        {
            InitializeComponent();
        }

        TeknikServisContext db = new TeknikServisContext();

        private void FrmActionsList_Load(object sender, EventArgs e)
        {
            ActionsList();
        }

        #region Extracted Methods

        private void ActionsList()
        {
            var values = db.Actions.Select(x => new
            {
                x.ActionId,
                Customer = x.CustomerNavigation.CustomerFirstName + " " + x.CustomerNavigation.CustomerLastName,
                Employee = x.EmployeeNavigation.EmployeeFirstName + " " + x.EmployeeNavigation.EmployeeLastName,
                x.ProductSerialNumber,
                x.AcceptedDate,
                x.CompletedDate
            }).ToList();
            grcActionsList.DataSource = values;
        }

        #endregion


    }
}
