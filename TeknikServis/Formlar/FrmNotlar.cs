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
    public partial class FrmNotlar : Form
    {
        public FrmNotlar()
        {
            InitializeComponent();
        }
        DbTeknikServisEntities1 db = new DbTeknikServisEntities1();
        private void FrmNotlar_Load(object sender, EventArgs e)
        {
            metot1();

        }
        void metot1()
        {
            gridControl1.DataSource = db.TBLNOTLARIM.Where(x => x.DURUM == false).ToList();
            gridControl2.DataSource = db.TBLNOTLARIM.Where(x => x.DURUM == true).ToList();
        }
        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            try
            {
                TBLNOTLARIM t = new TBLNOTLARIM();
                t.BASLIK = TxtBaslik.Text;
                t.ICERIK = TxtIcerik.Text;
                t.DURUM = false;
                t.TARIH = DateTime.Parse(TxtTarih.Text);
                db.TBLNOTLARIM.Add(t);
                db.SaveChanges();
                MessageBox.Show("Not başarıyla kaydedildi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                metot1();
            }
            catch
            {
                MessageBox.Show("Not kaydedilmedi", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            TxtID.Text = gridView1.GetFocusedRowCellValue("ID").ToString();
            //TxtBaslik.Text = gridView1.GetFocusedRowCellValue("BASLIK").ToString();
            //TxtIcerik.Text = gridView1.GetFocusedRowCellValue("ICERIK").ToString();

           
        }

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {


            if (CheckDurum.Checked == true)
            {

                int id = int.Parse(TxtID.Text);
                var deger = db.TBLNOTLARIM.Find(id);
                deger.BASLIK = TxtBaslik.Text;
                deger.ICERIK = TxtIcerik.Text;
                deger.TARIH = DateTime.Parse(TxtTarih.Text);
                db.SaveChanges();
                deger.DURUM = true;
                MessageBox.Show("Not başarıyla güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                metot1();
            }


            else
            {
                MessageBox.Show("Not güncellenemedi", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        
        private void BtnListele_Click(object sender, EventArgs e)
        {
            TxtID.Text = "";
            TxtBaslik.Text = "";
            TxtIcerik.Text = "";


        }

        private void BtnSil_Click(object sender, EventArgs e)
        {
            try
            {
                int id = int.Parse(TxtID.Text);
                var deger = db.TBLNOTLARIM.Find(id);
                db.TBLNOTLARIM.Remove(deger);
                db.SaveChanges();
                MessageBox.Show("Not başarıyla silindi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                metot1();
            }
            catch
            {
                MessageBox.Show("Not silinemedi", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void gridView2_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            TxtID.Text = gridView2.GetFocusedRowCellValue("ID").ToString();
          
            

        }

        private void TxtTarih_Click(object sender, EventArgs e)
        {
            TxtTarih.Text = DateTime.Now.ToShortDateString();
        }
    }
}
