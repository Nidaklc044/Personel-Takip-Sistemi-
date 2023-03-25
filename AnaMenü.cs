using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ntpödevi
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PersonelIşlemleri personelIşlemleri = new PersonelIşlemleri();
            this.Hide();
            personelIşlemleri.ShowDialog();
        
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MaasIslemleri maasIslemleri = new MaasIslemleri();
            this.Hide();
            maasIslemleri.ShowDialog();
       

        }

        private void button3_Click(object sender, EventArgs e)
        {
        IzınTakip izintakip =new IzınTakip();
            this.Hide();
            izintakip.ShowDialog();
      

        }

        private void button4_Click(object sender, EventArgs e)
        {
            FormBolum calıstıgıbolum= new FormBolum();
            this.Hide();
            calıstıgıbolum.ShowDialog();
       


        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            this.Hide();
            form1.ShowDialog();
        }
    }
}
