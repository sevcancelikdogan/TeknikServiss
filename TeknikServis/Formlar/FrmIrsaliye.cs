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
    public partial class FrmIrsaliye : Form
    {
        public FrmIrsaliye()
        {
            InitializeComponent();
        }

        private void TxtFatura_Paint(object sender, PaintEventArgs e)
        {

        }

        private void BtnListele_Click(object sender, EventArgs e)
        {
            txtID.Text = "";
            TxtCari.Text = "";
            TxtUrun.Text = "";
            TxtSaat.Text = "";
            TxtTarih.Text = "";
            TxtSeriNo.Text = "";
            TxtMarka.Text = "";
            TxtVergiDairesi.Text = "";
            TxtAdet.Text = "";
            TxtSatisTutar.Text = "";
            TxtSevkSaat.Text = "";
            TxtIrsaliyeTarih.Text = "";
            TxtToplam.Text = "";
        }
        DbTeknikServisEntities1 db = new DbTeknikServisEntities1();

        void metot1()
        {
            var degerler = from u in db.TBLIRSALIYE
                           select new
                           {

                               NUMARA = u.ID,
                               TARİH = u.TARIH,
                               u.SAAT,
                               CARİ = u.TBLCARI.AD + " " + u.TBLCARI.SOYAD,
                               ÜRÜN = u.TBLURUN.AD,
                               ÜRÜNSERİNUMARASI = u.URUNSERINO,
                               u.MARKA,
                               VERGİDAİRESİ = u.VERGIDAIRESI,
                               u.ADET,
                               FİYAT = u.FIYAT,
                               SEVKTARİHİ = u.SEVKTARIHI,
                               SEVKSAATİ = u.SEVKSAATI,
                               TOPLAM = u.TUTAR,

                           };
            gridControl1.DataSource = degerler.ToList();
        }
        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            try
            {
                TBLIRSALIYE t = new TBLIRSALIYE();
                t.CARI = int.Parse(TxtCari.EditValue.ToString());
                t.URUN = int.Parse(TxtUrun.EditValue.ToString());
                t.TARIH = DateTime.Parse(TxtIrsaliyeTarih.Text);
                t.SAAT = TxtSaat.Text;
                t.URUNSERINO = TxtSeriNo.Text;
                t.MARKA = TxtMarka.Text;
                t.VERGIDAIRESI = TxtVergiDairesi.Text;
                t.ADET = short.Parse(TxtAdet.Text);
                t.FIYAT = decimal.Parse(TxtSatisTutar.EditValue.ToString());
                t.SEVKSAATI = TxtSevkSaat.Text;
                t.SEVKTARIHI = DateTime.Parse(TxtTarih.Text);
                t.TUTAR = decimal.Parse(TxtToplam.Text);
                db.TBLIRSALIYE.Add(t);
                db.SaveChanges();
                MessageBox.Show("İrsaliye Başarıyla Kaydedildi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                metot1();
            }
            catch
            {
                MessageBox.Show("İrsaliye Kaydedilemedi", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void FrmIrsalıye_Load(object sender, EventArgs e)
        {


            metot1();

            TxtCari.Properties.DataSource = (from x in db.TBLCARI
                                             select new
                                             {
                                                 NUMARASI = x.ID,
                                                 CARİ = x.AD + " " + x.SOYAD
                                             }).ToList();

            TxtUrun.Properties.DataSource = (from x in db.TBLURUN
                                             select new
                                             {
                                                 NUMARASI = x.ID,
                                                 ÜRÜN = x.AD,
                                                 x.MARKA
                                             }).ToList();
        }
        int secilen;
        private void TxtUrun_EditValueChanged(object sender, EventArgs e)
        {
            secilen = int.Parse(TxtUrun.EditValue.ToString());
            TxtSatisTutar.Properties.DataSource = (from x in db.TBLURUN
                                                   select new
                                                   {
                                                       NUMARASI = x.ID,
                                                       FİYAT = x.SATISFIYAT,


                                                   }).Where(z => z.NUMARASI == secilen).ToList();
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            txtID.Text = gridView1.GetFocusedRowCellValue("NUMARA").ToString();
            TxtIrsaliyeTarih.Text = gridView1.GetFocusedRowCellValue("TARİH").ToString();
            TxtSaat.Text = gridView1.GetFocusedRowCellValue("SAAT").ToString();
            TxtCari.Text = gridView1.GetFocusedRowCellValue("CARİ").ToString();
            TxtUrun.Text = gridView1.GetFocusedRowCellValue("ÜRÜN").ToString();
            TxtSeriNo.Text = gridView1.GetFocusedRowCellValue("ÜRÜNSERİNUMARASI").ToString();
            TxtMarka.Text = gridView1.GetFocusedRowCellValue("MARKA").ToString();
            TxtVergiDairesi.Text = gridView1.GetFocusedRowCellValue("VERGİDAİRESİ").ToString();
            TxtAdet.Text = gridView1.GetFocusedRowCellValue("ADET").ToString();
            TxtSatisTutar.Text = gridView1.GetFocusedRowCellValue("FİYAT").ToString();
            TxtToplam.Text = gridView1.GetFocusedRowCellValue("TOPLAM").ToString();
            TxtTarih.Text = gridView1.GetFocusedRowCellValue("SEVKTARİHİ").ToString();
            TxtSevkSaat.Text = gridView1.GetFocusedRowCellValue("SEVKSAATİ").ToString();
        }

        private void BtnSil_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtID.Text);
            var deger = db.TBLIRSALIYE.Find(id);
            db.TBLIRSALIYE.Remove(deger);
            MessageBox.Show("İrsaliye Başarıyla Silindi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            metot1();
        }

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            try
            {
                int id = int.Parse(txtID.Text);
                var deger = db.TBLIRSALIYE.Find(id);
                deger.CARI = int.Parse(TxtCari.EditValue.ToString());
                deger.URUN = int.Parse(TxtUrun.EditValue.ToString());
                deger.TARIH = DateTime.Parse(TxtIrsaliyeTarih.Text);
                deger.SAAT = TxtSaat.Text;
                deger.URUNSERINO = TxtSeriNo.Text;
                deger.MARKA = TxtMarka.Text;
                deger.VERGIDAIRESI = TxtVergiDairesi.Text;
                deger.ADET = short.Parse(TxtAdet.Text);
                deger.FIYAT = decimal.Parse(TxtSatisTutar.EditValue.ToString());
                deger.SEVKSAATI = TxtSevkSaat.Text;
                deger.SEVKTARIHI = DateTime.Parse(TxtTarih.Text);
                deger.TUTAR = decimal.Parse(TxtToplam.Text);
                db.SaveChanges();
                MessageBox.Show("İrsaliye Başarıyla Güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                metot1();
            }
        

            catch
            {
                MessageBox.Show("İrsaliye Güncellenemedi", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }
    }
}
