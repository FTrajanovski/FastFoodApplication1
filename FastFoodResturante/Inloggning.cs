using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FastFoodResturante
{
    public partial class Inloggning : Form
    {
        public Inloggning()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
            
        {
           if (txtUserName.Text == "Grupp1" && txtpassword.Text == "12345")
            {
                new frm_Front().Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Incorrect password or username, please try again");
                txtUserName.Clear();
                txtpassword.Clear();
                txtUserName.Focus();
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {
            txtUserName.Clear();
            txtpassword.Clear();
            txtUserName.Focus();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
