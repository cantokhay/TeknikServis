//------------------------------------------------------------------------------
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
    using System.Collections.Generic;
    
    public partial class FaultDetail
    {
        public int FaultId { get; set; }
        public Nullable<int> Action { get; set; }
        public string FaultProblem { get; set; }
        public string FaultDescription { get; set; }
        public Nullable<decimal> FaultPrePrice { get; set; }
        public Nullable<decimal> FaultFinishPrice { get; set; }
        public string FaultOperation { get; set; }
    }
}
