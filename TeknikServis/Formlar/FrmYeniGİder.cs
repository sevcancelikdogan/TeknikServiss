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
    public partial class FrmYeniGİder : Form
    {
        public FrmYeniGİder()
        {
            InitializeComponent();
        }


        DbTeknikServisEntities1 db = new DbTeknikServisEntities1();
        private void richTextBox1_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "";
        }

        private void TxtTarih_Click(object sender, EventArgs e)
        {
            TxtTarih.Text = "";
        }

        private void TxtSeriNo_Click(object sender, EventArgs e)
        {
            TxtTutar.Text = "";
;        }

        private void pictureEdit1_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void pictureEdit1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnVazgeç_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            try
            {
                TBLGIDER t = new TBLGIDER();
                t.GIDERACIKLAMA = richTextBox1.Text;
                t.TARIH = DateTime.Parse(TxtTarih.Text);
                t.TUTAR = decimal.Parse(TxtTutar.Text);
                db.TBLGIDER.Add(t);
                db.SaveChanges();
                MessageBox.Show("Gider Başarıyla Kaydedildi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch
            {
                MessageBox.Show("Lütfen Bilgileri Eksiksiz Doldurunuz", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void FrmYeniGİder_Load(object sender, EventArgs e)
        {

        }
    }
}
