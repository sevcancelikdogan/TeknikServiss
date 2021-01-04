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
    public partial class FrmArizaDetayi : Form
    {
        public FrmArizaDetayi()
        {
            InitializeComponent();
        }
        DbTeknikServisEntities1 db = new DbTeknikServisEntities1();
        private void pictureEdit14_Click(object sender, EventArgs e)
        {
            this.Close();
        }

            private void FrmArizaDetayi_Load(object sender, EventArgs e)
        {
            TxtSeriNo.Properties.DataSource = (from x in db.TBLURUNKABUL
                                               select new
                                               {
                                               x.ISLEMID,  
                                               x.URUNSERINO
                                               }).ToList();

            TxtSeriNo.Text = serino;
        }
        public string id,serino;
        private void BtnGüncelle_Click(object sender, EventArgs e)
        {
            try
            {
                TBLURUNTAKIP t = new TBLURUNTAKIP();
                t.SERINO = TxtSeriNo.Text;
                t.TARIH = DateTime.Parse(TxtTarih.Text);
                t.ACIKLAMA = TxtDetay.Text;
                db.TBLURUNTAKIP.Add(t);
                db.SaveChanges();

                TBLURUNKABUL u = new TBLURUNKABUL();
                int urunid = int.Parse(id.ToString());
                var deger = db.TBLURUNKABUL.Find(urunid);
                deger.URUNDURUMDETAY = TxtUrunDurumu.Text;
                db.SaveChanges();

                MessageBox.Show("Ürün Arıza Detayı Güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch
            {
                MessageBox.Show("Ürün Arıza Detayı Güncellenemedi", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void TxtSeriNo_Click(object sender, EventArgs e)
        {
            TxtSeriNo.Text = "";
        }

        private void TxtTarih_Click(object sender, EventArgs e)
        {
            TxtTarih.Text = DateTime.Now.ToShortDateString();


        }

        private void TxtDetay_Click(object sender, EventArgs e)
        {
            TxtDetay.Text = "";

        }

        private void BtnVazgeç_Click(object sender, EventArgs e)
        {
            Formlar.FrmArizaDetayi fr = new Formlar.FrmArizaDetayi();
            this.Close();
        }

       
    }
}
