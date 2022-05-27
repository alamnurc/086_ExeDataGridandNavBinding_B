namespace _086_ExeDataGridandNavBinding_B
{
    partial class Form_DataBindingNavigation
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_DataBindingNavigation));
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
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.prodiTIDataSet_DataGridView = new _086_ExeDataGridandNavBinding_B.ProdiTIDataSet_DataGridView();
            this.mahasiswaBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.mahasiswaTableAdapter = new _086_ExeDataGridandNavBinding_B.ProdiTIDataSet_DataGridViewTableAdapters.MahasiswaTableAdapter();
            this.mahasiswaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator)).BeginInit();
            this.bindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.prodiTIDataSet_DataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mahasiswaBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mahasiswaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // button_Back
            // 
            this.button_Back.FlatAppearance.BorderSize = 0;
            this.button_Back.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Back.Image = ((System.Drawing.Image)(resources.GetObject("button_Back.Image")));
            this.button_Back.Location = new System.Drawing.Point(16, 49);
            this.button_Back.Name = "button_Back";
            this.button_Back.Size = new System.Drawing.Size(64, 64);
            this.button_Back.TabIndex = 26;
            this.button_Back.UseVisualStyleBackColor = true;
            this.button_Back.Click += new System.EventHandler(this.button_Back_Click);
            // 
            // textBox_NoTelepon
            // 
            this.textBox_NoTelepon.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.mahasiswaBindingSource1, "PhoneMhs", true));
            this.textBox_NoTelepon.Font = new System.Drawing.Font("HelveticaNowDisplay Regular", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_NoTelepon.Location = new System.Drawing.Point(160, 265);
            this.textBox_NoTelepon.Name = "textBox_NoTelepon";
            this.textBox_NoTelepon.Size = new System.Drawing.Size(240, 27);
            this.textBox_NoTelepon.TabIndex = 24;
            // 
            // textBox_JenisKelamin
            // 
            this.textBox_JenisKelamin.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.mahasiswaBindingSource1, "Sex", true));
            this.textBox_JenisKelamin.Font = new System.Drawing.Font("HelveticaNowDisplay Regular", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_JenisKelamin.Location = new System.Drawing.Point(160, 231);
            this.textBox_JenisKelamin.Name = "textBox_JenisKelamin";
            this.textBox_JenisKelamin.Size = new System.Drawing.Size(240, 27);
            this.textBox_JenisKelamin.TabIndex = 22;
            // 
            // textBox_NamaMahasiswa
            // 
            this.textBox_NamaMahasiswa.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.mahasiswaBindingSource1, "NamaMhs", true));
            this.textBox_NamaMahasiswa.Font = new System.Drawing.Font("HelveticaNowDisplay Regular", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_NamaMahasiswa.Location = new System.Drawing.Point(160, 163);
            this.textBox_NamaMahasiswa.Name = "textBox_NamaMahasiswa";
            this.textBox_NamaMahasiswa.Size = new System.Drawing.Size(240, 27);
            this.textBox_NamaMahasiswa.TabIndex = 18;
            // 
            // textBox_NoMahasiswa
            // 
            this.textBox_NoMahasiswa.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.mahasiswaBindingSource1, "NIM", true));
            this.textBox_NoMahasiswa.Font = new System.Drawing.Font("HelveticaNowDisplay Regular", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_NoMahasiswa.Location = new System.Drawing.Point(160, 129);
            this.textBox_NoMahasiswa.Name = "textBox_NoMahasiswa";
            this.textBox_NoMahasiswa.Size = new System.Drawing.Size(240, 27);
            this.textBox_NoMahasiswa.TabIndex = 16;
            // 
            // textBox_AlamatMahasiswa
            // 
            this.textBox_AlamatMahasiswa.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.mahasiswaBindingSource1, "AlamatMhs", true));
            this.textBox_AlamatMahasiswa.Font = new System.Drawing.Font("HelveticaNowDisplay Regular", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_AlamatMahasiswa.Location = new System.Drawing.Point(160, 197);
            this.textBox_AlamatMahasiswa.Name = "textBox_AlamatMahasiswa";
            this.textBox_AlamatMahasiswa.Size = new System.Drawing.Size(240, 27);
            this.textBox_AlamatMahasiswa.TabIndex = 20;
            // 
            // label_NoTelepon
            // 
            this.label_NoTelepon.AutoSize = true;
            this.label_NoTelepon.Font = new System.Drawing.Font("HelveticaNowDisplay Regular", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_NoTelepon.Location = new System.Drawing.Point(18, 265);
            this.label_NoTelepon.Name = "label_NoTelepon";
            this.label_NoTelepon.Size = new System.Drawing.Size(91, 24);
            this.label_NoTelepon.TabIndex = 23;
            this.label_NoTelepon.Text = "No. Telepon";
            // 
            // label_AlamatMahasiswa
            // 
            this.label_AlamatMahasiswa.AutoSize = true;
            this.label_AlamatMahasiswa.Font = new System.Drawing.Font("HelveticaNowDisplay Regular", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_AlamatMahasiswa.Location = new System.Drawing.Point(18, 197);
            this.label_AlamatMahasiswa.Name = "label_AlamatMahasiswa";
            this.label_AlamatMahasiswa.Size = new System.Drawing.Size(136, 24);
            this.label_AlamatMahasiswa.TabIndex = 19;
            this.label_AlamatMahasiswa.Text = "Alamat Mahasiswa";
            // 
            // label_JenisKelamin
            // 
            this.label_JenisKelamin.AutoSize = true;
            this.label_JenisKelamin.Font = new System.Drawing.Font("HelveticaNowDisplay Regular", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_JenisKelamin.Location = new System.Drawing.Point(18, 231);
            this.label_JenisKelamin.Name = "label_JenisKelamin";
            this.label_JenisKelamin.Size = new System.Drawing.Size(104, 24);
            this.label_JenisKelamin.TabIndex = 21;
            this.label_JenisKelamin.Text = "Jenis Kelamin";
            // 
            // label_NoMahasiswa
            // 
            this.label_NoMahasiswa.AutoSize = true;
            this.label_NoMahasiswa.Font = new System.Drawing.Font("HelveticaNowDisplay Regular", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_NoMahasiswa.Location = new System.Drawing.Point(18, 129);
            this.label_NoMahasiswa.Name = "label_NoMahasiswa";
            this.label_NoMahasiswa.Size = new System.Drawing.Size(110, 24);
            this.label_NoMahasiswa.TabIndex = 15;
            this.label_NoMahasiswa.Text = "No. Mahasiswa";
            // 
            // label_NamaMahasiswa
            // 
            this.label_NamaMahasiswa.AutoSize = true;
            this.label_NamaMahasiswa.Font = new System.Drawing.Font("HelveticaNowDisplay Regular", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_NamaMahasiswa.Location = new System.Drawing.Point(18, 163);
            this.label_NamaMahasiswa.Name = "label_NamaMahasiswa";
            this.label_NamaMahasiswa.Size = new System.Drawing.Size(128, 24);
            this.label_NamaMahasiswa.TabIndex = 17;
            this.label_NamaMahasiswa.Text = "Nama Mahasiswa";
            // 
            // label_DataMahasiswa
            // 
            this.label_DataMahasiswa.Dock = System.Windows.Forms.DockStyle.Top;
            this.label_DataMahasiswa.Font = new System.Drawing.Font("HelveticaNowDisplay Black", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_DataMahasiswa.Location = new System.Drawing.Point(0, 33);
            this.label_DataMahasiswa.Name = "label_DataMahasiswa";
            this.label_DataMahasiswa.Size = new System.Drawing.Size(418, 96);
            this.label_DataMahasiswa.TabIndex = 25;
            this.label_DataMahasiswa.Text = "Data Mahasiswa";
            this.label_DataMahasiswa.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 33);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(34, 28);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 33);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("HelveticaNowDisplay Regular", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 27);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 33);
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(34, 28);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(34, 28);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(34, 28);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Font = new System.Drawing.Font("HelveticaNowDisplay Regular", 8F);
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(49, 28);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(34, 28);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(34, 28);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigator
            // 
            this.bindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.bindingNavigator.BindingSource = this.mahasiswaBindingSource1;
            this.bindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.bindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.bindingNavigator.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.bindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem});
            this.bindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.bindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bindingNavigator.Name = "bindingNavigator";
            this.bindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.bindingNavigator.Size = new System.Drawing.Size(418, 33);
            this.bindingNavigator.TabIndex = 14;
            this.bindingNavigator.Text = "bindingNavigator1";
            // 
            // prodiTIDataSet_DataGridView
            // 
            this.prodiTIDataSet_DataGridView.DataSetName = "ProdiTIDataSet_DataGridView";
            this.prodiTIDataSet_DataGridView.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // mahasiswaBindingSource1
            // 
            this.mahasiswaBindingSource1.DataMember = "Mahasiswa";
            this.mahasiswaBindingSource1.DataSource = this.prodiTIDataSet_DataGridView;
            // 
            // mahasiswaTableAdapter
            // 
            this.mahasiswaTableAdapter.ClearBeforeFill = true;
            // 
            // Form_DataBindingNavigation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(418, 304);
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
            this.Controls.Add(this.bindingNavigator);
            this.Name = "Form_DataBindingNavigation";
            this.Text = "Data Binding Navigation";
            this.Load += new System.EventHandler(this.Form_DataBindingNavigation_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator)).EndInit();
            this.bindingNavigator.ResumeLayout(false);
            this.bindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.prodiTIDataSet_DataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mahasiswaBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mahasiswaBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

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
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.BindingSource mahasiswaBindingSource;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.BindingNavigator bindingNavigator;
        private ProdiTIDataSet_DataGridView prodiTIDataSet_DataGridView;
        private System.Windows.Forms.BindingSource mahasiswaBindingSource1;
        private ProdiTIDataSet_DataGridViewTableAdapters.MahasiswaTableAdapter mahasiswaTableAdapter;
    }
}