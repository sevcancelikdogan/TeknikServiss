namespace TeknikServis.Formlar
{
    partial class FrmArizaDetayi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmArizaDetayi));
            this.pictureEdit14 = new DevExpress.XtraEditors.PictureEdit();
            this.BtnGüncelle = new DevExpress.XtraEditors.SimpleButton();
            this.TxtDetay = new System.Windows.Forms.RichTextBox();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.TxtSeriNo = new DevExpress.XtraEditors.LookUpEdit();
            this.TxtTarih = new DevExpress.XtraEditors.DateEdit();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.TxtUrunDurumu = new System.Windows.Forms.ComboBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.BtnVazgeç = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit14.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtSeriNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtTarih.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtTarih.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureEdit14
            // 
            this.pictureEdit14.EditValue = ((object)(resources.GetObject("pictureEdit14.EditValue")));
            this.pictureEdit14.Location = new System.Drawing.Point(452, -2);
            this.pictureEdit14.Name = "pictureEdit14";
            this.pictureEdit14.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.pictureEdit14.Properties.Appearance.BorderColor = System.Drawing.Color.Transparent;
            this.pictureEdit14.Properties.Appearance.Options.UseBackColor = true;
            this.pictureEdit14.Properties.Appearance.Options.UseBorderColor = true;
            this.pictureEdit14.Properties.AppearanceDisabled.BorderColor = System.Drawing.Color.Transparent;
            this.pictureEdit14.Properties.AppearanceDisabled.Options.UseBorderColor = true;
            this.pictureEdit14.Properties.AppearanceFocused.BorderColor = System.Drawing.Color.Transparent;
            this.pictureEdit14.Properties.AppearanceFocused.Options.UseBorderColor = true;
            this.pictureEdit14.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.Transparent;
            this.pictureEdit14.Properties.AppearanceReadOnly.BorderColor = System.Drawing.Color.Transparent;
            this.pictureEdit14.Properties.AppearanceReadOnly.Options.UseBackColor = true;
            this.pictureEdit14.Properties.AppearanceReadOnly.Options.UseBorderColor = true;
            this.pictureEdit14.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pictureEdit14.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pictureEdit14.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Squeeze;
            this.pictureEdit14.Size = new System.Drawing.Size(25, 26);
            this.pictureEdit14.TabIndex = 101;
            this.pictureEdit14.Click += new System.EventHandler(this.pictureEdit14_Click);
            // 
            // BtnGüncelle
            // 
            this.BtnGüncelle.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.BtnGüncelle.Appearance.Options.UseBackColor = true;
            this.BtnGüncelle.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnGüncelle.ImageOptions.Image")));
            this.BtnGüncelle.Location = new System.Drawing.Point(68, 398);
            this.BtnGüncelle.Name = "BtnGüncelle";
            this.BtnGüncelle.Size = new System.Drawing.Size(158, 36);
            this.BtnGüncelle.TabIndex = 96;
            this.BtnGüncelle.Text = "Güncelle";
            this.BtnGüncelle.Click += new System.EventHandler(this.BtnGüncelle_Click);
            // 
            // TxtDetay
            // 
            this.TxtDetay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.TxtDetay.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtDetay.ForeColor = System.Drawing.Color.White;
            this.TxtDetay.Location = new System.Drawing.Point(20, 211);
            this.TxtDetay.Name = "TxtDetay";
            this.TxtDetay.Size = new System.Drawing.Size(434, 169);
            this.TxtDetay.TabIndex = 95;
            this.TxtDetay.Text = "Arıza Detayı";
            this.TxtDetay.Click += new System.EventHandler(this.TxtDetay_Click);
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl1.Appearance.ForeColor = System.Drawing.Color.Transparent;
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Appearance.Options.UseForeColor = true;
            this.labelControl1.Location = new System.Drawing.Point(20, 29);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(273, 19);
            this.labelControl1.TabIndex = 93;
            this.labelControl1.Text = "ARIZALI ÜRÜN KAYDI AÇIKLAMA";
            // 
            // TxtSeriNo
            // 
            this.TxtSeriNo.Location = new System.Drawing.Point(20, 73);
            this.TxtSeriNo.Name = "TxtSeriNo";
            this.TxtSeriNo.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.TxtSeriNo.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtSeriNo.Properties.Appearance.ForeColor = System.Drawing.Color.White;
            this.TxtSeriNo.Properties.Appearance.Options.UseBackColor = true;
            this.TxtSeriNo.Properties.Appearance.Options.UseFont = true;
            this.TxtSeriNo.Properties.Appearance.Options.UseForeColor = true;
            this.TxtSeriNo.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.TxtSeriNo.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.TxtSeriNo.Properties.DisplayMember = "URUNSERINO";
            this.TxtSeriNo.Properties.NullText = "Urun Seri Numarası";
            this.TxtSeriNo.Properties.PopupSizeable = false;
            this.TxtSeriNo.Properties.ValueMember = "ISLEMID";
            this.TxtSeriNo.Size = new System.Drawing.Size(226, 24);
            this.TxtSeriNo.TabIndex = 97;
            this.TxtSeriNo.Click += new System.EventHandler(this.TxtSeriNo_Click);
            // 
            // TxtTarih
            // 
            this.TxtTarih.EditValue = null;
            this.TxtTarih.Location = new System.Drawing.Point(20, 117);
            this.TxtTarih.Name = "TxtTarih";
            this.TxtTarih.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.TxtTarih.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtTarih.Properties.Appearance.ForeColor = System.Drawing.Color.White;
            this.TxtTarih.Properties.Appearance.Options.UseBackColor = true;
            this.TxtTarih.Properties.Appearance.Options.UseFont = true;
            this.TxtTarih.Properties.Appearance.Options.UseForeColor = true;
            this.TxtTarih.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.TxtTarih.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.TxtTarih.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.TxtTarih.Properties.NullText = "Tarih";
            this.TxtTarih.Size = new System.Drawing.Size(226, 24);
            this.TxtTarih.TabIndex = 102;
            this.TxtTarih.Click += new System.EventHandler(this.TxtTarih_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Location = new System.Drawing.Point(20, 98);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(226, 3);
            this.panel1.TabIndex = 103;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Location = new System.Drawing.Point(20, 140);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(225, 3);
            this.panel2.TabIndex = 104;
            // 
            // TxtUrunDurumu
            // 
            this.TxtUrunDurumu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.TxtUrunDurumu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtUrunDurumu.ForeColor = System.Drawing.Color.White;
            this.TxtUrunDurumu.FormattingEnabled = true;
            this.TxtUrunDurumu.Items.AddRange(new object[] {
            "Ürün Kayıt Edildi",
            "Parça Bekliyor",
            "Mesaj Bekliyor",
            "İptal Edildi",
            "Fiyat Verildi",
            "Tadilatı Bitti",
            "Kargoya Verildi",
            "Tamirde"});
            this.TxtUrunDurumu.Location = new System.Drawing.Point(20, 163);
            this.TxtUrunDurumu.Name = "TxtUrunDurumu";
            this.TxtUrunDurumu.Size = new System.Drawing.Size(225, 28);
            this.TxtUrunDurumu.TabIndex = 105;
            this.TxtUrunDurumu.Text = "Ürün Durumu";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Location = new System.Drawing.Point(20, 190);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(226, 3);
            this.panel3.TabIndex = 106;
            // 
            // BtnVazgeç
            // 
            this.BtnVazgeç.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.BtnVazgeç.Appearance.Options.UseBackColor = true;
            this.BtnVazgeç.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnVazgeç.ImageOptions.Image")));
            this.BtnVazgeç.Location = new System.Drawing.Point(232, 398);
            this.BtnVazgeç.Name = "BtnVazgeç";
            this.BtnVazgeç.Size = new System.Drawing.Size(158, 36);
            this.BtnVazgeç.TabIndex = 107;
            this.BtnVazgeç.Text = "Vazgeç";
            this.BtnVazgeç.Click += new System.EventHandler(this.BtnVazgeç_Click);
            // 
            // FrmArizaDetayi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.ClientSize = new System.Drawing.Size(473, 492);
            this.Controls.Add(this.BtnVazgeç);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.TxtUrunDurumu);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.TxtTarih);
            this.Controls.Add(this.pictureEdit14);
            this.Controls.Add(this.BtnGüncelle);
            this.Controls.Add(this.TxtDetay);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.TxtSeriNo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmArizaDetayi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Arıza Detayı";
            this.Load += new System.EventHandler(this.FrmArizaDetayi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit14.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtSeriNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtTarih.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtTarih.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.PictureEdit pictureEdit14;
        private DevExpress.XtraEditors.SimpleButton BtnGüncelle;
        private System.Windows.Forms.RichTextBox TxtDetay;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LookUpEdit TxtSeriNo;
        private DevExpress.XtraEditors.DateEdit TxtTarih;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox TxtUrunDurumu;
        private System.Windows.Forms.Panel panel3;
        private DevExpress.XtraEditors.SimpleButton BtnVazgeç;
    }
}