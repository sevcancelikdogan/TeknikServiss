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
    public partial class FrmGiderListesi : Form
    {
        public FrmGiderListesi()
        {
            InitializeComponent();
        }
        DbTeknikServisEntities1 db = new DbTeknikServisEntities1();
        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            txtID.Text = gridView1.GetFocusedRowCellValue("GİDERNUMARASI").ToString();
            TxtAciklama.Text = gridView1.GetFocusedRowCellValue("AÇIKLAMA").ToString();
            TxtTarih.Text = gridView1.GetFocusedRowCellValue("TARİH").ToString();
            TxtTutar.Text = gridView1.GetFocusedRowCellValue("TUTAR").ToString();
           
        }
        void metot1()
        {
            var sorgu = (from x in db.TBLGIDER
                         select new
                         {
                             GİDERNUMARASI = x.GIDERID,
                             AÇIKLAMA = x.GIDERACIKLAMA,
                             TARİH = x.TARIH,
                             x.TUTAR
                         });
            gridControl1.DataSource = sorgu.ToList();
        }
        private void FrmGiderListesi_Load(object sender, EventArgs e)
        {
            metot1();
        }

        private void BtnListele_Click(object sender, EventArgs e)
        {
            txtID.Text = "";
            TxtAciklama.Text = "";
            TxtTarih.Text = "";
            TxtTutar.Text = "";
        }

        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            try
            {
                TBLGIDER t = new TBLGIDER();
                t.GIDERACIKLAMA = TxtAciklama.Text;
                t.TARIH = DateTime.Parse(TxtTarih.Text);
                t.TUTAR = decimal.Parse(TxtTutar.Text);
                db.TBLGIDER.Add(t);
                db.SaveChanges();
                MessageBox.Show("Gider Başarıyla Kaydedildi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                metot1();
            }
            catch
            {
                MessageBox.Show("Gider Kaydedilemedi!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            try
            {
                int id = int.Parse(txtID.Text);
                var deger = db.TBLGIDER.Find(id);
                deger.GIDERACIKLAMA = TxtAciklama.Text;
                deger.TARIH = DateTime.Parse(TxtTarih.Text);
                deger.TUTAR = Decimal.Parse(TxtTutar.Text);             
                db.SaveChanges();
                MessageBox.Show("Cari başarıyla güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                metot1();
            }
            catch (Exception)
            {

                MessageBox.Show("Gider Güncellenemedi!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void BtnSil_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtID.Text);
            var deger = db.TBLGIDER.Find(id);
            db.TBLGIDER.Remove(deger);
            db.SaveChanges();
            MessageBox.Show("Gider Başarıyla Silindi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            metot1();
        }
    }
}
