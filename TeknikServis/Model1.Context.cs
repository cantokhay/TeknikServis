﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TeknikServis
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class TeknikServisDBEntitiesLaptop : DbContext
    {
        public TeknikServisDBEntitiesLaptop()
            : base("name=TeknikServisDBEntitiesLaptop")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Action> Action { get; set; }
        public virtual DbSet<Admin> Admin { get; set; }
        public virtual DbSet<Category> Category { get; set; }
        public virtual DbSet<Customer> Customer { get; set; }
        public virtual DbSet<Departmant> Departmant { get; set; }
        public virtual DbSet<Employee> Employee { get; set; }
        public virtual DbSet<Expense> Expense { get; set; }
        public virtual DbSet<FaultDetail> FaultDetail { get; set; }
        public virtual DbSet<Invoice> Invoice { get; set; }
        public virtual DbSet<InvoiceDetail> InvoiceDetail { get; set; }
        public virtual DbSet<Note> Note { get; set; }
        public virtual DbSet<Product> Product { get; set; }
        public virtual DbSet<ProductTrace> ProductTrace { get; set; }
        public virtual DbSet<Sale> Sale { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
    }
}
