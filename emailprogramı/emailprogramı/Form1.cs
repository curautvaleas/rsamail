using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Mail;
using System.Security.Cryptography;

namespace emailprogrami
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            txtDec.Text = "şifreli mesajı giriniz";
            txtKey.Text = "anahtarı giriniz";
            txtkimden.Text = "kayikcimail@gmail.com";
            txtkimden.ReadOnly = true;
            
        }

        const int keySize = 1024;
        string publicAndPrivateKey;
        string publicKey;
        string encrypted;
        string decrypted;
        


        private void button1_Click(object sender, EventArgs e)
        {
            MailMessage message = new MailMessage();
            message.Subject = txtkonu.Text;
            message.From = new MailAddress("kayikcimail@gmail.com");
            message.To.Add(txtkime.Text);
            emailprogrami.RSA.RSA_Class.GenerateKeys(keySize, out publicKey, out publicAndPrivateKey);
            encrypted = emailprogrami.RSA.RSA_Class.EncryptText(txtmsg.Text, keySize, publicKey);
            string spublicAndPrivateKey = publicAndPrivateKey.Replace("<RSAKeyValue><Modulus>", "^^^");
            message.Body = encrypted + Environment.NewLine + Environment.NewLine + Environment.NewLine + "ANAHTAR DEĞERİ : " + spublicAndPrivateKey;

            SmtpClient smtp = new SmtpClient();
            smtp.Credentials = new System.Net.NetworkCredential("kayikcimail@gmail.com", "omer123456789");
            smtp.Port = 587;
            smtp.Host = "smtp.gmail.com";
            smtp.EnableSsl = true;

            smtp.Send(message);

            MessageBox.Show("Mesaj Başarıyla Gönderildi");
        }

        private void btndec_Click(object sender, EventArgs e)
        {
            publicAndPrivateKey = txtKey.Text;
            publicAndPrivateKey = publicAndPrivateKey.Replace("^^^", "<RSAKeyValue><Modulus>");
            decrypted = emailprogrami.RSA.RSA_Class.DecryptText(txtDec.Text, keySize, publicAndPrivateKey);
            txtDec.Text = decrypted;
        }

        private void txtDec_Click(object sender, EventArgs e)
        {
            txtDec.Text = "";
        }

        private void txtKey_Click(object sender, EventArgs e)
        {
            txtKey.Text = "";
        }

    }
}
