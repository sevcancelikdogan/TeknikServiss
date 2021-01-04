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
    public partial class FrmCariListesi : Form
    {
        public FrmCariListesi()
        {
            InitializeComponent();
        }
        DbTeknikServisEntities1 db = new DbTeknikServisEntities1();
        int secilen;

        void listele()
        {
            var degerler = from u in db.TBLCARI
                           select new
                           {

                               NUMARA = u.ID,
                               u.AD,
                               u.SOYAD,
                               u.TELEFON,
                               MAİL = u.MAIL,
                               İL = u.IL,
                               İLÇE = u.ILCE,
                               u.BANKA,
                               VERGİDAİRESİ = u.VERGIDAIRESI,
                               VERGİNUMARASI=u.VERGINO,
                               STATÜ = u.STATU,
                               u.ADRES

                           };
            gridControl1.DataSource = degerler.ToList();
        }
            
        private void FrmCariListesi_Load(object sender, EventArgs e)
        {
            listele();

            labelControl18.Text = db.TBLCARI.Count().ToString();
            TxtIl.Properties.DataSource = (from x in db.TBLIL
                                           select new
                                           {
                                               x.ID,
                                               x.SEHIR
                                           }
                                           ).ToList();
            labelControl16.Text = db.TBLCARI.Select(x => x.IL).Distinct().Count().ToString();
            labelControl12.Text = db.TBLCARI.Select(x => x.ILCE).Distinct().Count().ToString();
            labelControl14.Text = db.TBLCARI.Max(x => x.IL).ToString();
            
        }

        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            try
            {
                TBLCARI t = new TBLCARI();
                t.AD = TxtCariAd.Text;
                t.SOYAD = TxtCariSoyadi.Text;
                t.MAIL = TxtMail.Text;
                t.TELEFON = TxtTelefon.Text;
                t.IL = TxtIl.Text;
                t.ILCE = TxtIlce.Text;
                t.BANKA = TxtBanka.Text;
                t.VERGIDAIRESI = TxtVergiDairesi.Text;
                t.VERGINO = TxtVergiNo.Text;
                t.STATU = TxtStatu.Text;
                t.ADRES = TxtAdres.Text;
                db.TBLCARI.Add(t);
                db.SaveChanges();
                MessageBox.Show("Cari Başarıyla Kaydedildi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                listele();
            }
            catch (Exception)
            {

                MessageBox.Show("Bilgileri Eksiksiz Doldurmalısınız");
            }
            
        }

        private void BtnSil_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtCariID.Text);
            var deger = db.TBLCARI.Find(id);
            db.TBLCARI.Remove(deger);
            db.SaveChanges();
            MessageBox.Show("Ürün başarıyla silindi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            listele();
        }

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            try
            {
                int id = int.Parse(txtCariID.Text);
                var deger = db.TBLCARI.Find(id);
                deger.AD = TxtCariAd.Text;
                deger.SOYAD = TxtCariSoyadi.Text;
                deger.MAIL = TxtMail.Text;
                deger.TELEFON = TxtTelefon.Text;
                deger.BANKA = TxtBanka.Text;
                deger.IL = TxtIl.Text;
                deger.ILCE = TxtIlce.Text;
                deger.VERGIDAIRESI = TxtVergiDairesi.Text;
                deger.VERGINO = TxtVergiNo.Text;
                deger.STATU = TxtStatu.Text;
                deger.ADRES = TxtAdres.Text;
                db.SaveChanges();
                MessageBox.Show("Cari başarıyla güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                listele();
            }
            catch (Exception)
            {

                MessageBox.Show("hata");
            }
           
        }

        private void BtnListele_Click(object sender, EventArgs e)
        {
            txtCariID.Text = "";
            TxtCariAd.Text = "";
            TxtCariSoyadi.Text = "";
            TxtTelefon.Text = "";
            TxtMail.Text = "";
            TxtBanka.Text="";
            TxtVergiDairesi.Text = "";
            TxtVergiNo.Text = "";
            TxtStatu.Text = "";
            TxtAdres.Text = "";
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
           txtCariID.Text = gridView1.GetFocusedRowCellValue("NUMARA").ToString();
           TxtCariAd.Text = gridView1.GetFocusedRowCellValue("AD").ToString();
           TxtCariSoyadi.Text = gridView1.GetFocusedRowCellValue("SOYAD").ToString();
           TxtTelefon.Text = gridView1.GetFocusedRowCellValue("TELEFON").ToString();
           TxtMail.Text = gridView1.GetFocusedRowCellValue("MAİL").ToString();
           TxtIl.Text = gridView1.GetFocusedRowCellValue("İL").ToString();
           TxtIlce.Text = gridView1.GetFocusedRowCellValue("İLÇE").ToString();
           TxtBanka.Text = gridView1.GetFocusedRowCellValue("BANKA").ToString();
           TxtVergiDairesi.Text = gridView1.GetFocusedRowCellValue("VERGİDAİRESİ").ToString();
           TxtVergiNo.Text = gridView1.GetFocusedRowCellValue("VERGİNUMARASI").ToString();
           TxtStatu.Text = gridView1.GetFocusedRowCellValue("STATÜ").ToString();
           TxtAdres.Text = gridView1.GetFocusedRowCellValue("ADRES").ToString();
        }

        private void TxtIl_EditValueChanged(object sender, EventArgs e)
        {
            secilen = int.Parse(TxtIl.EditValue.ToString());
            TxtIlce.Properties.DataSource = (from y in db.TBLILCE
                                             select new
                                             {
                                                 y.ID,
                                                 y.ILCE,
                                                 y.SEHIR
                                             }).Where(z => z.SEHIR == secilen).ToList();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
