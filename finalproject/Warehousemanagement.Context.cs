﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace finalproject
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class WarehousemanagementEntities : DbContext
    {
        public WarehousemanagementEntities()
            : base("name=WarehousemanagementEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<tblAgent> tblAgent { get; set; }
        public virtual DbSet<tblBillDetail> tblBillDetail { get; set; }
        public virtual DbSet<tblCategory> tblCategory { get; set; }
        public virtual DbSet<tblEmployee> tblEmployee { get; set; }
        public virtual DbSet<tblGood> tblGood { get; set; }
        public virtual DbSet<tblGoodRecieve> tblGoodRecieve { get; set; }
    }
}
