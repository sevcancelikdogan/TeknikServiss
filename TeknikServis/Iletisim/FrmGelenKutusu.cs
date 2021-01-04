using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TeknikServis.Iletisim
{
    public partial class FrmGelenKutusu : Form
    {
        public FrmGelenKutusu()
        {
            InitializeComponent();
        }
        DbTeknikServisEntities1 db = new DbTeknikServisEntities1();
        private void FrmGelenKutusu_Load(object sender, EventArgs e)
        {
            labelControl18.Text = db.TBLILETISIM.Count().ToString();
            labelControl14.Text = db.TBLILETISIM.Where(x => x.KONU == "Teşekkür").Count().ToString();
            labelControl16.Text = db.TBLILETISIM.Where(x => x.KONU == "Rica").Count().ToString();
            labelControl16.Text = db.TBLILETISIM.Where(x => x.KONU == "Şikayet").Count().ToString();
            labelControl12.Text = db.TBLILETISIM.Where(x => x.KONU == "Memnuniyet").Count().ToString();


            gridControl1.DataSource = (from x in db.TBLILETISIM
                                       select new
                                       {
                                          // x.ID,
                                          MÜŞTERİ = x.ADSOYAD,
                                           x.KONU,
                                          MAİL = x.MAIL,
                                           x.MESAJ,

                                       }).ToList();
        }








    }
}
