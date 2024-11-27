
namespace TeknikServis.EntityLayer.ConcreteModels
{
    public class Action
    {
        public int ActionId { get; set; } 
        public int Product { get; set; } 
        public int Customer { get; set; } 
        public short Employee { get; set; } 
        public System.DateTime AcceptedDate { get; set; }
        public System.DateTime CompletedDate { get; set; }

        public Product ProductNavigation { get; set; }
        public Customer CustomerNavigation { get; set; }
        public Employee EmployeeNavigation { get; set; }
    }

}
