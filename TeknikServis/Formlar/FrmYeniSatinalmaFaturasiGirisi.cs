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
    public partial class FrmYeniSatinalmaFaturasiGirisi : Form
    {
        public FrmYeniSatinalmaFaturasiGirisi()
        {
            InitializeComponent();
        }
        DbTeknikServisEntities1 db = new DbTeknikServisEntities1();
        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            try
            {
                TBLSATINALMAFATURASIBILGI t = new TBLSATINALMAFATURASIBILGI();
                t.SERI = TxtSeriNumarasi.Text;
                t.SIRANO = TxtSiraNumarasi.Text;
                t.FATURATIPID = int.Parse(TxtFaturaTipi.Text);
                t.TARIH = DateTime.Parse(TxtTarih.Text);
                t.SAAT = TxtSaat.Text;
                t.VERGIDAIRE = TxtVergiDairesi.Text;
                t.CARI = int.Parse(TxtCari.EditValue.ToString());
                t.PERSONEL = short.Parse(TxtPersonel.EditValue.ToString());
                db.TBLSATINALMAFATURASIBILGI.Add(t);
                db.SaveChanges();
                MessageBox.Show("Yeni Fatura Girişi Başarıyla Kaydedildi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch
            {
                MessageBox.Show("Fatura Girişi Kaydedilemedi!", "Hatas", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void FrmYeniSatinalmaFaturasiGirisi_Load(object sender, EventArgs e)
        {
            TxtCari.Properties.DataSource = (from x in db.TBLCARI
                                             select new
                                             {
                                                 x.ID,
                                                 MÜŞTERİ = x.AD + " " + x.SOYAD
                                             }).ToList();
            TxtPersonel.Properties.DataSource = (from x in db.TBLPERSONEL
                                                 select new
                                                 {
                                                     x.ID,
                                                     PERSONEL = x.AD + " " + x.SOYAD
                                                 }).ToList();

            /*     TxtVergiDairesi.Properties.DataSource = (from x in db.TBLCARI
                                                          select new
                                                          {

                                                              x.ID,
                                                              // x.VERGINO,
                                                              x.VERGIDAIRESI
                                                          }).ToList();*/

            //  TxtVergiDairesi.Properties.DataSource = db.vergidairesi().ToList();
            TxtFaturaTipi.Properties.DataSource = (from x in db.TBLFATURATIPLERI
                                                   select new
                                                   {
                                                       NUMARASI = x.ID,
                                                       FATURATİPİ = x.FATURATIPI
                                                   }).ToList();

        }

        private void BtnSil_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureEdit14_Click(object sender, EventArgs e)
        {
            this.Close();
        }

      

        private void TxtSeriNumarasi_Click(object sender, EventArgs e)
        {
            TxtSeriNumarasi.Text = "";
        }

        private void TxtSiraNumarasi_Click(object sender, EventArgs e)
        {
            TxtSiraNumarasi.Text = "";
        }

        private void TxtTarih_Click(object sender, EventArgs e)
        {
            TxtTarih.Text = "";
        }

        private void TxtSaat_Click(object sender, EventArgs e)
        {
            TxtSaat.Text = "";
        }

        private void TxtVergiDairesi_Click(object sender, EventArgs e)
        {
            TxtVergiDairesi.Text = "";
        }

        private void TxtCari_Click(object sender, EventArgs e)
        {
            TxtCari.Text = "";
        }

        private void TxtPersonel_Click(object sender, EventArgs e)
        {
            TxtPersonel.Text = "";
        }

        private void TxtFaturaTipi_Click(object sender, EventArgs e)
        {
            TxtFaturaTipi.Text = "";
        }
    }
}
