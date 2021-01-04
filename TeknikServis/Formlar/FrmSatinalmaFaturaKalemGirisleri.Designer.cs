namespace TeknikServis.Formlar
{
    partial class FrmSatinalmaFaturaKalemGirisleri
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSatinalmaFaturaKalemGirisleri));
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.TxtFatura = new DevExpress.XtraEditors.GroupControl();
            this.TxtMarka = new DevExpress.XtraEditors.TextEdit();
            this.TxtAdet = new System.Windows.Forms.NumericUpDown();
            this.TxtTutar = new DevExpress.XtraEditors.TextEdit();
            this.TxtUrun = new DevExpress.XtraEditors.LookUpEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.BtnListele = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.txtID = new DevExpress.XtraEditors.TextEdit();
            this.BtnGuncelle = new DevExpress.XtraEditors.SimpleButton();
            this.BtnSil = new DevExpress.XtraEditors.SimpleButton();
            this.BtnKaydet = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.TxtFiyat = new DevExpress.XtraEditors.LookUpEdit();
            this.TxtFaturaNumarasi = new DevExpress.XtraEditors.LookUpEdit();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            ((System.ComponentModel.ISupportInitialize)(this.TxtFatura)).BeginInit();
            this.TxtFatura.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TxtMarka.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtAdet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtTutar.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtUrun.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtFiyat.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtFaturaNumarasi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(78, 123);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(38, 13);
            this.labelControl6.TabIndex = 34;
            this.labelControl6.Text = "MODEL:";
            // 
            // TxtFatura
            // 
            this.TxtFatura.Controls.Add(this.TxtMarka);
            this.TxtFatura.Controls.Add(this.labelControl6);
            this.TxtFatura.Controls.Add(this.TxtAdet);
            this.TxtFatura.Controls.Add(this.TxtTutar);
            this.TxtFatura.Controls.Add(this.TxtUrun);
            this.TxtFatura.Controls.Add(this.labelControl4);
            this.TxtFatura.Controls.Add(this.labelControl5);
            this.TxtFatura.Controls.Add(this.labelControl2);
            this.TxtFatura.Controls.Add(this.labelControl3);
            this.TxtFatura.Controls.Add(this.BtnListele);
            this.TxtFatura.Controls.Add(this.labelControl7);
            this.TxtFatura.Controls.Add(this.txtID);
            this.TxtFatura.Controls.Add(this.BtnGuncelle);
            this.TxtFatura.Controls.Add(this.BtnSil);
            this.TxtFatura.Controls.Add(this.BtnKaydet);
            this.TxtFatura.Controls.Add(this.labelControl1);
            this.TxtFatura.Controls.Add(this.TxtFiyat);
            this.TxtFatura.Controls.Add(this.TxtFaturaNumarasi);
            this.TxtFatura.Location = new System.Drawing.Point(952, 3);
            this.TxtFatura.Name = "TxtFatura";
            this.TxtFatura.Size = new System.Drawing.Size(433, 575);
            this.TxtFatura.TabIndex = 29;
            this.TxtFatura.Text = "FATURA KALEM İŞLEMLERİ";
            // 
            // TxtMarka
            // 
            this.TxtMarka.Location = new System.Drawing.Point(129, 120);
            this.TxtMarka.Name = "TxtMarka";
            this.TxtMarka.Size = new System.Drawing.Size(241, 20);
            this.TxtMarka.TabIndex = 35;
            // 
            // TxtAdet
            // 
            this.TxtAdet.Location = new System.Drawing.Point(129, 147);
            this.TxtAdet.Name = "TxtAdet";
            this.TxtAdet.Size = new System.Drawing.Size(241, 21);
            this.TxtAdet.TabIndex = 33;
            // 
            // TxtTutar
            // 
            this.TxtTutar.Location = new System.Drawing.Point(129, 200);
            this.TxtTutar.Name = "TxtTutar";
            this.TxtTutar.Size = new System.Drawing.Size(241, 20);
            this.TxtTutar.TabIndex = 32;
            // 
            // TxtUrun
            // 
            this.TxtUrun.Location = new System.Drawing.Point(129, 94);
            this.TxtUrun.Name = "TxtUrun";
            this.TxtUrun.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.TxtUrun.Properties.DisplayMember = "ÜRÜN";
            this.TxtUrun.Properties.NullText = "Ürün Seçiniz";
            this.TxtUrun.Properties.ValueMember = "NUMARA";
            this.TxtUrun.Size = new System.Drawing.Size(241, 20);
            this.TxtUrun.TabIndex = 31;
            this.TxtUrun.EditValueChanged += new System.EventHandler(this.TxtUrun_EditValueChanged);
            this.TxtUrun.Click += new System.EventHandler(this.TxtUrun_Click);
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(78, 203);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(37, 13);
            this.labelControl4.TabIndex = 26;
            this.labelControl4.Text = "TUTAR:";
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(15, 229);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(100, 13);
            this.labelControl5.TabIndex = 24;
            this.labelControl5.Text = "FATURA NUMARASI:";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(85, 151);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(30, 13);
            this.labelControl2.TabIndex = 22;
            this.labelControl2.Text = "ADET:";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(82, 177);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(33, 13);
            this.labelControl3.TabIndex = 20;
            this.labelControl3.Text = "FİYAT:";
            // 
            // BtnListele
            // 
            this.BtnListele.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.BtnListele.Appearance.Options.UseBackColor = true;
            this.BtnListele.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnListele.ImageOptions.Image")));
            this.BtnListele.Location = new System.Drawing.Point(129, 395);
            this.BtnListele.Name = "BtnListele";
            this.BtnListele.Size = new System.Drawing.Size(241, 41);
            this.BtnListele.TabIndex = 19;
            this.BtnListele.Text = "TEMİZLE";
            this.BtnListele.Click += new System.EventHandler(this.BtnListele_Click);
            // 
            // labelControl7
            // 
            this.labelControl7.Location = new System.Drawing.Point(23, 71);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(92, 13);
            this.labelControl7.TabIndex = 17;
            this.labelControl7.Text = "DETAY NUMARASI:";
            // 
            // txtID
            // 
            this.txtID.Enabled = false;
            this.txtID.Location = new System.Drawing.Point(129, 68);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(241, 20);
            this.txtID.TabIndex = 18;
            // 
            // BtnGuncelle
            // 
            this.BtnGuncelle.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.BtnGuncelle.Appearance.Options.UseBackColor = true;
            this.BtnGuncelle.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnGuncelle.ImageOptions.Image")));
            this.BtnGuncelle.Location = new System.Drawing.Point(129, 347);
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
            this.BtnSil.Location = new System.Drawing.Point(129, 300);
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
            this.BtnKaydet.Location = new System.Drawing.Point(129, 252);
            this.BtnKaydet.Name = "BtnKaydet";
            this.BtnKaydet.Size = new System.Drawing.Size(241, 41);
            this.BtnKaydet.TabIndex = 13;
            this.BtnKaydet.Text = "KAYDET";
            this.BtnKaydet.Click += new System.EventHandler(this.BtnKaydet_Click);
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(83, 97);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(32, 13);
            this.labelControl1.TabIndex = 1;
            this.labelControl1.Text = "ÜRÜN:";
            // 
            // TxtFiyat
            // 
            this.TxtFiyat.Location = new System.Drawing.Point(129, 174);
            this.TxtFiyat.Name = "TxtFiyat";
            this.TxtFiyat.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.TxtFiyat.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.TxtFiyat.Properties.DisplayMember = "FİYAT";
            this.TxtFiyat.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.TxtFiyat.Properties.NullText = "Fiyat Seçiniz";
            this.TxtFiyat.Properties.ValueMember = "FİYAT";
            this.TxtFiyat.Size = new System.Drawing.Size(241, 20);
            this.TxtFiyat.TabIndex = 21;
            // 
            // TxtFaturaNumarasi
            // 
            this.TxtFaturaNumarasi.Location = new System.Drawing.Point(129, 226);
            this.TxtFaturaNumarasi.Name = "TxtFaturaNumarasi";
            this.TxtFaturaNumarasi.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.TxtFaturaNumarasi.Properties.DisplayMember = "NUMARASI";
            this.TxtFaturaNumarasi.Properties.NullText = "Fatura Seçiniz";
            this.TxtFaturaNumarasi.Properties.ValueMember = "NUMARASI";
            this.TxtFaturaNumarasi.Size = new System.Drawing.Size(241, 20);
            this.TxtFaturaNumarasi.TabIndex = 23;
            // 
            // gridControl1
            // 
            this.gridControl1.Location = new System.Drawing.Point(1, 3);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(945, 575);
            this.gridControl1.TabIndex = 28;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
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
            // FrmSatinalmaFaturaKalemGirisleri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1386, 580);
            this.Controls.Add(this.TxtFatura);
            this.Controls.Add(this.gridControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmSatinalmaFaturaKalemGirisleri";
            this.Text = "Satınalma Kalem Girişi";
            this.Load += new System.EventHandler(this.FrmSatinalmaFaturaKalemGirisleri_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TxtFatura)).EndInit();
            this.TxtFatura.ResumeLayout(false);
            this.TxtFatura.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TxtMarka.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtAdet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtTutar.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtUrun.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtFiyat.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtFaturaNumarasi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.GroupControl TxtFatura;
        private DevExpress.XtraEditors.TextEdit TxtMarka;
        private System.Windows.Forms.NumericUpDown TxtAdet;
        private DevExpress.XtraEditors.TextEdit TxtTutar;
        private DevExpress.XtraEditors.LookUpEdit TxtUrun;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.SimpleButton BtnListele;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.TextEdit txtID;
        private DevExpress.XtraEditors.SimpleButton BtnGuncelle;
        private DevExpress.XtraEditors.SimpleButton BtnSil;
        private DevExpress.XtraEditors.SimpleButton BtnKaydet;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LookUpEdit TxtFiyat;
        private DevExpress.XtraEditors.LookUpEdit TxtFaturaNumarasi;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
    }
}