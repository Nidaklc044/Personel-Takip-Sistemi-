using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Net;
using System.Net.Mail;

namespace ntpödevi
{
    public partial class Form2 : Form
    {
        SqlConnection con;
        SqlDataReader dr;
        SqlCommand com;
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            KontrolMail();
        }

        private void KontrolMail()
        {
            if (string.IsNullOrEmpty(textBox1.Text))

            {
                MessageBox.Show("Maili Doldurunuz");
                return;
            }

            if (string.IsNullOrEmpty(textBox2.Text))

            {
                MessageBox.Show("Kullanıcı Adını Doldurunuz");
                return;
            }
            else
            {

                SearchMail();
               

            }


        }
        private void sendMail()
        {

            try
            {
                string ad;
                Random rnd = new Random();
                int sayi = rnd.Next(999, 9999);
                string alici=textBox1.Text;
                MailMessage mailt = new MailMessage(); // mail adında MailMessage nesnesi yaratıyoruz.

                mailt.From = new MailAddress("nidamailyonlendirme@gmail.com"); //Mailin kimden gittiğini belirtiyoruz

                mailt.To.Add(alici); //Mailin kime gideceğini belirtiyoruz

                mailt.Subject = "NidaKılıc Parola Sıfırlama Talebi"; //Mail konusu 

                mailt.Body = "Parola sıfırlama talebiniz alındı.Sıfırlama Kodunuz: " + sayi + ""; //Mailin içeriği

                SmtpClient sc = new SmtpClient(); //sc adında SmtpClient nesnesi yaratıyoruz.

                sc.Port = 587; //Gmail için geçerli Portu bildiriyoruz
                sc.Host = "smtp.gmail.com"; //Gmailin smtp host adresini belirttik

                sc.EnableSsl = true; //SSL’i etkinleştirdik.

                sc.Credentials = new NetworkCredential("nidamailyonlendirme@gmail.com", "brjnmwlovdumitbf"); //Gmail hesap kontrolü için bilgilerimizi girdik
                sc.Send(mailt); //Mailinizi gönderiyoruz.



            }
            catch (Exception)
            {
                MessageBox.Show("Mail gonderilirken hata olustu");

            }
        }
































        //
        //alıcı mail adresı kısmını textbox.texden gelen deger ıle degıstır.Burada sabıt olarka benım hesabıma maıl gıdıyor
        //private void sendMail()
        //{
        //     string smtpAddress = "smtp.gmail.com";  //smtp mail portu
        //     int portNumber = 587;
        //     bool enableSSL = true;
        //     string emailFromAddress = "nidamailyonlendirme@gmail.com"; //Gonderici Email adresi  
        //     string password = "brjnmwlovdumitbf"; //gonderici parola 
        //    string emailToAddress = textBox1.Text; //Alıcı Email adresi  
        //     string subject = "Sıfre Sıfırlama Talebi";
        //     string body = "Merhaba sıfre sıfırlama talebınızı tamamlamak ıster mısınız.";

        //    try
        //    {
        //        //buraya bakılacak tekrar.MAyıs 2022 ıtıbarıyle mail kutuphanesı google guncellemesı ıle deactıvr
        //        using (MailMessage mail = new MailMessage())
        //        {
        //            mail.From = new MailAddress(emailFromAddress);
        //            mail.To.Add(emailToAddress);
        //            mail.Subject = subject;
        //            mail.Body = body;
        //            mail.IsBodyHtml = true;

        //            using (SmtpClient smtp = new SmtpClient(smtpAddress, portNumber))
        //            {
        //                smtp.Credentials = new NetworkCredential(emailFromAddress, password);
        //                smtp.EnableSsl = enableSSL;
        //                smtp.UseDefaultCredentials = false;
        //                smtp.Timeout = 20000;
        //                smtp.Send(mail);
        //            }
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show("Mail gonderilirken hata olustu");
        //    }
        //    }



        private void SearchMail()
        {

            con = new SqlConnection("Data Source=DESKTOP-U7FCHSD;Initial Catalog=ntp;Integrated Security=True");
            com = new SqlCommand();
            con.Open();
            com.Connection = con;
            com.CommandText = "Select*From Kullanici_Bilgileri where kullanici_adi='" + textBox1.Text +
                "' And Mail='" + textBox2.Text + "'";

            dr = com.ExecuteReader();
            if(dr != null)
            {
                MessageBox.Show("Kullanici  bulundu Mail Gonderiliyor");
                sendMail(); 
            }

            else
            {
                MessageBox.Show("Kayıt  Bulunamadı");
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {
          
        }
    }
    }

