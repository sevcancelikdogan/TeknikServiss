using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace TeknikServis.Formlar
{
    public partial class FrmMarkalar : Form
    {
        public FrmMarkalar()
        {
            InitializeComponent();
        }
        DbTeknikServisEntities1 db = new DbTeknikServisEntities1();
        private void FrmMarkalar_Load(object sender, EventArgs e)
        {

            var degerler = db.TBLURUN.OrderBy(x => x.MARKA).GroupBy(y => y.MARKA).
                Select(z => new
                {
                    Marka = z.Key,
                    Toplam = z.Count()
                });
            gridControl1.DataSource = degerler.ToList();

            labelControl2.Text = db.TBLURUN.Count().ToString();
            labelControl3.Text = (from x in db.TBLURUN                              // tekrarsız şekilde ssaydırdı
                                   select x.MARKA).Distinct().Count().ToString();
            labelControl7.Text = (from x in db.TBLURUN
                                   orderby x.SATISFIYAT descending
                                   select x.MARKA).FirstOrDefault();
            labelControl5.Text = db.marksurunmarka().FirstOrDefault();


            /*   chartControl1.Series["Series 1"].Points.AddPoint("LENOVA",4);
               chartControl1.Series["Series 1"].Points.AddPoint("APPLE", 6);
               chartControl1.Series["Series 1"].Points.AddPoint("ASUS", 2);
               chartControl1.Series["Series 1"].Points.AddPoint("SAMSUNG", 1);
               chartControl1.Series["Series 1"].Points.AddPoint("BEKO", 1);*/

            SqlConnection bag = new SqlConnection(@"Data Source=DESKTOP-G9I2N7Q;Initial Catalog=DbTeknikServis;Integrated Security=True");
            bag.Open();
            SqlCommand kmt = new SqlCommand("SELECT MARKA, COUNT(*) FROM TBLURUN GROUP BY MARKA", bag);
            SqlDataReader rd = kmt.ExecuteReader();
            while(rd.Read())
            {
                 chartControl1.Series["Series 1"].Points.AddPoint(Convert.ToString(rd[0]), int.Parse(rd[1].ToString()));

            }
            bag.Close();
            /* chartControl2.Series["Kategoriler"].Points.AddPoint("Beyaz Eşya", 4);
             chartControl2.Series["Kategoriler"].Points.AddPoint("Bilgisayar", 3);
             chartControl2.Series["Kategoriler"].Points.AddPoint("Küçük Ev Aletleri", 6);
             chartControl2.Series["Kategoriler"].Points.AddPoint("TV", 2);
             chartControl2.Series["Kategoriler"].Points.AddPoint("Telefon", 1);
             chartControl2.Series["Kategoriler"].Points.AddPoint("Diğer", 2);*/

            bag.Open();
            SqlCommand kmt2 = new SqlCommand("SELECT TBLKATEGORI.AD,COUNT(*) FROM TBLURUN INNER JOIN TBLKATEGORI ON TBLKATEGORI.ID= TBLURUN.KATEGORI GROUP BY TBLKATEGORI.AD", bag);
            SqlDataReader rd2 = kmt2.ExecuteReader();
            while (rd2.Read())
            {
                chartControl2.Series["Kategoriler"].Points.AddPoint(Convert.ToString(rd2[0]), int.Parse(rd2[1].ToString()));

            }
            bag.Close();


        }

       
        
    }
}
