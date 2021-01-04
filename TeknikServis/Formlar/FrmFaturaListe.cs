using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace TeknikServis.Formlar
{
    public partial class FrmFaturaListe : Form
    {
        public FrmFaturaListe()
        {
            InitializeComponent();
        }
        DbTeknikServisEntities1 db = new DbTeknikServisEntities1();

        void metot1()
        {
            var degerler = from u in db.TBLFATURABILGI
                           select new
                           {
                               NUMARA = u.ID,
                               SERİNUMARASI = u.SERI,
                               SIRANUMARASI =u.SIRANO,
                               TARİH =u.TARIH,
                               u.SAAT,
                               VERGİDAİRESİ = u.VERGIDAIRE,
                               CARİ = u.TBLCARI.AD + " " + u.TBLCARI.SOYAD,
                               PERSONEL = u.TBLPERSONEL.AD + " "+ u.TBLPERSONEL.SOYAD,
                               FATURATİPİ = u.TBLFATURATIPLERI.FATURATIPI
                           };
            gridControl1.DataSource = degerler.ToList();
        }
        private void FrmFaturaListe_Load(object sender, EventArgs e)
        {
            metot1();

            TxtCari.Properties.DataSource = (from x in db.TBLCARI
                                             select new
                                             {
                                                 x.ID,
                                                 CARİ = x.AD + " " + x.SOYAD
                                             }).ToList();
            TxtPersonel.Properties.DataSource = (from x in db.TBLPERSONEL
                                                 select new
                                                 {
                                                     x.ID,
                                                     PERSONEL = x.AD +" "+ x.SOYAD
                                                 }).ToList();

            /*   TxtVergiDairesi.Properties.DataSource = (from x in db.TBLCARI
                                                        select new
                                                        {

                                                            x.ID,
                                                            // x.VERGINO,
                                                            x.VERGIDAIRESI
                                                        }).ToList(); */

            //   TxtVergiDairesi.Properties.DataSource = db.vergidairesi().ToList();

            TxtFaturaTipi.Properties.DataSource = (from x in db.TBLFATURATIPLERI
                                                   select new
                                                   {
                                                        x.ID,
                                                       FATURATİPİ =  x.FATURATIPI
                                                   }).ToList();

        }

        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            try
            {
                TBLFATURABILGI t = new TBLFATURABILGI();
                t.SERI = TxtSeriNo.Text;
                t.FATURATIPID = int.Parse(TxtFaturaTipi.EditValue.ToString());
                t.SIRANO = TxtSıraNo.Text;
                t.TARIH = DateTime.Parse(TxtTarih.Text);
                t.SAAT = textEdit1.Text;
                t.VERGIDAIRE = TxtVergiDairesi.Text;
                t.CARI = int.Parse(TxtCari.EditValue.ToString());
                t.PERSONEL = short.Parse(TxtPersonel.EditValue.ToString());
                db.TBLFATURABILGI.Add(t);
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
            var deger = db.TBLFATURABILGI.Find(id);
            db.TBLFATURABILGI.Remove(deger);
            db.SaveChanges();
            MessageBox.Show("Fatura Başarıyla Silindi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            metot1();
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            txtID.Text = gridView1.GetFocusedRowCellValue("NUMARA").ToString();
            TxtFaturaTipi.Text = gridView1.GetFocusedRowCellValue("FATURATİPİ").ToString();
            TxtSeriNo.Text = gridView1.GetFocusedRowCellValue("SERİNUMARASI").ToString();
            TxtSıraNo.Text = gridView1.GetFocusedRowCellValue("SIRANUMARASI").ToString();
            TxtTarih.Text = gridView1.GetFocusedRowCellValue("TARİH").ToString();
            textEdit1.Text = gridView1.GetFocusedRowCellValue("SAAT").ToString();
            TxtVergiDairesi.Text = gridView1.GetFocusedRowCellValue("VERGİDAİRESİ").ToString();
            TxtCari.Text = gridView1.GetFocusedRowCellValue("CARİ").ToString();
            TxtPersonel.Text = gridView1.GetFocusedRowCellValue("PERSONEL").ToString();


        }

        private void BtnListele_Click(object sender, EventArgs e)
        {
            txtID.Text = "";
            TxtFaturaTipi.Text = "";
            TxtSeriNo.Text = "";
            TxtSıraNo.Text = "";
            TxtTarih.Text = "";
            textEdit1.Text = "";
            TxtVergiDairesi.Text = "";
            TxtCari.Text = "";
            TxtPersonel.Text = "";
           
        }

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            try
            {
                int id = int.Parse(txtID.Text);
                var deger = db.TBLFATURABILGI.Find(id);
                deger.SERI = TxtSeriNo.Text;
                deger.FATURATIPID = int.Parse(TxtFaturaTipi.EditValue.ToString());
                deger.SIRANO =TxtSıraNo.Text;
                deger.TARIH = DateTime.Parse(TxtTarih.Text);
                deger.SAAT = textEdit1.Text;
                deger.VERGIDAIRE = TxtVergiDairesi.Text;
                deger.CARI = int.Parse(TxtCari.EditValue.ToString());
                deger.PERSONEL =short.Parse(TxtPersonel.EditValue.ToString());
                db.SaveChanges();
                MessageBox.Show("Fatura Başarıyla Güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                metot1();
            }
            catch (Exception)
            {

                MessageBox.Show("Fatura Güncellenemedi", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void gridControl1_Click(object sender, EventArgs e)
        {

        }

        private void gridControl1_DoubleClick(object sender, EventArgs e)
        {
            FrmFaturaKalemPopup fr = new FrmFaturaKalemPopup();
            fr.id = int.Parse(gridView1.GetFocusedRowCellValue("NUMARA").ToString());
            fr.Show();
        }

      
    }
    
}
