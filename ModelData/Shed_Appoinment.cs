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
    
    public partial class Shed_Appoinment
    {
        public int AppointmntId { get; set; }
        public Nullable<System.DateTime> Appoinmt_Date { get; set; }
        public Nullable<decimal> Appoinmt_Time { get; set; }
        public Nullable<int> App_Emp_Id { get; set; }
        public Nullable<int> App_patient_Id { get; set; }
        public Nullable<short> Isactive { get; set; }
    
        public virtual Emp_Employee Emp_Employee { get; set; }
        public virtual Emp_Patient Emp_Patient { get; set; }
    }
}
