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
    public partial class Frmİstatik : Form
    {
        public Frmİstatik()
        {
            InitializeComponent();
        }

        DbTeknikServisEntities1 db = new DbTeknikServisEntities1();

        private void Frmİstatik_Load(object sender, EventArgs e)
        {
            labelControl2.Text = db.TBLURUN.Count().ToString();
            labelControl3.Text = db.TBLKATEGORI.Count().ToString();
            labelControl5.Text = db.TBLURUN.Sum(x => x.STOK).ToString();
            labelControl19.Text = (from x in db.TBLURUN    // ürün tablosundaki değerleri x e atıyor
                                  orderby x.STOK descending //daha sonra stok alanını z-den a-ya sıralıyor
                                  select x.AD).FirstOrDefault(); //ilk gelen değeri seçiyor
            labelControl18.Text = (from x in db.TBLURUN
                                   orderby x.STOK ascending  //stok alanını a-dan z-ye sıralıyor
                                   select x.AD).FirstOrDefault();
            labelControl13.Text = (from x in db.TBLURUN
                                   orderby x.SATISFIYAT descending
                                   select x.AD).FirstOrDefault();
            labelControl12.Text = (from x in db.TBLURUN
                                   orderby x.SATISFIYAT ascending
                                   select x.AD).FirstOrDefault();
            labelControl37.Text = db.TBLURUN.Count(x => x.KATEGORI == 5).ToString();
            labelControl33.Text = db.TBLURUN.Count(x => x.KATEGORI == 1).ToString();
            labelControl31.Text = db.TBLURUN.Count(x => x.KATEGORI == 4).ToString(); //ürünler tablosundan marka alanı
            labelControl29.Text = (from x in db.TBLURUN                              // tekrarsız şekilde ssaydırdı
                                   select x.MARKA).Distinct().Count().ToString();
            labelControl27.Text = db.TBLURUNKABUL.Count().ToString();
            labelControl16.Text = db.makskategoriurun().FirstOrDefault();
            labelControl39.Text = db.TBLURUNKABUL.Count(x => x.URUNDURUMDETAY == "Tadilatı Bitti").ToString();
            labelControl35.Text = db.TBLURUNKABUL.Count(x => x.URUNDURUMDETAY == "Kargoya Verildi").ToString();
            labelControl23.Text = db.TBLURUNKABUL.Count(x => x.URUNDURUMDETAY == "Tamirde").ToString();
            labelControl27.Text = db.TBLURUNKABUL.Count().ToString();
            DateTime bugun = DateTime.Today;
            var deger = db.TBLURUNKABUL.Count(x => x.GELISTARIHI == bugun);
           labelControl21.Text = deger.ToString();
            var degr = db.TBLURUNHAREKET.Count(x => x.TARIH == bugun);
            labelControl9.Text = degr.ToString();           
            labelControl7.Text = (from x in db.TBLURUN
                                   orderby x.STOK ascending  //stok alanını a-dan z-ye sıralıyor
                                   select x.MARKA).FirstOrDefault();
            labelControl25.Text = db.enfazlaurunolanmarka1().FirstOrDefault();
        }

        private void labelControl7_Click(object sender, EventArgs e)
        {
            
            
        }
    }
}
