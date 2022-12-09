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
    public partial class frm_avslut : Form
    {
        public frm_avslut()
        {
            InitializeComponent();
        }

        private void Avslut_Load(object sender, EventArgs e)
        {

        }

        private void Avsluta_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {
          

    
        }

        private void button1_Click(object sender, EventArgs e)
        {
            {
                Form item = new frm_item();
                item.Show();
                this.Hide();

            }
        }

        private void textBox1_TextChanged_2(object sender, EventArgs e)
        {
            
        }
    }
}
