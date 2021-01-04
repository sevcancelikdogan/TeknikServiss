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
    public partial class FrmCariRehber : Form
    {
        public FrmCariRehber()
        {
            InitializeComponent();
        }
        DbTeknikServisEntities1 db = new DbTeknikServisEntities1();
        private void FrmCariRehber_Load(object sender, EventArgs e)
        {
            gridControl1.DataSource = (from u in db.TBLCARI
                                       select new
                                       {
                                           //u.ID,
                                           u.AD,
                                           u.SOYAD,
                                           u.TELEFON,
                                           MAİL = u.MAIL,
                                           u.ADRES
                                       }).ToList(); 
        }
    }
}
