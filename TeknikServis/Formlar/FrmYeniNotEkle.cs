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
    public partial class FrmYeniNotEkle : Form
    {
        public FrmYeniNotEkle()
        {
            InitializeComponent();
        }

      

        private void BtnVazgeç_Click(object sender, EventArgs e)
        {
            Formlar.FrmYeniNotEkle fr = new Formlar.FrmYeniNotEkle();
            this.Close();
        }

        private void pictureEdit14_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            DbTeknikServisEntities1 db = new DbTeknikServisEntities1();
            TBLNOTLARIM t = new TBLNOTLARIM();
            t.BASLIK = TxtBaslik.Text;
            t.ICERIK = TxtIcerik.Text;
            t.DURUM = false;
            db.TBLNOTLARIM.Add(t);
            db.SaveChanges();
            MessageBox.Show("Not Başarıyla Kaydedildi");
        }

        private void TxtBaslik_Click(object sender, EventArgs e)
        {
            TxtBaslik.Text = "";
        }

        private void TxtIcerik_Click(object sender, EventArgs e)
        {
            TxtIcerik.Text = "";
        }
    }
}
