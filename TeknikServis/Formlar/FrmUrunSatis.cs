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
    public partial class FrmUrunSatis : Form
    {
        public FrmUrunSatis()
        {
            InitializeComponent();
        }
        DbTeknikServisEntities1 db = new DbTeknikServisEntities1();
        private void FrmUrunSatis_Load(object sender, EventArgs e)
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
            TxtUrunID.Properties.DataSource = (from x in db.TBLURUN
                                                 select new
                                                 {
                                                     x.ID,
                                                     x.AD,  
                                                     x.MARKA
                                                 }).ToList();
        


        }

        private void pictureEdit14_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnVazgeç_Click(object sender, EventArgs e)
        {
            Formlar.FrmUrunSatis fr = new Formlar.FrmUrunSatis();
            this.Close();
        }

        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            try
            {
                TBLURUNHAREKET t = new TBLURUNHAREKET();
                t.URUN = int.Parse(TxtUrunID.Text);
                t.TARIH = DateTime.Parse(TxtTarih.Text);
                t.ADET =short.Parse(TxtAdet.Text);
                t.FIYAT = decimal.Parse(TxtSatisFiyati.Text);
                t.MUSTERI = int.Parse(TxtMusteri.Text);
                t.PERSONEL = short.Parse(TxtPersonel.Text);
                t.URUNSERINO = TxtSeriNo.Text;
                db.TBLURUNHAREKET.Add(t);
                db.SaveChanges();
                MessageBox.Show("Yeni Ürün Satışı Başarıyla Kaydedildi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);


            }
            catch (Exception)
            {

                MessageBox.Show("Alanların Hepsini Eksiksiz Doldurunuz","Hata", MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }
        int secilen;
      

        private void TxtUrunID_EditValueChanged(object sender, EventArgs e)
        {
            secilen = int.Parse(TxtUrunID.EditValue.ToString());
            TxtSatisFiyati.Properties.DataSource = (from x in db.TBLURUN
                                               select new
                                               {
                                                   NUMARASI =x.ID,
                                                   FİYAT = x.SATISFIYAT,
                                                   

                                               }).Where(z => z.NUMARASI == secilen).ToList();
        }

        private void TxtAdet_ValueChanged(object sender, EventArgs e)
        {

        }

        private void TxtUrunID_Click(object sender, EventArgs e)
        {
            TxtUrunID.Text = "";
        }

        private void TxtMusteri_Click(object sender, EventArgs e)
        {
            TxtMusteri.Text = "";
        }

        private void TxtPersonel_Click(object sender, EventArgs e)
        {
            TxtPersonel.Text = "";
        }

        private void TxtTarih_Click(object sender, EventArgs e)
        {
            TxtTarih.Text = "";
        }

        private void TxtSatisFiyati_Click(object sender, EventArgs e)
        {
            TxtSatisFiyati.Text = "";
        }

        private void TxtSeriNo_Click(object sender, EventArgs e)
        {
            TxtSeriNo.Text = "";
        }
    }
}
