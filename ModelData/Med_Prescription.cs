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
    
    public partial class Med_Prescription
    {
        public Med_Prescription()
        {
            this.Med_Pres_type_Pres = new HashSet<Med_Pres_type_Pres>();
        }
    
        public int Prescrip_id { get; set; }
        public Nullable<int> Med_id { get; set; }
        public Nullable<decimal> Quantity { get; set; }
        public Nullable<int> Med_manualTimeId { get; set; }
        public Nullable<int> Med_manualDayId { get; set; }
        public Nullable<System.DateTime> Consulltdate { get; set; }
        public Nullable<short> Isdeliver { get; set; }
        public Nullable<System.DateTime> DeliverDate { get; set; }
    
        public virtual Med_Details Med_Details { get; set; }
        public virtual Med_ManualDay Med_ManualDay { get; set; }
        public virtual Med_ManualTime Med_ManualTime { get; set; }
        public virtual ICollection<Med_Pres_type_Pres> Med_Pres_type_Pres { get; set; }
    }
}
