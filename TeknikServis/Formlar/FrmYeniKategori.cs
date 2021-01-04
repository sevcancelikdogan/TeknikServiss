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
    public partial class FrmYeniKategori : Form
    {
        public FrmYeniKategori()
        {
            InitializeComponent();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {

            Formlar.FrmYeniUrun fr = new Formlar.FrmYeniUrun();
            this.Close();
        }

        private void BtnVazgeç_Click(object sender, EventArgs e)
        {

            Formlar.FrmYeniUrun fr = new Formlar.FrmYeniUrun();
            this.Close();
        }

        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            DbTeknikServisEntities1 db = new DbTeknikServisEntities1();
            TBLKATEGORI t = new TBLKATEGORI();
            t.AD = TxtKategoriAd.Text;
            db.TBLKATEGORI.Add(t);
            db.SaveChanges();
            MessageBox.Show("Kategori Başarıyla Kaydedildi");
        }

        private void pictureEdit14_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TxtKategoriAd_Click(object sender, EventArgs e)
        {
            TxtKategoriAd.Text = "";
        }
    }
}
