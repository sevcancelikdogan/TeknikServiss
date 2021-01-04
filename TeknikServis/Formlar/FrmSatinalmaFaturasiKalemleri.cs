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
    public partial class FrmSatinalmaFaturasiKalemleri : Form
    {
        public FrmSatinalmaFaturasiKalemleri()
        {
            InitializeComponent();
        }
        DbTeknikServisEntities1 db = new DbTeknikServisEntities1();
        private void FrmSatinalmaFaturasiKalemleri_Load(object sender, EventArgs e)
        {

        }

        private void BtnAra_Click(object sender, EventArgs e)
        {
            try
            {
                int id = Convert.ToInt16(TxtFaturaNumarasi.Text);
                var degerler = (from x in db.TBLSATINALMAFATURASIDETAY
                                select new
                                {
                                    NUMARA = x.FATURADETAYID,
                                    ÜRÜN = x.URUN,
                                    x.MARKA,
                                    x.ADET,
                                    FİYAT = x.FIYAT,
                                    x.TUTAR,
                                    FATURANUMARASI = x.FATURAID
                                }).Where(x => x.FATURANUMARASI == id);
                gridControl1.DataSource = degerler.ToList();
            }
            catch
            {
                MessageBox.Show("Lütfen Bilgileri Doğru Girdiğinize Emin Olunuz!");
            }
        }

        private void BtnAra2_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt16(TxtDetayNumarasi.Text);
            var degerler = (from x in db.TBLSATINALMAFATURASIDETAY
                            select new
                            {
                                NUMARA = x.FATURADETAYID,
                                ÜRÜN = x.URUN,
                                x.MARKA,
                                x.ADET,
                                FİYAT = x.FIYAT,
                                x.TUTAR,
                                FATURANUMARASI = x.FATURAID
                            }).Where(x => x.NUMARA == id);
            gridControl1.DataSource = degerler.ToList();

        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            TxtDetayNumarasi.Text = "";
            TxtFaturaNumarasi.Text = "";
        }
    }
}
