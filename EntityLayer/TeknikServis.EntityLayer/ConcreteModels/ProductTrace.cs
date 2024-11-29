using System;

namespace TeknikServis.EntityLayer.ConcreteModels
{
    public class ProductTrace
    {
        public int ProductTraceId { get; set; }
        public DateTime ProductTraceDate { get; set; }
        public string ProductSerialNumber { get; set; }
        public string ProductTraceInformation { get; set; }
    }

}
