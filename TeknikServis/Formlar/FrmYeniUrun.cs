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
    public partial class FrmYeniUrun : Form
    {
        public FrmYeniUrun()
        {
            InitializeComponent();
        }


        DbTeknikServisEntities1 db = new DbTeknikServisEntities1();

        private void BtnVazgeç_Click(object sender, EventArgs e)
        {
            Formlar.FrmYeniUrun fr = new Formlar.FrmYeniUrun();
            this.Close();
        }

        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            DbTeknikServisEntities1 db = new DbTeknikServisEntities1();
            TBLURUN t = new TBLURUN();
            t.AD = TxtUrunAd.Text;
            t.MARKA = TxtMarka.Text;
            t.ALISFIYAT = decimal.Parse(TxtAlisFiyat.Text);
            t.SATISFIYAT = decimal.Parse(TxtSatisFiyat.Text);
            t.STOK = short.Parse(TxtStok.Text);
            t.KATEGORI = byte.Parse(TxtKategori.Text);
            t.DURUM = false;
            db.TBLURUN.Add(t);
            db.SaveChanges();
            MessageBox.Show("Ürün Başarıyla Kaydedildi");

        }



       

        private void pictureEdit14_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmYeniUrun_Load(object sender, EventArgs e)
        {
            TxtKategori.Properties.DataSource = (from x in db.TBLKATEGORI
                                                  select new
                                                  {
                                                     // x.ID,
                                                      x.AD

                                                  }).ToList();
        }

        private void TxtUrunAd_Click(object sender, EventArgs e)
        {
            TxtUrunAd.Text = "";
        }

        private void TxtMarka_Click(object sender, EventArgs e)
        {
            TxtMarka.Text = "";
        }

        private void TxtKategori_Click(object sender, EventArgs e)
        {
            TxtKategori.Text = "";
        }

        private void TxtAlisFiyat_Click(object sender, EventArgs e)
        {
            TxtAlisFiyat.Text = "";
        }

        private void TxtSatisFiyat_Click(object sender, EventArgs e)
        {
            TxtSatisFiyat.Text = "";
        }

        private void TxtStok_Click(object sender, EventArgs e)
        {
            TxtStok.Text = "";
        }
    }
}
