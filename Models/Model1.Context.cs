﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MeyawoPortfolio.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class DbMyPortfolioEntities1 : DbContext
    {
        public DbMyPortfolioEntities1()
            : base("name=DbMyPortfolioEntities1")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<TblAbout> TblAbout { get; set; }
        public virtual DbSet<TblCategory> TblCategory { get; set; }
        public virtual DbSet<TblContact> TblContact { get; set; }
        public virtual DbSet<TblFuture> TblFuture { get; set; }
        public virtual DbSet<TblProject> TblProject { get; set; }
        public virtual DbSet<TblService> TblService { get; set; }
        public virtual DbSet<TblSocialMedia> TblSocialMedia { get; set; }
        public virtual DbSet<TblTestimonial> TblTestimonial { get; set; }
        public virtual DbSet<TblAdminSidebar> TblAdminSidebar { get; set; }
    }
}
