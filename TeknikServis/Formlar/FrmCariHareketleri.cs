using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TeknikServis.Formlar
{
    public partial class FrmCariHareketleri : Form
    {
        public FrmCariHareketleri()
        {
            InitializeComponent();
        }
        DbTeknikServisEntities1 db = new DbTeknikServisEntities1();
        private void FrmCariHareketleri_Load(object sender, EventArgs e)
        {
            gridControl1.DataSource = (from x in db.TBLURUNHAREKET
                                       select new
                                       {
                                           MÜŞTERİ = x.TBLCARI.AD + " " + x.TBLCARI.SOYAD,                                          
                                           İŞLEMNUMARASI = x.HAREKETID,                                          
                                           x.TARIH,
                                           x.ADET,
                                           FİYAT = x.FIYAT,
                                           ÜRÜNSERİNUMARASI = x.URUNSERINO,
                                           PERSONEL = x.TBLPERSONEL.AD + " " + x.TBLPERSONEL.SOYAD,
                                       }).ToList();



            gridControl2.DataSource = (from x in db.TBLURUNKABUL
                                       select new
                                       {
                                           CARİ = x.TBLCARI.AD + " " + x.TBLCARI.SOYAD,
                                           İŞLEMNUMARASI = x.ISLEMID,                                     
                                           GELİŞTARİHİ = x.GELISTARIHI,
                                           CIKIŞTARİHİ = x.CIKISTARIHI,
                                           SERİNUMARASI = x.URUNSERINO,
                                           DURUMDETAY = x.URUNDURUMDETAY,
                                           PERSONEL = x.TBLPERSONEL.AD + " " + x.TBLPERSONEL.SOYAD
                                       }).ToList();
        }
    }
}
