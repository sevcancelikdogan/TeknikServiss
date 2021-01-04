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
    public partial class FrmGelirGider : Form
    {
        public FrmGelirGider()
        {
            InitializeComponent();
        }

        private void labelControl19_Click(object sender, EventArgs e)
        {

        }
        DbTeknikServisEntities1 db = new DbTeknikServisEntities1();
        private void FrmGelirGider_Load(object sender, EventArgs e)
        {
            labelControl18.Text = db.TBLURUNHAREKET.Sum(x => x.FIYAT).ToString();
            labelControl14.Text = db.TBLURUNHAREKET.Average(x => x.FIYAT).ToString();
            labelControl1.Text = db.TBLURUNHAREKET.Max(x=>x.FIYAT).ToString();
            labelControl3.Text = db.TBLURUNHAREKET.Min(x=>x.FIYAT).ToString();
            labelControl6.Text = db.TBLGIDER.Sum(x => x.TUTAR).ToString();
            labelControl8.Text = db.TBLGIDER.Max(x => x.TUTAR).ToString();
            labelControl10.Text = db.TBLGIDER.Min(x => x.TUTAR).ToString();
            labelControl12.Text = db.TBLGIDER.Average(x => x.TUTAR).ToString();
            labelControl16.Text = db.TBLARIZAFATURA1Set.Sum(x => x.NETFIYAT).ToString();
            labelControl20.Text = db.TBLARIZAFATURA1Set.Average(x=>x.NETFIYAT).ToString();
            labelControl26.Text = db.TBLARIZAFATURA1Set.Min(x => x.NETFIYAT).ToString();
            labelControl28.Text = db.TBLARIZAFATURA1Set.Max(x => x.NETFIYAT).ToString();
            labelControl22.Text = db.TBLSATINALMAFATURASIDETAY.Sum(x => x.TUTAR).ToString();
            labelControl24.Text = db.TBLSATINALMAFATURASIDETAY.Average(x => x.TUTAR).ToString();
            labelControl30.Text = db.TBLSATINALMAFATURASIDETAY.Min(x => x.TUTAR).ToString();
            labelControl32.Text = db.TBLSATINALMAFATURASIDETAY.Max(x => x.TUTAR).ToString();
            labelControl5.Text = db.TBLMALALIMFATURASI.Sum(x => x.ALISBEDELI).ToString();
            labelControl35.Text = db.TBLMALALIMFATURASI.Average(x => x.ALISBEDELI).ToString();
            labelControl37.Text = db.TBLMALALIMFATURASI.Min(x => x.ALISBEDELI).ToString();
            labelControl39.Text = db.TBLMALALIMFATURASI.Max(x => x.ALISBEDELI).ToString();


        }

      
    }
}
