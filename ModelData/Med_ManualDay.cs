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
    
    public partial class Med_ManualDay
    {
        public Med_ManualDay()
        {
            this.Med_Prescription = new HashSet<Med_Prescription>();
        }
    
        public int Med_Manual_day_Id { get; set; }
        public string Med_Manual_day { get; set; }
    
        public virtual ICollection<Med_Prescription> Med_Prescription { get; set; }
    }
}
