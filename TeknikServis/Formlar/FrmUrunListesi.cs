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
    public partial class FrmUrunListesi : Form
    {
        public FrmUrunListesi()
        {
            InitializeComponent();
        }
        DbTeknikServisEntities1 db = new DbTeknikServisEntities1();

        //listeleme metodu
        void metot1()
        {

            var degerler = from u in db.TBLURUN
                           select new
                           {

                               NUMARA = u.ID,
                               u.AD,
                               u.MARKA,
                               u.STOK,
                               KATEGORI=u.TBLKATEGORI.AD,
                               ALIŞFİYAT = u.ALISFIYAT,
                               SATIŞFİYAT=u.SATISFIYAT,

                           };
            gridControl1.DataSource = degerler.ToList();
        }
        private void FrmUrunListesi_Load(object sender, EventArgs e)
        {     //listeleme
            //var degerler = db.TBLURUN.ToList();
            //gridControl1.DataSource = degerler;
            metot1();
            TxtKategori.Properties.DataSource = (from x in db.TBLKATEGORI
                                                 select new
                                                 {
                                                     x.ID,
                                                     x.AD

                                                 }).ToList();


        }

        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            TBLURUN t = new TBLURUN();
            t.AD = TxtUrunAd.Text;
            t.MARKA = TxtMarka.Text;
            t.ALISFIYAT =decimal.Parse(TxtAlisFiyat.Text);
            t.SATISFIYAT =decimal.Parse(TxtSatisFiyat.Text);
            t.STOK =short.Parse(TxtStok.Text);
            t.KATEGORI = byte.Parse(TxtKategori.EditValue.ToString());
            t.DURUM = false;
            db.TBLURUN.Add(t);
            db.SaveChanges();
            MessageBox.Show("Ürün Başarıyla Kaydedildi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            metot1();     
        }

        private void BtnListele_Click(object sender, EventArgs e)
        {
            //listeleme
            //var degerler = db.TBLURUN.ToList();
            //gridControl1.DataSource = degerler;
            txtID.Text = "";
            TxtUrunAd.Text = "";
            TxtMarka.Text = "";
            TxtAlisFiyat.Text = "";
            TxtSatisFiyat.Text = "";
            TxtStok.Text = "";
            

        }

        private void gridView1_FocusedRowChanged_1(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            txtID.Text = gridView1.GetFocusedRowCellValue("NUMARA").ToString();
            TxtUrunAd.Text = gridView1.GetFocusedRowCellValue("AD").ToString();
            TxtMarka.Text = gridView1.GetFocusedRowCellValue("MARKA").ToString();
            TxtAlisFiyat.Text = gridView1.GetFocusedRowCellValue("ALIŞFİYAT").ToString();
            TxtSatisFiyat.Text = gridView1.GetFocusedRowCellValue("SATIŞFİYAT").ToString();
            TxtStok.Text = gridView1.GetFocusedRowCellValue("STOK").ToString();
            TxtKategori.Text = gridView1.GetFocusedRowCellValue("AD").ToString();



        }

        private void BtnSil_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtID.Text);
            var deger = db.TBLURUN.Find(id);
            db.TBLURUN.Remove(deger);
            db.SaveChanges();
            MessageBox.Show("Ürün başarıyla silindi","Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            metot1();
        }

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtID.Text);
            var deger = db.TBLURUN.Find(id);
            deger.AD = TxtUrunAd.Text;
            deger.STOK = short.Parse(TxtStok.Text);
            deger.MARKA = TxtMarka.Text;
            deger.ALISFIYAT = decimal.Parse(TxtAlisFiyat.Text);
            deger.SATISFIYAT = decimal.Parse(TxtSatisFiyat.Text);
            deger.KATEGORI = byte.Parse(TxtKategori.EditValue.ToString());
            db.SaveChanges();
            MessageBox.Show("Ürün başarıyla güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            metot1();

        }
    }
}
