namespace TeknikServis.Formlar
{
    partial class FrmFaturaKalemleri
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmFaturaKalemleri));
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.TxtFaturaNumarasi = new DevExpress.XtraEditors.TextEdit();
            this.TxtDetayNumarasi = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.BtnAra = new DevExpress.XtraEditors.SimpleButton();
            this.BtnAra2 = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtFaturaNumarasi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtDetayNumarasi.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.Location = new System.Drawing.Point(1, 42);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(1383, 536);
            this.gridControl1.TabIndex = 25;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.gridControl1.Click += new System.EventHandler(this.gridControl1_Click);
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
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(12, 14);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(128, 16);
            this.labelControl1.TabIndex = 26;
            this.labelControl1.Text = "FATURA NUMARASI:";
            this.labelControl1.Click += new System.EventHandler(this.labelControl1_Click);
            // 
            // TxtFaturaNumarasi
            // 
            this.TxtFaturaNumarasi.Location = new System.Drawing.Point(146, 14);
            this.TxtFaturaNumarasi.Name = "TxtFaturaNumarasi";
            this.TxtFaturaNumarasi.Size = new System.Drawing.Size(140, 20);
            this.TxtFaturaNumarasi.TabIndex = 27;
            this.TxtFaturaNumarasi.EditValueChanged += new System.EventHandler(this.TxtFaturaNumarasi_EditValueChanged);
            // 
            // TxtDetayNumarasi
            // 
            this.TxtDetayNumarasi.Location = new System.Drawing.Point(557, 14);
            this.TxtDetayNumarasi.Name = "TxtDetayNumarasi";
            this.TxtDetayNumarasi.Size = new System.Drawing.Size(140, 20);
            this.TxtDetayNumarasi.TabIndex = 29;
            this.TxtDetayNumarasi.EditValueChanged += new System.EventHandler(this.TxtDetayNumarasi_EditValueChanged);
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(427, 16);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(124, 16);
            this.labelControl2.TabIndex = 28;
            this.labelControl2.Text = "DETAY NUMARASI :";
            this.labelControl2.Click += new System.EventHandler(this.labelControl2_Click);
            // 
            // BtnAra
            // 
            this.BtnAra.Appearance.BackColor = System.Drawing.Color.Gainsboro;
            this.BtnAra.Appearance.Options.UseBackColor = true;
            this.BtnAra.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnAra.ImageOptions.Image")));
            this.BtnAra.Location = new System.Drawing.Point(292, 13);
            this.BtnAra.Name = "BtnAra";
            this.BtnAra.Size = new System.Drawing.Size(120, 23);
            this.BtnAra.TabIndex = 32;
            this.BtnAra.Text = "ARA";
            this.BtnAra.Click += new System.EventHandler(this.BtnAra_Click);
            // 
            // BtnAra2
            // 
            this.BtnAra2.Appearance.BackColor = System.Drawing.Color.Gainsboro;
            this.BtnAra2.Appearance.Options.UseBackColor = true;
            this.BtnAra2.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnAra2.ImageOptions.Image")));
            this.BtnAra2.Location = new System.Drawing.Point(703, 14);
            this.BtnAra2.Name = "BtnAra2";
            this.BtnAra2.Size = new System.Drawing.Size(120, 23);
            this.BtnAra2.TabIndex = 35;
            this.BtnAra2.Text = "ARA";
            this.BtnAra2.Click += new System.EventHandler(this.BtnAra2_Click);
            // 
            // FrmFaturaKalemleri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1386, 580);
            this.Controls.Add(this.BtnAra2);
            this.Controls.Add(this.BtnAra);
            this.Controls.Add(this.TxtDetayNumarasi);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.TxtFaturaNumarasi);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.gridControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmFaturaKalemleri";
            this.Text = "Fatura Kalemleri";
            this.Load += new System.EventHandler(this.FrmFaturaKalemleri_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtFaturaNumarasi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtDetayNumarasi.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit TxtFaturaNumarasi;
        private DevExpress.XtraEditors.TextEdit TxtDetayNumarasi;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.SimpleButton BtnAra;
        private DevExpress.XtraEditors.SimpleButton BtnAra2;
    }
}