﻿using System;

namespace TeknikServis.EntityLayer.ConcreteModels
{
    public class FaultDetail
    {
        public int FaultDetailId { get; set; }
        public int Action { get; set; }
        public string FaultProblem { get; set; }
        public string FaultDescription { get; set; }
        public decimal FaultPrePrice { get; set; }
        public decimal FaultNetPrice { get; set; }
        public string FaultOperation { get; set; }
    }
}
