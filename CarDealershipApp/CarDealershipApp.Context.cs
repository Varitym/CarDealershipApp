﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CarDealershipApp
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class CarDealershipAppDBEntities : DbContext
    {
        public CarDealershipAppDBEntities()
            : base("name=CarDealershipAppDBEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<car> cars { get; set; }
        public virtual DbSet<customer> customers { get; set; }
        public virtual DbSet<dealer> dealers { get; set; }
        public virtual DbSet<sale> sales { get; set; }
    }
}
