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

namespace ntpödevi
{
    public partial class MaasIslemleri : Form
    {
        SqlConnection conn;
        SqlCommand komutt;
        // SqlDataAdapter daa;
        public MaasIslemleri()
        {
            InitializeComponent();
        }

        public void MüsteriGetir()
        {
            conn = new SqlConnection("Data Source=DESKTOP-U7FCHSD;Initial Catalog=ntp;Integrated Security=True");
            string Select = "Select * From MaasIslemler Where IsDeleted=0";  //tabloyuyu yazdırırlem sılındımı sutunu = false olanları getırıyoruz
            SqlDataAdapter adapter = new SqlDataAdapter(Select, conn);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;
            conn.Close();
        }

        //formun acıldıfı anda yapılacak ıslemlerın yazıldıdgı metod(Form_load)
        private void MaasIslemleri_Load(object sender, EventArgs e)
        {
            MüsteriGetir();
            TcGetir();




        }

        private void BilgiGetir()
        {
            comboBox2.Items.Clear();

            SqlCommand komuttt = new SqlCommand("select distinct Bölüm from tblMaas", conn);
            SqlDataReader readerr;
            conn.Open();
            readerr = komuttt.ExecuteReader();

            while (readerr.Read())
            {


                comboBox2.Items.Add(readerr["Bölüm"]);


            }
            conn.Close();

        }
        private void TcGetir()
        {
            SqlCommand komutt = new SqlCommand("select distinct TC  from tblPersonelInfo", conn);
            SqlDataReader reader;
            conn.Open();
            reader = komutt.ExecuteReader();

            while (reader.Read())
            {
                comboBox1.Items.Add(reader["TC"]);


            }
            conn.Close();

        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            //cells sonrası sutunun adını yazmalısın cels[0] yeırne cels["sutunadı"]


            comboBox1.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txtad.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txtsoyad.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            txtcalısmayılı.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            txtmaas.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            txtcocuksayısı.Text = dataGridView1.CurrentRow.Cells["NumberOfChildren"].Value.ToString();
            txtsatıs.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            comboBox2.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtsatıs.Text == "0")
            {
                MessageBox.Show("Satış Miktarı 0 olamaz");

            }


            else
            {
                try
                {


                    string sorgu = "INSERT INTO MaasIslemler(TC,[Name],Surname,OperationTime,Salary,NumberOfChildren,SalesAmount,Department) " +
                        "VALUES (@TC,@Name,@Surname,@OperationTime,@Salary,@NumberOfChildren,@SalesAmount,@Department)";

                    komutt = new SqlCommand(sorgu, conn);

                    komutt.Parameters.AddWithValue("@TC", comboBox1.Text);
                    komutt.Parameters.AddWithValue("@Name", txtad.Text);
                    komutt.Parameters.AddWithValue("@Surname", txtsoyad.Text);
                    komutt.Parameters.AddWithValue("@OperationTime", txtcalısmayılı.Text);
                    komutt.Parameters.AddWithValue("@Salary", textBox7.Text);

                    komutt.Parameters.AddWithValue("@NumberOfChildren", txtcocuksayısı.Text);
                    komutt.Parameters.AddWithValue("@SalesAmount", txtsatıs.Text);
                    komutt.Parameters.AddWithValue("@Department", comboBox2.Text);
                    conn.Open();
                    komutt.ExecuteNonQuery();

                    MessageBox.Show("Kayıt eklendi.");
                }

                catch (Exception ex)
                {
                    MessageBox.Show("Kayıt zaten var guncelleme ıslemı yapınız");
                }
                MüsteriGetir();
            }












        }

        private void button2_Click(object sender, EventArgs e)
        {

            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {

                string id = dataGridView1.SelectedRows[i].Cells["personelid"].Value.ToString();
                string sorgu = "UPDATE MaasIslemler Set IsDeleted=1  WHERE personelid=" + id + " ";
                komutt = new SqlCommand(sorgu, conn);
                komutt.Parameters.AddWithValue("@id", SqlDbType.Int).Value = id;
                conn.Open();
                komutt.ExecuteNonQuery();
                MessageBox.Show("Kayıt silindi.");
                conn.Close();
            }
            MüsteriGetir();



        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtad.Text = comboBox1.Text;
            soyadGetir();
            BilgiGetir();

        }
        public void soyadGetir()
        {
            SqlCommand komutt = new SqlCommand("select* from tblPersonelInfo Where Tc=@tc", conn);
            komutt.Parameters.AddWithValue("tc", comboBox1.Text);
            SqlDataReader reader;
            conn.Open();
            reader = komutt.ExecuteReader();
            while (reader.Read())
            {

                txtsoyad.Text = ((string)reader["Surname"].ToString());
                txtad.Text = ((string)reader["Name"].ToString());
                txtDate.Text = ((string)reader["DateofEntry"].ToString().Substring(0, 15));

                //txtDate.Text = ((string)reader["DateofEntry"].ToString());
                DateTime enddate = DateTime.Now;
                DateTime startdate = ((DateTime)reader["DateofEntry"]);
                int kidem = enddate.Year - startdate.Year;
                if (kidem == 0)
                {
                    kidem = 1;
                    txtcalısmayılı.Text = "1";

                }
                else
                {
                    kidem = enddate.Year - startdate.Year;
                    txtcalısmayılı.Text = kidem.ToString();


                }


            }
            conn.Close();
        }
        //public void isimGetir()
        //{
        //    SqlCommand komutt = new SqlCommand("select* from tblPersonelInfo", conn);
        //    SqlDataReader reader;
        //    conn.Open();
        //    reader = komutt.ExecuteReader();
        //    while (reader.Read())
        //    {

