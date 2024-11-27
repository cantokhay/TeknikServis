using System;

namespace TeknikServis.EntityLayer.ConcreteModels
{
    public class Expense
    {
        public int ExpenseId { get; set; }
        public string ExpenseDescription { get; set; }
        public DateTime ExpenseDate { get; set; }
        public decimal ExpenseTotalPrice { get; set; }
    }
}
