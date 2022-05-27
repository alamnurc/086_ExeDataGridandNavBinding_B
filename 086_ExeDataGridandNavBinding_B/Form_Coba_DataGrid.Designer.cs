namespace _086_ExeDataGridandNavBinding_B
{
    partial class Form_Coba_DataGrid
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Coba_DataGrid));
            this.mahasiswaTableAdapter = new _086_ExeDataGridandNavBinding_B.ProdiTIDataSet_DataGridViewTableAdapters.MahasiswaTableAdapter();
            this.prodiTIDataSet_DataGridView = new _086_ExeDataGridandNavBinding_B.ProdiTIDataSet_DataGridView();
            this.mahasiswaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.button_Back = new System.Windows.Forms.Button();
            this.textBox_NoTelepon = new System.Windows.Forms.TextBox();
            this.textBox_JenisKelamin = new System.Windows.Forms.TextBox();
            this.textBox_NamaMahasiswa = new System.Windows.Forms.TextBox();
            this.textBox_NoMahasiswa = new System.Windows.Forms.TextBox();
            this.textBox_AlamatMahasiswa = new System.Windows.Forms.TextBox();
            this.label_NoTelepon = new System.Windows.Forms.Label();
            this.label_AlamatMahasiswa = new System.Windows.Forms.Label();
            this.label_JenisKelamin = new System.Windows.Forms.Label();
            this.label_NoMahasiswa = new System.Windows.Forms.Label();
            this.label_NamaMahasiswa = new System.Windows.Forms.Label();
            this.label_DataMahasiswa = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.prodiTIDataSet_DataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mahasiswaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // mahasiswaTableAdapter
            // 
            this.mahasiswaTableAdapter.ClearBeforeFill = true;
            // 
            // prodiTIDataSet_DataGridView
            // 
            this.prodiTIDataSet_DataGridView.DataSetName = "ProdiTIDataSet_DataGridView";
            this.prodiTIDataSet_DataGridView.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // mahasiswaBindingSource
            // 
            this.mahasiswaBindingSource.DataMember = "Mahasiswa";
            this.mahasiswaBindingSource.DataSource = this.prodiTIDataSet_DataGridView;
            // 
            // button_Back
            // 
            this.button_Back.FlatAppearance.BorderSize = 0;
            this.button_Back.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Back.Image = ((System.Drawing.Image)(resources.GetObject("button_Back.Image")));
            this.button_Back.Location = new System.Drawing.Point(16, 16);
            this.button_Back.Name = "button_Back";
            this.button_Back.Size = new System.Drawing.Size(64, 64);
            this.button_Back.TabIndex = 51;
            this.button_Back.UseVisualStyleBackColor = true;
            this.button_Back.Click += new System.EventHandler(this.button_Back_Click);
            // 
            // textBox_NoTelepon
            // 
            this.textBox_NoTelepon.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.mahasiswaBindingSource, "PhoneMhs", true));
            this.textBox_NoTelepon.Font = new System.Drawing.Font("HelveticaNowDisplay Regular", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_NoTelepon.Location = new System.Drawing.Point(154, 232);
            this.textBox_NoTelepon.Name = "textBox_NoTelepon";
            this.textBox_NoTelepon.Size = new System.Drawing.Size(240, 27);
            this.textBox_NoTelepon.TabIndex = 49;
            // 
            // textBox_JenisKelamin
            // 
            this.textBox_JenisKelamin.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.mahasiswaBindingSource, "Sex", true));
            this.textBox_JenisKelamin.Font = new System.Drawing.Font("HelveticaNowDisplay Regular", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_JenisKelamin.Location = new System.Drawing.Point(154, 198);
            this.textBox_JenisKelamin.Name = "textBox_JenisKelamin";
            this.textBox_JenisKelamin.Size = new System.Drawing.Size(240, 27);
            this.textBox_JenisKelamin.TabIndex = 47;
            // 
            // textBox_NamaMahasiswa
            // 
            this.textBox_NamaMahasiswa.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.mahasiswaBindingSource, "NamaMhs", true));
            this.textBox_NamaMahasiswa.Font = new System.Drawing.Font("HelveticaNowDisplay Regular", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_NamaMahasiswa.Location = new System.Drawing.Point(154, 130);
            this.textBox_NamaMahasiswa.Name = "textBox_NamaMahasiswa";
            this.textBox_NamaMahasiswa.Size = new System.Drawing.Size(240, 27);
            this.textBox_NamaMahasiswa.TabIndex = 43;
            // 
            // textBox_NoMahasiswa
            // 
            this.textBox_NoMahasiswa.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.mahasiswaBindingSource, "NIM", true));
            this.textBox_NoMahasiswa.Font = new System.Drawing.Font("HelveticaNowDisplay Regular", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_NoMahasiswa.Location = new System.Drawing.Point(154, 96);
            this.textBox_NoMahasiswa.Name = "textBox_NoMahasiswa";
            this.textBox_NoMahasiswa.Size = new System.Drawing.Size(240, 27);
            this.textBox_NoMahasiswa.TabIndex = 41;
            // 
            // textBox_AlamatMahasiswa
            // 
            this.textBox_AlamatMahasiswa.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.mahasiswaBindingSource, "AlamatMhs", true));
            this.textBox_AlamatMahasiswa.Font = new System.Drawing.Font("HelveticaNowDisplay Regular", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_AlamatMahasiswa.Location = new System.Drawing.Point(154, 164);
            this.textBox_AlamatMahasiswa.Name = "textBox_AlamatMahasiswa";
            this.textBox_AlamatMahasiswa.Size = new System.Drawing.Size(240, 27);
            this.textBox_AlamatMahasiswa.TabIndex = 45;
            // 
            // label_NoTelepon
            // 
            this.label_NoTelepon.AutoSize = true;
            this.label_NoTelepon.Font = new System.Drawing.Font("HelveticaNowDisplay Regular", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_NoTelepon.Location = new System.Drawing.Point(12, 232);
            this.label_NoTelepon.Name = "label_NoTelepon";
            this.label_NoTelepon.Size = new System.Drawing.Size(91, 24);
            this.label_NoTelepon.TabIndex = 48;
            this.label_NoTelepon.Text = "No. Telepon";
            // 
            // label_AlamatMahasiswa
            // 
            this.label_AlamatMahasiswa.AutoSize = true;
            this.label_AlamatMahasiswa.Font = new System.Drawing.Font("HelveticaNowDisplay Regular", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_AlamatMahasiswa.Location = new System.Drawing.Point(12, 164);
            this.label_AlamatMahasiswa.Name = "label_AlamatMahasiswa";
            this.label_AlamatMahasiswa.Size = new System.Drawing.Size(136, 24);
            this.label_AlamatMahasiswa.TabIndex = 44;
            this.label_AlamatMahasiswa.Text = "Alamat Mahasiswa";
            // 
            // label_JenisKelamin
            // 
            this.label_JenisKelamin.AutoSize = true;
            this.label_JenisKelamin.Font = new System.Drawing.Font("HelveticaNowDisplay Regular", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_JenisKelamin.Location = new System.Drawing.Point(12, 198);
            this.label_JenisKelamin.Name = "label_JenisKelamin";
            this.label_JenisKelamin.Size = new System.Drawing.Size(104, 24);
            this.label_JenisKelamin.TabIndex = 46;
            this.label_JenisKelamin.Text = "Jenis Kelamin";
            // 
            // label_NoMahasiswa
            // 
            this.label_NoMahasiswa.AutoSize = true;
            this.label_NoMahasiswa.Font = new System.Drawing.Font("HelveticaNowDisplay Regular", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_NoMahasiswa.Location = new System.Drawing.Point(12, 96);
            this.label_NoMahasiswa.Name = "label_NoMahasiswa";
            this.label_NoMahasiswa.Size = new System.Drawing.Size(110, 24);
            this.label_NoMahasiswa.TabIndex = 40;
            this.label_NoMahasiswa.Text = "No. Mahasiswa";
            // 
            // label_NamaMahasiswa
            // 
            this.label_NamaMahasiswa.AutoSize = true;
            this.label_NamaMahasiswa.Font = new System.Drawing.Font("HelveticaNowDisplay Regular", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_NamaMahasiswa.Location = new System.Drawing.Point(12, 130);
            this.label_NamaMahasiswa.Name = "label_NamaMahasiswa";
            this.label_NamaMahasiswa.Size = new System.Drawing.Size(128, 24);
            this.label_NamaMahasiswa.TabIndex = 42;
            this.label_NamaMahasiswa.Text = "Nama Mahasiswa";
            // 
            // label_DataMahasiswa
            // 
            this.label_DataMahasiswa.Dock = System.Windows.Forms.DockStyle.Top;
            this.label_DataMahasiswa.Font = new System.Drawing.Font("HelveticaNowDisplay Black", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_DataMahasiswa.Location = new System.Drawing.Point(0, 0);
            this.label_DataMahasiswa.Name = "label_DataMahasiswa";
            this.label_DataMahasiswa.Size = new System.Drawing.Size(418, 96);
            this.label_DataMahasiswa.TabIndex = 50;
            this.label_DataMahasiswa.Text = "Data Mahasiswa";
            this.label_DataMahasiswa.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form_Coba_DataGrid
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(418, 284);
            this.Controls.Add(this.button_Back);
            this.Controls.Add(this.textBox_NoTelepon);
            this.Controls.Add(this.textBox_JenisKelamin);
            this.Controls.Add(this.textBox_NamaMahasiswa);
            this.Controls.Add(this.textBox_NoMahasiswa);
            this.Controls.Add(this.textBox_AlamatMahasiswa);
            this.Controls.Add(this.label_NoTelepon);
            this.Controls.Add(this.label_AlamatMahasiswa);
            this.Controls.Add(this.label_JenisKelamin);
            this.Controls.Add(this.label_NoMahasiswa);
            this.Controls.Add(this.label_NamaMahasiswa);
            this.Controls.Add(this.label_DataMahasiswa);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form_Coba_DataGrid";
            this.Text = "Data Grid";
            this.Load += new System.EventHandler(this.Form_Coba_DataGrid_Load);
            ((System.ComponentModel.ISupportInitialize)(this.prodiTIDataSet_DataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mahasiswaBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ProdiTIDataSet_DataGridViewTableAdapters.MahasiswaTableAdapter mahasiswaTableAdapter;
        private ProdiTIDataSet_DataGridView prodiTIDataSet_DataGridView;
        private System.Windows.Forms.BindingSource mahasiswaBindingSource;
        private System.Windows.Forms.Button button_Back;
        private System.Windows.Forms.TextBox textBox_NoTelepon;
        private System.Windows.Forms.TextBox textBox_JenisKelamin;
        private System.Windows.Forms.TextBox textBox_NamaMahasiswa;
        private System.Windows.Forms.TextBox textBox_NoMahasiswa;
        private System.Windows.Forms.TextBox textBox_AlamatMahasiswa;
        private System.Windows.Forms.Label label_NoTelepon;
        private System.Windows.Forms.Label label_AlamatMahasiswa;
        private System.Windows.Forms.Label label_JenisKelamin;
        private System.Windows.Forms.Label label_NoMahasiswa;
        private System.Windows.Forms.Label label_NamaMahasiswa;
        private System.Windows.Forms.Label label_DataMahasiswa;
    }
}