using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _086_ExeDataGridandNavBinding_B
{
    public partial class Form_Coba_DataGrid : Form
    {
        public Form_Coba_DataGrid()
        {
            InitializeComponent();
        }

        private void Form_Coba_DataGrid_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'prodiTIDataSet_DataGridView.Mahasiswa' table. You can move, or remove it, as needed.
            this.mahasiswaTableAdapter.Fill(this.prodiTIDataSet_DataGridView.Mahasiswa);

        }

        private void button_Back_Click(object sender, EventArgs e)
        {
            new Form_DataGridView().Show();
            this.Close();
        }
    }
}
