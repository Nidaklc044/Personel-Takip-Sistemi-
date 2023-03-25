using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ntpödevi
{
    public partial class FormBolum : Form
    {
        SqlConnection connect;
        SqlCommand komutttt;
        public FormBolum()
        {
            InitializeComponent();
        }

        

   

        public void MüsteriGetir()
        {

            connect = new SqlConnection("Data Source=DESKTOP-U7FCHSD;Initial Catalog=ntp;Integrated Security=True");
            string Select = "Select* From tblCalistigiBolum";  //tabloyuyu yazdırırlem sılındımı sutunu = false olanları getırıyoruz
            SqlDataAdapter adapter = new SqlDataAdapter(Select, connect);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;
            connect.Close();
        }

        private void TcGetir()
        {
            SqlCommand komutt = new SqlCommand("select distinct TC  from tblPersonelInfo", connect);
            SqlDataReader reader;
            connect.Open();
            reader = komutt.ExecuteReader();

            while (reader.Read())
            {
                txttc.Items.Add(reader["TC"]);


            }
            connect.Close();

        }


        //private void BolumGetir()
        //{
        //    SqlCommand komutt = new SqlCommand("select distinct Department  from MaasIslemler", connect);
        //    SqlDataReader reader;
        //    connect.Open();
        //    reader = komutt.ExecuteReader();

        //    while (reader.Read())
        //    {
        //        textBox1.Text=(reader["Department"].ToString());


        //    }
        //    connect.Close();

        //}







        private void ÇalıştığıBölüm_Load(object sender, EventArgs e)
        {
            MüsteriGetir();
            TcGetir();
           
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            MüsteriGetir();

           
                txttc.Text = dataGridView1.CurrentRow.Cells["Tc"].Value.ToString();
                txtad.Text = dataGridView1.CurrentRow.Cells["Name"].Value.ToString();
                txtsoyad.Text = dataGridView1.CurrentRow.Cells["Surname"].Value.ToString();
              txtbolum.Text = dataGridView1.CurrentRow.Cells["Department"].Value.ToString();
                txtdurum.Text = dataGridView1.CurrentRow.Cells["Durum"].Value.ToString();
          

            
        }



        private void button1_Click(object sender, EventArgs e)
        {
            try
            {

            connect = new SqlConnection("Data Source=DESKTOP-U7FCHSD;Initial Catalog=ntp;Integrated Security=True");
            connect.Open();

            string sorgu = "INSERT INTO tblCalistigiBolum(TC,[Name],Surname,Department,Durum) " +
                   "VALUES (@TC,@Name,@Surname,@Department,@Durum)";

            komutttt = new SqlCommand(sorgu, connect);

            komutttt.Parameters.AddWithValue("@TC", txttc.Text);
            komutttt.Parameters.AddWithValue("@Name", txtad.Text);
            komutttt.Parameters.AddWithValue("@Surname", txtsoyad.Text);
            komutttt.Parameters.AddWithValue("@Department", txtbolum.Text);
            komutttt.Parameters.AddWithValue("@Durum", txtdurum.Text);


              komutttt.ExecuteNonQuery();

              MessageBox.Show("Kayıt eklendi.");
                MüsteriGetir();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Personel zaten kayıtlı yalnızca günceleme yapabilirsiniz");
            }
            connect.Close();
        }

        private void txttc_SelectedIndexChanged(object sender, EventArgs e)
        {
            TcBul();

        }

        private void TcBul()
        {
            
            SqlCommand komutt = new SqlCommand("select* from MaasIslemler Where Tc='"+ txttc.Text+ "'", connect);
            SqlDataReader reader;
            connect.Open();
            reader = komutt.ExecuteReader();

            while (reader.Read())
            {
                txtad.Text = (reader["Name"].ToString());
                txtsoyad.Text = (reader["Surname"].ToString());
                txtbolum.Text = (reader["Department"].ToString());



            }
            connect.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string sorgu = "UPDATE tblCalistigiBolum SET TC=@TC,[Name]=@Name,Surname=@Surname,Department=@Department,Durum=@Durum WHERE TC=@TC";
            komutttt = new SqlCommand(sorgu, connect);

            komutttt.Parameters.AddWithValue("@TC", txttc.Text);
            komutttt.Parameters.AddWithValue("@Name", txtad.Text);
            komutttt.Parameters.AddWithValue("@Surname", txtsoyad.Text);
            komutttt.Parameters.AddWithValue("@Department", txtbolum.Text);
            komutttt.Parameters.AddWithValue("@Durum", txtdurum.Text);
            connect.Open();
            komutttt.ExecuteNonQuery();
            MessageBox.Show("Kayıt güncellendi.");
            connect.Close();
            MüsteriGetir();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            foreach (Control item in this.Controls)
            {
                if (item is TextBox)
                {
                    (item as TextBox).Clear();
                }
                txtdurum.Text = "";
                txttc.Text = "";
            }
        }

        private void txttc_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
            if ((int)e.KeyChar == 32)
            {
                e.Handled = true;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            FormMain anaMenü = new FormMain();
            this.Hide();
            anaMenü.ShowDialog();
        }
    }
}


