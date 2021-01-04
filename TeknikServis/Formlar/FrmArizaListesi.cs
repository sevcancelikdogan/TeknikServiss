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
    public partial class FrmArizaListesi : Form
    {
        public FrmArizaListesi()
        {
            InitializeComponent();
        }
        DbTeknikServisEntities1 db = new DbTeknikServisEntities1();


        void metot1()
        {
            var degerler = from x in db.TBLURUNKABUL
                           select new
                           {
                               NUMARA = x.ISLEMID,
                               CARİ = x.TBLCARI.AD + " " + x.TBLCARI.SOYAD,
                               PERSONEL = x.TBLPERSONEL.AD + " " + x.TBLPERSONEL.SOYAD,
                               GELİŞTARİHİ = x.GELISTARIHI,
                               CIKIŞTARİHİ = x.CIKISTARIHI,
                               SERİNUMARASI = x.URUNSERINO,
                               DURUMDETAY = x.URUNDURUMDETAY
                           };
            gridControl1.DataSource = degerler.ToList();
            labelControl5.Text = db.TBLURUNKABUL.Count(x => x.URUNDURUM == true).ToString();
            labelControl3.Text = db.TBLURUNKABUL.Count(x => x.URUNDURUM == false).ToString();
            labelControl1.Text = db.TBLURUN.Count().ToString();
            labelControl7.Text = db.TBLURUNKABUL.Count(x => x.URUNDURUMDETAY == "Parça Bekliyor").ToString();
            labelControl10.Text = db.TBLURUNKABUL.Count(x => x.URUNDURUMDETAY == "Mesaj Bekliyor").ToString();
            labelControl12.Text = db.TBLURUNKABUL.Count(x => x.URUNDURUMDETAY == "İptal Bekliyor").ToString();



            SqlConnection bag = new SqlConnection(@"Data Source=DESKTOP-G9I2N7Q;Initial Catalog=DbTeknikServis;Integrated Security=True");
            bag.Open();
            SqlCommand kmt = new SqlCommand("SELECT URUNDURUMDETAY, COUNT(*) FROM TBLURUNKABUL GROUP BY URUNDURUMDETAY", bag);
            SqlDataReader rd = kmt.ExecuteReader();
            while (rd.Read())
            {
                chartControl1.Series["Series 1"].Points.AddPoint(Convert.ToString(rd[0]), int.Parse(rd[1].ToString()));

            }
            bag.Close();


        }
        private void FrmArizaListesi_Load(object sender, EventArgs e)
        {
            metot1();   
        }

        private void gridControl1_DoubleClick(object sender, EventArgs e)
        {
            FrmArizaDetayi fr = new FrmArizaDetayi();
            fr.id = gridView1.GetFocusedRowCellValue("NUMARA").ToString();
            fr.serino = gridView1.GetFocusedRowCellValue("SERİNUMARASI").ToString();
            fr.Show();
        }
    }
}
