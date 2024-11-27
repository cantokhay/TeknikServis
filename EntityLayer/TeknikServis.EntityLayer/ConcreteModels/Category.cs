using System.Collections.Generic;

namespace TeknikServis.EntityLayer.ConcreteModels
{
    public class Category
    {
        public byte CategoryId { get; set; }
        public string CategoryName { get; set; }

        public ICollection<Product> Products { get; set; }
    }

}
