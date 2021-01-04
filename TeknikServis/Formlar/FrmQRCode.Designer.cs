namespace TeknikServis.Formlar
{
    partial class FrmQRCode
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmQRCode));
            this.QROlustur = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.pictureEdit1 = new DevExpress.XtraEditors.PictureEdit();
            this.TxtSeriNo = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureEdit14 = new DevExpress.XtraEditors.PictureEdit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtSeriNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit14.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // QROlustur
            // 
            this.QROlustur.Appearance.BackColor = System.Drawing.Color.LightGray;
            this.QROlustur.Appearance.Options.UseBackColor = true;
            this.QROlustur.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("QROlustur.ImageOptions.Image")));
            this.QROlustur.Location = new System.Drawing.Point(126, 84);
            this.QROlustur.Name = "QROlustur";
            this.QROlustur.Size = new System.Drawing.Size(118, 29);
            this.QROlustur.TabIndex = 0;
            this.QROlustur.Text = "QR OLUŞTUR";
            this.QROlustur.Click += new System.EventHandler(this.QROlustur_Click);
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(12, 12);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(298, 18);
            this.labelControl1.TabIndex = 1;
            this.labelControl1.Text = "SERİ NUMARASI QR CODE OLUŞTURMA";
            // 
            // pictureEdit1
            // 
            this.pictureEdit1.Location = new System.Drawing.Point(101, 119);
            this.pictureEdit1.Name = "pictureEdit1";
            this.pictureEdit1.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.pictureEdit1.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.pictureEdit1.Properties.Appearance.Options.UseBackColor = true;
            this.pictureEdit1.Properties.Appearance.Options.UseForeColor = true;
            this.pictureEdit1.Properties.PictureAlignment = System.Drawing.ContentAlignment.BottomLeft;
            this.pictureEdit1.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pictureEdit1.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch;
            this.pictureEdit1.Size = new System.Drawing.Size(170, 180);
            this.pictureEdit1.TabIndex = 2;
            // 
            // TxtSeriNo
            // 
            this.TxtSeriNo.Location = new System.Drawing.Point(101, 52);
            this.TxtSeriNo.Name = "TxtSeriNo";
            this.TxtSeriNo.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.TxtSeriNo.Properties.Appearance.Options.UseBackColor = true;
            this.TxtSeriNo.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.TxtSeriNo.Properties.Mask.EditMask = "AAAAA";
            this.TxtSeriNo.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Simple;
            this.TxtSeriNo.Size = new System.Drawing.Size(170, 18);
            this.TxtSeriNo.TabIndex = 3;
            this.TxtSeriNo.Click += new System.EventHandler(this.TxtSeriNo_Click);
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(14, 57);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(81, 14);
            this.labelControl2.TabIndex = 4;
            this.labelControl2.Text = "SERİ NUMARA:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Location = new System.Drawing.Point(101, 68);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(170, 3);
            this.panel1.TabIndex = 5;
            // 
            // pictureEdit14
            // 
            this.pictureEdit14.EditValue = ((object)(resources.GetObject("pictureEdit14.EditValue")));
            this.pictureEdit14.Location = new System.Drawing.Point(320, 2);
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
            this.pictureEdit14.TabIndex = 92;
            this.pictureEdit14.Click += new System.EventHandler(this.pictureEdit14_Click);
            // 
            // FrmQRCode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(344, 322);
            this.Controls.Add(this.pictureEdit14);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.TxtSeriNo);
            this.Controls.Add(this.pictureEdit1);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.QROlustur);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmQRCode";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "QR Code";
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtSeriNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit14.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton QROlustur;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.PictureEdit pictureEdit1;
        private DevExpress.XtraEditors.TextEdit TxtSeriNo;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraEditors.PictureEdit pictureEdit14;
    }
}