﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class HospitalEntities : DbContext
    {
        public HospitalEntities()
            : base("name=HospitalEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<C__MigrationHistory> C__MigrationHistory { get; set; }
        public virtual DbSet<AspNetRole> AspNetRoles { get; set; }
        public virtual DbSet<AspNetUserClaim> AspNetUserClaims { get; set; }
        public virtual DbSet<AspNetUserLogin> AspNetUserLogins { get; set; }
        public virtual DbSet<Emp_Designtion> Emp_Designtion { get; set; }
        public virtual DbSet<Emp_Doc_Specialist> Emp_Doc_Specialist { get; set; }
        public virtual DbSet<Emp_Employee> Emp_Employee { get; set; }
        public virtual DbSet<Emp_Patient> Emp_Patient { get; set; }
        public virtual DbSet<Med_Details> Med_Details { get; set; }
        public virtual DbSet<Med_ManualDay> Med_ManualDay { get; set; }
        public virtual DbSet<Med_ManualTime> Med_ManualTime { get; set; }
        public virtual DbSet<Med_Pres_Type> Med_Pres_Type { get; set; }
        public virtual DbSet<Med_Pres_type_Pres> Med_Pres_type_Pres { get; set; }
        public virtual DbSet<Med_Prescription> Med_Prescription { get; set; }
        public virtual DbSet<Med_quantity_type> Med_quantity_type { get; set; }
        public virtual DbSet<Med_Type> Med_Type { get; set; }
        public virtual DbSet<Shed_Appoinment> Shed_Appoinment { get; set; }
        public virtual DbSet<Shed_Available_Staff> Shed_Available_Staff { get; set; }
        public virtual DbSet<Shed_reshedule_Staff> Shed_reshedule_Staff { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<User_Account> User_Account { get; set; }
        public virtual DbSet<User_Group> User_Group { get; set; }
        public virtual DbSet<User_Group_Role> User_Group_Role { get; set; }
        public virtual DbSet<User_Role> User_Role { get; set; }
    }
}