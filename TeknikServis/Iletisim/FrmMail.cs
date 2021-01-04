using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Mail;

namespace TeknikServis.Iletisim
{
    public partial class FrmMail : Form
    {
        public FrmMail()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureEdit14_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TxtMail_Click(object sender, EventArgs e)
        {
            TxtMail.Text = "";
        }

        private void textEdit1_Click(object sender, EventArgs e)
        {
            textEdit1.Text = "";
        }

        private void richTextBox1_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "";
        }

        private void BtnGüncelle_Click(object sender, EventArgs e)
        {
            MailMessage mail = new MailMessage();
            string frommail = "sevcan.celikdogan9@gmail.com";
            string sifre = "15112016....";
            string alici = TxtMail.Text;
            string konu = textEdit1.Text;
            string icerik = richTextBox1.Text;
            mail.From = new MailAddress(frommail);
            mail.To.Add(alici);
            mail.Subject = konu;
            mail.Body = icerik;
            mail.IsBodyHtml = true;
            SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587);
            smtp.Credentials = new NetworkCredential(frommail, sifre);
            smtp.EnableSsl = true;
            smtp.Send(mail);
            MessageBox.Show("Mail Gönderildi");

        }
    }
}
