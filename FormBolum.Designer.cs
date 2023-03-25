namespace ntpödevi
{
    partial class FormBolum
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
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Surname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Department = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Durum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.labelad = new System.Windows.Forms.Label();
            this.txtad = new System.Windows.Forms.TextBox();
            this.txttc = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtsoyad = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.txtbolum = new System.Windows.Forms.TextBox();
            this.txtdurum = new System.Windows.Forms.ComboBox();
            this.button4 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.Tc,
            this.Name,
            this.Surname,
            this.Department,
            this.Durum});
            this.dataGridView1.Location = new System.Drawing.Point(117, 187);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(543, 240);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // id
            // 
            this.id.DataPropertyName = "id";
            this.id.HeaderText = "id";
            this.id.Name = "id";
            this.id.Visible = false;
            // 
            // Tc
            // 
            this.Tc.DataPropertyName = "Tc";
            this.Tc.HeaderText = "Tc";
            this.Tc.Name = "Tc";
            // 
            // Name
            // 
            this.Name.DataPropertyName = "Name";
            this.Name.HeaderText = "Ad";
            this.Name.Name = "Name";
            // 
            // Surname
            // 
            this.Surname.DataPropertyName = "Surname";
            this.Surname.HeaderText = "Soyad";
            this.Surname.Name = "Surname";
            // 
            // Department
            // 
            this.Department.DataPropertyName = "Department";
            this.Department.HeaderText = "Bölüm";
            this.Department.Name = "Department";
            // 
            // Durum
            // 
            this.Durum.DataPropertyName = "Durum";
            this.Durum.HeaderText = "Durum";
            this.Durum.Name = "Durum";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(85, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "TC";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(272, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Çalıştığı Bölüm";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(283, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Durum";
            // 
            // labelad
            // 
            this.labelad.AutoSize = true;
            this.labelad.Location = new System.Drawing.Point(86, 93);
            this.labelad.Name = "labelad";
            this.labelad.Size = new System.Drawing.Size(20, 13);
            this.labelad.TabIndex = 6;
            this.labelad.Text = "Ad";
            // 
            // txtad
            // 
            this.txtad.Location = new System.Drawing.Point(131, 90);
            this.txtad.Name = "txtad";
            this.txtad.Size = new System.Drawing.Size(121, 20);
            this.txtad.TabIndex = 10;
            // 
            // txttc
            // 
            this.txttc.FormattingEnabled = true;
            this.txttc.Location = new System.Drawing.Point(131, 46);
            this.txttc.Name = "txttc";
            this.txttc.Size = new System.Drawing.Size(121, 21);
            this.txttc.TabIndex = 14;
            this.txttc.SelectedIndexChanged += new System.EventHandler(this.txttc_SelectedIndexChanged);
            this.txttc.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txttc_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(86, 135);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "Soyad";
            // 
            // txtsoyad
            // 
            this.txtsoyad.Location = new System.Drawing.Point(129, 128);
            this.txtsoyad.Name = "txtsoyad";
            this.txtsoyad.Size = new System.Drawing.Size(123, 20);
            this.txtsoyad.TabIndex = 16;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(654, 43);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 17;
            this.button1.Text = "KAYDET";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(654, 83);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 18;
            this.button2.Text = "GÜNCELLE";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(654, 118);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 19;
            this.button3.Text = "TEMİZLE";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // txtbolum
            // 
            this.txtbolum.Location = new System.Drawing.Point(362, 46);
            this.txtbolum.Name = "txtbolum";
            this.txtbolum.Size = new System.Drawing.Size(123, 20);
            this.txtbolum.TabIndex = 21;
            // 
            // txtdurum
            // 
            this.txtdurum.FormattingEnabled = true;
            this.txtdurum.Items.AddRange(new object[] {
            "Çalışan",
            "Ayrıldı"});
            this.txtdurum.Location = new System.Drawing.Point(350, 82);
            this.txtdurum.Name = "txtdurum";
            this.txtdurum.Size = new System.Drawing.Size(121, 21);
            this.txtdurum.TabIndex = 8;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(654, 158);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 22;
            this.button4.Text = "GERİ";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // FormBolum
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.BackgroundImage = global::ntpödevi.Properties.Resources.sayfa14;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.txtbolum);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtsoyad);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txttc);
            this.Controls.Add(this.txtad);
            this.Controls.Add(this.txtdurum);
            this.Controls.Add(this.labelad);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.DoubleBuffered = true;
         
            this.Text = "Deparmant";
            this.Load += new System.EventHandler(this.ÇalıştığıBölüm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelad;
        private System.Windows.Forms.TextBox txtad;
        private System.Windows.Forms.ComboBox txttc;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtsoyad;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox txtbolum;
        private System.Windows.Forms.ComboBox txtdurum;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tc;
        private System.Windows.Forms.DataGridViewTextBoxColumn Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Surname;
        private System.Windows.Forms.DataGridViewTextBoxColumn Department;
        private System.Windows.Forms.DataGridViewTextBoxColumn Durum;
        private System.Windows.Forms.Button button4;
    }
}