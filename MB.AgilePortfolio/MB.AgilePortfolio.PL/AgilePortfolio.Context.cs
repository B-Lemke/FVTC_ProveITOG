﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MB.AgilePortfolio.PL
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class PortfolioEntities : DbContext
    {
        public PortfolioEntities()
            : base("name=PortfolioEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<tblLanguage> tblLanguages { get; set; }
        public virtual DbSet<tblPortfolio> tblPortfolios { get; set; }
        public virtual DbSet<tblPortfolioProject> tblPortfolioProjects { get; set; }
        public virtual DbSet<tblPrivacy> tblPrivacies { get; set; }
        public virtual DbSet<tblProject> tblProjects { get; set; }
        public virtual DbSet<tblProjectLanguage> tblProjectLanguages { get; set; }
        public virtual DbSet<tblScreenshot> tblScreenshots { get; set; }
        public virtual DbSet<tblUser> tblUsers { get; set; }
        public virtual DbSet<tblUserType> tblUserTypes { get; set; }
        public virtual DbSet<tblStatus> tblStatuses { get; set; }
    }
}
