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
    public partial class FrmSatisSiparisListesics : Form
    {
        public FrmSatisSiparisListesics()
        {
            InitializeComponent();
        }
        DbTeknikServisEntities1 db = new DbTeknikServisEntities1();
        private void FrmSatisSiparisListesics_Load(object sender, EventArgs e)
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
        }
        void metot1()
        {
            gridControl1.DataSource = (from x in db.TBLURUNHAREKET
                                       select new
                                       {
                                           NUMARA = x.HAREKETID,
                                           ÜRÜN = x.TBLURUN.AD,
                                           MÜŞTERİ = x.TBLCARI.AD + " " + x.TBLCARI.SOYAD,
                                           PERSONEL = x.TBLPERSONEL.AD + " " + x.TBLPERSONEL.SOYAD,
                                           TARİH = x.TARIH,
                                           x.ADET,
                                           FİYAT = x.FIYAT,
                                           ÜRÜNSERİNUMARASI = x.URUNSERINO
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

        private void BtnListele_Click(object sender, EventArgs e)
        {
            txtID.Text = "";
            TxtUrun.Text = "";
            TxtCari.Text = "";
            TxtPersonel.Text = "";
            TxtTarih.Text = "";
            TxtAdet.Text = "";
            TxtFiyat.Text = "";
            TxtSeriNo.Text = "";
        }

        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            try
            {
                TBLURUNHAREKET t = new TBLURUNHAREKET();
                t.URUN = int.Parse(TxtUrun.EditValue.ToString());
                t.TARIH = DateTime.Parse(TxtTarih.Text);
                t.ADET = short.Parse(TxtAdet.Text);
                t.FIYAT = decimal.Parse(TxtFiyat.EditValue.ToString());
                t.MUSTERI = int.Parse(TxtCari.EditValue.ToString());
                t.PERSONEL = short.Parse(TxtPersonel.EditValue.ToString());
                t.URUNSERINO = TxtSeriNo.Text;
                db.TBLURUNHAREKET.Add(t);
                db.SaveChanges();
                MessageBox.Show("Yeni Ürün Satışı Başarıyla Kaydedildi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                metot1();

            }
            catch (Exception)
            {

                MessageBox.Show("Alanların Hepsini Eksiksiz Doldurunuz", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            txtID.Text = gridView1.GetFocusedRowCellValue("NUMARA").ToString();
            TxtUrun.Text = gridView1.GetFocusedRowCellValue("ÜRÜN").ToString();
            TxtSeriNo.Text = gridView1.GetFocusedRowCellValue("ÜRÜNSERİNUMARASI").ToString();
            TxtCari.Text = gridView1.GetFocusedRowCellValue("MÜŞTERİ").ToString();
            TxtTarih.Text = gridView1.GetFocusedRowCellValue("TARİH").ToString();
            TxtPersonel.Text = gridView1.GetFocusedRowCellValue("PERSONEL").ToString();
            TxtAdet.Text = gridView1.GetFocusedRowCellValue("ADET").ToString();
            TxtFiyat.Text = gridView1.GetFocusedRowCellValue("FİYAT").ToString();

        }

        private void BtnSil_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtID.Text);
            var deger = db.TBLURUNHAREKET.Find(id);
            db.TBLURUNHAREKET.Remove(deger);
            db.SaveChanges();
            MessageBox.Show("Fatura Başarıyla Silindi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            metot1();
        }

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            try
            {
                int id = int.Parse(txtID.Text);
                var deger = db.TBLURUNHAREKET.Find(id);
                deger.URUNSERINO = TxtSeriNo.Text;
                deger.URUN = int.Parse(TxtUrun.EditValue.ToString());
                deger.ADET = short.Parse(TxtAdet.Text);
                deger.TARIH = DateTime.Parse(TxtTarih.Text);
                deger.FIYAT = decimal.Parse(TxtFiyat.EditValue.ToString());
                deger.MUSTERI = int.Parse(TxtCari.EditValue.ToString());
                deger.PERSONEL = short.Parse(TxtPersonel.EditValue.ToString());
                db.SaveChanges();
                MessageBox.Show("Fatura Başarıyla Güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                metot1();
            }
            catch (Exception)
            {

                MessageBox.Show("Fatura Güncellenemedi", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
