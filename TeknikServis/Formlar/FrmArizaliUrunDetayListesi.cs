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
    public partial class FrmArizaliUrunDetayListesi : Form
    {
        public FrmArizaliUrunDetayListesi()
        {
            InitializeComponent();
        }
        DbTeknikServisEntities1 db = new DbTeknikServisEntities1();
        private void FrmArizaliUrunDetayListesi_Load(object sender, EventArgs e)
        {
            var degerler = from u in db.TBLURUNTAKIP
                           select new
                           {

                               NUMARA = u.TAKIPID,
                          //   ÜRÜN = u.URUN,
                               AÇIKLAMA = u.ACIKLAMA,
                               TARİH = u.TARIH,
                               SERİNUMARASI = u.SERINO
                           };
            gridControl1.DataSource = degerler.ToList();
        }
    }
}
