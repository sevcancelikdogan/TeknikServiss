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
    public partial class FrmYeniPersonel : Form
    {
        public FrmYeniPersonel()
        {
            InitializeComponent();
        }

        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            DbTeknikServisEntities1 db = new DbTeknikServisEntities1();
            TBLPERSONEL t = new TBLPERSONEL();
            t.AD = TxtPersonelAd.Text;
            t.SOYAD = TxtPersonelSoyad.Text;
            t.DEPARTMAN = byte.Parse(TxtDepartman.EditValue.ToString());
            t.MAIL = TxtPersonelMail.Text;
            t.TELEFON = TxtPersonelTelefon.Text;
            db.TBLPERSONEL.Add(t);
            db.SaveChanges();
            MessageBox.Show("Personel Başarıyla Kaydedildi", "Bilgi");

        }
        DbTeknikServisEntities1 db = new DbTeknikServisEntities1();

        private void BtnVazgeç_Click(object sender, EventArgs e)
        {
            Formlar.FrmYeniPersonel fr = new Formlar.FrmYeniPersonel();
            this.Close();
        }

      

        private void FrmYeniPersonel_Load(object sender, EventArgs e)
        {
            TxtDepartman.Properties.DataSource = (from x in db.TBLDEPARTMAN
                                                  select new
                                                  {
                                                      x.ID,
                                                      x.AD

                                                  }).ToList();
        }

        private void pictureEdit14_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void TxtPersonelAd_Click(object sender, EventArgs e)
        {
            TxtPersonelAd.Text = "";
        }

        private void TxtPersonelSoyad_Click(object sender, EventArgs e)
        {
            TxtPersonelSoyad.Text = "";
        }

        private void TxtDepartman_Click(object sender, EventArgs e)
        {
            TxtDepartman.Text = "";
        }

        private void TxtPersonelMail_Click(object sender, EventArgs e)
        {
            TxtPersonelMail.Text = "";
        }

        private void TxtPersonelTelefon_Click(object sender, EventArgs e)
        {
            TxtPersonelTelefon.Text = "";
        }
    }
}
