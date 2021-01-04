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
    public partial class FrmIadeFaturasi : Form
    {
        public FrmIadeFaturasi()
        {
            InitializeComponent();
        }

        private void TxtFatura_Paint(object sender, PaintEventArgs e)
        {

        }
        void metot1()
        {
            gridControl1.DataSource = (from x in db.TBLIADEFATURASI
                                       select new
                                       {
                                           NUMARA = x.ID,                                          
                                           SERİNUMARASI = x.SERI,
                                           SIRANUMARASI = x.SIRANO,
                                           TARİH = x.TARIH,
                                           ÜRÜN = x.TBLURUN.AD,
                                           x.MARKA,
                                           x.ADET,
                                           MÜŞTERİ = x.TBLCARI.AD + " " + x.TBLCARI.SOYAD,
                                           VERGİDAİRESİ = x.VERGIDAIRESI,
                                           PERSONEL = x.TBLPERSONEL.AD + " " + x.TBLPERSONEL.SOYAD,
                                           x.SAAT,
                                           FİYAT = x.FIYAT,
                                           x.TUTAR,
                                           FATURATİP = x.TBLFATURATIPLERI.FATURATIPI
                                           
                                       }).ToList();



        }
        DbTeknikServisEntities1 db = new DbTeknikServisEntities1();
        private void FrmIadeFaturasi_Load(object sender, EventArgs e)
        {
            metot1();
            TxtCari.Properties.DataSource = (from x in db.TBLCARI
                                             select new
                                             {
                                                 NUMARASI = x.ID,
                                                 MÜŞTERİ = x.AD + " " + x.SOYAD
                                             }).ToList();
            TxtPersonel.Properties.DataSource = (from x in db.TBLPERSONEL
                                                 select new
                                                 {
                                                     NUMARASI = x.ID,
                                                     PERSONEL = x.AD + " " + x.SOYAD
                                                 }).ToList();
            TxtUrun.Properties.DataSource = (from x in db.TBLURUN
                                             select new
                                             {
                                                 NUMARASI = x.ID,
                                                 ÜRÜN = x.AD,
                                                 x.MARKA
                                             }).ToList();

            TxtFaturaTipi.Properties.DataSource = (from x in db.TBLFATURATIPLERI
                                                   select new
                                                   {
                                                       x.ID,
                                                       FATURATİPİ = x.FATURATIPI,
                                                       
                                                   }).ToList();
        }
        int secilen;
        private void TxtUrun_EditValueChanged(object sender, EventArgs e)
        {
            secilen = int.Parse(TxtUrun.EditValue.ToString());
            TxtFiyat.Properties.DataSource = (from x in db.TBLURUN
                                              select new
                                              {
                                                  NUMARASI = x.ID,
                                                  FİYAT = x.SATISFIYAT,


                                              }).Where(z => z.NUMARASI == secilen).ToList();
        }


        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            try
            {
                TBLIADEFATURASI t = new TBLIADEFATURASI();
                t.SERI = TxtSeriNo.Text;
                t.FATURATIPI = int.Parse(TxtFaturaTipi.Text);
                t.SIRANO = TxtSiraNo.Text;
                t.URUN = int.Parse(TxtUrun.Text);
                t.MARKA = TxtMarka.Text;
                t.ADET = short.Parse(TxtAdet.Text);
                t.TARIH = DateTime.Parse(TxtTarih.Text);
                t.SAAT = TxtSaat.Text;
                t.VERGIDAIRESI = TxtVergiDairesi.Text;
                t.CARI = int.Parse(TxtCari.EditValue.ToString());
                t.PERSONEL = short.Parse(TxtPersonel.EditValue.ToString());
                t.FIYAT = decimal.Parse(TxtFiyat.Text);
                t.TUTAR = decimal.Parse(TxtTutar.Text);
                db.TBLIADEFATURASI.Add(t);
                db.SaveChanges();
                MessageBox.Show("Yeni Fatura Girişi Başarıyla Kaydedildi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                metot1();
            }
            catch
            {
                MessageBox.Show("Fatura Kaydedilemedi", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void BtnSil_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtID.Text);
            var deger = db.TBLIADEFATURASI.Find(id);
            db.TBLIADEFATURASI.Remove(deger);
            db.SaveChanges();
            MessageBox.Show("Fatura Başarıyla Silindi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            metot1();
        }

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
          /*    try
              {*/
                int id = int.Parse(txtID.Text);
                var deger = db.TBLIADEFATURASI.Find(id);
                deger.SERI = TxtSeriNo.Text;
                deger.FATURATIPI = int.Parse(TxtFaturaTipi.Text);
                deger.SIRANO = TxtSiraNo.Text;
                deger.URUN = int.Parse(TxtUrun.Text);
                deger.MARKA = TxtMarka.Text;
                deger.ADET = short.Parse(TxtAdet.Text);
                deger.TARIH = DateTime.Parse(TxtTarih.Text);
                deger.SAAT = TxtSaat.Text;
                deger.VERGIDAIRESI = TxtVergiDairesi.Text;
                deger.CARI = int.Parse(TxtCari.EditValue.ToString());
                deger.PERSONEL = short.Parse(TxtPersonel.EditValue.ToString());
                deger.FIYAT = decimal.Parse(TxtFiyat.Text);
                deger.TUTAR = decimal.Parse(TxtTutar.Text);
                db.SaveChanges();
                MessageBox.Show("Fatura Başarıyla Güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                metot1();
          /*  }
              catch (Exception)
              {

                  MessageBox.Show("Fatura Güncellenemedi", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
              }*/

        }

        private void BtnListele_Click(object sender, EventArgs e)
        {
            TxtSeriNo.Text = "";
            TxtSiraNo.Text = "";
            TxtFaturaTipi.Text = "";
            TxtCari.Text = "";
            TxtPersonel.Text = "";
            TxtUrun.Text = "";
            TxtMarka.Text = "";
            txtID.Text = "";
            TxtSaat.Text = "";
            TxtFiyat.Text = "";
            TxtTutar.Text = "";
            TxtVergiDairesi.Text = "";
            TxtAdet.Text = "";

        }

        private void gridView1_AfterPrintRow(object sender, DevExpress.XtraGrid.Views.Printing.PrintRowEventArgs e)
        {

        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            txtID.Text = gridView1.GetFocusedRowCellValue("NUMARA").ToString();
            TxtSeriNo.Text = gridView1.GetFocusedRowCellValue("SERİNUMARASI").ToString();
            TxtFaturaTipi.Text = gridView1.GetFocusedRowCellValue("FATURATİP").ToString();
            TxtSiraNo.Text = gridView1.GetFocusedRowCellValue("SIRANUMARASI").ToString();
            TxtTarih.Text = gridView1.GetFocusedRowCellValue("TARİH").ToString();
            TxtUrun.Text = gridView1.GetFocusedRowCellValue("ÜRÜN").ToString();
            TxtMarka.Text = gridView1.GetFocusedRowCellValue("MARKA").ToString();
            TxtAdet.Text = gridView1.GetFocusedRowCellValue("ADET").ToString();
            TxtCari.Text = gridView1.GetFocusedRowCellValue("MÜŞTERİ").ToString();
            TxtVergiDairesi.Text = gridView1.GetFocusedRowCellValue("VERGİDAİRESİ").ToString();
            TxtPersonel.Text = gridView1.GetFocusedRowCellValue("PERSONEL").ToString();
            TxtSaat.Text = gridView1.GetFocusedRowCellValue("SAAT").ToString();
            TxtFiyat.Text = gridView1.GetFocusedRowCellValue("FİYAT").ToString();
            TxtTutar.Text = gridView1.GetFocusedRowCellValue("TUTAR").ToString();
        }
    }
}
