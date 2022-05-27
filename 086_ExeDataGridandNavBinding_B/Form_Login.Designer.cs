namespace _086_ExeDataGridandNavBinding_B
{
    partial class Form_Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Login));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label_DataMahasiswa = new System.Windows.Forms.Label();
            this.label_Username = new System.Windows.Forms.Label();
            this.textBox_Username = new System.Windows.Forms.TextBox();
            this.label_Password = new System.Windows.Forms.Label();
            this.textBox_Password = new System.Windows.Forms.TextBox();
            this.checkBox_Login = new System.Windows.Forms.CheckBox();
            this.button_Login = new System.Windows.Forms.Button();
            this.button_Keluar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 96);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(278, 96);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            // 
            // label_DataMahasiswa
            // 
            this.label_DataMahasiswa.Dock = System.Windows.Forms.DockStyle.Top;
            this.label_DataMahasiswa.Font = new System.Drawing.Font("HelveticaNowDisplay Black", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_DataMahasiswa.Location = new System.Drawing.Point(0, 0);
            this.label_DataMahasiswa.Name = "label_DataMahasiswa";
            this.label_DataMahasiswa.Size = new System.Drawing.Size(278, 96);
            this.label_DataMahasiswa.TabIndex = 16;
            this.label_DataMahasiswa.Text = "Data Mahasiswa";
            this.label_DataMahasiswa.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_Username
            // 
            this.label_Username.AutoSize = true;
            this.label_Username.Font = new System.Drawing.Font("HelveticaNowDisplay Regular", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Username.Location = new System.Drawing.Point(14, 215);
            this.label_Username.Name = "label_Username";
            this.label_Username.Size = new System.Drawing.Size(82, 24);
            this.label_Username.TabIndex = 9;
            this.label_Username.Text = "Username";
            // 
            // textBox_Username
            // 
            this.textBox_Username.Font = new System.Drawing.Font("HelveticaNowDisplay Regular", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_Username.Location = new System.Drawing.Point(18, 242);
            this.textBox_Username.Name = "textBox_Username";
            this.textBox_Username.Size = new System.Drawing.Size(240, 27);
            this.textBox_Username.TabIndex = 11;
            // 
            // label_Password
            // 
            this.label_Password.AutoSize = true;
            this.label_Password.Font = new System.Drawing.Font("HelveticaNowDisplay Regular", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Password.Location = new System.Drawing.Point(14, 272);
            this.label_Password.Name = "label_Password";
            this.label_Password.Size = new System.Drawing.Size(76, 24);
            this.label_Password.TabIndex = 10;
            this.label_Password.Text = "Password";
            // 
            // textBox_Password
            // 
            this.textBox_Password.Font = new System.Drawing.Font("HelveticaNowDisplay Regular", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_Password.Location = new System.Drawing.Point(18, 299);
            this.textBox_Password.Name = "textBox_Password";
            this.textBox_Password.Size = new System.Drawing.Size(240, 27);
            this.textBox_Password.TabIndex = 12;
            this.textBox_Password.UseSystemPasswordChar = true;
            // 
            // checkBox_Login
            // 
            this.checkBox_Login.AutoSize = true;
            this.checkBox_Login.Font = new System.Drawing.Font("HelveticaNowDisplay Regular", 7.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox_Login.Location = new System.Drawing.Point(18, 352);
            this.checkBox_Login.Name = "checkBox_Login";
            this.checkBox_Login.Size = new System.Drawing.Size(245, 28);
            this.checkBox_Login.TabIndex = 13;
            this.checkBox_Login.Text = "Saya merupakan administrator";
            this.checkBox_Login.UseVisualStyleBackColor = true;
            // 
            // button_Login
            // 
            this.button_Login.AutoSize = true;
            this.button_Login.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Login.Font = new System.Drawing.Font("HelveticaNowDisplay Regular", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Login.Location = new System.Drawing.Point(150, 406);
            this.button_Login.Name = "button_Login";
            this.button_Login.Size = new System.Drawing.Size(108, 36);
            this.button_Login.TabIndex = 14;
            this.button_Login.Text = "Login";
            this.button_Login.UseVisualStyleBackColor = true;
            this.button_Login.Click += new System.EventHandler(this.button_Login_Click);
            // 
            // button_Keluar
            // 
            this.button_Keluar.AutoSize = true;
            this.button_Keluar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Keluar.Font = new System.Drawing.Font("HelveticaNowDisplay Regular", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Keluar.Location = new System.Drawing.Point(18, 406);
            this.button_Keluar.Name = "button_Keluar";
            this.button_Keluar.Size = new System.Drawing.Size(108, 36);
            this.button_Keluar.TabIndex = 15;
            this.button_Keluar.Text = "Keluar";
            this.button_Keluar.UseVisualStyleBackColor = true;
            this.button_Keluar.Click += new System.EventHandler(this.button_Keluar_Click);
            // 
            // Form_Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(278, 454);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label_DataMahasiswa);
            this.Controls.Add(this.label_Username);
            this.Controls.Add(this.textBox_Username);
            this.Controls.Add(this.label_Password);
            this.Controls.Add(this.textBox_Password);
            this.Controls.Add(this.checkBox_Login);
            this.Controls.Add(this.button_Login);
            this.Controls.Add(this.button_Keluar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form_Login";
            this.Text = "Data Mahasiswa";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label_DataMahasiswa;
        private System.Windows.Forms.Label label_Username;
        private System.Windows.Forms.TextBox textBox_Username;
        private System.Windows.Forms.Label label_Password;
        private System.Windows.Forms.TextBox textBox_Password;
        private System.Windows.Forms.CheckBox checkBox_Login;
        private System.Windows.Forms.Button button_Login;
        private System.Windows.Forms.Button button_Keluar;
    }
}

