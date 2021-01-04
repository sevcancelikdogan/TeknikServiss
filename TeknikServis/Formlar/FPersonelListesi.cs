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
    public partial class FPersonelListesi : Form
    {
        public FPersonelListesi()
        {
            InitializeComponent();
        }
        DbTeknikServisEntities1 db = new DbTeknikServisEntities1();
        void metot1()
        {
            var degerler = from u in db.TBLPERSONEL
                           select new
                           {

                               NUMARA = u.ID,
                               u.AD,
                               u.SOYAD,
                               DEPARTMAN = u.TBLDEPARTMAN.AD,
                               MAİL = u.MAIL,
                               u.TELEFON,


                           };
            gridControl1.DataSource = degerler.ToList();
        }
        private void FPersonelListesi_Load(object sender, EventArgs e)
        {
            metot1();
            TxtDepartman.Properties.DataSource = (from x in db.TBLDEPARTMAN
                                                  select new
                                                  {
                                                     x.ID,
                                                     x.AD

                                                  }).ToList();

        }

       

        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            try
            {
                TBLPERSONEL t = new TBLPERSONEL();
                t.AD = TxtPersonelAd.Text;
                t.SOYAD = TxtPersonelSoyad.Text;
                t.DEPARTMAN = byte.Parse(TxtDepartman.EditValue.ToString());
                t.MAIL = TxtPersonelMail.Text;
                t.TELEFON = TxtPersonelTelefon.Text;
                db.TBLPERSONEL.Add(t);
                db.SaveChanges();
                MessageBox.Show("Personel Başarıyla Kaydedildi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                metot1();
            }
            catch
            {
                MessageBox.Show("Personel Bilgileri Eksiksiz Girilmeli", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            try
            {
                int id = int.Parse(txtPersonelID.Text);
                var deger = db.TBLPERSONEL.Find(id);
                deger.AD = TxtPersonelAd.Text;
                deger.SOYAD = TxtPersonelSoyad.Text;
                deger.DEPARTMAN = byte.Parse(TxtDepartman.EditValue.ToString());
                deger.MAIL = TxtPersonelMail.Text;
                deger.TELEFON = TxtPersonelTelefon.Text;
                db.SaveChanges();
                MessageBox.Show("Personel başarıyla güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                metot1();
            }
            catch
            {
                MessageBox.Show("Personel güncellenemedi","Hata",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void BtnSil_Click(object sender, EventArgs e)
        {
            try
            {
                int id = int.Parse(txtPersonelID.Text);
                var deger = db.TBLPERSONEL.Find(id);
                db.TBLPERSONEL.Remove(deger);
                db.SaveChanges();
                MessageBox.Show("Personel başarıyla silindi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                metot1();
            }
            catch
            {
                MessageBox.Show("Personel Silinemedi","Hata",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void BtnListele_Click(object sender, EventArgs e)
        {
            txtPersonelID.Text = "";
            TxtPersonelAd.Text = "";
            TxtPersonelSoyad.Text = "";
            TxtPersonelMail.Text = "";
            TxtPersonelTelefon.Text = "";
        }

        private void gridView1_FocusedRowChanged_1(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            txtPersonelID.Text = gridView1.GetFocusedRowCellValue("NUMARA").ToString();
            TxtPersonelAd.Text = gridView1.GetFocusedRowCellValue("AD").ToString();
            TxtPersonelSoyad.Text = gridView1.GetFocusedRowCellValue("SOYAD").ToString();
            TxtPersonelMail.Text = gridView1.GetFocusedRowCellValue("MAİL").ToString();
            TxtPersonelTelefon.Text = gridView1.GetFocusedRowCellValue("TELEFON").ToString();
            TxtDepartman.Text = gridView1.GetFocusedRowCellValue("AD").ToString();

        }
    }
}
