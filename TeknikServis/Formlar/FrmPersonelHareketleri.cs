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
    public partial class FrmPersonelHareketleri : Form
    {
        public FrmPersonelHareketleri()
        {
            InitializeComponent();
        }
        DbTeknikServisEntities1 db = new DbTeknikServisEntities1();
        private void FrmPersonelHareketleri_Load(object sender, EventArgs e)
        {


            gridControl1.DataSource = (from x in db.TBLURUNHAREKET
                                       select new
                                       {

                                           PERSONEL = x.TBLPERSONEL.AD + " " + x.TBLPERSONEL.SOYAD,
                                           İŞLEMNUMARASI = x.HAREKETID,
                                           MÜŞTERİ = x.TBLCARI.AD + " " + x.TBLCARI.SOYAD,
                                           x.TARIH,
                                           x.ADET,
                                           FİYAT = x.FIYAT,
                                           ÜRÜNSERİNUMARASI = x.URUNSERINO
                                       }).ToList();



            gridControl2.DataSource = (from x in db.TBLURUNKABUL
                                       select new
                                       {
                                           PERSONEL = x.TBLPERSONEL.AD + " " + x.TBLPERSONEL.SOYAD,
                                           İŞLEMNUMARASI = x.ISLEMID,
                                           CARİ = x.TBLCARI.AD + " " + x.TBLCARI.SOYAD,
                                           GELİŞTARİHİ = x.GELISTARIHI,
                                           CIKIŞTARİHİ = x.CIKISTARIHI,
                                           SERİNUMARASI = x.URUNSERINO,
                                           DURUMDETAY = x.URUNDURUMDETAY

                                       }).ToList();
        }
    }
}
