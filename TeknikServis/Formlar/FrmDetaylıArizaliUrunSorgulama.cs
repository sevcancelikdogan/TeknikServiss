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
    public partial class FrmDetaylıArizaliUrunSorgulama : Form
    {
        public FrmDetaylıArizaliUrunSorgulama()
        {
            InitializeComponent();
        }
        DbTeknikServisEntities1 db = new DbTeknikServisEntities1();

        private void FrmDetaylıArizaliUrunSorgulama_Load(object sender, EventArgs e)
        {

        }

        private void BtnAra_Click(object sender, EventArgs e)
        {
            try
            {
                int id = Convert.ToInt16(TxtFaturaNumarasi.Text);
                var degerler = (from x in db.TBLARIZAFATURADETAY
                                select new
                                {
                                    DETAYNUMARASI = x.DETAYID,
                                    FATURANUMARASI = x.FATURAID,
                                    ÜRÜNSERİNUMARASI =x.URUNSERINO,
                                    ALINANPARÇA = x.ALINANPARCA,
                                    PARÇAFİYATI = x.ALINANPARCAFIYATI,
                                    SORUN = x.SORUN,
                                    AÇIKLAMA = x.ACIKLAMA,
                                    İŞLEMLER = x.ISLEMLER,
                                    SERVİSÜCRETİ = x.SERVISUCRETI
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
            try
            {
                int id = Convert.ToInt16(TxtDetayNumarasi.Text);
                var degerler = (from x in db.TBLARIZAFATURADETAY
                                select new
                                {
                                    DETAYNUMARASI = x.DETAYID,
                                    FATURANUMARASI = x.FATURAID,
                                    ÜRÜNSERİNUMARASI = x.URUNSERINO,
                                    ALINANPARÇA = x.ALINANPARCA,
                                    PARÇAFİYATI = x.ALINANPARCAFIYATI,
                                    SORUN = x.SORUN,
                                    AÇIKLAMA = x.ACIKLAMA,
                                    İŞLEMLER = x.ISLEMLER,
                                    SERVİSÜCRETİ = x.SERVISUCRETI
                                }).Where(x => x.DETAYNUMARASI == id);
                gridControl1.DataSource = degerler.ToList();
            }
            catch
            {
                MessageBox.Show("Lütfen Bilgileri Doğru Girdiğinize Emin Olunuz!");
            }
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            TxtDetayNumarasi.Text = "";
            TxtFaturaNumarasi.Text = "";
        }
    }
}
