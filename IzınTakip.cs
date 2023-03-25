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
    public partial class IzınTakip : Form
    {
        public double totalizin,farkizin;

        SqlConnection connn;
        SqlCommand komuttt;
        public IzınTakip()
        {
            InitializeComponent();
        }
        public void MüsteriGetirr()
        {
            connn = new SqlConnection("Data Source=DESKTOP-U7FCHSD;Initial Catalog=ntp;Integrated Security=True");
            string Select = " Select * From tblIzin";
            SqlDataAdapter adapter = new SqlDataAdapter(Select, connn);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;
            connn.Close();
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void IzınTakip_Load(object sender, EventArgs e)
        {
            MüsteriGetirr();
            SqlCommand komutt = new SqlCommand("select* from tblPersonelInfo", connn);
            SqlDataReader reader;
            connn.Open();
            reader = komutt.ExecuteReader();

            while (reader.Read())
            {
                comboBox2.Items.Add(reader["TC"]);


            }
            connn.Close();

            dateend.MinDate = DateTime.Now.AddDays(1);
            datestart.MinDate = DateTime.Now;

        }
  private void GetDepartment()
        {
            SqlCommand komuttt = new SqlCommand("select distinct  Department  from MaasIslemler Where Tc='"+comboBox2.Text+"'", connn);
            SqlDataReader readerr;
            connn.Open();
            readerr = komuttt.ExecuteReader();

            while (readerr.Read())
            {
                txtDepart.Text=(readerr["Department"].ToString());

              
            }
            connn.Close();
            IzınGetir();
        }
        private void IzınGetir()
        {


            SqlCommand komuttt = new SqlCommand("select distinct  BölümIzni  from tblIzınSayisi Where Bölüm='" + txtDepart.Text + "'", connn);
            SqlDataReader readerr;
            connn.Open();
            readerr = komuttt.ExecuteReader();

            while (readerr.Read())
            {
                txtizin.Text = (readerr["BölümIzni"].ToString());


            }
            connn.Close();




        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

            //textBox8.Text = txtDepart.Text;
            adGetir();
            GetDepartment();
        }
        public void adGetir()
        {
            SqlCommand komutt = new SqlCommand("select* from tblPersonelInfo Where Tc=@tc", connn);
            komutt.Parameters.AddWithValue("@tc", comboBox2.Text);
            SqlDataReader reader;
            connn.Open();
            reader = komutt.ExecuteReader();
            while (reader.Read())
            {

                textBox8.Text = ((string)reader["Name"].ToString());
            }
            connn.Close();


        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            comboBox2.Text = dataGridView1.CurrentRow.Cells["TC"].Value.ToString();
            textBox8.Text = dataGridView1.CurrentRow.Cells["Name"].Value.ToString();
            txtDepart.Text = dataGridView1.CurrentRow.Cells["CalistiğiBirim"].Value.ToString();
            txtizin.Text = dataGridView1.CurrentRow.Cells["HakkettiğiI"].Value.ToString();
            txttoplam.Text = dataGridView1.CurrentRow.Cells["ToplamI"].Value.ToString();
            textBox4.Text = dataGridView1.CurrentRow.Cells["GecenYildanK"].Value.ToString();
            txtkalan.Text = dataGridView1.CurrentRow.Cells["KIzin"].Value.ToString();
        }
      
        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (totalizin > 120)
            {
                MessageBox.Show("En fazla 120 gün izin verilebilir");

                totalizin = 120;
            }
            else
            {
                totalizin = totalizin;
                IzınVer();

            }




            
        }


        private void IzınVer()
        {
            string sorgu = "INSERT INTO tblIzin(TC,[Name],CalistiğiBirim,GecenYildanK,HakkettiğiI,ToplamI,IBas,IBts,KIzin) " +
              "VALUES (@TC,@Name,@CalistiğiBirim,@GecenYildanK,@HakkettiğiI,@ToplamI,@IBas,@IBts,@KIzin)";

            komuttt = new SqlCommand(sorgu, connn);

            komuttt.Parameters.AddWithValue("@TC", comboBox2.Text);
            komuttt.Parameters.AddWithValue("@Name", textBox8.Text);
            komuttt.Parameters.AddWithValue("@CalistiğiBirim", txtDepart.Text);
            komuttt.Parameters.AddWithValue("@GecenYildanK", textBox4.Text);
            komuttt.Parameters.AddWithValue("@HakkettiğiI", txtizin.Text);

            komuttt.Parameters.AddWithValue("@ToplamI", txttoplam.Text);
            komuttt.Parameters.AddWithValue("@IBas", SqlDbType.DateTime2).Value = datestart.Value.Date;
            komuttt.Parameters.AddWithValue("@IBts", SqlDbType.DateTime2).Value = dateend.Value.Date;
            komuttt.Parameters.AddWithValue("@KIzin", txtkalan.Text);
            connn.Open();


            komuttt.ExecuteNonQuery();

            MessageBox.Show("Kayıt eklendi.");
            MüsteriGetirr();



        }

        private void button3_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dataGridView1.SelectedRows.Count; i++)
            {
                int id = Convert.ToInt32(dataGridView1.SelectedRows[i].Cells["id"].Value);
                string sorgu = "DELETE FROM tblIzin WHERE id=@id ";
                komuttt = new SqlCommand(sorgu, connn);
                komuttt.Parameters.AddWithValue("@id", id);

                connn.Open();
                komuttt.ExecuteNonQuery();
                MessageBox.Show("Kayıt silindi.");
                connn.Close();
                MüsteriGetirr();

            }

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
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBox4.Text = txtDepart.Text;
            BolumGetir();

        }
        
        public void BolumGetir()
        {

            SqlCommand komutt = new SqlCommand("select* from tblIzınSayisi where Bölüm=@Bölüm", connn);
            komutt.Parameters.AddWithValue("@Bölüm", txtDepart.Text);
            SqlDataReader reader;
            connn.Open();
            reader = komutt.ExecuteReader();
            while (reader.Read())
            {

                textBox4.Text = ((string)reader["BölümIzni"].ToString());

            }
            connn.Close();

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            int sayi1, sayi2, sayi3, sayi4;

            if (textBox4.Text == "0" || textBox4.Text == null || textBox4.Text == "" || textBox4.Text.Length < 1)
            {
                sayi1 = 0;
            }
            else if(Convert.ToInt32(textBox4.Text)>365)
            {
                MessageBox.Show("İzin sayısı 365 den buyuk olamaz");
                textBox4.Text = "365";
                sayi1 = 365;
            }
            else
            {

                sayi1 = Convert.ToInt32(textBox4.Text);

            }

            if (txtizin.Text == "0" || txtizin.Text == null || txtizin.Text == "" || txtizin.Text.Length < 1)
            {
                sayi2 = 0;
            }
            else
            {

                sayi2 = Convert.ToInt32(txtizin.Text);

            }
            ;
            double sonuc = sayi1 + sayi2;
            txttoplam.Text = sonuc.ToString();
            farkizin = sonuc;

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            int sayi1, sayi2, sayi3, sayi4;

            if (txtizin.Text == "0" || txtizin.Text == null || txtizin.Text == "" || txtizin.Text.Length < 1)
            {
                sayi1 = 0;
            }
            else 
            {

                sayi1 = Convert.ToInt32(txtizin.Text);

            }

            if (txttoplam.Text == "0" || txttoplam.Text == null || txttoplam.Text == "" || txttoplam.Text.Length < 1)
            {
                sayi2 = 0;
            }
            else
            {

                sayi2 = Convert.ToInt32(txttoplam.Text);

            }
            ;
           
         
        }

        private void button2_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dataGridView1.SelectedRows.Count; i++)
            {
                int id = Convert.ToInt32(dataGridView1.SelectedRows[i].Cells["id"].Value);
                string tc = dataGridView1.SelectedRows[i].Cells["TC"].Value.ToString();

                string sorgu = "UPDATE tblIzin SET TC=@TC,[Name]=@Name,CalistiğiBirim=@CalistiğiBirim,GecenYildanK=@GecenYildanK,HakkettiğiI=@HakkettiğiI,ToplamI=@ToplamI,IBas=@IBas,IBts=@IBts,KIzin=@KIzin where id="+id+" ";


                komuttt = new SqlCommand(sorgu, connn);
              
                komuttt.Parameters.AddWithValue("@TC", comboBox2.Text);
                komuttt.Parameters.AddWithValue("@Name", textBox8.Text);
                komuttt.Parameters.AddWithValue("@CalistiğiBirim", txtDepart.Text);
                komuttt.Parameters.AddWithValue("@GecenYildanK", textBox4.Text);
                komuttt.Parameters.AddWithValue("@HakkettiğiI", txtizin.Text);

                komuttt.Parameters.AddWithValue("@ToplamI", txttoplam.Text);
                komuttt.Parameters.AddWithValue("@IBas", SqlDbType.DateTime2).Value = datestart.Value.Date;
                komuttt.Parameters.AddWithValue("@IBts", SqlDbType.DateTime2).Value = dateend.Value.Date;
                komuttt.Parameters.AddWithValue("@KIzin", txtkalan.Text);
                connn.Open();


                komuttt.ExecuteNonQuery();

                MessageBox.Show("Kayıt güncellendi.");
                MüsteriGetirr();

            }
        }

            private void comboBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
            if ((int)e.KeyChar == 32)
            {
                e.Handled = true;
            }
        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
            if ((int)e.KeyChar == 32)
            {
                e.Handled = true;
            }
        }

        private void txttoplam_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
            if ((int)e.KeyChar == 32)
            {
                e.Handled = true;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            FormMain anaMenü = new FormMain();
            this.Hide();
            anaMenü.ShowDialog();
        }

        private void dateend_ValueChanged(object sender, EventArgs e)
        {
            dateend.MinDate = DateTime.Now.AddDays(1);  //mınumum tarıhı bugune ayarladık
            DateTime end = dateend.Value.Date;
            DateTime start = datestart.Value.Date;
            double fark = (end - start).TotalDays;
            totalizin = fark;
            txtkalan.Text = (farkizin - totalizin).ToString();

        }
    }
}

