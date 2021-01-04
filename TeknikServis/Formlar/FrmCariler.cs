using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace TeknikServis.Formlar
{
    public partial class FrmCariler : Form
    {
        public FrmCariler()
        {
            InitializeComponent();
        }
        DbTeknikServisEntities1 db = new DbTeknikServisEntities1();
        SqlConnection bag = new SqlConnection(@"Data Source=DESKTOP-G9I2N7Q;Initial Catalog=DbTeknikServis;Integrated Security=True");
        private void FrmCariler_Load(object sender, EventArgs e)
        {
           /* chartControl1.Series["Series 1"].Points.AddPoint("ANKARA", 22);
            chartControl1.Series["Series 1"].Points.AddPoint("İSTANBUL", 12);
            chartControl1.Series["Series 1"].Points.AddPoint("İZMİR", 8);
            chartControl1.Series["Series 1"].Points.AddPoint("BURSA", 14);*/

            gridControl1.DataSource = db.TBLCARI.OrderBy(x => x.IL).
                GroupBy(y => y.IL).
                Select(z => new { IL = z.Key, Toplam = z.Count() }).ToList();

            bag.Open();
            SqlCommand kmt = new SqlCommand("select IL,Count(*) from TBLCARI group by IL",bag);
            SqlDataReader dr = kmt.ExecuteReader();
            while(dr.Read())
            {
                chartControl1.Series["Series 1"].Points.AddPoint(Convert.ToString(dr[0]), int.Parse(dr[1].ToString()));


            }
            bag.Close();
        }
    }
}
