//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ShowCase
{
    using System;
    using System.Collections.Generic;
    
    public partial class Storage
    {
        public int ID_storage { get; set; }
        public int Id_product { get; set; }
        public int id_supply { get; set; }
        public int Available_items { get; set; }
        public System.DateTime FinalDate { get; set; }
    
        public virtual Supply Supply { get; set; }
    }
}
