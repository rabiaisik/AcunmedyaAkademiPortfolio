﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AcunmedyaAkademiPortfolio.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class DbAcunmedyaakademi1Entities : DbContext
    {
        public DbAcunmedyaakademi1Entities()
            : base("name=DbAcunmedyaakademi1Entities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<Table_category> Table_category { get; set; }
        public virtual DbSet<Table_project> Table_project { get; set; }
        public virtual DbSet<Table_service> Table_service { get; set; }
        public virtual DbSet<Table_testimoniall> Table_testimoniall { get; set; }
        public virtual DbSet<TblEducation> TblEducation { get; set; }
        public virtual DbSet<TblExperience> TblExperience { get; set; }
        public virtual DbSet<TblMessage> TblMessage { get; set; }
        public virtual DbSet<TblSkill> TblSkill { get; set; }
        public virtual DbSet<TblHakkimda> TblHakkimda { get; set; }
        public virtual DbSet<TblStats> TblStats { get; set; }
        public virtual DbSet<Tblİletisim> Tblİletisim { get; set; }
    }
}
