using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;
namespace ntpödevi
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        SqlConnection can=new SqlConnection("Data Source=DESKTOP-U7FCHSD;Initial Catalog=ntp;Integrated Security=True");

        private void button1_Click(object sender, EventArgs e)
        {
         
           SearchUser();
           
        }
    }


    private void SearchUser()
    {

           SqlCommand cmd = new SqlCommand("SELECT * FROM Kullanici_Bilgileri Where kullanici_adi='" + textBox1.Text.ToString()  //TABLO ADI YANLIS 

            + "'and sifre='" + textBox2.Text.ToString() + "'", can);
            can.Open();
            SqlDataReader oku=cmd.ExecuteReader();
        if(oku != null)
        {
            MessageBox.Show("Giriş Başarılı");
        }
        else
        {
                        MessageBox.Show("Hatalı kullanıcı  bilgileri");

        }




    }
    private void SendMail()
    {


         if (oku.Read())
            {
                try
                {
                    SmtpClient smtp = new SmtpClient();
                    MailMessage mailMessage = new MailMessage();
                    String tarih = DateTime.Now.ToLongDateString();
                    String mail_adresin = ("nidakilic1707@gmail.com");
                    String sifre = ("123456");
                    String smtpserver = "smtp.gmail.com";
                 

           ;

                    String kime = (oku["mail_adresi"].ToString());

                    String konu=("şifre Hatırlatma");
                    String yaz=("Sayin"+" "+ oku["kullanici_adi"].ToString() + "" 
                        + "şifreniz : "+ oku["sifre"].ToString());


                    smtp.Credentials = new NetworkCredential(mail_adresin, sifre);

                    smtp.Port = 587;

                    smtp.Host = smtpserver;

                    smtp.EnableSsl = true;

                    mail.From = new MailAddress(mail_adresin);

                    mail.To.Add(kime);

                    mail.Subject = konu;

                   mail.Body= yaz;

                    smtp.Send(mail);

                    DialogResult bilgi = new DialogResult();

                    bilgi=MessageBox.Show("Şifreniz mail adresinize gönderilmiştir.");
                    this.Hide();

                }
                catch(Exception hata)
                {
                    MessageBox.Show("Bilgileri Kontrol Ediniz");
                    //burası en basından hatalı
                }
            }
            else
            {
                MessageBox.Show("Basarisiz");
            }





    }



}
