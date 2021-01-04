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
    public partial class FrmSabitKıymetListesi : Form
    {
        public FrmSabitKıymetListesi()
        {
            InitializeComponent();
        }
        DbTeknikServisEntities1 db = new DbTeknikServisEntities1();
        private void FrmSabitKıymetListesi_Load(object sender, EventArgs e)
        {
            metot1();

            TxtPersonel.Properties.DataSource = (from x in db.TBLPERSONEL
                                                 select new
                                                 {
                                                     NUMARASI = x.ID,
                                                     PERSONEL = x.AD + " " + x.SOYAD
                                                 }).ToList();
        }
        void metot1()
        {
            var degerler = from u in db.TBLSABITKIYMET
                           select new
                           {

                               NUMARA = u.ID,
                               MALZEME = u.AD,
                               PERSONEL = u.TBLPERSONEL.AD + " " + u.TBLPERSONEL.SOYAD,
                               KAYITTARİHİ = u.TARIH,
                               // FATURATİPİ = u.FATURATIPIID,
                               // FATURATİPİ = u.TBLFATURATIPLERI.FATURATIPI

                           };
            gridControl1.DataSource = degerler.ToList();
        }
        private void gridControl1_Click(object sender, EventArgs e)
        {

        }

        private void BtnSil_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtID.Text);
            var t = db.TBLSABITKIYMET.Find(id);
            db.TBLSABITKIYMET.Remove(t);
            db.SaveChanges();
            MessageBox.Show("Fatura Başarıyla Silindi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            metot1();
        }

        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            try
            {
                TBLSABITKIYMET t = new TBLSABITKIYMET();
                t.PERSONEL = short.Parse(TxtPersonel.Text);
                t.AD = TxtMalzeme.Text;
                t.TARIH = DateTime.Parse(TxtTarih.Text);
                db.TBLSABITKIYMET.Add(t);
                db.SaveChanges();
                MessageBox.Show("Fatura Başarıyla Kaydedildi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                metot1();
            }
            catch
            {
                MessageBox.Show("Fatura Kaydedilemedi!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            try
            {
                int id = int.Parse(txtID.Text);
                var t = db.TBLSABITKIYMET.Find(id);
                t.PERSONEL = short.Parse(TxtPersonel.Text);
                t.AD = TxtMalzeme.Text;
                t.TARIH = DateTime.Parse(TxtTarih.Text);
                db.SaveChanges();
                MessageBox.Show("Fatura Başarıyla Güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                metot1();

            }

            catch
            {
                MessageBox.Show("Fatura Güncellenemedi!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void BtnListele_Click(object sender, EventArgs e)
        {
            txtID.Text = "";
            TxtMalzeme.Text = "";
            TxtPersonel.Text = "";
            TxtTarih.Text = "";
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            txtID.Text = gridView1.GetFocusedRowCellValue("NUMARA").ToString();
            TxtPersonel.Text = gridView1.GetFocusedRowCellValue("PERSONEL").ToString();
            TxtMalzeme.Text = gridView1.GetFocusedRowCellValue("MALZEME").ToString();
            TxtTarih.Text = gridView1.GetFocusedRowCellValue("KAYITTARİHİ").ToString();

        }
    }

}
