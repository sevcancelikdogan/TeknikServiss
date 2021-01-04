namespace TeknikServis.Formlar
{
    partial class FrmSabitkiymetAlis
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSabitkiymetAlis));
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.TxtCari = new DevExpress.XtraEditors.LookUpEdit();
            this.TxtToplam = new DevExpress.XtraEditors.TextEdit();
            this.labelControl12 = new DevExpress.XtraEditors.LabelControl();
            this.TxtAdet = new System.Windows.Forms.NumericUpDown();
            this.TxtFatura = new DevExpress.XtraEditors.GroupControl();
            this.labelControl11 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl10 = new DevExpress.XtraEditors.LabelControl();
            this.TxtSatisTutar = new DevExpress.XtraEditors.TextEdit();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.TxtVkn = new DevExpress.XtraEditors.TextEdit();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.TxtPersonel = new DevExpress.XtraEditors.LookUpEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.BtnListele = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.txtID = new DevExpress.XtraEditors.TextEdit();
            this.BtnGuncelle = new DevExpress.XtraEditors.SimpleButton();
            this.BtnSil = new DevExpress.XtraEditors.SimpleButton();
            this.BtnKaydet = new DevExpress.XtraEditors.SimpleButton();
            this.TxtMalzeme = new DevExpress.XtraEditors.TextEdit();
            this.TxtTarih = new DevExpress.XtraEditors.DateEdit();
            this.TxtVergiDairesi = new DevExpress.XtraEditors.TextEdit();
            this.TxtFaturaTipi = new DevExpress.XtraEditors.LookUpEdit();
            this.TxtStokKodu = new DevExpress.XtraEditors.LookUpEdit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtCari.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtToplam.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtAdet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtFatura)).BeginInit();
            this.TxtFatura.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TxtSatisTutar.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtVkn.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtPersonel.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtMalzeme.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtTarih.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtTarih.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtVergiDairesi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtFaturaTipi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtStokKodu.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // gridView1
            // 
            this.gridView1.Appearance.Row.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(156)))), ((int)(((byte)(218)))));
            this.gridView1.Appearance.Row.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(209)))), ((int)(((byte)(245)))));
            this.gridView1.Appearance.Row.Options.UseBackColor = true;
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridView1_FocusedRowChanged);
            // 
            // gridControl1
            // 
            this.gridControl1.Location = new System.Drawing.Point(1, 2);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(945, 576);
            this.gridControl1.TabIndex = 34;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // TxtCari
            // 
            this.TxtCari.Location = new System.Drawing.Point(129, 133);
            this.TxtCari.Name = "TxtCari";
            this.TxtCari.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.TxtCari.Properties.DisplayMember = "CARİ";
            this.TxtCari.Properties.NullText = "Cari Seçiniz";
            this.TxtCari.Properties.ValueMember = "NUMARASI";
            this.TxtCari.Size = new System.Drawing.Size(241, 20);
            this.TxtCari.TabIndex = 45;
            // 
            // TxtToplam
            // 
            this.TxtToplam.Location = new System.Drawing.Point(129, 314);
            this.TxtToplam.Name = "TxtToplam";
            this.TxtToplam.Size = new System.Drawing.Size(241, 20);
            this.TxtToplam.TabIndex = 44;
            // 
            // labelControl12
            // 
            this.labelControl12.Location = new System.Drawing.Point(79, 317);
            this.labelControl12.Name = "labelControl12";
            this.labelControl12.Size = new System.Drawing.Size(44, 13);
            this.labelControl12.TabIndex = 43;
            this.labelControl12.Text = "TOPLAM:";
            // 
            // TxtAdet
            // 
            this.TxtAdet.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtAdet.Location = new System.Drawing.Point(129, 235);
            this.TxtAdet.Name = "TxtAdet";
            this.TxtAdet.Size = new System.Drawing.Size(241, 23);
            this.TxtAdet.TabIndex = 42;
            // 
            // TxtFatura
            // 
            this.TxtFatura.Controls.Add(this.TxtCari);
            this.TxtFatura.Controls.Add(this.TxtToplam);
            this.TxtFatura.Controls.Add(this.labelControl12);
            this.TxtFatura.Controls.Add(this.TxtAdet);
            this.TxtFatura.Controls.Add(this.labelControl11);
            this.TxtFatura.Controls.Add(this.labelControl10);
            this.TxtFatura.Controls.Add(this.TxtSatisTutar);
            this.TxtFatura.Controls.Add(this.labelControl9);
            this.TxtFatura.Controls.Add(this.labelControl2);
            this.TxtFatura.Controls.Add(this.labelControl1);
            this.TxtFatura.Controls.Add(this.TxtVkn);
            this.TxtFatura.Controls.Add(this.labelControl8);
            this.TxtFatura.Controls.Add(this.labelControl6);
            this.TxtFatura.Controls.Add(this.TxtPersonel);
            this.TxtFatura.Controls.Add(this.labelControl4);
            this.TxtFatura.Controls.Add(this.labelControl5);
            this.TxtFatura.Controls.Add(this.labelControl3);
            this.TxtFatura.Controls.Add(this.BtnListele);
            this.TxtFatura.Controls.Add(this.labelControl7);
            this.TxtFatura.Controls.Add(this.txtID);
            this.TxtFatura.Controls.Add(this.BtnGuncelle);
            this.TxtFatura.Controls.Add(this.BtnSil);
            this.TxtFatura.Controls.Add(this.BtnKaydet);
            this.TxtFatura.Controls.Add(this.TxtMalzeme);
            this.TxtFatura.Controls.Add(this.TxtTarih);
            this.TxtFatura.Controls.Add(this.TxtVergiDairesi);
            this.TxtFatura.Controls.Add(this.TxtFaturaTipi);
            this.TxtFatura.Controls.Add(this.TxtStokKodu);
            this.TxtFatura.Location = new System.Drawing.Point(952, 2);
            this.TxtFatura.Name = "TxtFatura";
            this.TxtFatura.Size = new System.Drawing.Size(433, 576);
            this.TxtFatura.TabIndex = 33;
            this.TxtFatura.Text = "FATURA İŞLEMLERİ";
            // 
            // labelControl11
            // 
            this.labelControl11.Location = new System.Drawing.Point(56, 84);
            this.labelControl11.Name = "labelControl11";
            this.labelControl11.Size = new System.Drawing.Size(67, 13);
            this.labelControl11.TabIndex = 41;
            this.labelControl11.Text = "FATURA TİPİ:";
            // 
            // labelControl10
            // 
            this.labelControl10.Location = new System.Drawing.Point(18, 58);
            this.labelControl10.Name = "labelControl10";
            this.labelControl10.Size = new System.Drawing.Size(105, 13);
            this.labelControl10.TabIndex = 40;
            this.labelControl10.Text = "SABİT KIYMET KAYDI:";
            // 
            // TxtSatisTutar
            // 
            this.TxtSatisTutar.Location = new System.Drawing.Point(129, 288);
            this.TxtSatisTutar.Name = "TxtSatisTutar";
            this.TxtSatisTutar.Size = new System.Drawing.Size(241, 20);
            this.TxtSatisTutar.TabIndex = 38;
            // 
            // labelControl9
            // 
            this.labelControl9.Location = new System.Drawing.Point(73, 110);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(50, 13);
            this.labelControl9.TabIndex = 37;
            this.labelControl9.Text = "MALZEME:";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(93, 239);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(30, 13);
            this.labelControl2.TabIndex = 35;
            this.labelControl2.Text = "ADET:";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(100, 213);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(23, 13);
            this.labelControl1.TabIndex = 33;
            this.labelControl1.Text = "VKN:";
            // 
            // TxtVkn
            // 
            this.TxtVkn.Location = new System.Drawing.Point(129, 210);
            this.TxtVkn.Name = "TxtVkn";
            this.TxtVkn.Size = new System.Drawing.Size(241, 20);
            this.TxtVkn.TabIndex = 34;
            // 
            // labelControl8
            // 
            this.labelControl8.Location = new System.Drawing.Point(94, 135);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(29, 13);
            this.labelControl8.TabIndex = 30;
            this.labelControl8.Text = "CARİ:";
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(68, 160);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(55, 13);
            this.labelControl6.TabIndex = 28;
            this.labelControl6.Text = "PERSONEL:";
            // 
            // TxtPersonel
            // 
            this.TxtPersonel.Location = new System.Drawing.Point(129, 157);
            this.TxtPersonel.Name = "TxtPersonel";
            this.TxtPersonel.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.TxtPersonel.Properties.DisplayMember = "PERSONEL";
            this.TxtPersonel.Properties.NullText = "Personel Seçiniz";
            this.TxtPersonel.Properties.ValueMember = "NUMARASI";
            this.TxtPersonel.Size = new System.Drawing.Size(241, 20);
            this.TxtPersonel.TabIndex = 29;
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(61, 291);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(62, 13);
            this.labelControl4.TabIndex = 26;
            this.labelControl4.Text = "ALIŞ FİYATI:";
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(45, 186);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(78, 13);
            this.labelControl5.TabIndex = 24;
            this.labelControl5.Text = "VERGİ DAİRESİ:";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(88, 265);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(35, 13);
            this.labelControl3.TabIndex = 20;
            this.labelControl3.Text = "TARİH:";
            // 
            // BtnListele
            // 
            this.BtnListele.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.BtnListele.Appearance.Options.UseBackColor = true;
            this.BtnListele.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnListele.ImageOptions.Image")));
            this.BtnListele.Location = new System.Drawing.Point(129, 489);
            this.BtnListele.Name = "BtnListele";
            this.BtnListele.Size = new System.Drawing.Size(241, 41);
            this.BtnListele.TabIndex = 19;
            this.BtnListele.Text = "TEMİZLE";
            this.BtnListele.Click += new System.EventHandler(this.BtnListele_Click);
            // 
            // labelControl7
            // 
            this.labelControl7.Location = new System.Drawing.Point(23, 32);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(100, 13);
            this.labelControl7.TabIndex = 17;
            this.labelControl7.Text = "FATURA NUMARASI:";
            // 
            // txtID
            // 
            this.txtID.Enabled = false;
            this.txtID.Location = new System.Drawing.Point(129, 29);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(241, 20);
            this.txtID.TabIndex = 18;
            // 
            // BtnGuncelle
            // 
            this.BtnGuncelle.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.BtnGuncelle.Appearance.Options.UseBackColor = true;
            this.BtnGuncelle.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnGuncelle.ImageOptions.Image")));
            this.BtnGuncelle.Location = new System.Drawing.Point(129, 442);
            this.BtnGuncelle.Name = "BtnGuncelle";
            this.BtnGuncelle.Size = new System.Drawing.Size(241, 41);
            this.BtnGuncelle.TabIndex = 15;
            this.BtnGuncelle.Text = "GÜNCELLE";
            this.BtnGuncelle.Click += new System.EventHandler(this.BtnGuncelle_Click);
            // 
            // BtnSil
            // 
            this.BtnSil.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.BtnSil.Appearance.Options.UseBackColor = true;
            this.BtnSil.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnSil.ImageOptions.Image")));
            this.BtnSil.Location = new System.Drawing.Point(129, 395);
            this.BtnSil.Name = "BtnSil";
            this.BtnSil.Size = new System.Drawing.Size(241, 41);
            this.BtnSil.TabIndex = 14;
            this.BtnSil.Text = "SİL";
            this.BtnSil.Click += new System.EventHandler(this.BtnSil_Click);
            // 
            // BtnKaydet
            // 
            this.BtnKaydet.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.BtnKaydet.Appearance.Options.UseBackColor = true;
            this.BtnKaydet.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnKaydet.ImageOptions.Image")));
            this.BtnKaydet.Location = new System.Drawing.Point(129, 348);
            this.BtnKaydet.Name = "BtnKaydet";
            this.BtnKaydet.Size = new System.Drawing.Size(241, 41);
            this.BtnKaydet.TabIndex = 13;
            this.BtnKaydet.Text = "KAYDET";
            this.BtnKaydet.Click += new System.EventHandler(this.BtnKaydet_Click);
            // 
            // TxtMalzeme
            // 
            this.TxtMalzeme.Location = new System.Drawing.Point(129, 107);
            this.TxtMalzeme.Name = "TxtMalzeme";
            this.TxtMalzeme.Size = new System.Drawing.Size(241, 20);
            this.TxtMalzeme.TabIndex = 2;
            // 
            // TxtTarih
            // 
            this.TxtTarih.EditValue = null;
            this.TxtTarih.Location = new System.Drawing.Point(129, 262);
            this.TxtTarih.Name = "TxtTarih";
            this.TxtTarih.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.TxtTarih.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.TxtTarih.Properties.DisplayFormat.FormatString = "";
            this.TxtTarih.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.TxtTarih.Properties.EditFormat.FormatString = "";
            this.TxtTarih.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.TxtTarih.Properties.NullText = "Tarih Seçiniz";
            this.TxtTarih.Size = new System.Drawing.Size(241, 20);
            this.TxtTarih.TabIndex = 21;
            // 
            // TxtVergiDairesi
            // 
            this.TxtVergiDairesi.Location = new System.Drawing.Point(129, 183);
            this.TxtVergiDairesi.Name = "TxtVergiDairesi";
            this.TxtVergiDairesi.Size = new System.Drawing.Size(241, 20);
            this.TxtVergiDairesi.TabIndex = 25;
            // 
            // TxtFaturaTipi
            // 
            this.TxtFaturaTipi.Location = new System.Drawing.Point(129, 81);
            this.TxtFaturaTipi.Name = "TxtFaturaTipi";
            this.TxtFaturaTipi.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.TxtFaturaTipi.Properties.DisplayMember = "FATURATİPİ";
            this.TxtFaturaTipi.Properties.NullText = "Fatura Tipi Seçiniz";
            this.TxtFaturaTipi.Properties.ValueMember = "NUMARASI";
            this.TxtFaturaTipi.Size = new System.Drawing.Size(241, 20);
            this.TxtFaturaTipi.TabIndex = 39;
            // 
            // TxtStokKodu
            // 
            this.TxtStokKodu.Location = new System.Drawing.Point(129, 55);
            this.TxtStokKodu.Name = "TxtStokKodu";
            this.TxtStokKodu.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.TxtStokKodu.Properties.DisplayMember = "STOKKODU";
            this.TxtStokKodu.Properties.NullText = "Sabit Kıymet Kaydı Seçiniz";
            this.TxtStokKodu.Properties.ValueMember = "STOKKODU";
            this.TxtStokKodu.Size = new System.Drawing.Size(241, 20);
            this.TxtStokKodu.TabIndex = 23;
            // 
            // FrmSabitkiymetAlis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1386, 580);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.TxtFatura);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmSabitkiymetAlis";
            this.Text = "Sabit Kıymet Alış Listesi";
            this.Load += new System.EventHandler(this.FrmSabitkiymetAlis_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtCari.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtToplam.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtAdet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtFatura)).EndInit();
            this.TxtFatura.ResumeLayout(false);
            this.TxtFatura.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TxtSatisTutar.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtVkn.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtPersonel.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtMalzeme.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtTarih.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtTarih.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtVergiDairesi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtFaturaTipi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtStokKodu.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraEditors.LookUpEdit TxtCari;
        private DevExpress.XtraEditors.TextEdit TxtToplam;
        private DevExpress.XtraEditors.LabelControl labelControl12;
        private System.Windows.Forms.NumericUpDown TxtAdet;
        private DevExpress.XtraEditors.GroupControl TxtFatura;
        private DevExpress.XtraEditors.LabelControl labelControl11;
        private DevExpress.XtraEditors.LabelControl labelControl10;
        private DevExpress.XtraEditors.TextEdit TxtSatisTutar;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit TxtVkn;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LookUpEdit TxtPersonel;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.SimpleButton BtnListele;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.TextEdit txtID;
        private DevExpress.XtraEditors.SimpleButton BtnGuncelle;
        private DevExpress.XtraEditors.SimpleButton BtnSil;
        private DevExpress.XtraEditors.SimpleButton BtnKaydet;
        private DevExpress.XtraEditors.TextEdit TxtMalzeme;
        private DevExpress.XtraEditors.DateEdit TxtTarih;
        private DevExpress.XtraEditors.TextEdit TxtVergiDairesi;
        private DevExpress.XtraEditors.LookUpEdit TxtFaturaTipi;
        private DevExpress.XtraEditors.LookUpEdit TxtStokKodu;
    }
}