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
    public partial class Form_Menu : Form
    {
        public Form_Menu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new Form_Login().Show();
            this.Close();
        }

        private void button_DataGridView_Click(object sender, EventArgs e)
        {
            new Form_DataGridView().Show();
            this.Close();
        }

        private void button_BindingNavigation_Click(object sender, EventArgs e)
        {
            new Form_DataBindingNavigation().Show();
            this.Close();
        }
    }
}