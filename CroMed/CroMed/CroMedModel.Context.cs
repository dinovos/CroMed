﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CroMed
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class CroMedDB_DataEntities : DbContext
    {
        public CroMedDB_DataEntities()
            : base("name=CroMedDB_DataEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Dokument> Dokument { get; set; }
        public virtual DbSet<Kategorija> Kategorija { get; set; }
        public virtual DbSet<PoslovniSubjekt> PoslovniSubjekt { get; set; }
        public virtual DbSet<Proizvodi> Proizvodi { get; set; }
        public virtual DbSet<RazinaOvlasti> RazinaOvlasti { get; set; }
        public virtual DbSet<StanjeDokumenta> StanjeDokumenta { get; set; }
        public virtual DbSet<VrstaSubjekta> VrstaSubjekta { get; set; }
        public virtual DbSet<Zaposlenik> Zaposlenik { get; set; }
        public virtual DbSet<PromjeneStanjaDokumenta> PromjeneStanjaDokumenta { get; set; }
        public virtual DbSet<StavkeDokumenta> StavkeDokumenta { get; set; }
    }
}