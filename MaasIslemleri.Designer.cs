namespace ntpödevi
{
    partial class MaasIslemleri
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.personelid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OperationTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NumberOfChildren = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SalesAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Department = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Salary = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IsDeleted = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtsatıs = new System.Windows.Forms.TextBox();
            this.txtcocuksayısı = new System.Windows.Forms.TextBox();
            this.txtmaas = new System.Windows.Forms.TextBox();
            this.txtcalısmayılı = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtsoyad = new System.Windows.Forms.TextBox();
            this.txtad = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtDate = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.personelid,
            this.TC,
            this.Ad,
            this.Name,
            this.OperationTime,
            this.NumberOfChildren,
            this.SalesAmount,
            this.Department,
            this.Salary,
            this.IsDeleted});
            this.dataGridView1.Location = new System.Drawing.Point(12, 200);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(764, 238);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellEnter_1);
            // 
            // personelid
            // 
            this.personelid.DataPropertyName = "personelid";
            this.personelid.HeaderText = "Sicil No";
            this.personelid.Name = "personelid";
            this.personelid.ReadOnly = true;
            // 
            // TC
            // 
            this.TC.DataPropertyName = "TC";
            this.TC.HeaderText = "Tc";
            this.TC.Name = "TC";
            this.TC.ReadOnly = true;
            // 
            // Ad
            // 
            this.Ad.DataPropertyName = "Name";
            this.Ad.HeaderText = "Ad";
            this.Ad.Name = "Ad";
            this.Ad.ReadOnly = true;
            // 
            // Name
            // 
            this.Name.DataPropertyName = "Surname";
            this.Name.HeaderText = "Soyad";
            this.Name.Name = "Name";
            this.Name.ReadOnly = true;
            // 
            // OperationTime
            // 
            this.OperationTime.DataPropertyName = "OperationTime";
            this.OperationTime.HeaderText = "Çalışma Yılı";
            this.OperationTime.Name = "OperationTime";
            this.OperationTime.ReadOnly = true;
            // 
            // NumberOfChildren
            // 
            this.NumberOfChildren.DataPropertyName = "NumberOfChildren";
            this.NumberOfChildren.HeaderText = "Çocuk Sayısı";
            this.NumberOfChildren.Name = "NumberOfChildren";
            this.NumberOfChildren.ReadOnly = true;
            // 
            // SalesAmount
            // 
            this.SalesAmount.DataPropertyName = "SalesAmount";
            this.SalesAmount.HeaderText = "Satış Sayısı";
            this.SalesAmount.Name = "SalesAmount";
            this.SalesAmount.ReadOnly = true;
            // 
            // Department
            // 
            this.Department.DataPropertyName = "Department";
            this.Department.HeaderText = "Bölüm";
            this.Department.Name = "Department";
            this.Department.ReadOnly = true;
            // 
            // Salary
            // 
            this.Salary.DataPropertyName = "Salary";
            this.Salary.HeaderText = "Maaş";
            this.Salary.Name = "Salary";
            this.Salary.ReadOnly = true;
            // 
            // IsDeleted
            // 
            this.IsDeleted.DataPropertyName = "IsDeleted";
            this.IsDeleted.HeaderText = "IsDeleted";
            this.IsDeleted.Name = "IsDeleted";
            this.IsDeleted.ReadOnly = true;
            this.IsDeleted.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "TC";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 26);
            this.label2.TabIndex = 2;
            this.label2.Text = "Çalışma\r\n Yılı";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 142);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Maaş";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(302, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 26);
            this.label4.TabIndex = 4;
            this.label4.Text = "Çocuk\r\n Sayısı";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(302, 50);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 26);
            this.label5.TabIndex = 5;
            this.label5.Text = "Satış\r\nMiktarı";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(302, 87);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(36, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Bölüm";
            // 
            // txtsatıs
            // 
            this.txtsatıs.Location = new System.Drawing.Point(350, 50);
            this.txtsatıs.Name = "txtsatıs";
            this.txtsatıs.Size = new System.Drawing.Size(121, 20);
            this.txtsatıs.TabIndex = 9;
            this.txtsatıs.TextChanged += new System.EventHandler(this.txtsatıs_TextChanged);
            // 
            // txtcocuksayısı
            // 
            this.txtcocuksayısı.Location = new System.Drawing.Point(350, 13);
            this.txtcocuksayısı.MaxLength = 32700;
            this.txtcocuksayısı.Name = "txtcocuksayısı";
            this.txtcocuksayısı.Size = new System.Drawing.Size(121, 20);
            this.txtcocuksayısı.TabIndex = 10;
            this.txtcocuksayısı.TextChanged += new System.EventHandler(this.txtcocuksayısı_TextChanged);
            this.txtcocuksayısı.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtcocuksayısı_KeyPress);
            // 
            // txtmaas
            // 
            this.txtmaas.Location = new System.Drawing.Point(71, 135);
            this.txtmaas.Name = "txtmaas";
            this.txtmaas.ReadOnly = true;
            this.txtmaas.Size = new System.Drawing.Size(100, 20);
            this.txtmaas.TabIndex = 11;
            this.txtmaas.TextChanged += new System.EventHandler(this.txtmaas_TextChanged);
            // 
            // txtcalısmayılı
            // 
            this.txtcalısmayılı.Location = new System.Drawing.Point(71, 107);
            this.txtcalısmayılı.Name = "txtcalısmayılı";
            this.txtcalısmayılı.ReadOnly = true;
            this.txtcalısmayılı.Size = new System.Drawing.Size(100, 20);
            this.txtcalısmayılı.TabIndex = 12;
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(350, 135);
            this.textBox7.Name = "textBox7";
            this.textBox7.ReadOnly = true;
            this.textBox7.Size = new System.Drawing.Size(121, 20);
            this.textBox7.TabIndex = 13;
            this.textBox7.TextChanged += new System.EventHandler(this.textBox7_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(296, 129);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(42, 26);
            this.label7.TabIndex = 14;
            this.label7.Text = "Toplam\r\nMaaş";
            // 
            // txtsoyad
            // 
            this.txtsoyad.Location = new System.Drawing.Point(71, 75);
            this.txtsoyad.Name = "txtsoyad";
            this.txtsoyad.ReadOnly = true;
            this.txtsoyad.Size = new System.Drawing.Size(100, 20);
            this.txtsoyad.TabIndex = 15;
            // 
            // txtad
            // 
            this.txtad.Location = new System.Drawing.Point(71, 39);
            this.txtad.Name = "txtad";
            this.txtad.ReadOnly = true;
            this.txtad.Size = new System.Drawing.Size(100, 20);
            this.txtad.TabIndex = 16;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(27, 43);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(20, 13);
            this.label8.TabIndex = 17;
            this.label8.Text = "Ad";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(27, 79);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(37, 13);
            this.label9.TabIndex = 18;
            this.label9.Text = "Soyad";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(646, 33);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 19;
            this.button1.Text = "KAYDET";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(646, 59);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 20;
            this.button2.Text = "SİL";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(646, 87);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 21;
            this.button3.Text = "DÜZENLE";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(71, 13);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(100, 21);
            this.comboBox1.TabIndex = 22;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(350, 88);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 21);
            this.comboBox2.TabIndex = 23;
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(27, 168);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(57, 13);
            this.label10.TabIndex = 24;
            this.label10.Text = "İşe Giriş T:";
            // 
            // txtDate
            // 
            this.txtDate.Location = new System.Drawing.Point(90, 165);
            this.txtDate.Name = "txtDate";
            this.txtDate.ReadOnly = true;
            this.txtDate.Size = new System.Drawing.Size(144, 20);
            this.txtDate.TabIndex = 25;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(646, 116);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 26;
            this.button4.Text = "TEMİZLE";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(646, 145);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 23);
            this.button6.TabIndex = 28;
            this.button6.Text = "GERİ";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // MaasIslemleri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ntpödevi.Properties.Resources.sayfa12;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.txtDate);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtad);
            this.Controls.Add(this.txtsoyad);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.txtcalısmayılı);
            this.Controls.Add(this.txtmaas);
            this.Controls.Add(this.txtcocuksayısı);
            this.Controls.Add(this.txtsatıs);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.DoubleBuffered = true;
           
            this.Load += new System.EventHandler(this.MaasIslemleri_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtsatıs;
        private System.Windows.Forms.TextBox txtcocuksayısı;
        private System.Windows.Forms.TextBox txtmaas;
        private System.Windows.Forms.TextBox txtcalısmayılı;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtsoyad;
        private System.Windows.Forms.TextBox txtad;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtDate;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.DataGridViewTextBoxColumn personelid;
        private System.Windows.Forms.DataGridViewTextBoxColumn TC;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn OperationTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumberOfChildren;
        private System.Windows.Forms.DataGridViewTextBoxColumn SalesAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn Department;
        private System.Windows.Forms.DataGridViewTextBoxColumn Salary;
        private System.Windows.Forms.DataGridViewTextBoxColumn IsDeleted;
        private System.Windows.Forms.Button button6;
    }
}