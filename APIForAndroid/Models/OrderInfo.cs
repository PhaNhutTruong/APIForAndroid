//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace APIForAndroid.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class OrderInfo
    {
        public int Id { get; set; }
        public int IdOrder { get; set; }
        public int IdProduct { get; set; }
        public int Quantity { get; set; }
        public decimal Total { get; set; }
    
        public virtual Oder Oder { get; set; }
        public virtual Product Product { get; set; }
    }
}
