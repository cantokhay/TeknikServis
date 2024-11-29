﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TeknikServis.DataAccessLayer.Context;
using TeknikServis.EntityLayer.ConcreteModels;

namespace TeknikServis.Forms
{
    public partial class FrmSaleList : Form
    {
        public FrmSaleList()
        {
            InitializeComponent();
        }

        TeknikServisContext db = new TeknikServisContext();

        private void FrmSaleList_Load(object sender, EventArgs e)
        {
            SaleList();
        }

        #region Extracted Methods

        private void SaleList()
        {
            var saleList = from s in db.Sales
                           join p in db.Products on s.Product equals p.ProductId
                           join c in db.Customers on s.Customer equals c.CustomerId
                           join e in db.Employees on s.Employee equals e.EmployeeId
                           select new
                           {
                               s.SaleId,
                               Product = p.ProductName,
                               Customer = c.CustomerFirstName + " " + c.CustomerLastName,
                               Employee = e.EmployeeFirstName + " " + e.EmployeeLastName,
                               s.SaleDate,
                               s.SaleQuantity,
                               s.SaleTotalPrice,
                               s.ProductSerialNumber
                           };
            grcSaleList.DataSource = saleList.ToList();
        }

        #endregion
    }
}
