namespace TeknikServis.Formlar
{
    partial class FrmArizaFaturaListesi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmArizaFaturaListesi));
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.TxtFaturaTipi = new DevExpress.XtraEditors.LookUpEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.lookUpEdit2 = new DevExpress.XtraEditors.LookUpEdit();
            this.lookUpEdit1 = new DevExpress.XtraEditors.LookUpEdit();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.TxTarih = new DevExpress.XtraEditors.DateEdit();
            this.TxtOnFiyat = new DevExpress.XtraEditors.TextEdit();
            this.TxtNetFiyat = new DevExpress.XtraEditors.TextEdit();
            this.TxtIslemNumarasi = new DevExpress.XtraEditors.LookUpEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.BtnListele = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.txtID = new DevExpress.XtraEditors.TextEdit();
            this.BtnGuncelle = new DevExpress.XtraEditors.SimpleButton();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.BtnSil = new DevExpress.XtraEditors.SimpleButton();
            this.BtnKaydet = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.TxtFatura = new DevExpress.XtraEditors.GroupControl();
            ((System.ComponentModel.ISupportInitialize)(this.TxtFaturaTipi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEdit2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxTarih.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxTarih.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtOnFiyat.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtNetFiyat.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtIslemNumarasi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtFatura)).BeginInit();
            this.TxtFatura.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelControl9
            // 
            this.labelControl9.Location = new System.Drawing.Point(81, 95);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(67, 13);
            this.labelControl9.TabIndex = 44;
            this.labelControl9.Text = "FATURA TİPİ:";
            // 
            // TxtFaturaTipi
            // 
            this.TxtFaturaTipi.Location = new System.Drawing.Point(154, 92);
            this.TxtFaturaTipi.Name = "TxtFaturaTipi";
            this.TxtFaturaTipi.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.TxtFaturaTipi.Properties.DisplayMember = "FATURATİPİ";
            this.TxtFaturaTipi.Properties.NullText = "Fatura Tipi Seçiniz";
            this.TxtFaturaTipi.Properties.ValueMember = "NUMARASI";
            this.TxtFaturaTipi.Size = new System.Drawing.Size(293, 20);
            this.TxtFaturaTipi.TabIndex = 45;
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(93, 173);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(55, 13);
            this.labelControl5.TabIndex = 43;
            this.labelControl5.Text = "PERSONEL:";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(119, 147);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(29, 13);
            this.labelControl2.TabIndex = 42;
            this.labelControl2.Text = "CARİ:";
            // 
            // lookUpEdit2
            // 
            this.lookUpEdit2.Location = new System.Drawing.Point(154, 170);
            this.lookUpEdit2.Name = "lookUpEdit2";
            this.lookUpEdit2.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookUpEdit2.Properties.DisplayMember = "PERSONEL";
            this.lookUpEdit2.Properties.NullText = "Personel Seçiniz";
            this.lookUpEdit2.Properties.ValueMember = "PERSONELNUMARASI";
            this.lookUpEdit2.Size = new System.Drawing.Size(293, 20);
            this.lookUpEdit2.TabIndex = 41;
            // 
            // lookUpEdit1
            // 
            this.lookUpEdit1.Location = new System.Drawing.Point(154, 144);
            this.lookUpEdit1.Name = "lookUpEdit1";
            this.lookUpEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookUpEdit1.Properties.DisplayMember = "MÜŞTERİ";
            this.lookUpEdit1.Properties.NullText = "Müşteri Seçiniz";
            this.lookUpEdit1.Properties.ValueMember = "MÜŞTERİNUMARASI";
            this.lookUpEdit1.Size = new System.Drawing.Size(293, 20);
            this.lookUpEdit1.TabIndex = 40;
            // 
            // labelControl8
            // 
            this.labelControl8.Location = new System.Drawing.Point(66, 251);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(82, 13);
            this.labelControl8.TabIndex = 39;
            this.labelControl8.Text = "FATURA TARİHİ:";
            // 
            // TxTarih
            // 
            this.TxTarih.EditValue = null;
            this.TxTarih.Location = new System.Drawing.Point(154, 248);
            this.TxTarih.Name = "TxTarih";
            this.TxTarih.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.TxTarih.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.TxTarih.Properties.NullText = "Tarih Seçiniz";
            this.TxTarih.Size = new System.Drawing.Size(293, 20);
            this.TxTarih.TabIndex = 38;
            // 
            // TxtOnFiyat
            // 
            this.TxtOnFiyat.Location = new System.Drawing.Point(154, 196);
            this.TxtOnFiyat.Name = "TxtOnFiyat";
            this.TxtOnFiyat.Size = new System.Drawing.Size(293, 20);
            this.TxtOnFiyat.TabIndex = 35;
            // 
            // TxtNetFiyat
            // 
            this.TxtNetFiyat.Location = new System.Drawing.Point(154, 222);
            this.TxtNetFiyat.Name = "TxtNetFiyat";
            this.TxtNetFiyat.Size = new System.Drawing.Size(293, 20);
            this.TxtNetFiyat.TabIndex = 32;
            // 
            // TxtIslemNumarasi
            // 
            this.TxtIslemNumarasi.Location = new System.Drawing.Point(154, 118);
            this.TxtIslemNumarasi.Name = "TxtIslemNumarasi";
            this.TxtIslemNumarasi.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.TxtIslemNumarasi.Properties.DisplayMember = "İŞLEMNUMARASI";
            this.TxtIslemNumarasi.Properties.NullText = "İşlem Seçiniz";
            this.TxtIslemNumarasi.Properties.ValueMember = "İŞLEMNUMARASI";
            this.TxtIslemNumarasi.Size = new System.Drawing.Size(293, 20);
            this.TxtIslemNumarasi.TabIndex = 31;
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(93, 225);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(55, 13);
            this.labelControl4.TabIndex = 26;
            this.labelControl4.Text = "NET FİYAT:";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(97, 199);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(51, 13);
            this.labelControl3.TabIndex = 20;
            this.labelControl3.Text = "ÖN FİYAT:";
            // 
            // BtnListele
            // 
            this.BtnListele.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.BtnListele.Appearance.Options.UseBackColor = true;
            this.BtnListele.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnListele.ImageOptions.Image")));
            this.BtnListele.Location = new System.Drawing.Point(154, 425);
            this.BtnListele.Name = "BtnListele";
            this.BtnListele.Size = new System.Drawing.Size(293, 41);
            this.BtnListele.TabIndex = 19;
            this.BtnListele.Text = "TEMİZLE";
            this.BtnListele.Click += new System.EventHandler(this.BtnListele_Click);
            // 
            // labelControl7
            // 
            this.labelControl7.Location = new System.Drawing.Point(5, 69);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(143, 13);
            this.labelControl7.TabIndex = 17;
            this.labelControl7.Text = "ARIZALI FATURA NUMARASI:";
            // 
            // txtID
            // 
            this.txtID.Enabled = false;
            this.txtID.Location = new System.Drawing.Point(154, 66);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(293, 20);
            this.txtID.TabIndex = 18;
            // 
            // BtnGuncelle
            // 
            this.BtnGuncelle.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.BtnGuncelle.Appearance.Options.UseBackColor = true;
            this.BtnGuncelle.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnGuncelle.ImageOptions.Image")));
            this.BtnGuncelle.Location = new System.Drawing.Point(154, 378);
            this.BtnGuncelle.Name = "BtnGuncelle";
            this.BtnGuncelle.Size = new System.Drawing.Size(293, 41);
            this.BtnGuncelle.TabIndex = 15;
            this.BtnGuncelle.Text = "GÜNCELLE";
            this.BtnGuncelle.Click += new System.EventHandler(this.BtnGuncelle_Click);
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
            this.gridControl1.Location = new System.Drawing.Point(-18, 3);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(922, 575);
            this.gridControl1.TabIndex = 30;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // BtnSil
            // 
            this.BtnSil.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.BtnSil.Appearance.Options.UseBackColor = true;
            this.BtnSil.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnSil.ImageOptions.Image")));
            this.BtnSil.Location = new System.Drawing.Point(154, 332);
            this.BtnSil.Name = "BtnSil";
            this.BtnSil.Size = new System.Drawing.Size(293, 40);
            this.BtnSil.TabIndex = 14;
            this.BtnSil.Text = "SİL";
            this.BtnSil.Click += new System.EventHandler(this.BtnSil_Click);
            // 
            // BtnKaydet
            // 
            this.BtnKaydet.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.BtnKaydet.Appearance.Options.UseBackColor = true;
            this.BtnKaydet.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnKaydet.ImageOptions.Image")));
            this.BtnKaydet.Location = new System.Drawing.Point(154, 285);
            this.BtnKaydet.Name = "BtnKaydet";
            this.BtnKaydet.Size = new System.Drawing.Size(293, 41);
            this.BtnKaydet.TabIndex = 13;
            this.BtnKaydet.Text = "KAYDET";
            this.BtnKaydet.Click += new System.EventHandler(this.BtnKaydet_Click);
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(59, 121);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(89, 13);
            this.labelControl1.TabIndex = 1;
            this.labelControl1.Text = "İŞLEM NUMARASI:";
            // 
            // TxtFatura
            // 
            this.TxtFatura.Controls.Add(this.labelControl9);
            this.TxtFatura.Controls.Add(this.TxtFaturaTipi);
            this.TxtFatura.Controls.Add(this.labelControl5);
            this.TxtFatura.Controls.Add(this.labelControl2);
            this.TxtFatura.Controls.Add(this.lookUpEdit2);
            this.TxtFatura.Controls.Add(this.lookUpEdit1);
            this.TxtFatura.Controls.Add(this.labelControl8);
            this.TxtFatura.Controls.Add(this.TxTarih);
            this.TxtFatura.Controls.Add(this.TxtOnFiyat);
            this.TxtFatura.Controls.Add(this.TxtNetFiyat);
            this.TxtFatura.Controls.Add(this.TxtIslemNumarasi);
            this.TxtFatura.Controls.Add(this.labelControl4);
            this.TxtFatura.Controls.Add(this.labelControl3);
            this.TxtFatura.Controls.Add(this.BtnListele);
            this.TxtFatura.Controls.Add(this.labelControl7);
            this.TxtFatura.Controls.Add(this.txtID);
            this.TxtFatura.Controls.Add(this.BtnGuncelle);
            this.TxtFatura.Controls.Add(this.BtnSil);
            this.TxtFatura.Controls.Add(this.BtnKaydet);
            this.TxtFatura.Controls.Add(this.labelControl1);
            this.TxtFatura.Location = new System.Drawing.Point(910, 3);
            this.TxtFatura.Name = "TxtFatura";
            this.TxtFatura.Size = new System.Drawing.Size(494, 575);
            this.TxtFatura.TabIndex = 31;
            this.TxtFatura.Text = "Arızalı Ürün Fatura Listesi";
            // 
            // FrmArizaFaturaListesi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1386, 580);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.TxtFatura);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmArizaFaturaListesi";
            this.Text = "Arızalı Fatura Listesi";
            this.Load += new System.EventHandler(this.FrmArizaFaturaListesi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TxtFaturaTipi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEdit2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxTarih.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxTarih.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtOnFiyat.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtNetFiyat.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtIslemNumarasi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtFatura)).EndInit();
            this.TxtFatura.ResumeLayout(false);
            this.TxtFatura.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl9;
        private DevExpress.XtraEditors.LookUpEdit TxtFaturaTipi;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LookUpEdit lookUpEdit2;
        private DevExpress.XtraEditors.LookUpEdit lookUpEdit1;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.DateEdit TxTarih;
        private DevExpress.XtraEditors.TextEdit TxtOnFiyat;
        private DevExpress.XtraEditors.TextEdit TxtNetFiyat;
        private DevExpress.XtraEditors.LookUpEdit TxtIslemNumarasi;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.SimpleButton BtnListele;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.TextEdit txtID;
        private DevExpress.XtraEditors.SimpleButton BtnGuncelle;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraEditors.SimpleButton BtnSil;
        private DevExpress.XtraEditors.SimpleButton BtnKaydet;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.GroupControl TxtFatura;
    }
}