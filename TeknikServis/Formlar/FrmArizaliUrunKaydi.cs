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
    public partial class FrmArizaliUrunKaydi : Form
    {
        public FrmArizaliUrunKaydi()
        {
            InitializeComponent();
        }
        DbTeknikServisEntities1 db = new DbTeknikServisEntities1();

        private void FrmArizaliUrunKaydi_Load(object sender, EventArgs e)
        {
            TxtMusteri.Properties.DataSource = (from x in db.TBLCARI
                                                select new
                                                {
                                                    x.ID,
                                                    x.AD,
                                                    x.SOYAD
                                                }).ToList();
            TxtPersonel.Properties.DataSource = (from x in db.TBLPERSONEL
                                                 select new
                                                 {
                                                     x.ID,
                                                     x.AD,
                                                     x.SOYAD
                                                 }).ToList();
            
        }

        private void BtnVazgeç_Click(object sender, EventArgs e)
        {
            Formlar.FrmArizaliUrunKaydi fr = new Formlar.FrmArizaliUrunKaydi();
            this.Close();
        }

        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            try
            {
                TBLURUNKABUL t = new TBLURUNKABUL();
                // t.GELISTARIHI = DateTime.Parse(TxtTarih.Text);
                t.GELISTARIHI = DateTime.Parse(TxtTarih.Text);
                t.CARI = int.Parse(TxtMusteri.Text);
                t.PERSONEL = short.Parse(TxtPersonel.Text);
                t.URUNSERINO = TxtSeriNo.Text;
                db.TBLURUNKABUL.Add(t);
                db.SaveChanges();
                MessageBox.Show("Ürün Arıza Girişi Kaydedildi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);


            }
            catch (Exception)
            {

                MessageBox.Show("Alanların Hepsini Eksiksiz Doldurunuz", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void pictureEdit14_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void TxtTarih_Click(object sender, EventArgs e)
        {
            TxtTarih.Text = DateTime.Now.ToShortDateString();
        }

        private void TxtSeriNo_Click(object sender, EventArgs e)
        {
            TxtSeriNo.Text = "";
        }

        private void TxtPersonel_Click(object sender, EventArgs e)
        {
            TxtPersonel.Text = "";
        }

        private void TxtMusteri_Click(object sender, EventArgs e)
        {
            TxtMusteri.Text = "";
;        }

       
    }
}
