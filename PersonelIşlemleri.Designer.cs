namespace ntpödevi
{
    partial class PersonelIşlemleri
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PersonelIşlemleri));
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txttc = new System.Windows.Forms.TextBox();
            this.txtad = new System.Windows.Forms.TextBox();
            this.txtsoyad = new System.Windows.Forms.TextBox();
            this.txttel = new System.Windows.Forms.TextBox();
            this.txtmail = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.SilindiMi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ıdkısmı = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblPersonelInfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ntpDataSet1 = new ntpödevi.ntpDataSet1();
            this.tblPersonelInfoTableAdapter = new ntpödevi.ntpDataSet1TableAdapters.tblPersonelInfoTableAdapter();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.ntpDataSet2 = new ntpödevi.ntpDataSet();
            this.button5 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblPersonelInfoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ntpDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ntpDataSet2)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(606, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tc";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(606, 147);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(20, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Ad";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(606, 174);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Soyad";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(606, 203);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Tel No";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(606, 234);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(26, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Mail";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(598, 264);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(40, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "Giriş T.";
            // 
            // txttc
            // 
            this.txttc.Location = new System.Drawing.Point(648, 120);
            this.txttc.MaxLength = 11;
            this.txttc.Name = "txttc";
            this.txttc.Size = new System.Drawing.Size(100, 20);
            this.txttc.TabIndex = 9;
            this.txttc.TextChanged += new System.EventHandler(this.txttc_TextChanged);
            this.txttc.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txttc_KeyPress);
            // 
            // txtad
            // 
            this.txtad.Location = new System.Drawing.Point(648, 147);
            this.txtad.Name = "txtad";
            this.txtad.Size = new System.Drawing.Size(100, 20);
            this.txtad.TabIndex = 10;
            this.txtad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtad_KeyPress);
            // 
            // txtsoyad
            // 
            this.txtsoyad.Location = new System.Drawing.Point(648, 174);
            this.txtsoyad.Name = "txtsoyad";
            this.txtsoyad.Size = new System.Drawing.Size(100, 20);
            this.txtsoyad.TabIndex = 11;
            this.txtsoyad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtsoyad_KeyPress);
            // 
            // txttel
            // 
            this.txttel.Location = new System.Drawing.Point(648, 203);
            this.txttel.Name = "txttel";
            this.txttel.Size = new System.Drawing.Size(100, 20);
            this.txttel.TabIndex = 12;
            this.txttel.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txttel_KeyPress);
            // 
            // txtmail
            // 
            this.txtmail.Location = new System.Drawing.Point(648, 234);
            this.txtmail.Name = "txtmail";
            this.txtmail.Size = new System.Drawing.Size(100, 20);
            this.txtmail.TabIndex = 13;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SilindiMi,
            this.ıdkısmı});
            this.dataGridView1.Location = new System.Drawing.Point(10, 60);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(548, 348);
            this.dataGridView1.TabIndex = 16;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellEnter);
            // 
            // SilindiMi
            // 
            this.SilindiMi.DataPropertyName = "Deleted";
            this.SilindiMi.HeaderText = "Column1";
            this.SilindiMi.Name = "SilindiMi";
            this.SilindiMi.ReadOnly = true;
            this.SilindiMi.Visible = false;
            // 
            // ıdkısmı
            // 
            this.ıdkısmı.DataPropertyName = "Id";
            this.ıdkısmı.HeaderText = "Column1";
            this.ıdkısmı.Name = "ıdkısmı";
            this.ıdkısmı.ReadOnly = true;
            this.ıdkısmı.Visible = false;
            // 
            // tblPersonelInfoBindingSource
            // 
            this.tblPersonelInfoBindingSource.DataMember = "tblPersonelInfo";
            this.tblPersonelInfoBindingSource.DataSource = this.ntpDataSet1;
            // 
            // ntpDataSet1
            // 
            this.ntpDataSet1.DataSetName = "ntpDataSet1";
            this.ntpDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblPersonelInfoTableAdapter
            // 
            this.tblPersonelInfoTableAdapter.ClearBeforeFill = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(600, 303);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 18;
            this.button2.Text = "EKLE";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(97, 31);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 19;
            this.button3.Text = "SİL";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(698, 303);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 20;
            this.button4.Text = "GÜNCELLE";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(197, 31);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 21;
            this.button1.Text = "TEMİZLE";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(648, 264);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(2);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(100, 20);
            this.dateTimePicker1.TabIndex = 22;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // ntpDataSet2
            // 
            this.ntpDataSet2.DataSetName = "ntpDataSet";
            this.ntpDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(10, 31);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 23;
            this.button5.Text = "GERİ";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // PersonelIşlemleri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtmail);
            this.Controls.Add(this.txttel);
            this.Controls.Add(this.txtsoyad);
            this.Controls.Add(this.txtad);
            this.Controls.Add(this.txttc);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.Color.DarkBlue;
            this.Name = "PersonelIşlemleri";
            this.Text = "PersonelIşlemleri";
            this.Load += new System.EventHandler(this.PersonelIşlemleri_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblPersonelInfoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ntpDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ntpDataSet2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txttc;
        private System.Windows.Forms.TextBox txtad;
        private System.Windows.Forms.TextBox txtsoyad;
        private System.Windows.Forms.TextBox txttel;
        private System.Windows.Forms.TextBox txtmail;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn SilindiMi;
        private System.Windows.Forms.DataGridViewTextBoxColumn ıdkısmı;
        private ntpDataSet1 ntpDataSet1;
        private System.Windows.Forms.BindingSource tblPersonelInfoBindingSource;
        private ntpDataSet1TableAdapters.tblPersonelInfoTableAdapter tblPersonelInfoTableAdapter;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private ntpDataSet ntpDataSet2;
        private System.Windows.Forms.Button button5;
    }
}