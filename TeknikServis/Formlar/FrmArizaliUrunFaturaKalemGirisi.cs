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
    public partial class FrmArizaliUrunFaturaKalemGirisi : Form
    {
        public FrmArizaliUrunFaturaKalemGirisi()
        {
            InitializeComponent();
        }
        void metot()
        {
            var sorgu = from x in db.TBLARIZAFATURADETAY
                         select new
                         {
                            DETAYNUMARASI= x.DETAYID,
                            FATURANUMARASI= x.FATURAID,
                            ÜRÜNSERİNUMARASI= x.URUNSERINO,
                            ALINANPARÇA= x.ALINANPARCA,
                            PARÇAFİYATI = x.ALINANPARCAFIYATI,
                            SORUN =x.SORUN,
                            AÇIKLAMA = x.ACIKLAMA,
                            İŞLEMLER = x.ISLEMLER,
                            SERVİSÜCRETİ = x.SERVISUCRETI
                         };
            gridControl1.DataSource = sorgu.ToList();
        }

        DbTeknikServisEntities1 db = new DbTeknikServisEntities1();
        private void FrmArizaliUrunFaturaKalemGirisi_Load(object sender, EventArgs e)
        {
           TxtUrunSeriNumarasi.Properties.DataSource = (from x in db.TBLURUNKABUL
                                                select new
                                                {
                                                   ÜRÜNSERİNUMARASI = x.URUNSERINO
                                                }).ToList();

            lookUpEdit1.Properties.DataSource = (from x in db.TBLARIZAFATURA1Set
                                                select new
                                                {
                                                   FATURANUMARASI= x.ARIZAID
                                                }).ToList();

            metot();
        }
        
        private void lookUpEdit1_EditValueChanged(object sender, EventArgs e)
        {
           
        }

        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            try
            {
                TBLARIZAFATURADETAY t = new TBLARIZAFATURADETAY();
                t.FATURAID = int.Parse(lookUpEdit1.EditValue.ToString());
                t.URUNSERINO = TxtUrunSeriNumarasi.EditValue.ToString();
                t.ALINANPARCA = richTextBox1.Text;
                t.ALINANPARCAFIYATI = decimal.Parse(TxtTutar.Text);
                t.SORUN = richTextBox4.Text;
                t.ACIKLAMA = richTextBox3.Text;
                t.ISLEMLER = richTextBox2.Text;
                t.SERVISUCRETI = decimal.Parse(TxtServisUcreti.Text);
                db.TBLARIZAFATURADETAY.Add(t);
                db.SaveChanges();
                MessageBox.Show("Fatura Kalemi Başarıyla Kaydedildi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                metot();
            }
            catch
            {
                MessageBox.Show("Lütfen Tüm Bilgileri Eksiksiz Doldurunuz!","Hata", MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void BtnListele_Click(object sender, EventArgs e)
        {
            txtID.Text = "";
            richTextBox3.Text = "";
            richTextBox2.Text = "";
            richTextBox4.Text = "";
            TxtServisUcreti.Text = "";
            TxtTutar.Text = "";
            TxtUrunSeriNumarasi.Text = "";
            lookUpEdit1.Text = "";
            richTextBox1.Text = "";
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            txtID.Text = gridView1.GetFocusedRowCellValue("DETAYNUMARASI").ToString();
            lookUpEdit1.Text = gridView1.GetFocusedRowCellValue("FATURANUMARASI").ToString();
            TxtUrunSeriNumarasi.Text = gridView1.GetFocusedRowCellValue("ÜRÜNSERİNUMARASI").ToString();
            richTextBox1.Text = gridView1.GetFocusedRowCellValue("ALINANPARÇA").ToString();
            TxtTutar.Text = gridView1.GetFocusedRowCellValue("PARÇAFİYATI").ToString();
            richTextBox4.Text = gridView1.GetFocusedRowCellValue("SORUN").ToString();
            richTextBox3.Text = gridView1.GetFocusedRowCellValue("AÇIKLAMA").ToString();
            richTextBox2.Text = gridView1.GetFocusedRowCellValue("İŞLEMLER").ToString();
            TxtServisUcreti.Text = gridView1.GetFocusedRowCellValue("SERVİSÜCRETİ").ToString();
            
        }

        private void BtnSil_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtID.Text);
            var sorgu = db.TBLARIZAFATURADETAY.Find(id);
            db.TBLARIZAFATURADETAY.Remove(sorgu);
            db.SaveChanges();
            MessageBox.Show("Fatura Kalemi Başarıyla Silindi!","Bilgi",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            metot();
        }

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            try
            {
                int id = int.Parse(txtID.Text);
                var deger = db.TBLARIZAFATURADETAY.Find(id);
                deger.FATURAID = int.Parse(lookUpEdit1.EditValue.ToString());
                deger.URUNSERINO = TxtUrunSeriNumarasi.EditValue.ToString();
                deger.ALINANPARCA = richTextBox1.Text;
                deger.ALINANPARCAFIYATI = decimal.Parse(TxtTutar.Text);
                deger.SORUN = richTextBox4.Text;
                deger.ACIKLAMA = richTextBox3.Text;
                deger.ISLEMLER = richTextBox2.Text;
                deger.SERVISUCRETI = decimal.Parse(TxtServisUcreti.Text);
                db.SaveChanges();
                MessageBox.Show("Fatura Kalemi Başarıyla Güncellendi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                metot();
            }
            catch
            {
                MessageBox.Show("Fatura Kalemi Başarıyla Güncellenemedi!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
    }
}
