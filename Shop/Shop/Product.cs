//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Shop
{
    using System;
    using System.Collections.Generic;
    
    public partial class Product
    {
        public Product()
        {
            this.Discount = new HashSet<Discount>();
            this.Orders = new HashSet<Orders>();
            this.Supply = new HashSet<Supply>();
        }
    
        public int ID_prod { get; set; }
        public string Name { get; set; }
        public Nullable<int> Expiry_time { get; set; }
        public Nullable<int> ID_category { get; set; }
        public Nullable<int> ID_producer { get; set; }
    
        public virtual Category Category { get; set; }
        public virtual ICollection<Discount> Discount { get; set; }
        public virtual ICollection<Orders> Orders { get; set; }
        public virtual Producer Producer { get; set; }
        public virtual ICollection<Supply> Supply { get; set; }
    }
}
