//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ModelData
{
    using System;
    using System.Collections.Generic;
    
    public partial class Med_Pres_Type
    {
        public Med_Pres_Type()
        {
            this.Med_Pres_type_Pres = new HashSet<Med_Pres_type_Pres>();
        }
    
        public int Pres_Type_ID { get; set; }
        public string Pres_Type { get; set; }
    
        public virtual ICollection<Med_Pres_type_Pres> Med_Pres_type_Pres { get; set; }
    }
}