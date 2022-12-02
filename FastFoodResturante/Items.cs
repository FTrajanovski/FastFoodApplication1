using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.AccessControl;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FastFoodResturante
{
    public partial class frm_item : Form
    {
        public frm_item()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void checkBox8_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult iExit;
            iExit = MessageBox.Show("Confirm you want to exit the system", "Ordering System",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (iExit == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void frm_item_Load(object sender, EventArgs e)
        {
            cmb_payment.Items.Add(" ");
            cmb_payment.Items.Add("Cash");
            cmb_payment.Items.Add("Cash on delivery");


        }

        private void enableTextBoxes()
        {
            Action<Control.ControlCollection> func = null;
           

            
        
        }


        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}
