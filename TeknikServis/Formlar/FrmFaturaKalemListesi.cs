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
    public partial class FrmFaturaKalemListesi : Form
    {
        public FrmFaturaKalemListesi()
        {
            InitializeComponent();
        }
        DbTeknikServisEntities1 db = new DbTeknikServisEntities1();
        private void FrmFaturaKalemListesi_Load(object sender, EventArgs e)
        {
            metot1();

            TxtUrun.Properties.DataSource = (from x in db.TBLURUN
                                             select new
                                             {
                                                 NUMARA = x.ID,
                                                 ÜRÜN = x.AD + " " + x.MARKA
                                             }).ToList();

            TxtFaturaNumarasi.Properties.DataSource = (from x in db.TBLFATURABILGI
                                                       select new
                                                       {
                                                           NUMARASI = x.ID
                                                       }).ToList();
        }
        void metot1()
        {
            var degerler = from x in db.TBLFATURADETAY
                           select new
                           {
                               NUMARA = x.FATURADETAYID,
                               ÜRÜN = x.URUN,
                               x.MARKA,
                               x.ADET,
                               FİYAT = x.FIYAT,
                               x.TUTAR,
                               FATURANUMARASI = x.FATURAID
                           };
            gridControl1.DataSource = degerler.ToList();
        }
        int secilen;
        private void TxtUrun_EditValueChanged(object sender, EventArgs e)
        {
            secilen = int.Parse(TxtUrun.EditValue.ToString());
            TxtFiyat.Properties.DataSource = (from y in db.TBLURUN
                                              select new
                                              {
                                                  ÜRÜNNUMARASI = y.ID,
                                                  FİYAT = y.SATISFIYAT,

                                              }).Where(z => z.ÜRÜNNUMARASI == secilen).ToList();
        }

        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            try
            {
                TBLFATURADETAY t = new TBLFATURADETAY();
                t.URUN = TxtUrun.EditValue.ToString();
                t.MARKA = TxtMarka.Text;
                t.ADET = short.Parse(TxtAdet.Text);
                t.FIYAT = decimal.Parse(TxtFiyat.EditValue.ToString());
                t.TUTAR = decimal.Parse(TxtTutar.Text);
                t.FATURAID = int.Parse(TxtFaturaNumarasi.EditValue.ToString());
                db.TBLFATURADETAY.Add(t);
                db.SaveChanges();
                MessageBox.Show("Faturaya Ait Kalem Girişi Başarıyla Kayedildi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                metot1();
            }
            catch
            {

                MessageBox.Show("Lütfen Alanları Eksizsiz Doldurunuz", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnListele_Click(object sender, EventArgs e)
        {
            txtID.Text = "";
            TxtUrun.Text = "";
            TxtMarka.Text = "";
            TxtAdet.Text = "";
            TxtFiyat.Text = "";
            TxtTutar.Text = "";
            TxtFaturaNumarasi.Text = "";
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            txtID.Text = gridView1.GetFocusedRowCellValue("NUMARA").ToString();
            TxtUrun.Text = gridView1.GetFocusedRowCellValue("ÜRÜN").ToString();
            TxtMarka.Text = gridView1.GetFocusedRowCellValue("MARKA").ToString();
            TxtAdet.Text = gridView1.GetFocusedRowCellValue("ADET").ToString();
            TxtTutar.Text = gridView1.GetFocusedRowCellValue("TUTAR").ToString();
            TxtFiyat.Text = gridView1.GetFocusedRowCellValue("FİYAT").ToString();
            TxtFaturaNumarasi.Text = gridView1.GetFocusedRowCellValue("FATURANUMARASI").ToString();

        }

        private void BtnSil_Click(object sender, EventArgs e)
        {
            try
            {
                int id = int.Parse(txtID.Text);
                var deger = db.TBLFATURADETAY.Find(id);
                db.TBLFATURADETAY.Remove(deger);
                db.SaveChanges();
                MessageBox.Show("Fatura Detayı Başarıyla Silindi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                metot1();
            }
            catch
            {
                MessageBox.Show("Fatura Detayı Silinemedi", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            try
            {
                int id = int.Parse(txtID.Text);
                var deger = db.TBLFATURADETAY.Find(id);
                deger.URUN = TxtUrun.EditValue.ToString();
                deger.MARKA = TxtMarka.Text;
                deger.ADET = short.Parse(TxtAdet.Text);
                deger.TUTAR = decimal.Parse(TxtTutar.Text);
                deger.FIYAT = decimal.Parse(TxtFiyat.EditValue.ToString());
                deger.FATURAID = int.Parse(TxtFaturaNumarasi.EditValue.ToString());
                db.SaveChanges();
                MessageBox.Show("Fatura Ait Kalem Detayı Başarıyla Güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                metot1();
            }
            catch (Exception)
            {

                MessageBox.Show("Fatura Ait Kalem Detayı  Güncellenemedi", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
