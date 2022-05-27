namespace _086_ExeDataGridandNavBinding_B
{
    partial class Form_DataGridView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_DataGridView));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.button_Back = new System.Windows.Forms.Button();
            this.label_DataMahasiswaTeknologiInformasi = new System.Windows.Forms.Label();
            this.dataGridView_DMTI = new System.Windows.Forms.DataGridView();
            this.prodiTIDataSet_DataGridView = new _086_ExeDataGridandNavBinding_B.ProdiTIDataSet_DataGridView();
            this.mahasiswaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mahasiswaTableAdapter = new _086_ExeDataGridandNavBinding_B.ProdiTIDataSet_DataGridViewTableAdapters.MahasiswaTableAdapter();
            this.nIMDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.namaMhsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.alamatMhsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sexDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneMhsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_DMTI)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.prodiTIDataSet_DataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mahasiswaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // button_Back
            // 
            this.button_Back.FlatAppearance.BorderSize = 0;
            this.button_Back.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Back.Image = ((System.Drawing.Image)(resources.GetObject("button_Back.Image")));
            this.button_Back.Location = new System.Drawing.Point(16, 16);
            this.button_Back.Name = "button_Back";
            this.button_Back.Size = new System.Drawing.Size(64, 64);
            this.button_Back.TabIndex = 12;
            this.button_Back.UseVisualStyleBackColor = true;
            this.button_Back.Click += new System.EventHandler(this.button_Back_Click);
            // 
            // label_DataMahasiswaTeknologiInformasi
            // 
            this.label_DataMahasiswaTeknologiInformasi.Dock = System.Windows.Forms.DockStyle.Top;
            this.label_DataMahasiswaTeknologiInformasi.Font = new System.Drawing.Font("HelveticaNowDisplay Black", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_DataMahasiswaTeknologiInformasi.Location = new System.Drawing.Point(0, 0);
            this.label_DataMahasiswaTeknologiInformasi.Name = "label_DataMahasiswaTeknologiInformasi";
            this.label_DataMahasiswaTeknologiInformasi.Size = new System.Drawing.Size(1258, 96);
            this.label_DataMahasiswaTeknologiInformasi.TabIndex = 11;
            this.label_DataMahasiswaTeknologiInformasi.Text = "Data Mahasiswa Teknologi Informasi";
            this.label_DataMahasiswaTeknologiInformasi.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dataGridView_DMTI
            // 
            this.dataGridView_DMTI.AutoGenerateColumns = false;
            this.dataGridView_DMTI.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView_DMTI.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("HelveticaNowDisplay Medium", 8F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView_DMTI.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView_DMTI.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_DMTI.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nIMDataGridViewTextBoxColumn,
            this.namaMhsDataGridViewTextBoxColumn,
            this.alamatMhsDataGridViewTextBoxColumn,
            this.sexDataGridViewTextBoxColumn,
            this.phoneMhsDataGridViewTextBoxColumn});
            this.dataGridView_DMTI.DataSource = this.mahasiswaBindingSource;
            this.dataGridView_DMTI.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView_DMTI.Location = new System.Drawing.Point(0, 96);
            this.dataGridView_DMTI.Name = "dataGridView_DMTI";
            this.dataGridView_DMTI.RowHeadersWidth = 62;
            this.dataGridView_DMTI.RowTemplate.Height = 28;
            this.dataGridView_DMTI.Size = new System.Drawing.Size(1258, 568);
            this.dataGridView_DMTI.TabIndex = 13;
            this.dataGridView_DMTI.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_DMTI_CellContentClick);
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
            // mahasiswaTableAdapter
            // 
            this.mahasiswaTableAdapter.ClearBeforeFill = true;
            // 
            // nIMDataGridViewTextBoxColumn
            // 
            this.nIMDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nIMDataGridViewTextBoxColumn.DataPropertyName = "NIM";
            dataGridViewCellStyle2.Font = new System.Drawing.Font("HelveticaNowDisplay Regular", 8F);
            this.nIMDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle2;
            this.nIMDataGridViewTextBoxColumn.HeaderText = "No. Mahasiswa";
            this.nIMDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.nIMDataGridViewTextBoxColumn.Name = "nIMDataGridViewTextBoxColumn";
            // 
            // namaMhsDataGridViewTextBoxColumn
            // 
            this.namaMhsDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.namaMhsDataGridViewTextBoxColumn.DataPropertyName = "NamaMhs";
            dataGridViewCellStyle3.Font = new System.Drawing.Font("HelveticaNowDisplay Regular", 8F);
            this.namaMhsDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle3;
            this.namaMhsDataGridViewTextBoxColumn.HeaderText = "Nama Mahasiswa";
            this.namaMhsDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.namaMhsDataGridViewTextBoxColumn.Name = "namaMhsDataGridViewTextBoxColumn";
            // 
            // alamatMhsDataGridViewTextBoxColumn
            // 
            this.alamatMhsDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.alamatMhsDataGridViewTextBoxColumn.DataPropertyName = "AlamatMhs";
            dataGridViewCellStyle4.Font = new System.Drawing.Font("HelveticaNowDisplay Regular", 8F);
            this.alamatMhsDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle4;
            this.alamatMhsDataGridViewTextBoxColumn.HeaderText = "Alamat Mahasiswa";
            this.alamatMhsDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.alamatMhsDataGridViewTextBoxColumn.Name = "alamatMhsDataGridViewTextBoxColumn";
            // 
            // sexDataGridViewTextBoxColumn
            // 
            this.sexDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.sexDataGridViewTextBoxColumn.DataPropertyName = "Sex";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("HelveticaNowDisplay Regular", 8F);
            this.sexDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle5;
            this.sexDataGridViewTextBoxColumn.HeaderText = "Jenis Kelamin";
            this.sexDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.sexDataGridViewTextBoxColumn.Name = "sexDataGridViewTextBoxColumn";
            // 
            // phoneMhsDataGridViewTextBoxColumn
            // 
            this.phoneMhsDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.phoneMhsDataGridViewTextBoxColumn.DataPropertyName = "PhoneMhs";
            dataGridViewCellStyle6.Font = new System.Drawing.Font("HelveticaNowDisplay Regular", 8F);
            this.phoneMhsDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle6;
            this.phoneMhsDataGridViewTextBoxColumn.HeaderText = "No. Telepon";
            this.phoneMhsDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.phoneMhsDataGridViewTextBoxColumn.Name = "phoneMhsDataGridViewTextBoxColumn";
            // 
            // Form_DataGridView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1258, 664);
            this.Controls.Add(this.dataGridView_DMTI);
            this.Controls.Add(this.button_Back);
            this.Controls.Add(this.label_DataMahasiswaTeknologiInformasi);
            this.Name = "Form_DataGridView";
            this.Text = "Data Grid View";
            this.Load += new System.EventHandler(this.Form_DataGridView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_DMTI)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.prodiTIDataSet_DataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mahasiswaBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_Back;
        private System.Windows.Forms.Label label_DataMahasiswaTeknologiInformasi;
        private System.Windows.Forms.DataGridView dataGridView_DMTI;
        private ProdiTIDataSet_DataGridView prodiTIDataSet_DataGridView;
        private System.Windows.Forms.BindingSource mahasiswaBindingSource;
        private ProdiTIDataSet_DataGridViewTableAdapters.MahasiswaTableAdapter mahasiswaTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn nIMDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn namaMhsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn alamatMhsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sexDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneMhsDataGridViewTextBoxColumn;
    }
}