﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TeknikServis
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class DbTeknikServisEntities1 : DbContext
    {
        public DbTeknikServisEntities1()
            : base("name=DbTeknikServisEntities1")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<TBLADMIN> TBLADMIN { get; set; }
        public virtual DbSet<TBLCARI> TBLCARI { get; set; }
        public virtual DbSet<TBLDEPARTMAN> TBLDEPARTMAN { get; set; }
        public virtual DbSet<TBLFATURABILGI> TBLFATURABILGI { get; set; }
        public virtual DbSet<TBLFATURADETAY> TBLFATURADETAY { get; set; }
        public virtual DbSet<TBLGIDER> TBLGIDER { get; set; }
        public virtual DbSet<TBLIL> TBLIL { get; set; }
        public virtual DbSet<TBLILCE> TBLILCE { get; set; }
        public virtual DbSet<TBLKATEGORI> TBLKATEGORI { get; set; }
        public virtual DbSet<TBLNOTLARIM> TBLNOTLARIM { get; set; }
        public virtual DbSet<TBLPERSONEL> TBLPERSONEL { get; set; }
        public virtual DbSet<TBLURUN> TBLURUN { get; set; }
        public virtual DbSet<TBLURUNHAREKET> TBLURUNHAREKET { get; set; }
        public virtual DbSet<TBLURUNKABUL> TBLURUNKABUL { get; set; }
        public virtual DbSet<TBLURUNTAKIP> TBLURUNTAKIP { get; set; }
        public virtual DbSet<TBLARACLAR> TBLARACLAR { get; set; }
        public virtual DbSet<TBLHAKKIMIZDA> TBLHAKKIMIZDA { get; set; }
        public virtual DbSet<TBLILETISIM> TBLILETISIM { get; set; }
        public virtual DbSet<TBLARIZAFATURA1> TBLARIZAFATURA1Set { get; set; }
        public virtual DbSet<TBLARIZAFATURADETAY> TBLARIZAFATURADETAY { get; set; }
        public virtual DbSet<TBLSATINALMAFATURASIBILGI> TBLSATINALMAFATURASIBILGI { get; set; }
        public virtual DbSet<TBLSATINALMAFATURASIDETAY> TBLSATINALMAFATURASIDETAY { get; set; }
        public virtual DbSet<TBLFATURATIPLERI> TBLFATURATIPLERI { get; set; }
        public virtual DbSet<TBLMALALIMFATURASI> TBLMALALIMFATURASI { get; set; }
        public virtual DbSet<TBLMALSATIMFATURASI> TBLMALSATIMFATURASI { get; set; }
        public virtual DbSet<TBLSABITKIYMET> TBLSABITKIYMET { get; set; }
        public virtual DbSet<TBLFISTIPI> TBLFISTIPI { get; set; }
        public virtual DbSet<TBLURUNHAREKETSATINALMA> TBLURUNHAREKETSATINALMA { get; set; }
        public virtual DbSet<TBLIADEFATURASI> TBLIADEFATURASI { get; set; }
        public virtual DbSet<TBLIRSALIYE> TBLIRSALIYE { get; set; }
        public virtual DbSet<TBLKULLANICI> TBLKULLANICI { get; set; }
        public virtual DbSet<TBLYETKIDURUMU> TBLYETKIDURUMU { get; set; }
        public virtual DbSet<TBLYETKITANIM> TBLYETKITANIM { get; set; }
    
        public virtual ObjectResult<urunkategori_Result> urunkategori()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<urunkategori_Result>("urunkategori");
        }
    
        public virtual ObjectResult<string> makskategoriurun()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<string>("makskategoriurun");
        }
    
        public virtual ObjectResult<string> marksurunmarka()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<string>("marksurunmarka");
        }
    
        public virtual int kritikseviye()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("kritikseviye");
        }
    
        public virtual ObjectResult<Nullable<int>> kritikseviyee()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Nullable<int>>("kritikseviyee");
        }
    
        public virtual ObjectResult<Nullable<decimal>> bugunsatilan()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Nullable<decimal>>("bugunsatilan");
        }
    
        public virtual ObjectResult<enfazlaurunolanmarka_Result> enfazlaurunolanmarka()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<enfazlaurunolanmarka_Result>("enfazlaurunolanmarka");
        }
    
        public virtual ObjectResult<string> enfazlaurunolanmarka1()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<string>("enfazlaurunolanmarka1");
        }
    
        public virtual ObjectResult<string> vergidairesi()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<string>("vergidairesi");
        }
    }
}