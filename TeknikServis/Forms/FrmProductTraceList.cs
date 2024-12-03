﻿using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using TeknikServis.DataAccessLayer.Context;

namespace TeknikServis.Forms
{
    public partial class FrmProductTraceList : Form
    {
        public FrmProductTraceList()
        {
            InitializeComponent();
        }

        TeknikServisContext db = new TeknikServisContext();

        private void FrmProductTraceList_Load(object sender, EventArgs e)
        {
            ProductTraceList();
        }

        #region

        private void ProductTraceList()
        {
            var productTraceList = db.ProductTraces
               .Select(pt => new
               {
                   pt.ProductTraceId,
                   pt.ProductTraceDate,
                   ProductTraceDetail = pt.ProductTraceInformation,
                   SaleDate = db.Sales
                       .Where(s => s.ProductSerialNumber == pt.ProductSerialNumber)
                       .Select(s => s.SaleDate)
                       .FirstOrDefault(),
                   ProductName = db.Sales
                       .Where(s => s.ProductSerialNumber == pt.ProductSerialNumber)
                       .Select(s => db.Products.Where(p => p.ProductId == s.Product)
                       .Select(p => p.ProductName).FirstOrDefault())
                       .FirstOrDefault(),
                   CustomerName = db.Sales
                       .Where(s => s.ProductSerialNumber == pt.ProductSerialNumber)
                       .Select(s => db.Customers.Where(c => c.CustomerId == s.Customer)
                       .Select(c => c.CustomerFirstName + " " + c.CustomerLastName).FirstOrDefault())
                       .FirstOrDefault(),
                   EmployeeName = db.Sales
                       .Where(s => s.ProductSerialNumber == pt.ProductSerialNumber)
                       .Select(s => db.Employees.Where(e => e.EmployeeId == s.Employee)
                       .Select(e => e.EmployeeFirstName + " " + e.EmployeeLastName).FirstOrDefault())
                       .FirstOrDefault(),
                   Action = db.Actions
                       .Where(a => a.ProductSerialNumber == pt.ProductSerialNumber)
                       .Select(a => a.ActionId)
                       .FirstOrDefault()
               })
               .ToList();

            grcProductTraceList.DataSource = productTraceList;
        }

        #endregion
    }
}
