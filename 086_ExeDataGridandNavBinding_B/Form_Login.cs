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
    public partial class Form_Login : Form
    {
        readonly string Username = "alamnurcahaya";
        readonly string Password = "nurcahaya";
        public Form_Login()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button_Login_Click(object sender, EventArgs e)
        {
            if (textBox_Username.Text == Username && textBox_Password.Text == Password && checkBox_Login.Checked)
            {
                MessageBox.Show("Login berhasil! Tekan 'OK' untuk melanjutkan.");
                new Form_Menu().Show();
                this.Hide();
            }
            else if (textBox_Username.Text == "" || textBox_Password.Text == "")
            {
                MessageBox.Show("Data login belum diisi!");
            }
            else if (!checkBox_Login.Checked)
            {
                MessageBox.Show("Silahkan centang bukti bahwa anda administrator!");
            }
            else
            {
                MessageBox.Show("Username atau Password salah!");
            }
        }

        private void button_Keluar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}