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
    public partial class FrmUrunAra : Form
    {
        public FrmUrunAra()
        {
            InitializeComponent();
        }
        DbTeknikServisEntities1 db = new DbTeknikServisEntities1();
        private void FrmUrunAra_Load(object sender, EventArgs e)
        {

        }

        private void BtnAra_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt16(TxtUrunId.Text);
            var degerler = (from x in db.TBLURUN
                            select new
                            {
                                NUMARA = x.ID,
                                ÜRÜN = x.AD,
                                x.MARKA,
                                x.STOK,                              
                                FİYAT = x.SATISFIYAT,
                                x.ALISFIYAT,
                                KATEGORİ = x.KATEGORI
                            }).Where(x => x.NUMARA == id);
            gridControl1.DataSource = degerler.ToList();
        }

        private void BtnAra2_Click(object sender, EventArgs e)
        {
            string id = TxtUrunAdi.Text;
            var degerler = (from x in db.TBLURUN
                            select new
                            {
                                NUMARA = x.ID,
                                ÜRÜN = x.AD,
                                x.MARKA,
                                x.STOK,
                                FİYAT = x.SATISFIYAT,
                                x.ALISFIYAT,
                                KATEGORİ = x.KATEGORI
                            }).Where(x => x.ÜRÜN == id);
            gridControl1.DataSource = degerler.ToList();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            string id = TxtUrunMarkasi.Text;
            var degerler = (from x in db.TBLURUN
                            select new
                            {
                                NUMARA = x.ID,
                                ÜRÜN = x.AD,
                                x.MARKA,
                                x.STOK,
                                FİYAT = x.SATISFIYAT,
                                x.ALISFIYAT,
                                KATEGORİ = x.KATEGORI
                            }).Where(x => x.MARKA == id);
            gridControl1.DataSource = degerler.ToList();
        }

        private void simpleButton1_Click_1(object sender, EventArgs e)
        {
            TxtUrunAdi.Text = "";
            TxtUrunId.Text = "";
            TxtUrunMarkasi.Text = "";
        }
    }
}
