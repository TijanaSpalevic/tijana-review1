//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace FoodDelivery.DBModel
{
    using System;
    using System.Collections.Generic;
    
    public partial class Order
    {
        public int OrderID { get; set; }
        public int UserID { get; set; }
        public int FoodID { get; set; }
        public System.DateTime Updated { get; set; }
        public System.DateTime Created { get; set; }
    
        public virtual Food Food { get; set; }
        public virtual User User { get; set; }
    }
}
