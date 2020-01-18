namespace MultiFaceRec
{
    partial class FrmPrincipal
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.buttonView = new System.Windows.Forms.Button();
            this.buttonAll = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.password = new System.Windows.Forms.TextBox();
            this.username = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxDate = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Black;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(553, 70);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(211, 46);
            this.button1.TabIndex = 0;
            this.button1.Text = "Start Attendance";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Visible = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Black;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(313, 71);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(195, 46);
            this.button2.TabIndex = 1;
            this.button2.Text = "Register Student";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Visible = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 225);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(587, 351);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.Visible = false;
            // 
            // buttonView
            // 
            this.buttonView.BackColor = System.Drawing.Color.Black;
            this.buttonView.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonView.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonView.ForeColor = System.Drawing.Color.White;
            this.buttonView.Location = new System.Drawing.Point(444, 177);
            this.buttonView.Name = "buttonView";
            this.buttonView.Size = new System.Drawing.Size(148, 29);
            this.buttonView.TabIndex = 5;
            this.buttonView.Text = "View Record";
            this.buttonView.UseVisualStyleBackColor = false;
            this.buttonView.Visible = false;
            this.buttonView.Click += new System.EventHandler(this.buttonView_Click);
            // 
            // buttonAll
            // 
            this.buttonAll.BackColor = System.Drawing.Color.Black;
            this.buttonAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAll.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAll.ForeColor = System.Drawing.Color.White;
            this.buttonAll.Location = new System.Drawing.Point(810, 70);
            this.buttonAll.Name = "buttonAll";
            this.buttonAll.Size = new System.Drawing.Size(259, 46);
            this.buttonAll.TabIndex = 6;
            this.buttonAll.Text = "View All Registered Student";
            this.buttonAll.UseVisualStyleBackColor = false;
            this.buttonAll.Visible = false;
            this.buttonAll.Click += new System.EventHandler(this.buttonAll_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(53, 181);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 21);
            this.label2.TabIndex = 7;
            this.label2.Text = "Username";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(53, 233);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 21);
            this.label3.TabIndex = 8;
            this.label3.Text = "Password";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Black;
            this.groupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.button4);
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.checkBox1);
            this.groupBox1.Controls.Add(this.password);
            this.groupBox1.Controls.Add(this.username);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(700, 160);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(458, 416);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.ErrorImage = global::MultiFaceRec.Properties.Resources.user_login;
            this.pictureBox1.Image = global::MultiFaceRec.Properties.Resources.user_login;
            this.pictureBox1.InitialImage = global::MultiFaceRec.Properties.Resources.user_login;
            this.pictureBox1.Location = new System.Drawing.Point(189, 25);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(112, 127);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // button4
            // 
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button4.Location = new System.Drawing.Point(286, 311);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(101, 36);
            this.button4.TabIndex = 13;
            this.button4.Text = "CLEAR";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button3.Location = new System.Drawing.Point(154, 311);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(108, 36);
            this.button3.TabIndex = 12;
            this.button3.Text = "LOGIN";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox1.ForeColor = System.Drawing.Color.White;
            this.checkBox1.Location = new System.Drawing.Point(154, 267);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(147, 25);
            this.checkBox1.TabIndex = 11;
            this.checkBox1.Text = "Show Password";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // password
            // 
            this.password.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.password.Location = new System.Drawing.Point(154, 229);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(233, 29);
            this.password.TabIndex = 10;
            this.password.TextChanged += new System.EventHandler(this.password_TextChanged);
            // 
            // username
            // 
            this.username.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.username.Location = new System.Drawing.Point(154, 178);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(233, 29);
            this.username.TabIndex = 9;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Snow;
            this.label4.Location = new System.Drawing.Point(251, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(872, 47);
            this.label4.TabIndex = 12;
            this.label4.Text = "FACE RECOGNITION BASED ATTENDANCE SYSTEM ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Elephant", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(102, 149);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 21);
            this.label1.TabIndex = 14;
            this.label1.Text = "Select Date";
            this.label1.Visible = false;
            // 
            // comboBoxDate
            // 
            this.comboBoxDate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxDate.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.comboBoxDate.Font = new System.Drawing.Font("Lucida Handwriting", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxDate.FormattingEnabled = true;
            this.comboBoxDate.Location = new System.Drawing.Point(106, 177);
            this.comboBoxDate.Name = "comboBoxDate";
            this.comboBoxDate.Size = new System.Drawing.Size(298, 29);
            this.comboBoxDate.TabIndex = 13;
            this.comboBoxDate.Visible = false;
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.BackgroundImage = global::MultiFaceRec.Properties.Resources.pexels_photo_1169754;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1299, 635);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxDate);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.buttonAll);
            this.Controls.Add(this.buttonView);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "FrmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Federal Polytechnic Bauchi";
            this.Load += new System.EventHandler(this.FrmPrincipal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button buttonView;
        private System.Windows.Forms.Button buttonAll;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.TextBox username;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxDate;
    }
}

