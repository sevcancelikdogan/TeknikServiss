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
    public partial class FrmArizaliFaturaGirişi : Form
    {
        public FrmArizaliFaturaGirişi()
        {
            InitializeComponent();
        }

        private void pictureEdit14_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnSil_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        DbTeknikServisEntities1 db = new DbTeknikServisEntities1();
        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            try
            {
                TBLURUNKABUL u = new TBLURUNKABUL();
                int id = int.Parse(TxtIslemNumarasi.Text);
                var deger = db.TBLURUNKABUL.Find(id);
                TBLARIZAFATURA1 t = new TBLARIZAFATURA1();
                t.ISLEMID = int.Parse(TxtIslemNumarasi.Text);
                t.FATURATIPID = int.Parse(TxtFaturaTipi.Text);
                t.CARI = int.Parse(lookUpEdit1.Text);
                t.PERSONEL = short.Parse(lookUpEdit2.Text);
                t.ONFIYAT = decimal.Parse(TxtOnFiyat.Text);
                t.NETFIYAT = decimal.Parse(TxtNetFiyat.Text);
                t.TARIH = DateTime.Parse(TxTarih.Text);
                deger.CIKISTARIHI = DateTime.Parse(TxTarih.Text);
                db.TBLARIZAFATURA1Set.Add(t);
                // db.TBLURUNKABUL.Add(u);
                db.SaveChanges();
                MessageBox.Show("Arızalı Ürünün Faturası Başarıyla Kaydedildi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
            }
            catch
            {
                MessageBox.Show("Arızalı Ürünün Faturası Kaydedilemedi!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void FrmArizaliFaturaGirişi_Load(object sender, EventArgs e)
        {
            TxtIslemNumarasi.Properties.DataSource = (from x in db.TBLURUNKABUL
                                                      select new
                                                      {
                                                          x.ISLEMID,
                                                          x.URUNSERINO

                                                      }).ToList();
            TxtFaturaTipi.Properties.DataSource = (from x in db.TBLFATURATIPLERI
                                                   select new
                                                   {
                                                       NUMARASI = x.ID,
                                                       FATURATİPİ = x.FATURATIPI
                                                   }).ToList();
            lookUpEdit1.Properties.DataSource = (from x in db.TBLCARI
                                                 select new
                                                 {

                                                     MÜŞTERİNUMARASI = x.ID,
                                                     MÜŞTERİ = x.AD + " " + x.SOYAD
                                                 }).ToList();

            lookUpEdit2.Properties.DataSource = (from x in db.TBLPERSONEL
                                                 select new
                                                 {

                                                     PERSONELNUMARASI = x.ID,
                                                     PERSONEL = x.AD + " " + x.SOYAD
                                                 }).ToList();


        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
           
        }

        


        private void TxtOnFiyat_Click(object sender, EventArgs e)
        {
            TxtOnFiyat.Text = "";
        }

        private void TxtNetFiyat_Click(object sender, EventArgs e)
        {
            TxtNetFiyat.Text = "";
        }

        

        private void TxTarih_Click(object sender, EventArgs e)
        {
            TxTarih.Text = "";
        }

        private void TxtIslemNumarasi_Click(object sender, EventArgs e)
        {
            TxtIslemNumarasi.Text = "";
        }

        private void TxtFaturaTipi_Click(object sender, EventArgs e)
        {
            TxtFaturaTipi.Text = "";
        }

        private void lookUpEdit2_Click(object sender, EventArgs e)
        {
            lookUpEdit2.Text = "";
        }

        private void lookUpEdit1_Click(object sender, EventArgs e)
        {
            lookUpEdit1.Text = "";
        }
    }
}
