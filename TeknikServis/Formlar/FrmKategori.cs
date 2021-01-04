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
    public partial class FrmKategori : Form
    {
        public FrmKategori()
        {
            InitializeComponent();
        }
        DbTeknikServisEntities1 db = new DbTeknikServisEntities1();

        void metot1()
        {
            var degerler = from k in db.TBLKATEGORI
                           select new
                           {
                               NUMARA = k.ID,
                               k.AD

                           };
            gridControl1.DataSource = degerler.ToList();
        }
        private void FrmKategori_Load(object sender, EventArgs e)
        {
            metot1();
        }

        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            TBLKATEGORI t = new TBLKATEGORI();
            t.AD = TxtKategoriAdi.Text;
            db.TBLKATEGORI.Add(t);
            db.SaveChanges();
            MessageBox.Show("Katgori Başarıyla Kaydedildi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            metot1();
        }

        private void BtnListele_Click(object sender, EventArgs e)
        {
            TxtKategoriID.Text = "";
            TxtKategoriAdi.Text = "";
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            TxtKategoriID.Text = gridView1.GetFocusedRowCellValue("NUMARA").ToString();
            TxtKategoriAdi.Text = gridView1.GetFocusedRowCellValue("AD").ToString();
            
        }

        private void BtnSil_Click(object sender, EventArgs e)
        {
            int id = int.Parse(TxtKategoriID.Text);
            var deger = db.TBLKATEGORI.Find(id);
            db.TBLKATEGORI.Remove(deger);
            db.SaveChanges();
            MessageBox.Show("Kategori başarıyla silindi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            metot1();
        }

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            int id = int.Parse(TxtKategoriID.Text);
            var deger = db.TBLKATEGORI.Find(id);
            deger.AD = TxtKategoriAdi.Text;
            db.SaveChanges();
            MessageBox.Show("Kategori başarıyla güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            metot1();

        }

       
    }
}
