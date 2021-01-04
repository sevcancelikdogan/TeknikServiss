namespace TeknikServis.Formlar
{
    partial class FrmArizaliFaturaGirişi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmArizaliFaturaGirişi));
            this.TxTarih = new DevExpress.XtraEditors.DateEdit();
            this.TxtOnFiyat = new DevExpress.XtraEditors.TextEdit();
            this.TxtNetFiyat = new DevExpress.XtraEditors.TextEdit();
            this.TxtIslemNumarasi = new DevExpress.XtraEditors.LookUpEdit();
            this.BtnSil = new DevExpress.XtraEditors.SimpleButton();
            this.BtnKaydet = new DevExpress.XtraEditors.SimpleButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.pictureEdit14 = new DevExpress.XtraEditors.PictureEdit();
            this.textEdit7 = new DevExpress.XtraEditors.TextEdit();
            this.pictureEdit6 = new DevExpress.XtraEditors.PictureEdit();
            this.pictureEdit8 = new DevExpress.XtraEditors.PictureEdit();
            this.pictureEdit7 = new DevExpress.XtraEditors.PictureEdit();
            this.pictureEdit5 = new DevExpress.XtraEditors.PictureEdit();
            this.pictureEdit1 = new DevExpress.XtraEditors.PictureEdit();
            this.TxtFaturaTipi = new DevExpress.XtraEditors.LookUpEdit();
            this.panel8 = new System.Windows.Forms.Panel();
            this.pictureEdit3 = new DevExpress.XtraEditors.PictureEdit();
            this.lookUpEdit2 = new DevExpress.XtraEditors.LookUpEdit();
            this.lookUpEdit1 = new DevExpress.XtraEditors.LookUpEdit();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.pictureEdit9 = new DevExpress.XtraEditors.PictureEdit();
            this.pictureEdit2 = new DevExpress.XtraEditors.PictureEdit();
            ((System.ComponentModel.ISupportInitialize)(this.TxTarih.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxTarih.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtOnFiyat.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtNetFiyat.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtIslemNumarasi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit14.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit7.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit6.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit8.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit7.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit5.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtFaturaTipi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit3.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEdit2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit9.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit2.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // TxTarih
            // 
            this.TxTarih.EditValue = null;
            this.TxTarih.Location = new System.Drawing.Point(62, 333);
            this.TxTarih.Name = "TxTarih";
            this.TxTarih.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.TxTarih.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxTarih.Properties.Appearance.ForeColor = System.Drawing.Color.White;
            this.TxTarih.Properties.Appearance.Options.UseBackColor = true;
            this.TxTarih.Properties.Appearance.Options.UseFont = true;
            this.TxTarih.Properties.Appearance.Options.UseForeColor = true;
            this.TxTarih.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.TxTarih.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.TxTarih.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.TxTarih.Properties.NullText = "Fatura Tarihi";
            this.TxTarih.Size = new System.Drawing.Size(293, 24);
            this.TxTarih.TabIndex = 58;
            this.TxTarih.Click += new System.EventHandler(this.TxTarih_Click);
            // 
            // TxtOnFiyat
            // 
            this.TxtOnFiyat.EditValue = "Ön Fiyat";
            this.TxtOnFiyat.Location = new System.Drawing.Point(62, 242);
            this.TxtOnFiyat.Name = "TxtOnFiyat";
            this.TxtOnFiyat.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.TxtOnFiyat.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtOnFiyat.Properties.Appearance.ForeColor = System.Drawing.Color.White;
            this.TxtOnFiyat.Properties.Appearance.Options.UseBackColor = true;
            this.TxtOnFiyat.Properties.Appearance.Options.UseFont = true;
            this.TxtOnFiyat.Properties.Appearance.Options.UseForeColor = true;
            this.TxtOnFiyat.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.TxtOnFiyat.Size = new System.Drawing.Size(293, 24);
            this.TxtOnFiyat.TabIndex = 55;
            this.TxtOnFiyat.Click += new System.EventHandler(this.TxtOnFiyat_Click);
            // 
            // TxtNetFiyat
            // 
            this.TxtNetFiyat.EditValue = "Net Fiyat";
            this.TxtNetFiyat.Location = new System.Drawing.Point(62, 292);
            this.TxtNetFiyat.Name = "TxtNetFiyat";
            this.TxtNetFiyat.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.TxtNetFiyat.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtNetFiyat.Properties.Appearance.ForeColor = System.Drawing.Color.White;
            this.TxtNetFiyat.Properties.Appearance.Options.UseBackColor = true;
            this.TxtNetFiyat.Properties.Appearance.Options.UseFont = true;
            this.TxtNetFiyat.Properties.Appearance.Options.UseForeColor = true;
            this.TxtNetFiyat.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.TxtNetFiyat.Size = new System.Drawing.Size(293, 24);
            this.TxtNetFiyat.TabIndex = 52;
            this.TxtNetFiyat.Click += new System.EventHandler(this.TxtNetFiyat_Click);
            // 
            // TxtIslemNumarasi
            // 
            this.TxtIslemNumarasi.Location = new System.Drawing.Point(62, 72);
            this.TxtIslemNumarasi.Name = "TxtIslemNumarasi";
            this.TxtIslemNumarasi.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.TxtIslemNumarasi.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtIslemNumarasi.Properties.Appearance.ForeColor = System.Drawing.Color.White;
            this.TxtIslemNumarasi.Properties.Appearance.Options.UseBackColor = true;
            this.TxtIslemNumarasi.Properties.Appearance.Options.UseFont = true;
            this.TxtIslemNumarasi.Properties.Appearance.Options.UseForeColor = true;
            this.TxtIslemNumarasi.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.TxtIslemNumarasi.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.TxtIslemNumarasi.Properties.DisplayMember = "ISLEMID";
            this.TxtIslemNumarasi.Properties.NullText = "İşlem Numarası";
            this.TxtIslemNumarasi.Properties.ValueMember = "ISLEMID";
            this.TxtIslemNumarasi.Size = new System.Drawing.Size(293, 24);
            this.TxtIslemNumarasi.TabIndex = 51;
            this.TxtIslemNumarasi.Click += new System.EventHandler(this.TxtIslemNumarasi_Click);
            // 
            // BtnSil
            // 
            this.BtnSil.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.BtnSil.Appearance.Options.UseBackColor = true;
            this.BtnSil.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnSil.ImageOptions.Image")));
            this.BtnSil.Location = new System.Drawing.Point(216, 389);
            this.BtnSil.Name = "BtnSil";
            this.BtnSil.Size = new System.Drawing.Size(139, 30);
            this.BtnSil.TabIndex = 42;
            this.BtnSil.Text = "VAZGEÇ";
            this.BtnSil.Click += new System.EventHandler(this.BtnSil_Click);
            // 
            // BtnKaydet
            // 
            this.BtnKaydet.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.BtnKaydet.Appearance.Options.UseBackColor = true;
            this.BtnKaydet.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnKaydet.ImageOptions.Image")));
            this.BtnKaydet.Location = new System.Drawing.Point(62, 389);
            this.BtnKaydet.Name = "BtnKaydet";
            this.BtnKaydet.Size = new System.Drawing.Size(139, 30);
            this.BtnKaydet.TabIndex = 41;
            this.BtnKaydet.Text = "KAYDET";
            this.BtnKaydet.Click += new System.EventHandler(this.BtnKaydet_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Location = new System.Drawing.Point(62, 363);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(293, 3);
            this.panel1.TabIndex = 73;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Location = new System.Drawing.Point(62, 322);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(293, 3);
            this.panel3.TabIndex = 75;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Location = new System.Drawing.Point(62, 271);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(293, 3);
            this.panel4.TabIndex = 76;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.White;
            this.panel7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel7.Location = new System.Drawing.Point(62, 102);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(293, 3);
            this.panel7.TabIndex = 79;
            // 
            // pictureEdit14
            // 
            this.pictureEdit14.EditValue = ((object)(resources.GetObject("pictureEdit14.EditValue")));
            this.pictureEdit14.Location = new System.Drawing.Point(361, 0);
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
            this.pictureEdit14.TabIndex = 94;
            this.pictureEdit14.Click += new System.EventHandler(this.pictureEdit14_Click);
            // 
            // textEdit7
            // 
            this.textEdit7.EditValue = "Arızalı Fatura Girişi";
            this.textEdit7.Enabled = false;
            this.textEdit7.Location = new System.Drawing.Point(148, 21);
            this.textEdit7.Name = "textEdit7";
            this.textEdit7.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.textEdit7.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textEdit7.Properties.Appearance.ForeColor = System.Drawing.Color.White;
            this.textEdit7.Properties.Appearance.Options.UseBackColor = true;
            this.textEdit7.Properties.Appearance.Options.UseFont = true;
            this.textEdit7.Properties.Appearance.Options.UseForeColor = true;
            this.textEdit7.Properties.AppearanceDisabled.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textEdit7.Properties.AppearanceDisabled.Options.UseFont = true;
            this.textEdit7.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.textEdit7.Size = new System.Drawing.Size(153, 24);
            this.textEdit7.TabIndex = 93;
            // 
            // pictureEdit6
            // 
            this.pictureEdit6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureEdit6.EditValue = ((object)(resources.GetObject("pictureEdit6.EditValue")));
            this.pictureEdit6.Location = new System.Drawing.Point(81, 7);
            this.pictureEdit6.Name = "pictureEdit6";
            this.pictureEdit6.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.pictureEdit6.Properties.Appearance.ForeColor = System.Drawing.Color.Transparent;
            this.pictureEdit6.Properties.Appearance.Options.UseBackColor = true;
            this.pictureEdit6.Properties.Appearance.Options.UseForeColor = true;
            this.pictureEdit6.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pictureEdit6.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pictureEdit6.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch;
            this.pictureEdit6.Size = new System.Drawing.Size(56, 49);
            this.pictureEdit6.TabIndex = 92;
            // 
            // pictureEdit8
            // 
            this.pictureEdit8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureEdit8.EditValue = ((object)(resources.GetObject("pictureEdit8.EditValue")));
            this.pictureEdit8.Location = new System.Drawing.Point(12, 331);
            this.pictureEdit8.Name = "pictureEdit8";
            this.pictureEdit8.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.pictureEdit8.Properties.Appearance.ForeColor = System.Drawing.Color.Transparent;
            this.pictureEdit8.Properties.Appearance.Options.UseBackColor = true;
            this.pictureEdit8.Properties.Appearance.Options.UseForeColor = true;
            this.pictureEdit8.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pictureEdit8.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch;
            this.pictureEdit8.Size = new System.Drawing.Size(38, 35);
            this.pictureEdit8.TabIndex = 102;
            // 
            // pictureEdit7
            // 
            this.pictureEdit7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureEdit7.EditValue = ((object)(resources.GetObject("pictureEdit7.EditValue")));
            this.pictureEdit7.Location = new System.Drawing.Point(12, 239);
            this.pictureEdit7.Name = "pictureEdit7";
            this.pictureEdit7.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.pictureEdit7.Properties.Appearance.ForeColor = System.Drawing.Color.Transparent;
            this.pictureEdit7.Properties.Appearance.Options.UseBackColor = true;
            this.pictureEdit7.Properties.Appearance.Options.UseForeColor = true;
            this.pictureEdit7.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pictureEdit7.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch;
            this.pictureEdit7.Size = new System.Drawing.Size(38, 35);
            this.pictureEdit7.TabIndex = 101;
            // 
            // pictureEdit5
            // 
            this.pictureEdit5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureEdit5.EditValue = ((object)(resources.GetObject("pictureEdit5.EditValue")));
            this.pictureEdit5.Location = new System.Drawing.Point(12, 290);
            this.pictureEdit5.Name = "pictureEdit5";
            this.pictureEdit5.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.pictureEdit5.Properties.Appearance.ForeColor = System.Drawing.Color.Transparent;
            this.pictureEdit5.Properties.Appearance.Options.UseBackColor = true;
            this.pictureEdit5.Properties.Appearance.Options.UseForeColor = true;
            this.pictureEdit5.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pictureEdit5.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch;
            this.pictureEdit5.Size = new System.Drawing.Size(38, 35);
            this.pictureEdit5.TabIndex = 100;
            // 
            // pictureEdit1
            // 
            this.pictureEdit1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureEdit1.EditValue = ((object)(resources.GetObject("pictureEdit1.EditValue")));
            this.pictureEdit1.Location = new System.Drawing.Point(12, 70);
            this.pictureEdit1.Name = "pictureEdit1";
            this.pictureEdit1.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.pictureEdit1.Properties.Appearance.ForeColor = System.Drawing.Color.Transparent;
            this.pictureEdit1.Properties.Appearance.Options.UseBackColor = true;
            this.pictureEdit1.Properties.Appearance.Options.UseForeColor = true;
            this.pictureEdit1.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pictureEdit1.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch;
            this.pictureEdit1.Size = new System.Drawing.Size(38, 35);
            this.pictureEdit1.TabIndex = 96;
            // 
            // TxtFaturaTipi
            // 
            this.TxtFaturaTipi.Location = new System.Drawing.Point(62, 118);
            this.TxtFaturaTipi.Name = "TxtFaturaTipi";
            this.TxtFaturaTipi.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.TxtFaturaTipi.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtFaturaTipi.Properties.Appearance.ForeColor = System.Drawing.Color.White;
            this.TxtFaturaTipi.Properties.Appearance.Options.UseBackColor = true;
            this.TxtFaturaTipi.Properties.Appearance.Options.UseFont = true;
            this.TxtFaturaTipi.Properties.Appearance.Options.UseForeColor = true;
            this.TxtFaturaTipi.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.TxtFaturaTipi.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.TxtFaturaTipi.Properties.DisplayMember = "NUMARASI";
            this.TxtFaturaTipi.Properties.NullText = "Fatura Tipi Seçiniz";
            this.TxtFaturaTipi.Properties.ValueMember = "NUMARASI";
            this.TxtFaturaTipi.Size = new System.Drawing.Size(293, 24);
            this.TxtFaturaTipi.TabIndex = 104;
            this.TxtFaturaTipi.Click += new System.EventHandler(this.TxtFaturaTipi_Click);
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.White;
            this.panel8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel8.Location = new System.Drawing.Point(62, 150);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(293, 3);
            this.panel8.TabIndex = 105;
            // 
            // pictureEdit3
            // 
            this.pictureEdit3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureEdit3.EditValue = ((object)(resources.GetObject("pictureEdit3.EditValue")));
            this.pictureEdit3.Location = new System.Drawing.Point(12, 111);
            this.pictureEdit3.Name = "pictureEdit3";
            this.pictureEdit3.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.pictureEdit3.Properties.Appearance.ForeColor = System.Drawing.Color.Transparent;
            this.pictureEdit3.Properties.Appearance.Options.UseBackColor = true;
            this.pictureEdit3.Properties.Appearance.Options.UseForeColor = true;
            this.pictureEdit3.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pictureEdit3.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch;
            this.pictureEdit3.Size = new System.Drawing.Size(38, 35);
            this.pictureEdit3.TabIndex = 98;
            // 
            // lookUpEdit2
            // 
            this.lookUpEdit2.Location = new System.Drawing.Point(62, 201);
            this.lookUpEdit2.Name = "lookUpEdit2";
            this.lookUpEdit2.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.lookUpEdit2.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lookUpEdit2.Properties.Appearance.ForeColor = System.Drawing.Color.White;
            this.lookUpEdit2.Properties.Appearance.Options.UseBackColor = true;
            this.lookUpEdit2.Properties.Appearance.Options.UseFont = true;
            this.lookUpEdit2.Properties.Appearance.Options.UseForeColor = true;
            this.lookUpEdit2.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.lookUpEdit2.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookUpEdit2.Properties.DisplayMember = "PERSONELNUMARASI";
            this.lookUpEdit2.Properties.NullText = "Personel Seçiniz";
            this.lookUpEdit2.Properties.ValueMember = "PERSONELNUMARASI";
            this.lookUpEdit2.Size = new System.Drawing.Size(293, 24);
            this.lookUpEdit2.TabIndex = 107;
            this.lookUpEdit2.Click += new System.EventHandler(this.lookUpEdit2_Click);
            // 
            // lookUpEdit1
            // 
            this.lookUpEdit1.Location = new System.Drawing.Point(62, 159);
            this.lookUpEdit1.Name = "lookUpEdit1";
            this.lookUpEdit1.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.lookUpEdit1.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lookUpEdit1.Properties.Appearance.ForeColor = System.Drawing.Color.White;
            this.lookUpEdit1.Properties.Appearance.Options.UseBackColor = true;
            this.lookUpEdit1.Properties.Appearance.Options.UseFont = true;
            this.lookUpEdit1.Properties.Appearance.Options.UseForeColor = true;
            this.lookUpEdit1.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.lookUpEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookUpEdit1.Properties.DisplayMember = "MÜŞTERİNUMARASI";
            this.lookUpEdit1.Properties.NullText = "Müşteri Seçiniz";
            this.lookUpEdit1.Properties.ValueMember = "MÜŞTERİNUMARASI";
            this.lookUpEdit1.Size = new System.Drawing.Size(293, 24);
            this.lookUpEdit1.TabIndex = 106;
            this.lookUpEdit1.Click += new System.EventHandler(this.lookUpEdit1_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Location = new System.Drawing.Point(62, 233);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(293, 3);
            this.panel2.TabIndex = 108;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.White;
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Location = new System.Drawing.Point(62, 191);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(293, 3);
            this.panel5.TabIndex = 109;
            // 
            // pictureEdit9
            // 
            this.pictureEdit9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureEdit9.EditValue = ((object)(resources.GetObject("pictureEdit9.EditValue")));
            this.pictureEdit9.Location = new System.Drawing.Point(12, 193);
            this.pictureEdit9.Name = "pictureEdit9";
            this.pictureEdit9.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.pictureEdit9.Properties.Appearance.ForeColor = System.Drawing.Color.Transparent;
            this.pictureEdit9.Properties.Appearance.Options.UseBackColor = true;
            this.pictureEdit9.Properties.Appearance.Options.UseForeColor = true;
            this.pictureEdit9.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pictureEdit9.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch;
            this.pictureEdit9.Size = new System.Drawing.Size(38, 35);
            this.pictureEdit9.TabIndex = 128;
            // 
            // pictureEdit2
            // 
            this.pictureEdit2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureEdit2.EditValue = ((object)(resources.GetObject("pictureEdit2.EditValue")));
            this.pictureEdit2.Location = new System.Drawing.Point(12, 152);
            this.pictureEdit2.Name = "pictureEdit2";
            this.pictureEdit2.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.pictureEdit2.Properties.Appearance.ForeColor = System.Drawing.Color.Transparent;
            this.pictureEdit2.Properties.Appearance.Options.UseBackColor = true;
            this.pictureEdit2.Properties.Appearance.Options.UseForeColor = true;
            this.pictureEdit2.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pictureEdit2.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch;
            this.pictureEdit2.Size = new System.Drawing.Size(38, 35);
            this.pictureEdit2.TabIndex = 127;
            // 
            // FrmArizaliFaturaGirişi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.ClientSize = new System.Drawing.Size(387, 448);
            this.Controls.Add(this.pictureEdit9);
            this.Controls.Add(this.pictureEdit2);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.lookUpEdit2);
            this.Controls.Add(this.lookUpEdit1);
            this.Controls.Add(this.panel8);
            this.Controls.Add(this.TxtFaturaTipi);
            this.Controls.Add(this.pictureEdit8);
            this.Controls.Add(this.pictureEdit7);
            this.Controls.Add(this.pictureEdit5);
            this.Controls.Add(this.pictureEdit3);
            this.Controls.Add(this.pictureEdit1);
            this.Controls.Add(this.pictureEdit14);
            this.Controls.Add(this.textEdit7);
            this.Controls.Add(this.pictureEdit6);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.TxTarih);
            this.Controls.Add(this.TxtOnFiyat);
            this.Controls.Add(this.TxtNetFiyat);
            this.Controls.Add(this.TxtIslemNumarasi);
            this.Controls.Add(this.BtnSil);
            this.Controls.Add(this.BtnKaydet);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmArizaliFaturaGirişi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmArizaliFaturaGirişi";
            this.Load += new System.EventHandler(this.FrmArizaliFaturaGirişi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TxTarih.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxTarih.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtOnFiyat.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtNetFiyat.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtIslemNumarasi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit14.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit7.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit6.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit8.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit7.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit5.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtFaturaTipi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit3.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEdit2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit9.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit2.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraEditors.DateEdit TxTarih;
        private DevExpress.XtraEditors.TextEdit TxtOnFiyat;
        private DevExpress.XtraEditors.TextEdit TxtNetFiyat;
        private DevExpress.XtraEditors.LookUpEdit TxtIslemNumarasi;
        private DevExpress.XtraEditors.SimpleButton BtnSil;
        private DevExpress.XtraEditors.SimpleButton BtnKaydet;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel7;
        private DevExpress.XtraEditors.PictureEdit pictureEdit14;
        private DevExpress.XtraEditors.TextEdit textEdit7;
        private DevExpress.XtraEditors.PictureEdit pictureEdit6;
        private DevExpress.XtraEditors.PictureEdit pictureEdit8;
        private DevExpress.XtraEditors.PictureEdit pictureEdit7;
        private DevExpress.XtraEditors.PictureEdit pictureEdit5;
        private DevExpress.XtraEditors.PictureEdit pictureEdit1;
        private DevExpress.XtraEditors.LookUpEdit TxtFaturaTipi;
        private System.Windows.Forms.Panel panel8;
        private DevExpress.XtraEditors.PictureEdit pictureEdit3;
        private DevExpress.XtraEditors.LookUpEdit lookUpEdit2;
        private DevExpress.XtraEditors.LookUpEdit lookUpEdit1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel5;
        private DevExpress.XtraEditors.PictureEdit pictureEdit9;
        private DevExpress.XtraEditors.PictureEdit pictureEdit2;
    }
}