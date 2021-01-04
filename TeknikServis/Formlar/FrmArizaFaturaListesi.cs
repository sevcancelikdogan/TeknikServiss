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
    public partial class FrmArizaFaturaListesi : Form
    {
        public FrmArizaFaturaListesi()
        {
            InitializeComponent();
        }
        DbTeknikServisEntities1 db = new DbTeknikServisEntities1();
        private void FrmArizaFaturaListesi_Load(object sender, EventArgs e)
        {
            metot();

            TxtIslemNumarasi.Properties.DataSource = (from x in db.TBLURUNKABUL
                                                      select new
                                                      {
                                                          İŞLEMNUMARASI = x.ISLEMID,
                                                          ÜRÜNSERİNUMARASI = x.URUNSERINO

                                                      }).ToList();

            lookUpEdit1.Properties.DataSource = (from x in db.TBLCARI
                                                 select new
                                                 {

                                                     MÜŞTERİNUMARASI = x.ID,
                                                     MÜŞTERİ = x.AD + " " + x.SOYAD,

                                                 }).ToList();

            lookUpEdit2.Properties.DataSource = (from x in db.TBLPERSONEL
                                                 select new
                                                 {

                                                     PERSONELNUMARASI = x.ID,
                                                     PERSONEL = x.AD + " " + x.SOYAD
                                                 }).ToList();

            TxtFaturaTipi.Properties.DataSource = (from x in db.TBLFATURATIPLERI
                                                   select new
                                                   {
                                                       NUMARASI = x.ID,
                                                       FATURATİPİ = x.FATURATIPI
                                                   }).ToList();
        }
        void metot()
        {


            gridControl1.DataSource = (from u in db.TBLARIZAFATURA1Set
                                       select new
                                       {

                                           NUMARA = u.ARIZAID,
                                           İŞLEMNUMARASI = u.ISLEMID,
                                           PERSONEL = u.TBLPERSONEL.AD + " " + u.TBLPERSONEL.SOYAD,
                                           MÜŞTERİ = u.TBLCARI.AD + " " + u.TBLCARI.SOYAD,
                                           //  MÜŞTERİ = u.TBLURUNKABUL.TBLCARI.AD+ " " + u.TBLURUNKABUL.TBLCARI.SOYAD,
                                           //  PERSONEL= u.TBLURUNKABUL.TBLPERSONEL.AD+ " "+u.TBLURUNKABUL.TBLPERSONEL.SOYAD,

                                           ÖNFİYAT = u.ONFIYAT,
                                           NETFİYAT = u.NETFIYAT,
                                           TARİH = u.TARIH,
                                           FATURATİPİ = u.TBLFATURATIPLERI.FATURATIPI
                                       }).ToList();
        }

        private void BtnListele_Click(object sender, EventArgs e)
        {
            txtID.Text = "";
            TxtIslemNumarasi.Text = "";
            TxtOnFiyat.Text = "";
            TxtNetFiyat.Text = "";
            TxTarih.Text = "";
            lookUpEdit1.Text = "";
            lookUpEdit2.Text = "";
        }

        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            try
            {
                TBLURUNKABUL u = new TBLURUNKABUL();
                int id = int.Parse(TxtIslemNumarasi.Text);
                var deger = db.TBLURUNKABUL.Find(id);
                TBLARIZAFATURA1 t = new TBLARIZAFATURA1();
                t.ISLEMID = int.Parse(TxtIslemNumarasi.EditValue.ToString());
                t.FATURATIPID = int.Parse(TxtFaturaTipi.EditValue.ToString());
                t.CARI = int.Parse(lookUpEdit1.EditValue.ToString());
                t.PERSONEL = short.Parse(lookUpEdit2.EditValue.ToString());
                t.ONFIYAT = decimal.Parse(TxtOnFiyat.Text);
                t.NETFIYAT = decimal.Parse(TxtNetFiyat.Text);
                t.TARIH = DateTime.Parse(TxTarih.Text);
                deger.CIKISTARIHI = DateTime.Parse(TxTarih.Text);
                db.TBLARIZAFATURA1Set.Add(t);
                // db.TBLURUNKABUL.Add(u);
                db.SaveChanges();
                MessageBox.Show("Arızalı Ürünün Faturası Başarıyla Kaydedildi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                metot();
            }
            catch
            {
                MessageBox.Show("Arızalı Ürünün Faturası Kaydedilemedi!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            txtID.Text = gridView1.GetFocusedRowCellValue("NUMARA").ToString();
            TxtFaturaTipi.Text = gridView1.GetFocusedRowCellValue("FATURATİPİ").ToString();
            TxtIslemNumarasi.Text = gridView1.GetFocusedRowCellValue("İŞLEMNUMARASI").ToString();
            lookUpEdit1.Text = gridView1.GetFocusedRowCellValue("MÜŞTERİ").ToString();
            lookUpEdit2.Text = gridView1.GetFocusedRowCellValue("PERSONEL").ToString();
            TxtOnFiyat.Text = gridView1.GetFocusedRowCellValue("ÖNFİYAT").ToString();
            TxtNetFiyat.Text = gridView1.GetFocusedRowCellValue("NETFİYAT").ToString();
            TxTarih.Text = gridView1.GetFocusedRowCellValue("TARİH").ToString();

        }

        private void BtnSil_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtID.Text);
            var sorgu = db.TBLARIZAFATURA1Set.Find(id);
            db.TBLARIZAFATURA1Set.Remove(sorgu);
            db.SaveChanges();
            MessageBox.Show("Arızalı Ürünün Faturası Başarıyla Silindi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            metot();
        }

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            try
            {
                int id = int.Parse(txtID.Text);
                var deger = db.TBLARIZAFATURA1Set.Find(id);
                deger.ISLEMID = int.Parse(TxtIslemNumarasi.EditValue.ToString());
                deger.FATURATIPID = int.Parse(TxtFaturaTipi.EditValue.ToString());
                deger.CARI = int.Parse(lookUpEdit1.EditValue.ToString());
                deger.PERSONEL = short.Parse(lookUpEdit2.EditValue.ToString());
                deger.ONFIYAT = decimal.Parse(TxtOnFiyat.Text);
                deger.NETFIYAT = decimal.Parse(TxtNetFiyat.Text);
                deger.TARIH = DateTime.Parse(TxTarih.Text);
                var dgr = db.TBLURUNKABUL.Find(id);
                dgr.CIKISTARIHI = DateTime.Parse(TxTarih.Text);
                db.SaveChanges();
                MessageBox.Show("Arızalı Ürünün Faturası Başarıyla Güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                metot();
            }
            catch (Exception)
            {

                MessageBox.Show("Arızalı Ürünün Faturası Güncellenemedi!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