        //        txtad.Text = ((string)reader["Name"].ToString());

        //    }
        //    conn.Close();
        //}

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtmaas.Text = comboBox2.Text;

            maasGetir();
            //BilgiGetir();

        }
        public void maasGetir()
        {
            SqlCommand komutt = new SqlCommand("select* from tblMaas where Bölüm =@p", conn);
            komutt.Parameters.AddWithValue("@P", txtmaas.Text);
            SqlDataReader reader;
            conn.Open();
            reader = komutt.ExecuteReader();
            while (reader.Read())
            {

                txtmaas.Text = ((string)reader["BölümMaaşi"].ToString());

            }
            conn.Close();

        }




        private void txtmaas_TextChanged(object sender, EventArgs e)
        {
        }
        private void txtcocuksayısı_TextChanged(object sender, EventArgs e)
        {
            Hesapla();
        }


        private void textBox7_TextChanged(object sender, EventArgs e)
        {
            //int sayi1, sayi2, sayi3;
            //sayi1 = Convert.ToInt32(txtcocuksayısı.Text);
            //sayi1 = sayi1 * 300;
            //sayi2 = Convert.ToInt32(txtsatıs.Text);
            //sayi2 = sayi2 * 100;
            //sayi3 = Convert.ToInt32(txtcalısmayılı.Text);
            //sayi3 = sayi3 * 500;
            //textBox7.Text = Convert.ToString(sayi1 + sayi2 + txtmaas.Text + sayi3);
        }

        private void txtsatıs_TextChanged(object sender, EventArgs e)
        {
            Hesapla();
        }

        private void Hesapla()
        {
            int sayi1, sayi2, sayi3, sayi4;




            if (txtcocuksayısı.Text == "0" || txtcocuksayısı.Text == null || txtcocuksayısı.Text == "" || txtcocuksayısı.Text.Length < 1)
            {
                sayi1 = 0;
            }
            else if (Convert.ToInt32(txtcocuksayısı.Text) > 20)
            {

                MessageBox.Show("Cocuk Sayısı 20 den buyuk olamaz");
                txtcocuksayısı.Text = "20";
                sayi1 = 20;


            }
            else
            {

                sayi1 = Convert.ToInt32(txtcocuksayısı.Text);

                sayi1 = sayi1 * 300;
            }










            if (txtsatıs.Text == "0" || txtsatıs.Text == "")
            {
                sayi2 = 1;
            }
            else
            {
                sayi2 = Convert.ToInt32(txtsatıs.Text);

            }

            if (txtmaas.Text == "0" || txtmaas.Text == "")
            {
                sayi4 = 1;
            }
            else
            {
                sayi4 = Convert.ToInt32(txtmaas.Text);

            }


            if (txtcalısmayılı.Text == "0" || txtcalısmayılı.Text == null || txtcalısmayılı.Text == "" || txtcalısmayılı.Text.Length < 1)
            {
                sayi3 = 0;
            }
            else
            {
                sayi3 = Convert.ToInt32(txtcalısmayılı.Text);
                sayi3 = sayi3 * 500;
            }








            sayi2 = sayi2 * 100;

            double sonuc = sayi1 + sayi2 + sayi3 + sayi4;
            textBox7.Text = sonuc.ToString();

        }





        private void button3_Click(object sender, EventArgs e)
        {
            try
            {

                string sorgu = "UPDATE MaasIslemler SET [Name]=@Name,Surname=@Surname,OperationTime=@OperationTime,Salary=@Salary,NumberOfChildren=@NumberOfChildren,SalesAmount=@SalesAmount," +
                    "Department=@Department WHERE TC=@TC";




                komutt = new SqlCommand(sorgu, conn);


                komutt = new SqlCommand(sorgu, conn);

                komutt.Parameters.AddWithValue("@TC", comboBox1.Text);
                komutt.Parameters.AddWithValue("@Name", txtad.Text);
                komutt.Parameters.AddWithValue("@Surname", txtsoyad.Text);
                komutt.Parameters.AddWithValue("@OperationTime", txtcalısmayılı.Text);
                komutt.Parameters.AddWithValue("@Salary", txtmaas.Text);

                komutt.Parameters.AddWithValue("@NumberOfChildren", txtcocuksayısı.Text);
                komutt.Parameters.AddWithValue("@SalesAmount", txtsatıs.Text);
                komutt.Parameters.AddWithValue("@Department", comboBox2.Text);

                conn.Open();
                komutt.ExecuteNonQuery();
                MessageBox.Show("Kayıt güncellendi.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata meydana geldi");
            }
            conn.Close();
            MüsteriGetir();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            foreach (Control item in this.Controls)
            {
                if (item is TextBox)
                {
                    (item as TextBox).Clear();
                }
            }
            comboBox1.Text = "";
            comboBox2.Text = "";
            textBox7.Text = "";

        }

        private void txtcocuksayısı_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
      (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void dataGridView1_CellEnter_1(object sender, DataGridViewCellEventArgs e)
        {
            comboBox1.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txtad.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            txtsoyad.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            txtcalısmayılı.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            txtmaas.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            txtsatıs.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            comboBox2.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
            textBox7.Text = dataGridView1.CurrentRow.Cells[8].Value.ToString();
            txtcocuksayısı.Text = dataGridView1.CurrentRow.Cells["NumberOfChildren"].Value.ToString();



        }

        private void button6_Click(object sender, EventArgs e)
        {
            FormMain anaMenü = new FormMain();
            this.Hide();
            anaMenü.ShowDialog();
        }
    }
}
