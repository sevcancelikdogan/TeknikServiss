//------------------------------------------------------------------------------
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
    using System.Collections.Generic;
    
    public partial class TBLIADEFATURASI
    {
        public int ID { get; set; }
        public string SIRANO { get; set; }
        public Nullable<System.DateTime> TARIH { get; set; }
        public Nullable<int> URUN { get; set; }
        public string MARKA { get; set; }
        public Nullable<short> ADET { get; set; }
        public Nullable<int> CARI { get; set; }
        public Nullable<short> PERSONEL { get; set; }
        public string SAAT { get; set; }
        public Nullable<decimal> FIYAT { get; set; }
        public Nullable<decimal> TUTAR { get; set; }
        public Nullable<int> FATURATIPI { get; set; }
        public string SERI { get; set; }
        public string VERGIDAIRESI { get; set; }
    
        public virtual TBLCARI TBLCARI { get; set; }
        public virtual TBLFATURATIPLERI TBLFATURATIPLERI { get; set; }
        public virtual TBLPERSONEL TBLPERSONEL { get; set; }
        public virtual TBLURUN TBLURUN { get; set; }
    }
}