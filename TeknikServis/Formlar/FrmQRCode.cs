using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MessagingToolkit.QRCode.Codec;

namespace TeknikServis.Formlar
{
    public partial class FrmQRCode : Form
    {
        public FrmQRCode()
        {
            InitializeComponent();
        }

        private void QROlustur_Click(object sender, EventArgs e)
        {
            
                QRCodeEncoder enc = new QRCodeEncoder();
                pictureEdit1.Image = enc.Encode(TxtSeriNo.Text);
                       
        }
        private void pictureEdit14_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TxtSeriNo_Click(object sender, EventArgs e)
        {
            TxtSeriNo.Text = "";
        }
    }
}
