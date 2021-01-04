namespace TeknikServis.Formlar
{
    partial class FrmIrsaliye
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmIrsaliye));
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.TxtFatura = new DevExpress.XtraEditors.GroupControl();
            this.labelControl13 = new DevExpress.XtraEditors.LabelControl();
            this.TxtSevkSaat = new DevExpress.XtraEditors.TextEdit();
            this.labelControl11 = new DevExpress.XtraEditors.LabelControl();
            this.TxtSeriNo = new DevExpress.XtraEditors.TextEdit();
            this.labelControl10 = new DevExpress.XtraEditors.LabelControl();
            this.TxtIrsaliyeTarih = new DevExpress.XtraEditors.DateEdit();
            this.TxtToplam = new DevExpress.XtraEditors.TextEdit();
            this.labelControl12 = new DevExpress.XtraEditors.LabelControl();
            this.TxtAdet = new System.Windows.Forms.NumericUpDown();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.TxtMarka = new DevExpress.XtraEditors.TextEdit();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.TxtCari = new DevExpress.XtraEditors.LookUpEdit();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.TxtUrun = new DevExpress.XtraEditors.LookUpEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.BtnListele = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.txtID = new DevExpress.XtraEditors.TextEdit();
            this.BtnGuncelle = new DevExpress.XtraEditors.SimpleButton();
            this.BtnSil = new DevExpress.XtraEditors.SimpleButton();
            this.BtnKaydet = new DevExpress.XtraEditors.SimpleButton();
            this.TxtSaat = new DevExpress.XtraEditors.TextEdit();
            this.TxtTarih = new DevExpress.XtraEditors.DateEdit();
            this.TxtVergiDairesi = new DevExpress.XtraEditors.TextEdit();
            this.TxtSatisTutar = new DevExpress.XtraEditors.LookUpEdit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtFatura)).BeginInit();
            this.TxtFatura.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TxtSevkSaat.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtSeriNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtIrsaliyeTarih.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtIrsaliyeTarih.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtToplam.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtAdet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtMarka.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtCari.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtUrun.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtSaat.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtTarih.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtTarih.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtVergiDairesi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtSatisTutar.Properties)).BeginInit();
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
            this.gridControl1.TabIndex = 30;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // TxtFatura
            // 
            this.TxtFatura.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003;
            this.TxtFatura.Controls.Add(this.labelControl13);
            this.TxtFatura.Controls.Add(this.TxtSevkSaat);
            this.TxtFatura.Controls.Add(this.labelControl11);
            this.TxtFatura.Controls.Add(this.TxtSeriNo);
            this.TxtFatura.Controls.Add(this.labelControl10);
            this.TxtFatura.Controls.Add(this.TxtIrsaliyeTarih);
            this.TxtFatura.Controls.Add(this.TxtToplam);
            this.TxtFatura.Controls.Add(this.labelControl12);
            this.TxtFatura.Controls.Add(this.TxtAdet);
            this.TxtFatura.Controls.Add(this.labelControl9);
            this.TxtFatura.Controls.Add(this.labelControl2);
            this.TxtFatura.Controls.Add(this.labelControl1);
            this.TxtFatura.Controls.Add(this.TxtMarka);
            this.TxtFatura.Controls.Add(this.labelControl8);
            this.TxtFatura.Controls.Add(this.TxtCari);
            this.TxtFatura.Controls.Add(this.labelControl6);
            this.TxtFatura.Controls.Add(this.TxtUrun);
            this.TxtFatura.Controls.Add(this.labelControl4);
            this.TxtFatura.Controls.Add(this.labelControl5);
            this.TxtFatura.Controls.Add(this.labelControl3);
            this.TxtFatura.Controls.Add(this.BtnListele);
            this.TxtFatura.Controls.Add(this.labelControl7);
            this.TxtFatura.Controls.Add(this.txtID);
            this.TxtFatura.Controls.Add(this.BtnGuncelle);
            this.TxtFatura.Controls.Add(this.BtnSil);
            this.TxtFatura.Controls.Add(this.BtnKaydet);
            this.TxtFatura.Controls.Add(this.TxtSaat);
            this.TxtFatura.Controls.Add(this.TxtTarih);
            this.TxtFatura.Controls.Add(this.TxtVergiDairesi);
            this.TxtFatura.Controls.Add(this.TxtSatisTutar);
            this.TxtFatura.Location = new System.Drawing.Point(952, 2);
            this.TxtFatura.Name = "TxtFatura";
            this.TxtFatura.Size = new System.Drawing.Size(433, 576);
            this.TxtFatura.TabIndex = 31;
            this.TxtFatura.Text = "IRSALİYE İŞLEMLERİ";
            this.TxtFatura.Paint += new System.Windows.Forms.PaintEventHandler(this.TxtFatura_Paint);
            // 
            // labelControl13
            // 
            this.labelControl13.Location = new System.Drawing.Point(66, 295);
            this.labelControl13.Name = "labelControl13";
            this.labelControl13.Size = new System.Drawing.Size(57, 13);
            this.labelControl13.TabIndex = 52;
            this.labelControl13.Text = "SEVK SAAT:";
            // 
            // TxtSevkSaat
            // 
            this.TxtSevkSaat.Location = new System.Drawing.Point(129, 292);
            this.TxtSevkSaat.Name = "TxtSevkSaat";
            this.TxtSevkSaat.Properties.Mask.EditMask = "90:00";
            this.TxtSevkSaat.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Simple;
            this.TxtSevkSaat.Size = new System.Drawing.Size(241, 20);
            this.TxtSevkSaat.TabIndex = 51;
            // 
            // labelControl11
            // 
            this.labelControl11.Location = new System.Drawing.Point(40, 164);
            this.labelControl11.Name = "labelControl11";
            this.labelControl11.Size = new System.Drawing.Size(83, 13);
            this.labelControl11.TabIndex = 50;
            this.labelControl11.Text = "SERİ NUMARASI:";
            // 
            // TxtSeriNo
            // 
            this.TxtSeriNo.Location = new System.Drawing.Point(129, 161);
            this.TxtSeriNo.Name = "TxtSeriNo";
            this.TxtSeriNo.Size = new System.Drawing.Size(241, 20);
            this.TxtSeriNo.TabIndex = 49;
            // 
            // labelControl10
            // 
            this.labelControl10.Location = new System.Drawing.Point(40, 62);
            this.labelControl10.Name = "labelControl10";
            this.labelControl10.Size = new System.Drawing.Size(83, 13);
            this.labelControl10.TabIndex = 47;
            this.labelControl10.Text = "İRSALİYE TARİH:";
            // 
            // TxtIrsaliyeTarih
            // 
            this.TxtIrsaliyeTarih.EditValue = null;
            this.TxtIrsaliyeTarih.Location = new System.Drawing.Point(129, 59);
            this.TxtIrsaliyeTarih.Name = "TxtIrsaliyeTarih";
            this.TxtIrsaliyeTarih.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.TxtIrsaliyeTarih.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.TxtIrsaliyeTarih.Properties.DisplayFormat.FormatString = "";
            this.TxtIrsaliyeTarih.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.TxtIrsaliyeTarih.Properties.EditFormat.FormatString = "";
            this.TxtIrsaliyeTarih.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.TxtIrsaliyeTarih.Properties.NullText = "Tarih Seçiniz";
            this.TxtIrsaliyeTarih.Size = new System.Drawing.Size(241, 20);
            this.TxtIrsaliyeTarih.TabIndex = 48;
            // 
            // TxtToplam
            // 
            this.TxtToplam.Location = new System.Drawing.Point(129, 318);
            this.TxtToplam.Name = "TxtToplam";
            this.TxtToplam.Size = new System.Drawing.Size(241, 20);
            this.TxtToplam.TabIndex = 46;
            // 
            // labelControl12
            // 
            this.labelControl12.Location = new System.Drawing.Point(79, 321);
            this.labelControl12.Name = "labelControl12";
            this.labelControl12.Size = new System.Drawing.Size(44, 13);
            this.labelControl12.TabIndex = 45;
            this.labelControl12.Text = "TOPLAM:";
            // 
            // TxtAdet
            // 
            this.TxtAdet.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtAdet.Location = new System.Drawing.Point(129, 239);
            this.TxtAdet.Name = "TxtAdet";
            this.TxtAdet.Size = new System.Drawing.Size(81, 23);
            this.TxtAdet.TabIndex = 42;
            // 
            // labelControl9
            // 
            this.labelControl9.Location = new System.Drawing.Point(93, 88);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(30, 13);
            this.labelControl9.TabIndex = 37;
            this.labelControl9.Text = "SAAT:";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(93, 243);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(30, 13);
            this.labelControl2.TabIndex = 35;
            this.labelControl2.Text = "ADET:";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(84, 190);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(39, 13);
            this.labelControl1.TabIndex = 33;
            this.labelControl1.Text = "MARKA:";
            // 
            // TxtMarka
            // 
            this.TxtMarka.Location = new System.Drawing.Point(129, 187);
            this.TxtMarka.Name = "TxtMarka";
            this.TxtMarka.Size = new System.Drawing.Size(241, 20);
            this.TxtMarka.TabIndex = 34;
            // 
            // labelControl8
            // 
            this.labelControl8.Location = new System.Drawing.Point(94, 114);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(29, 13);
            this.labelControl8.TabIndex = 30;
            this.labelControl8.Text = "CARİ:";
            // 
            // TxtCari
            // 
            this.TxtCari.Location = new System.Drawing.Point(129, 111);
            this.TxtCari.Name = "TxtCari";
            this.TxtCari.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.TxtCari.Properties.DisplayMember = "CARİ";
            this.TxtCari.Properties.NullText = "Cari Seçiniz";
            this.TxtCari.Properties.ValueMember = "NUMARASI";
            this.TxtCari.Size = new System.Drawing.Size(241, 20);
            this.TxtCari.TabIndex = 31;
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(91, 140);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(32, 13);
            this.labelControl6.TabIndex = 28;
            this.labelControl6.Text = "ÜRUN:";
            // 
            // TxtUrun
            // 
            this.TxtUrun.Location = new System.Drawing.Point(129, 137);
            this.TxtUrun.Name = "TxtUrun";
            this.TxtUrun.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.TxtUrun.Properties.DisplayMember = "ÜRÜN";
            this.TxtUrun.Properties.NullText = "Ürün Seçiniz";
            this.TxtUrun.Properties.ValueMember = "NUMARASI";
            this.TxtUrun.Size = new System.Drawing.Size(241, 20);
            this.TxtUrun.TabIndex = 29;
            this.TxtUrun.EditValueChanged += new System.EventHandler(this.TxtUrun_EditValueChanged);
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(216, 243);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(33, 13);
            this.labelControl4.TabIndex = 26;
            this.labelControl4.Text = "FİYAT:";
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(45, 216);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(78, 13);
            this.labelControl5.TabIndex = 24;
            this.labelControl5.Text = "VERGİ DAİRESİ:";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(61, 269);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(62, 13);
            this.labelControl3.TabIndex = 20;
            this.labelControl3.Text = "SEVK TARİH:";
            // 
            // BtnListele
            // 
            this.BtnListele.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.BtnListele.Appearance.Options.UseBackColor = true;
            this.BtnListele.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnListele.ImageOptions.Image")));
            this.BtnListele.Location = new System.Drawing.Point(129, 484);
            this.BtnListele.Name = "BtnListele";
            this.BtnListele.Size = new System.Drawing.Size(241, 41);
            this.BtnListele.TabIndex = 19;
            this.BtnListele.Text = "TEMİZLE";
            this.BtnListele.Click += new System.EventHandler(this.BtnListele_Click);
            // 
            // labelControl7
            // 
            this.labelControl7.Location = new System.Drawing.Point(18, 36);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(105, 13);
            this.labelControl7.TabIndex = 17;
            this.labelControl7.Text = "IRSALİYE NUMARASI:";
            // 
            // txtID
            // 
            this.txtID.Enabled = false;
            this.txtID.Location = new System.Drawing.Point(129, 33);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(241, 20);
            this.txtID.TabIndex = 18;
            // 
            // BtnGuncelle
            // 
            this.BtnGuncelle.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.BtnGuncelle.Appearance.Options.UseBackColor = true;
            this.BtnGuncelle.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnGuncelle.ImageOptions.Image")));
            this.BtnGuncelle.Location = new System.Drawing.Point(129, 437);
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
            this.BtnSil.Location = new System.Drawing.Point(129, 390);
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
            this.BtnKaydet.Location = new System.Drawing.Point(129, 343);
            this.BtnKaydet.Name = "BtnKaydet";
            this.BtnKaydet.Size = new System.Drawing.Size(241, 41);
            this.BtnKaydet.TabIndex = 13;
            this.BtnKaydet.Text = "KAYDET";
            this.BtnKaydet.Click += new System.EventHandler(this.BtnKaydet_Click);
            // 
            // TxtSaat
            // 
            this.TxtSaat.Location = new System.Drawing.Point(129, 85);
            this.TxtSaat.Name = "TxtSaat";
            this.TxtSaat.Properties.Mask.EditMask = "90:00";
            this.TxtSaat.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Simple;
            this.TxtSaat.Size = new System.Drawing.Size(241, 20);
            this.TxtSaat.TabIndex = 2;
            // 
            // TxtTarih
            // 
            this.TxtTarih.EditValue = null;
            this.TxtTarih.Location = new System.Drawing.Point(129, 266);
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
            this.TxtVergiDairesi.Location = new System.Drawing.Point(129, 213);
            this.TxtVergiDairesi.Name = "TxtVergiDairesi";
            this.TxtVergiDairesi.Size = new System.Drawing.Size(241, 20);
            this.TxtVergiDairesi.TabIndex = 25;
            // 
            // TxtSatisTutar
            // 
            this.TxtSatisTutar.Location = new System.Drawing.Point(255, 240);
            this.TxtSatisTutar.Name = "TxtSatisTutar";
            this.TxtSatisTutar.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.TxtSatisTutar.Properties.DisplayMember = "FİYAT";
            this.TxtSatisTutar.Properties.NullText = "";
            this.TxtSatisTutar.Properties.ValueMember = "FİYAT";
            this.TxtSatisTutar.Size = new System.Drawing.Size(115, 20);
            this.TxtSatisTutar.TabIndex = 38;
            // 
            // FrmIrsaliye
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1386, 580);
            this.Controls.Add(this.TxtFatura);
            this.Controls.Add(this.gridControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmIrsaliye";
            this.Text = "FrmIrsalıye";
            this.Load += new System.EventHandler(this.FrmIrsalıye_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtFatura)).EndInit();
            this.TxtFatura.ResumeLayout(false);
            this.TxtFatura.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TxtSevkSaat.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtSeriNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtIrsaliyeTarih.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtIrsaliyeTarih.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtToplam.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtAdet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtMarka.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtCari.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtUrun.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtSaat.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtTarih.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtTarih.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtVergiDairesi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtSatisTutar.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraEditors.GroupControl TxtFatura;
        private DevExpress.XtraEditors.TextEdit TxtToplam;
        private DevExpress.XtraEditors.LabelControl labelControl12;
        private System.Windows.Forms.NumericUpDown TxtAdet;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit TxtMarka;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.LookUpEdit TxtCari;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LookUpEdit TxtUrun;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.SimpleButton BtnListele;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.TextEdit txtID;
        private DevExpress.XtraEditors.SimpleButton BtnGuncelle;
        private DevExpress.XtraEditors.SimpleButton BtnSil;
        private DevExpress.XtraEditors.SimpleButton BtnKaydet;
        private DevExpress.XtraEditors.TextEdit TxtSaat;
        private DevExpress.XtraEditors.DateEdit TxtTarih;
        private DevExpress.XtraEditors.TextEdit TxtVergiDairesi;
        private DevExpress.XtraEditors.LabelControl labelControl10;
        private DevExpress.XtraEditors.DateEdit TxtIrsaliyeTarih;
        private DevExpress.XtraEditors.LabelControl labelControl11;
        private DevExpress.XtraEditors.TextEdit TxtSeriNo;
        private DevExpress.XtraEditors.LabelControl labelControl13;
        private DevExpress.XtraEditors.TextEdit TxtSevkSaat;
        private DevExpress.XtraEditors.LookUpEdit TxtSatisTutar;
    }
}