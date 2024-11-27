using System;

namespace TeknikServis.EntityLayer.ConcreteModels
{
    public class ProductTrace
    {
        public int ProductTraceId { get; set; }
        public int Product { get; set; }
        public string ProductCondition { get; set; }
        public DateTime ProductTraceDate { get; set; }
        public string ProductTraceCode { get; set; }

        public Product ProductNavigation { get; set; }
    }

}
