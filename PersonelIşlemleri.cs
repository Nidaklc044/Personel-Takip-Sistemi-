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
    public partial class PersonelIşlemleri : Form
    {
        SqlConnection con;
        SqlCommand komut;
        SqlDataAdapter da;
        public PersonelIşlemleri()
        {
            InitializeComponent();
            txttc.Text = "11111111111";
            txtmail.Text = "as@gmail.com";
            txtsoyad.Text = "testsoyad";
            txtad.Text = "testad";
            txttel.Text = "05411471201";




        }


        //yapılan ıslem eger tc varsa durum= false
        //durum kontrol mekanızması olarak kullanıldı(durum=ıslem engellenesınmı)
        //tc verı tabanında yok ıse durum true ısleme devam et metodu buton clıck eventda calıstırıyoruz
        bool durum;
        void TcVarMı()
        {

            con = new SqlConnection("Data Source=DESKTOP-U7FCHSD;Initial Catalog=ntp;Integrated Security=True");
            con.Open();
            SqlCommand komut = new SqlCommand("Select  TC FROM tblPersonelInfo WHERE Tc=@TC", con);
            komut.Parameters.AddWithValue("@TC", SqlDbType.NVarChar).Value = txttc.Text;
            SqlDataReader dr = komut.ExecuteReader();
            if (dr.Read())
            {
                durum = false;
                MessageBox.Show("Tc numarası zaten kayıtlı");
            }
            else
            {
                durum = true;
            }

            con.Close();
        }



        //musteri listele
        public void MüsteriGetir()
        {
            con = new SqlConnection("Data Source=DESKTOP-U7FCHSD;Initial Catalog=ntp;Integrated Security=True");
            string Select = " Select * From tblPersonelInfo Where Deleted=0";
            SqlDataAdapter adapter = new SqlDataAdapter(Select, con);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }
        //private void button1_Click(object sender, EventArgs e)
        //{
        //    MüsteriGetir();
        //}

        private void PersonelIşlemleri_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'ntpDataSet1.tblPersonelInfo' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            MüsteriGetir();
        }

        public void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {

            txttc.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txtad.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            txtsoyad.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            txttel.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            txtmail.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
        }


        //tc ad soyad tel maıl bılgılerı varmı yokmu kontrol edıldı
        //eger tum sartlar yerınde ıse tc varmı metodu calıstırıldı
        //tc varmı dan durum degıskenı sonucu dondu
        //durum true ıse ıslemın yapılmasını ıstendı if blogu ıcerısınde
        //datetimepicker /c# zaman bılgııs almak ıcın yardımcı companent eklendı
        //sılme ıslemlerı ıcın deleted degıl update kullanıldı
        //sılınen kayıtların verıtabanındakı deleted sutunu true olarak ısaretlendı
        //tablo sonucu yazdırılırken de where sartı ıle deleted=0 olan kayıtlar sorgulandı boylece verı kaybı olmadan sadece kaydın sılındıgı bılgısı kullanıcı ekranına verıldı
        //verıtabanına date sutunu eklendı(kullanıcı datetimepickerdan ıstedıgı tarıhı secerek gecmıs ıslem yapabılır
        //tc sutunu bıgınt olarak olusturulmustu hatalı nvarchar olarak degıstırıldı
        //SqlDbType seklınde yazılan kodlar program ıle verıtabanı arasında verı donusumlerı saglamak ve olası sorunları engellemek ıcın kullanılan yardımcı c# kodudur.Saglıklı olan tum verıler ıcın sqldbtype kullanılmasıdır


        public void button2_Click(object sender, EventArgs e)
        {
            con = new SqlConnection("Data Source=DESKTOP-U7FCHSD;Initial Catalog=ntp;Integrated Security=True");
            con.Open();


            string sorgu = "INSERT INTO tblPersonelInfo(TC,[Name],Surname,PhoneNumber,Mail,Date) VALUES (@TC,@Name,@Surname,@PhoneNumber,@Mail,@Date)";

            komut = new SqlCommand(sorgu, con);


            if (txttc.Text == null || txttc.Text.Length < 11)
            {
                MessageBox.Show("Lutfen 11 haneli Tc No giriniz");
                return;

            }

            if (txtad.Text == null || txtad.Text.Length < 2)  // bos olamaz ve en az 3 karakter Ali
            {
                MessageBox.Show("Lutfen Ad  alanını doldurunuz");
                return;


            }


            if (txtsoyad.Text == null || txtsoyad.Text.Length < 2) // bos olamaz ve en az 3 karakter 
            {
                MessageBox.Show("Lutfen soyad  alanını doldurunuz");
                return;


            }

            if (txtmail.Text == null || txtmail.Text.Length < 10) // bos olamaz ve en az 11 karakter 
            {
                MessageBox.Show("Lutfen mail  alanını doldurunuz");
                return;


            }
            if (txttel.Text == null || txttel.Text.Length < 10)
            {
                MessageBox.Show("Lutfen 11 haneli telefon numarası giriniz");
                return;


            }

            else
            {


                TcVarMı();
                if (durum == true)
                {


                    komut.Parameters.AddWithValue("@TC", SqlDbType.NVarChar).Value = txttc.Text.ToString();
                    komut.Parameters.AddWithValue("@Name", txtad.Text);
                    komut.Parameters.AddWithValue("@Surname", txtsoyad.Text);
                    komut.Parameters.AddWithValue("@PhoneNumber", txttel.Text);
                    komut.Parameters.AddWithValue("@Mail", txtmail.Text);
                    komut.Parameters.AddWithValue("@Date", SqlDbType.DateTime2).Value = dateTimePicker1.Value.Date;

                    komut.ExecuteNonQuery();

                    MessageBox.Show("Kayıt eklendi.");
                }


            }


            MüsteriGetir();
            con.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string sorgu = "UPDATE  tblPersonelInfo SET Deleted=1 WHERE TC=@tc ";
            komut = new SqlCommand(sorgu, con);
            komut.Parameters.AddWithValue("tc", Convert.ToInt64(txttc.Text));

            con.Open();
            komut.ExecuteNonQuery();
            MessageBox.Show("Kayıt silindi.");
            con.Close();
            MüsteriGetir();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string sorgu = "UPDATE tblPersonelInfo SET [Name]=@Name,Surname=@Surname,PhoneNumber=@PhoneNumber,Mail=@Mail WHERE TC=@TC";
            komut = new SqlCommand(sorgu, con);
            komut.Parameters.AddWithValue("@TC", txttc.Text);
            komut.Parameters.AddWithValue("@Name", txtad.Text);
            komut.Parameters.AddWithValue("@Surname", txtsoyad.Text);
            komut.Parameters.AddWithValue("@PhoneNumber", txttel.Text);
            komut.Parameters.AddWithValue("@Mail", txtmail.Text);

            komut.Parameters.AddWithValue("@DateOfEntry", SqlDbType.DateTime2).Value = dateTimePicker1.Value.Date;
            con.Open();
            komut.ExecuteNonQuery();
            MessageBox.Show("Kayıt güncellendi.");
            con.Close();
            MüsteriGetir();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txttc_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            foreach (Control item in this.Controls)
            {
                if (item is TextBox)
                {
                    (item as TextBox).Clear();
                }
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

        private void txttel_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
            if ((int)e.KeyChar == 32)
            {
                e.Handled = true;
            }
        }

        private void txtgiris_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
            if ((int)e.KeyChar == 32)
            {
                e.Handled = true;
            }
        }

        private void txtad_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsSeparator(e.KeyChar);
        }

        private void txtsoyad_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsSeparator(e.KeyChar);
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            FormMain anaMenü = new FormMain();
            this.Hide();
            anaMenü.ShowDialog();
        }
    }
}
