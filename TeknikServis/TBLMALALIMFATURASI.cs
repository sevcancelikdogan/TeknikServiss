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
    
    public partial class TBLMALALIMFATURASI
    {
        public int ID { get; set; }
        public Nullable<int> CARI { get; set; }
        public Nullable<short> PERSONEL { get; set; }
        public string VERGIDAIRESI { get; set; }
        public string VKN { get; set; }
        public Nullable<short> ADET { get; set; }
        public string AD { get; set; }
        public Nullable<System.DateTime> ALISTARIHI { get; set; }
        public Nullable<decimal> ALISBEDELI { get; set; }
        public Nullable<int> STOKKODU { get; set; }
        public Nullable<int> FATURATIPIID { get; set; }
        public Nullable<decimal> TOPLAM { get; set; }
    
        public virtual TBLFATURATIPLERI TBLFATURATIPLERI { get; set; }
        public virtual TBLSABITKIYMET TBLSABITKIYMET { get; set; }
        public virtual TBLPERSONEL TBLPERSONEL { get; set; }
        public virtual TBLCARI TBLCARI { get; set; }
    }
}
