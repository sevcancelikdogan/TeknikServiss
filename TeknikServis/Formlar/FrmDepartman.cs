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
    public partial class FrmDepartman : Form
    {
        public FrmDepartman()
        {
            InitializeComponent();
        }
        DbTeknikServisEntities1 db = new DbTeknikServisEntities1();
         void metot1()
         {
          var degerler = from u in db.TBLDEPARTMAN
                            select new
                            {

                                NUMARA = u.ID,
                                u.AD
                                
                                

                            };
             gridControl1.DataSource = degerler.ToList();
         }
        private void FrmDepartman_Load(object sender, EventArgs e)
        {
            metot1();
            labelControl18.Text = db.TBLDEPARTMAN.Count().ToString();
            labelControl14.Text = db.TBLPERSONEL.Count().ToString();
            
        }

        private void BtnKaydet_Click(object sender, EventArgs e)
        {

            if(TxtDepartmanAd.Text.Length<=50&& TxtDepartmanAd.Text!="")
            {
                TBLDEPARTMAN t = new TBLDEPARTMAN();
                t.AD = TxtDepartmanAd.Text;
                db.TBLDEPARTMAN.Add(t);
                db.SaveChanges();
                MessageBox.Show("Departman Başarıyla Kaydedildi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                metot1();
            }
            else
            {
                MessageBox.Show("Departman Kaydedilemedi", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }

        private void BtnSil_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtDepartmanID.Text);
            var deger = db.TBLDEPARTMAN.Find(id);
            db.TBLDEPARTMAN.Remove(deger);
            db.SaveChanges();
            MessageBox.Show("Ürün başarıyla silindi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            metot1();
        }

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            try
            {
                int id = int.Parse(txtDepartmanID.Text);
                var deger = db.TBLDEPARTMAN.Find(id);
                deger.AD = TxtDepartmanAd.Text;
                db.SaveChanges();
                MessageBox.Show("Cari başarıyla güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                metot1();
            }
            catch (Exception)
            {

                MessageBox.Show("hata");
            }
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            txtDepartmanID.Text = gridView1.GetFocusedRowCellValue("NUMARA").ToString();
            TxtDepartmanAd.Text = gridView1.GetFocusedRowCellValue("AD").ToString();

        }

        private void BtnListele_Click(object sender, EventArgs e)
        {
            TxtDepartmanAd.Text = "";
            txtDepartmanID.Text = "";
        }
    }
}
