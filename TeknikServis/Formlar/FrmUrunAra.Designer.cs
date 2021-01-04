namespace TeknikServis.Formlar
{
    partial class FrmUrunAra
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmUrunAra));
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.BtnAra2 = new DevExpress.XtraEditors.SimpleButton();
            this.BtnAra = new DevExpress.XtraEditors.SimpleButton();
            this.TxtUrunAdi = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.TxtUrunId = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.BtnAra3 = new DevExpress.XtraEditors.SimpleButton();
            this.TxtUrunMarkasi = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtUrunAdi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtUrunId.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtUrunMarkasi.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.Location = new System.Drawing.Point(2, 35);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(1366, 501);
            this.gridControl1.TabIndex = 36;
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
            // 
            // BtnAra2
            // 
            this.BtnAra2.Appearance.BackColor = System.Drawing.Color.Gainsboro;
            this.BtnAra2.Appearance.Options.UseBackColor = true;
            this.BtnAra2.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnAra2.ImageOptions.Image")));
            this.BtnAra2.Location = new System.Drawing.Point(647, 6);
            this.BtnAra2.Name = "BtnAra2";
            this.BtnAra2.Size = new System.Drawing.Size(120, 23);
            this.BtnAra2.TabIndex = 42;
            this.BtnAra2.Text = "ARA";
            this.BtnAra2.Click += new System.EventHandler(this.BtnAra2_Click);
            // 
            // BtnAra
            // 
            this.BtnAra.Appearance.BackColor = System.Drawing.Color.Gainsboro;
            this.BtnAra.Appearance.Options.UseBackColor = true;
            this.BtnAra.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnAra.ImageOptions.Image")));
            this.BtnAra.Location = new System.Drawing.Point(271, 5);
            this.BtnAra.Name = "BtnAra";
            this.BtnAra.Size = new System.Drawing.Size(120, 23);
            this.BtnAra.TabIndex = 41;
            this.BtnAra.Text = "ARA";
            this.BtnAra.Click += new System.EventHandler(this.BtnAra_Click);
            // 
            // TxtUrunAdi
            // 
            this.TxtUrunAdi.Location = new System.Drawing.Point(501, 9);
            this.TxtUrunAdi.Name = "TxtUrunAdi";
            this.TxtUrunAdi.Size = new System.Drawing.Size(140, 20);
            this.TxtUrunAdi.TabIndex = 40;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(433, 10);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(62, 16);
            this.labelControl2.TabIndex = 39;
            this.labelControl2.Text = "URUN ADI";
            // 
            // TxtUrunId
            // 
            this.TxtUrunId.Location = new System.Drawing.Point(125, 9);
            this.TxtUrunId.Name = "TxtUrunId";
            this.TxtUrunId.Size = new System.Drawing.Size(140, 20);
            this.TxtUrunId.TabIndex = 38;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(12, 12);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(107, 16);
            this.labelControl1.TabIndex = 37;
            this.labelControl1.Text = "URUN NUMARASI";
            // 
            // BtnAra3
            // 
            this.BtnAra3.Appearance.BackColor = System.Drawing.Color.Gainsboro;
            this.BtnAra3.Appearance.Options.UseBackColor = true;
            this.BtnAra3.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnAra3.ImageOptions.Image")));
            this.BtnAra3.Location = new System.Drawing.Point(1067, 5);
            this.BtnAra3.Name = "BtnAra3";
            this.BtnAra3.Size = new System.Drawing.Size(120, 23);
            this.BtnAra3.TabIndex = 45;
            this.BtnAra3.Text = "ARA";
            this.BtnAra3.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // TxtUrunMarkasi
            // 
            this.TxtUrunMarkasi.Location = new System.Drawing.Point(921, 8);
            this.TxtUrunMarkasi.Name = "TxtUrunMarkasi";
            this.TxtUrunMarkasi.Size = new System.Drawing.Size(140, 20);
            this.TxtUrunMarkasi.TabIndex = 44;
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(807, 10);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(99, 16);
            this.labelControl3.TabIndex = 43;
            this.labelControl3.Text = "URUN MARKASI";
            // 
            // simpleButton1
            // 
            this.simpleButton1.Appearance.BackColor = System.Drawing.Color.Gainsboro;
            this.simpleButton1.Appearance.Options.UseBackColor = true;
            this.simpleButton1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.ImageOptions.Image")));
            this.simpleButton1.Location = new System.Drawing.Point(1330, 0);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(38, 33);
            this.simpleButton1.TabIndex = 46;
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click_1);
            // 
            // FrmUrunAra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1370, 541);
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.BtnAra3);
            this.Controls.Add(this.TxtUrunMarkasi);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.BtnAra2);
            this.Controls.Add(this.BtnAra);
            this.Controls.Add(this.TxtUrunAdi);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.TxtUrunId);
            this.Controls.Add(this.labelControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmUrunAra";
            this.Text = "Detaylı Ürün Ara";
            this.Load += new System.EventHandler(this.FrmUrunAra_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtUrunAdi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtUrunId.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtUrunMarkasi.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.SimpleButton BtnAra2;
        private DevExpress.XtraEditors.SimpleButton BtnAra;
        private DevExpress.XtraEditors.TextEdit TxtUrunAdi;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit TxtUrunId;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SimpleButton BtnAra3;
        private DevExpress.XtraEditors.TextEdit TxtUrunMarkasi;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
    }
}