﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CasePortal.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class CasePortalEntities : DbContext
    {
        public CasePortalEntities()
            : base("name=CasePortalEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<District> Districts { get; set; }
        public virtual DbSet<Document> Documents { get; set; }
        public virtual DbSet<IncidentTyle> IncidentTyles { get; set; }
        public virtual DbSet<Log> Logs { get; set; }
        public virtual DbSet<Medium> Media { get; set; }
    }
}