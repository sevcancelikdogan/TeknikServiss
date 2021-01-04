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
    public partial class FrmSabitkiymetSatisListesics : Form
    {
        public FrmSabitkiymetSatisListesics()
        {
            InitializeComponent();
        }
        DbTeknikServisEntities1 db = new DbTeknikServisEntities1();
        private void FrmSabitkiymetSatisListesics_Load(object sender, EventArgs e)
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
        void metot1()
        {
            var degerler = from u in db.TBLMALSATIMFATURASI
                           select new
                           {

                               NUMARA = u.ID,
                               SABİTKIYMETKAYDI = u.STOKKODU,
                               CARİ = u.TBLCARI.AD + " " + u.TBLCARI.SOYAD,
                               PERSONEL = u.TBLPERSONEL.AD + " " + u.TBLPERSONEL.SOYAD,
                               MALZEME = u.AD,
                               VERGİDAİRESİ = u.VERGIDAIRESI,
                               u.VKN,
                               u.ADET,
                               SATIŞTUTARI = u.SATISBEDELI,
                               SATIŞTARİHİ = u.SATISTARIHI,
                               FATURATİPİ = u.TBLFATURATIPLERI.FATURATIPI,
                               u.TOPLAM
                           };
            gridControl1.DataSource = degerler.ToList();
        }

        private void BtnKaydet_Click(object sender, EventArgs e)
        {

            try
            {
                int d = int.Parse(TxtStokKodu.Text);
                var s = db.TBLSABITKIYMET.Find(d);
                TBLMALSATIMFATURASI t = new TBLMALSATIMFATURASI();
                t.STOKKODU = int.Parse(TxtStokKodu.EditValue.ToString());
                t.CARI = int.Parse(TxtCari.EditValue.ToString());
                t.PERSONEL = short.Parse(TxtPersonel.EditValue.ToString());
                t.AD = TxtMalzeme.Text;
                t.VERGIDAIRESI = TxtVergiDairesi.Text;
                t.VKN = TxtVkn.Text;
                t.ADET = short.Parse(TxtAdet.Text);
                t.SATISBEDELI = decimal.Parse(TxtSatisTutar.Text);
                t.SATISTARIHI = DateTime.Parse(TxtTarih.Text);
                t.FATURATIPIID = int.Parse(TxtFaturaTipi.EditValue.ToString());
                s.FATURATIPIID = int.Parse(TxtFaturaTipi.EditValue.ToString());
                t.TOPLAM = decimal.Parse(TxtToplam.Text);
                db.TBLMALSATIMFATURASI.Add(t);
                db.SaveChanges();
                MessageBox.Show("Fatura Başarıyla Kaydedildi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                metot1();
            }
            catch
            {
                MessageBox.Show("Fatura Kaydedilemedi!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            txtID.Text = gridView1.GetFocusedRowCellValue("NUMARA").ToString();
            TxtStokKodu.Text = gridView1.GetFocusedRowCellValue("SABİTKIYMETKAYDI").ToString();
            TxtCari.Text = gridView1.GetFocusedRowCellValue("CARİ").ToString();
            TxtPersonel.Text = gridView1.GetFocusedRowCellValue("PERSONEL").ToString();
            TxtMalzeme.Text = gridView1.GetFocusedRowCellValue("MALZEME").ToString();
            TxtVergiDairesi.Text = gridView1.GetFocusedRowCellValue("VERGİDAİRESİ").ToString();
            TxtVkn.Text = gridView1.GetFocusedRowCellValue("VKN").ToString();
            TxtAdet.Text = gridView1.GetFocusedRowCellValue("ADET").ToString();
            TxtSatisTutar.Text = gridView1.GetFocusedRowCellValue("SATIŞTUTARI").ToString();
            TxtTarih.Text = gridView1.GetFocusedRowCellValue("SATIŞTARİHİ").ToString();
            TxtFaturaTipi.Text = gridView1.GetFocusedRowCellValue("FATURATİPİ").ToString();
            TxtToplam.Text = gridView1.GetFocusedRowCellValue("TOPLAM").ToString();

        }

        private void BtnSil_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtID.Text);
            var t = db.TBLMALSATIMFATURASI.Find(id);
            db.TBLMALSATIMFATURASI.Remove(t);
            db.SaveChanges();
            MessageBox.Show("Fatura Başarıyla Silindi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            metot1();
        }

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            try
            {

                int id = int.Parse(txtID.Text);
                var t = db.TBLMALSATIMFATURASI.Find(id);
                t.STOKKODU = int.Parse(TxtStokKodu.EditValue.ToString());
                t.CARI = int.Parse(TxtCari.EditValue.ToString());
                t.PERSONEL = short.Parse(TxtPersonel.EditValue.ToString());
                t.AD = TxtMalzeme.Text;
                t.VERGIDAIRESI = TxtVergiDairesi.Text;
                t.VKN = TxtVkn.Text;
                t.ADET = short.Parse(TxtAdet.Text);
                t.SATISBEDELI = decimal.Parse(TxtSatisTutar.Text);
                t.SATISTARIHI = DateTime.Parse(TxtTarih.Text);
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
