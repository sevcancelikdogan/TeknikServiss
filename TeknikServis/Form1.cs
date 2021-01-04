using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TeknikServis
{

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        DbTeknikServisEntities1 db = new DbTeknikServisEntities1();

        Formlar.FrmUrunListesi fr1;
        private void BtnUrunListesiFormu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (fr1 == null || fr1.IsDisposed)
            {
                fr1 = new Formlar.FrmUrunListesi();
                fr1.MdiParent = this;
                fr1.Show();
            }
        }

        private void BtnYeniUrun_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Formlar.FrmYeniUrun fr = new Formlar.FrmYeniUrun();
            fr.Show();
        }
        Formlar.FrmKategori fr2;
        private void BtnKategoriListe_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            if (fr2 == null || fr2.IsDisposed)
            {
                fr2 = new Formlar.FrmKategori();
                fr2.MdiParent = this;
                fr2.Show();
            }
        }

        private void BtnYeniKategori_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Formlar.FrmYeniKategori fr = new Formlar.FrmYeniKategori();
            fr.Show();
        }
        Formlar.Frmİstatik fr3;
        private void Btnİstatistik_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (fr3 == null || fr3.IsDisposed)
            {
                fr3 = new Formlar.Frmİstatik();
                fr3.MdiParent = this;
                fr3.Show();
            }
        }
        Formlar.FrmMarkalar fr4;
        private void barButtonItem7_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (fr4 == null || fr4.IsDisposed)
            {
                fr4 = new Formlar.FrmMarkalar();
                fr4.MdiParent = this;
                fr4.Show();
            }
        }
        Formlar.FrmCariListesi fr5;
        private void BtnCariListesi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (fr5 == null || fr5.IsDisposed)
            {
                fr5 = new Formlar.FrmCariListesi();
                fr5.MdiParent = this;
                fr5.Show();
            }
        }
        Formlar.FrmCariler fr6;
        private void BtnCariİstatistik_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (fr6 == null || fr6.IsDisposed)
            {
                fr6 = new Formlar.FrmCariler();
                fr6.MdiParent = this;
                fr6.Show();
            }
        }

        private void BtnCariEkle_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Formlar.FrmCariEkle fr = new Formlar.FrmCariEkle();
            fr.Show();
        }

        Formlar.FrmAnaSayfa fr;

        private void Form1_Load(object sender, EventArgs e)
        {
            if (fr == null || fr.IsDisposed)
            {
                fr = new Formlar.FrmAnaSayfa();
                fr.MdiParent = this;
                fr.Show();
            }
        }
        Formlar.FrmDepartman fr7;
        private void BtnDepartmanListesi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (fr7 == null || fr7.IsDisposed)
            {
                fr7 = new Formlar.FrmDepartman();
                fr7.MdiParent = this;
                fr7.Show();
            }
        }

        private void BtnYeniDepartman_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Formlar.FrmYeniDepartman fr = new Formlar.FrmYeniDepartman();
            fr.Show();
        }
        Formlar.FPersonelListesi fr8;
        private void barButtonItem22_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (fr8 == null || fr8.IsDisposed)
            {
                fr8 = new Formlar.FPersonelListesi();
                fr8.MdiParent = this;
                fr8.Show();
            }
        }

        private void barButtonItem23_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Formlar.FrmYeniPersonel fr = new Formlar.FrmYeniPersonel();
            fr.Show();
        }
        Formlar.FrmUrunAra fr24;
        private void barButtonItem5_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (fr24 == null || fr24.IsDisposed)
            {
                fr24 = new Formlar.FrmUrunAra();
                fr24.MdiParent = this;
                fr24.Show();
            }
        }

        private void BtnHesapMakinesi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            System.Diagnostics.Process.Start("Calc.exe");
        }
        Formlar.FrmKurlar fr9;
        private void BtnKurlar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (fr9 == null || fr9.IsDisposed)
            {
                fr9 = new Formlar.FrmKurlar();
                fr9.MdiParent = this;
                fr9.Show();
            }
        }

        private void BtnWord_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            System.Diagnostics.Process.Start("winword");

        }

        private void BtnExcel_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            System.Diagnostics.Process.Start("excel");

        }
        Formlar.FrmYoutube fr10;
        private void BtnYoutube_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (fr10 == null || fr10.IsDisposed)
            {
                fr10 = new Formlar.FrmYoutube();
                fr10.MdiParent = this;
                fr10.Show();
            }
        }
        Formlar.FrmHaberler fr11;
        private void BtnHaberler_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (fr11 == null || fr11.IsDisposed)
            {
                fr11 = new Formlar.FrmHaberler();
                fr11.MdiParent = this;
                fr11.Show();
            }
        }
        Formlar.FrmNotlar fr12;
        private void BtnAjanda_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (fr12 == null || fr12.IsDisposed)
            {
                fr12 = new Formlar.FrmNotlar();
                fr12.MdiParent = this;
                fr12.Show();
            }
        }

        private void BtnYeniNot_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Formlar.FrmYeniNotEkle fr = new Formlar.FrmYeniNotEkle();
            fr.Show();
        }
        Formlar.FrmArizaListesi fr13;
        private void BtnArizaListesi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (fr13 == null || fr13.IsDisposed)
            {
                fr13 = new Formlar.FrmArizaListesi();
                fr13.MdiParent = this;
                fr13.Show();
            }
        }


        private void BtnArizaliUrunKaydi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Formlar.FrmArizaliUrunKaydi fr = new Formlar.FrmArizaliUrunKaydi();
            fr.Show();
        }

        private void BtnUrunAcıklama_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Formlar.FrmArizaDetayi fr = new Formlar.FrmArizaDetayi();
            fr.Show();
        }
        Formlar.FrmArizaliUrunDetayListesi fr15;
        private void BtnArizaUrunDetaylari_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
                if (fr15 == null || fr15.IsDisposed)
            {
                fr15 = new Formlar.FrmArizaliUrunDetayListesi();
                fr15.MdiParent = this;
                fr15.Show();
            }
        }

        private void BtnQRCode_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Formlar.FrmQRCode fr = new Formlar.FrmQRCode();
            fr.Show();
        }
        Formlar.FrmFaturaListe fr16;
        private void BtnFaturaListesi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (fr16 == null || fr16.IsDisposed)
            {
                fr16 = new Formlar.FrmFaturaListe();
                fr16.MdiParent = this;
                fr16.Show();
            }
        }

        Formlar.FrmFaturaKalemListesi fr17;
        private void BtnFaturaKalemGirisi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (fr17 == null || fr17.IsDisposed)
            {
                fr17 = new Formlar.FrmFaturaKalemListesi();
                fr17.MdiParent = this;
                fr17.Show();
            }
        }
        Formlar.FrmFaturaKalemleri fr18;
        private void BtnFaturaKalemListele_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (fr18 == null || fr18.IsDisposed)
            {
                fr18 = new Formlar.FrmFaturaKalemleri();
                fr18.MdiParent = this;
                fr18.Show();
            }
        }

      
        Formlar.FrmHaritalar fr19;
        private void BtnHaritalar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (fr19 == null || fr19.IsDisposed)
            {
                fr19 = new Formlar.FrmHaritalar();
                fr19.MdiParent = this;
                fr19.Show();
            }

        }
        Formlar.FrmGaugecs fr20;
        private void BtnGauge_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (fr20 == null || fr20.IsDisposed)
            {
                fr20 = new Formlar.FrmGaugecs();
                fr20.MdiParent = this;
                fr20.Show();
            }
        }

        private void BtnRaporlar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Formlar.FrmRapor fr = new Formlar.FrmRapor();
           // fr.MdiParent = this;
            fr.Show();
        }

        private void BtnAnaSayfa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (fr == null || fr.IsDisposed)
            {
                fr = new Formlar.FrmAnaSayfa();
                fr.MdiParent = this;
                fr.Show();
            }
        }

        private void barButtonItem17_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Formlar.FrmYeniFaturaGirisi fr25 = new Formlar.FrmYeniFaturaGirisi();
            fr25
                .Show();
        }
        Iletisim.FrmCariRehber fr21;
        private void BtnRehber_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (fr21 == null || fr21.IsDisposed)
             {
            fr21 = new Iletisim.FrmCariRehber();
            fr21.MdiParent = this;
            fr21.Show();
            }

            
        }
        Iletisim.FrmGelenKutusu fr22;
        private void BtnMailKutusu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (fr22 == null || fr22.IsDisposed)
            {
                fr22 = new Iletisim.FrmGelenKutusu();
                fr22.MdiParent = this;
                fr22.Show();
            }
        }
        Iletisim.FrmMail fr23;
        private void BtnMailGönder_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (fr23 == null || fr23.IsDisposed)
            {
                fr23 = new Iletisim.FrmMail();
               // fr23.MdiParent = this;
                fr23.Show();
            }
        }

        private void BtnYardım_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            MessageBox.Show("Bize Ulaşın (444 21 33)","Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        Formlar.FrmPersonelHareketleri fr25;
        private void BtnPerosnelHareketleri_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            if (fr25 == null || fr25.IsDisposed)
            {
                fr25 = new Formlar.FrmPersonelHareketleri();
                fr25.MdiParent = this;
                fr25.Show();
            }
        }
        Formlar.FrmCariHareketleri fr26;
        private void BtnCariHareketleri_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (fr26 == null || fr26.IsDisposed)
            {
                fr26 = new Formlar.FrmCariHareketleri();
                fr26.MdiParent = this;
                fr26.Show();
            }
        }
        Formlar.FrmGelirGider fr27;
        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (fr27 == null || fr27.IsDisposed)
            {
                fr27 = new Formlar.FrmGelirGider();
                fr27.MdiParent = this;
                fr27.Show();
            }
        }
        Formlar.FrmGiderListesi fr28;
        private void barButtonItem5_ItemClick_1(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (fr28 == null || fr28.IsDisposed)
            {
                fr28 = new Formlar.FrmGiderListesi();
                fr28.MdiParent = this;
                fr28.Show();
            }
        }
        Formlar.FrmYeniGİder fr29;
        private void BtnYeniGider_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (fr29 == null || fr29.IsDisposed)
            {
                fr29 = new Formlar.FrmYeniGİder();
                fr29.Show();
            }
        }
      
        Formlar.FrmArizaFaturaListesi fr30;
        private void BtnArizaliFaturaListesi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (fr30 == null || fr30.IsDisposed)
            {
                fr30 = new Formlar.FrmArizaFaturaListesi();
                fr30.MdiParent = this;
                fr30.Show();
            }
        }
        Formlar.FrmArizaliFaturaGirişi fr31;
        private void BtnArizaliUrunFaturaGirisi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (fr31 == null || fr31.IsDisposed)
            {
                fr31 = new Formlar.FrmArizaliFaturaGirişi();
                fr31.Show();
            }
        }
        Formlar.FrmArizaliUrunFaturaKalemGirisi fr32;
        private void BtnArızaliUrunFaturaKalem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (fr32 == null || fr32.IsDisposed)
            {
                fr32 = new Formlar.FrmArizaliUrunFaturaKalemGirisi();
                fr32.MdiParent = this;
                fr32.Show();
            }
        }
        Formlar.FrmDetaylıArizaliUrunSorgulama fr33;
        private void BtnArizaliUrünFaturasıSorgulama_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            if (fr33 == null || fr33.IsDisposed)
            {
                fr33 = new Formlar.FrmDetaylıArizaliUrunSorgulama();
                fr33.MdiParent = this;
                fr33.Show();
            }
        }
       
        Formlar.FrmYeniSatinalmaFaturasiGirisi fr35;
        private void BtnYeniSatınAlmaFatura_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            if (fr35 == null || fr35.IsDisposed)
            {
                fr35 = new Formlar.FrmYeniSatinalmaFaturasiGirisi();
                fr35.Show();
            }
        }
        Formlar.FrmSatinalmaFaturaKalemGirisleri fr36;
        private void BtnSatinalmaFaturasiKalemGirisi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (fr36 == null || fr36.IsDisposed)
            {
                fr36 = new Formlar.FrmSatinalmaFaturaKalemGirisleri();
                fr36.MdiParent = this;
                fr36.Show();
            }
        }
        Formlar.FrmSatinalmaFaturasiKalemleri fr37;
        private void BtnDetaylıSatınAlmaFaturaListesi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (fr37 == null || fr37.IsDisposed)
            {
                fr37 = new Formlar.FrmSatinalmaFaturasiKalemleri();
                fr37.MdiParent = this;
                fr37.Show();
            }
        }
        Formlar.FrmSatinalmaFaturaListesi fr34;
        private void BtnSatinAlmaFaturaListesi_ItemClick_1(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (fr34 == null || fr34.IsDisposed)
            {
                fr34 = new Formlar.FrmSatinalmaFaturaListesi();
                fr34.MdiParent = this;
                fr34.Show();
            }
        }
        Formlar.FrmSabitKıymetListesi fr38;
        private void BtnSabitKiymetListesi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (fr38 == null || fr38.IsDisposed)
            {
                fr38 = new Formlar.FrmSabitKıymetListesi();
                fr38.MdiParent = this;
                fr38.Show();
            }
        }
        Formlar.FrmSabitkiymetSatisListesics fr39;
        private void barButtonItem11_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (fr39 == null || fr39.IsDisposed)
            {
                fr39 = new Formlar.FrmSabitkiymetSatisListesics();
                fr39.MdiParent = this;
                fr39.Show();
            }


        }
        Formlar.FrmSabitKiymet fr40;
        private void BtnSabitKiymetKaydi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (fr40 == null || fr40.IsDisposed)
            {
                fr40 = new Formlar.FrmSabitKiymet();
                fr40.Show();
            }
        }
        Formlar.FrmSabitkiymetAlis fr41;
        private void BtnMalAlisFaturasi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (fr41 == null || fr41.IsDisposed)
            {
                fr41 = new Formlar.FrmSabitkiymetAlis();
                fr41.MdiParent = this;
                fr41.Show();
            }
        }
        Formlar.FrmUrunSatis fr14;
        private void BtnYeniSatisSiparisi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            if (fr14 == null || fr14.IsDisposed)
            {
                fr14 = new Formlar.FrmUrunSatis();
                fr14.Show();
            }
        }
        Formlar.FrmSatisSiparisListesics fr42;
        private void BtnSatisSiparisleriListesi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (fr42 == null || fr42.IsDisposed)
            {
                fr42 = new Formlar.FrmSatisSiparisListesics();
                fr42.MdiParent = this;
                fr42.Show();
            }
        }
        Formlar.FrmUrunSatinalma fr43;
        private void BtnYeniSatinalma_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (fr43 == null || fr43.IsDisposed)
            {
                fr43 = new Formlar.FrmUrunSatinalma();
                fr43.Show();
            }
        }
        Formlar.FrmSatinalmaSiparisListesi fr44;
        private void barButtonItem23_ItemClick_1(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (fr44 == null || fr44.IsDisposed)
            {
                fr44 = new Formlar.FrmSatinalmaSiparisListesi();
                fr44.MdiParent = this;
                fr44.Show();
            }
        }
      /*  Formlar.FrmIadeFaturasi fr45;
        private void BtnIadeFaturalariListesi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (fr45 == null || fr45.IsDisposed)
            {
                fr45 = new Formlar.FrmIadeFaturasi();
                fr45.MdiParent = this;
                fr45.Show();
            }
        }*/
        Formlar.FrmIrsaliye fr46;
        private void BtnIrsaliyeListesi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (fr46 == null || fr46.IsDisposed)
            {
                fr46 = new Formlar.FrmIrsaliye();
                fr46.MdiParent = this;
                fr46.Show();
            }
        }
        Formlar.FrmKullanici fr47;
        private void barButtonItem16_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            if (fr47 == null || fr46.IsDisposed)
            {

                fr47 = new Formlar.FrmKullanici();
                fr47.MdiParent = this;
                fr47.Show();
            }          

        }
        private void BtnKullaniciYetkilendirme_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
        } 
    }
}

