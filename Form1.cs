using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;
namespace ntpödevi
{
    public partial class Form1 : Form
    {
        SqlConnection con;
        SqlDataReader dr;
        SqlCommand com;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {


            string user = textBox1.Text;
            string password = textBox2.Text;
            con = new SqlConnection("Data Source=DESKTOP-U7FCHSD;Initial Catalog=ntp;Integrated Security=True");
            com = new SqlCommand();
            con.Open();
            com.Connection = con;
            com.CommandText="Select*From Kullanici_Bilgileri where kullanici_adi='"+textBox1.Text+
                "' And sifre='"+ textBox2.Text + "'";   
 
            dr =com.ExecuteReader();
            if (dr.Read())
            {
                MessageBox.Show("Başarılı giriş");
                FormMain anaMenü = new FormMain();
                anaMenü.ShowDialog();
            }

            else
            {
                MessageBox.Show("Hatalı Giriş");
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

      

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
            form2.BringToFront();
        }
    }
}
