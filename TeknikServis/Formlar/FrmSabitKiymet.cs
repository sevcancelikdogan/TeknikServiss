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
    public partial class FrmSabitKiymet : Form
    {
        public FrmSabitKiymet()
        {
            InitializeComponent();
        }
        DbTeknikServisEntities1 db = new DbTeknikServisEntities1();
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
                TBLSABITKIYMET t = new TBLSABITKIYMET();
                t.PERSONEL = short.Parse(TxtPersonel.Text);
                t.AD = TxtMalzeme.Text;
                t.ADET = short.Parse(TxtAdet.Text);
                t.TARIH = DateTime.Parse(TxtTarih.Text);
                db.TBLSABITKIYMET.Add(t);
                db.SaveChanges();
                MessageBox.Show("Sabit Kıymet Kaydı Başarıyla Oluşturuldu","Bilgi",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            catch
            {
                MessageBox.Show("Sabit Kıymet Kaydı Oluşuturulamadı", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void FrmSabitKiymet_Load(object sender, EventArgs e)
        {
            TxtPersonel.Properties.DataSource = (from x in db.TBLPERSONEL
                                                 select new
                                                 {
                                                     NUMARASI =  x.ID,
                                                     PERSONEL = x.AD + " " + x.SOYAD
                                                 }).ToList();
        }

        private void TxtPersonel_Click(object sender, EventArgs e)
        {
            TxtPersonel.Text = "";
        }

        private void TxtMalzeme_Click(object sender, EventArgs e)
        {
            TxtMalzeme.Text = "";
        }

        private void TxtAdet_Click(object sender, EventArgs e)
        {
            TxtAdet.Text = "";
        }

        private void textEdit1_Click(object sender, EventArgs e)
        {
            TxtTarih.Text = "";
        }

        private void TxtPersonel_EditValueChanged(object sender, EventArgs e)
        {

        }
    }
}
