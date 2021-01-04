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
    public partial class FrmYeniDepartman : Form
    {
        public FrmYeniDepartman()
        {
            InitializeComponent();
        }

        private void BtnKaydet_Click(object sender, EventArgs e)
        {

            DbTeknikServisEntities1 db = new DbTeknikServisEntities1();
            TBLDEPARTMAN t = new TBLDEPARTMAN();
            t.AD =TxtDepartmanAd.Text;
            db.TBLDEPARTMAN.Add(t);
            db.SaveChanges();
            MessageBox.Show("Departman Başarıyla Kaydedildi");
        }

 
        private void BtnVazgeç_Click(object sender, EventArgs e)
        {
            Formlar.FrmYeniUrun fr = new Formlar.FrmYeniUrun();
            this.Close();
        }

        private void pictureEdit14_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void TxtDepartmanAd_Click(object sender, EventArgs e)
        {
            TxtDepartmanAd.Text = "";
        }

        private void FrmYeniDepartman_Load(object sender, EventArgs e)
        {

        }
    }
}
