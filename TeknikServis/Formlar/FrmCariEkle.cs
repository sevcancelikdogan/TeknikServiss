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
    public partial class FrmCariEkle : Form
    {
        public FrmCariEkle()
        {
            InitializeComponent();
        }

      
        private void BtnVazgeç_Click(object sender, EventArgs e)
        {
            Formlar.FrmCariEkle fr = new Formlar.FrmCariEkle();
            this.Close();
        }


        DbTeknikServisEntities1 db = new DbTeknikServisEntities1();
        int secilen;
        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            try
            {
                TBLCARI t = new TBLCARI();
                t.AD = TxtCariAd.Text;
                t.SOYAD = TxtCariSoyadı.Text;
                t.TELEFON = TxtTelefon.Text;
                t.MAIL = TxtMail.Text;
                t.IL = TxtIl.Text;
                t.ILCE = TxtIlce.Text;
                t.BANKA = TxtBanka.Text;
                t.VERGIDAIRESI = TxtVergiDairesi.Text;
                t.VERGINO = TxtVergiNumarası.Text;
                t.STATU = TxtStatu.Text;
                t.ADRES = TxtAdres.Text;
                db.TBLCARI.Add(t);
                db.SaveChanges();
                MessageBox.Show("Yeni Cari Başarıyla Kaydedildi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);


            }
            catch (Exception)
            {

                MessageBox.Show("Hata");
            }
            
        }

    
       
        private void FrmCariEkle_Load(object sender, EventArgs e)
        {
            TxtIl.Properties.DataSource = (from x in db.TBLIL
                                           select new
                                           {
                                               x.ID,
                                               x.SEHIR
                                           }
                                           ).ToList();
        }

        private void TxtIl_EditValueChanged(object sender, EventArgs e)
        {
            secilen = int.Parse(TxtIl.EditValue.ToString());
            TxtIlce.Properties.DataSource = (from y in db.TBLILCE
                                             select new
                                             {
                                                 y.ID,
                                                 y.ILCE,
                                                 y.SEHIR
                                             }).Where(z => z.SEHIR == secilen).ToList();
        }

        private void pictureEdit14_Click(object sender, EventArgs e)
        {
            this.Close();
        }

      

        private void TxtCariAd_Click(object sender, EventArgs e)
        {
            TxtCariAd.Text = "";
        }

        private void TxtCariSoyadı_Click(object sender, EventArgs e)
        {
            TxtCariSoyadı.Text = "";
        }

        private void TxtMail_Click(object sender, EventArgs e)
        {
            TxtMail.Text = "";
        }

        private void TxtTelefon_Click(object sender, EventArgs e)
        {
            TxtTelefon.Text = "";
        }

        private void TxtIl_Click(object sender, EventArgs e)
        {
            TxtIl.Text = "";
        }

        private void TxtIlce_Click(object sender, EventArgs e)
        {
            TxtIlce.Text = "";
        }

        private void TxtBanka_Click(object sender, EventArgs e)
        {
            TxtBanka.Text = "";
        }

        private void TxtVergiDairesi_Click(object sender, EventArgs e)
        {
            TxtVergiDairesi.Text = "";
        }

        private void TxtVergiNumarası_Click(object sender, EventArgs e)
        {
            TxtVergiDairesi.Text = "";
        }

        private void TxtStatu_Click(object sender, EventArgs e)
        {
            TxtStatu.Text = "";
        }

        private void TxtAdres_Click(object sender, EventArgs e)
        {
            TxtAdres.Text = "";
        }

        private void panel8_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel9_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel10_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
