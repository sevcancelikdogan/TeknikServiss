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
    public partial class FrmKullanici : Form
    {
        public FrmKullanici()
        {
            InitializeComponent();
        }
        DbTeknikServisEntities1 db = new DbTeknikServisEntities1();

        //listeleme metodu
        void metot1()
        {

            var degerler = from u in db.TBLKULLANICI
                           select new
                           {

                               NUMARA = u.ID,
                               PERSONELADI=u.KULLANICI_ADI,
                               PERSONELSOYADI =u.KULLANICI_SOYADI,
                               KULLANICIADI = u.KULLANICI,
                               ŞİFRE =u.SIFRE
                           };
            gridControl1.DataSource = degerler.ToList();
        }
        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            TBLKULLANICI t = new TBLKULLANICI();
            t.KULLANICI_ADI = TxtPersonelAd.Text;
            t.KULLANICI_SOYADI = TxtPersonelSoyad.Text;
            t.KULLANICI = TxtKullanici.Text;
            t.SIFRE = TxtSifre.Text;
            db.TBLKULLANICI.Add(t);
            db.SaveChanges();
            MessageBox.Show("Kullanıcı başarıyla eklendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            metot1();
        }

        private void BtnSil_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtID.Text);
            var deger = db.TBLKULLANICI.Find(id);
            db.TBLKULLANICI.Remove(deger);
            db.SaveChanges();
            MessageBox.Show("Kullanıcı başarıyla silindi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            metot1();
        }

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtID.Text);
            var deger = db.TBLKULLANICI.Find(id);
            deger.KULLANICI_ADI = TxtPersonelAd.Text;
            deger.KULLANICI_SOYADI = TxtPersonelSoyad.Text;
            deger.KULLANICI = TxtKullanici.Text;
            deger.SIFRE = TxtSifre.Text;
            db.SaveChanges();
            MessageBox.Show("Kullanıcı başarıyla güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            metot1();

        }

        private void BtnListele_Click(object sender, EventArgs e)
        {
            txtID.Text = "";
            TxtPersonelAd.Text = "";
            TxtPersonelSoyad.Text = "";
            TxtKullanici.Text = "";
            TxtSifre.Text = "";
        }

        private void FrmKullanici_Load(object sender, EventArgs e)
        {
            metot1();
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            txtID.Text = gridView1.GetFocusedRowCellValue("NUMARA").ToString();
            TxtPersonelAd.Text = gridView1.GetFocusedRowCellValue("PERSONELADI").ToString();
            TxtPersonelSoyad.Text = gridView1.GetFocusedRowCellValue("PERSONELSOYADI").ToString();
            TxtKullanici.Text = gridView1.GetFocusedRowCellValue("KULLANICIADI").ToString();
            TxtSifre.Text = gridView1.GetFocusedRowCellValue("ŞİFRE").ToString();
        }
    }
}
