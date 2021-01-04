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
    public partial class FrmSabitkiymetAlis : Form
    {
        public FrmSabitkiymetAlis()
        {
            InitializeComponent();
        }
        DbTeknikServisEntities1 db = new DbTeknikServisEntities1();
        private void FrmSabitkiymetAlis_Load(object sender, EventArgs e)
        {
            metot1();

            TxtFaturaTipi.Properties.DataSource = (from x in db.TBLFATURATIPLERI
                                                   select new
                                                   {
                                                       NUMARASI = x.ID,
                                                       FATURATİPİ = x.FATURATIPI
                                                   }).ToList();
            TxtStokKodu.Properties.DataSource = (from x in db.TBLSABITKIYMET
                                                 select new
                                                 {
                                                     STOKKODU = x.ID,
                                                     MALZEME = x.AD
                                                 }).ToList();

            TxtCari.Properties.DataSource = (from x in db.TBLCARI
                                             select new
                                             {
                                                 NUMARASI = x.ID,
                                                 CARİ = x.AD + " " + x.SOYAD
                                             }).ToList();

            TxtPersonel.Properties.DataSource = (from x in db.TBLPERSONEL
                                                 select new
                                                 {
                                                     NUMARASI = x.ID,
                                                     PERSONEL = x.AD + " " + x.SOYAD
                                                 }).ToList();
        }
        void metot1()
        {
            var degerler = from u in db.TBLMALALIMFATURASI
                           select new
                           {

                               NUMARA = u.ID,
                               u.STOKKODU,
                               CARİ = u.TBLCARI.AD + " " + u.TBLCARI.SOYAD,
                               PERSONEL = u.TBLPERSONEL.AD + " " + u.TBLPERSONEL.SOYAD,
                               MALZEME = u.AD,
                               VERGİDAİRESİ = u.VERGIDAIRESI,
                               u.VKN,
                               u.ADET,
                               ALIŞTUTARI = u.ALISBEDELI,
                               ALIŞTARİHİ = u.ALISTARIHI,
                               FATURATİPİ = u.TBLFATURATIPLERI.FATURATIPI,
                               u.TOPLAM
                           };
            gridControl1.DataSource = degerler.ToList();
        }

        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            try
            {
                TBLMALALIMFATURASI t = new TBLMALALIMFATURASI();
                t.STOKKODU = int.Parse(TxtStokKodu.EditValue.ToString());
                t.CARI = int.Parse(TxtCari.EditValue.ToString());
                t.PERSONEL = short.Parse(TxtPersonel.EditValue.ToString());
                t.AD = TxtMalzeme.Text;
                t.VERGIDAIRESI = TxtVergiDairesi.Text;
                t.VKN = TxtVkn.Text;
                t.ADET = short.Parse(TxtAdet.Text);
                t.ALISBEDELI = decimal.Parse(TxtSatisTutar.Text);
                t.ALISTARIHI = DateTime.Parse(TxtTarih.Text);
                t.FATURATIPIID = int.Parse(TxtFaturaTipi.EditValue.ToString());
                t.TOPLAM = decimal.Parse(TxtToplam.Text);
                db.TBLMALALIMFATURASI.Add(t);
                db.SaveChanges();
                MessageBox.Show("Fatura Başarıyla Kaydedildi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                metot1();
            }
            catch
            {
                MessageBox.Show("Fatura Kaydedilemedi!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }

        private void BtnListele_Click(object sender, EventArgs e)
        {
            txtID.Text = "";
            TxtStokKodu.Text = "";
            TxtFaturaTipi.Text = "";
            TxtMalzeme.Text = "";
            TxtCari.Text = "";
            TxtPersonel.Text = "";
            TxtVergiDairesi.Text = "";
            TxtVkn.Text = "";
            TxtSatisTutar.Text = "";
            TxtTarih.Text = "";
            TxtAdet.Text = "";
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            txtID.Text = gridView1.GetFocusedRowCellValue("NUMARA").ToString();
            TxtStokKodu.Text = gridView1.GetFocusedRowCellValue("STOKKODU").ToString();
            TxtCari.Text = gridView1.GetFocusedRowCellValue("CARİ").ToString();
            TxtPersonel.Text = gridView1.GetFocusedRowCellValue("PERSONEL").ToString();
            TxtMalzeme.Text = gridView1.GetFocusedRowCellValue("MALZEME").ToString();
            TxtVkn.Text = gridView1.GetFocusedRowCellValue("VKN").ToString();
            TxtVergiDairesi.Text = gridView1.GetFocusedRowCellValue("VERGİDAİRESİ").ToString();
            TxtAdet.Text = gridView1.GetFocusedRowCellValue("ADET").ToString();
            TxtSatisTutar.Text = gridView1.GetFocusedRowCellValue("ALIŞTUTARI").ToString();
            TxtTarih.Text = gridView1.GetFocusedRowCellValue("ALIŞTARİHİ").ToString();
            TxtFaturaTipi.Text = gridView1.GetFocusedRowCellValue("FATURATİPİ").ToString();
            TxtToplam.Text = gridView1.GetFocusedRowCellValue("TOPLAM").ToString();

        }

        private void BtnSil_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtID.Text);
            var t = db.TBLMALALIMFATURASI.Find(id);
            db.TBLMALALIMFATURASI.Remove(t);
            db.SaveChanges();
            MessageBox.Show("Fatura Başarıyla Silindi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            metot1();
        }

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            try
            {

                int id = int.Parse(txtID.Text);
                var t = db.TBLMALALIMFATURASI.Find(id);
                t.STOKKODU = int.Parse(TxtStokKodu.EditValue.ToString());
                t.CARI = int.Parse(TxtCari.EditValue.ToString());
                t.PERSONEL = short.Parse(TxtPersonel.EditValue.ToString());
                t.AD = TxtMalzeme.Text;
                t.VERGIDAIRESI = TxtVergiDairesi.Text;
                t.VKN = TxtVkn.Text;
                t.ADET = short.Parse(TxtAdet.Text);
                t.ALISBEDELI = decimal.Parse(TxtSatisTutar.Text);
                t.ALISTARIHI = DateTime.Parse(TxtTarih.Text);
                t.FATURATIPIID = int.Parse(TxtFaturaTipi.EditValue.ToString());
                t.TOPLAM = decimal.Parse(TxtToplam.Text);
                db.SaveChanges();
                MessageBox.Show("Fatura Başarıyla Güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                metot1();
            }
            catch
            {
                MessageBox.Show("Fatura Güncellenemedi!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
    }
}
