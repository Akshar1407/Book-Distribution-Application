//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace FINAL_PROJECT.MODEL
{
    using System;
    using System.Collections.Generic;
    
    public partial class Order
    {
        public int OrderId { get; set; }
        public Nullable<System.DateTime> OrderDate { get; set; }
        public string OrderType { get; set; }
        public Nullable<System.DateTime> RequiredDate { get; set; }
        public Nullable<System.DateTime> ShippingDate { get; set; }
        public Nullable<int> StatusId { get; set; }
        public Nullable<int> CustomerId { get; set; }
        public Nullable<int> EmployeeId { get; set; }
        public Nullable<decimal> Payment { get; set; }
    
        public virtual Customer Customer { get; set; }
        public virtual Employee Employee { get; set; }
        public virtual Status Status { get; set; }
    }
}