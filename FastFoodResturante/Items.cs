using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.AccessControl;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FastFoodResturante
{

    public partial class frm_item : Form
    {
        const double price_burger = 80;
        const double price_hotdog = 60;
        const double price_pizza = 90;
        const double price_sallad = 75;
        const double price_sandwich = 50;
        const double price_cola = 15;
        const double price_sprite = 15;
        const double price_fanta = 15;
        const double price_hotchoclate = 30;
        const double price_coffe = 30;


        public frm_item()
        {
            InitializeComponent();
        }

      

        private void checkBox8_CheckedChanged(object sender, EventArgs e)
        {
            {
                if (chk_fanta.Checked == true)
                {
                    txt_fanta.Enabled = true;
                    txt_fanta.Text = "";
                    txt_fanta.Focus();
                }
                else
                {
                    txt_fanta.Enabled = false;
                    txt_fanta.Text = "0";
                }
            }
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

      


     

        private void chk_burger_CheckedChanged(object sender, EventArgs e)
        {
            if (chk_burger.Checked == true)
            {
                txt_burger.Enabled = true;
                txt_burger.Text = "";
                txt_burger.Focus();
            }
            else
            {
                txt_burger.Enabled = false;
                txt_burger.Text = "0";
            }
        }

     

        private void chk_hotdog_CheckedChanged(object sender, EventArgs e)
        {
            {
                if (chk_hotdog.Checked == true)
                {
                    txt_hotdog.Enabled = true;
                    txt_hotdog.Text = "";
                    txt_hotdog.Focus();
                }
                else
                {
                    txt_hotdog.Enabled = false;
                    txt_hotdog.Text = "0";
                }
            }
        }

        private void chk_pizza_CheckedChanged(object sender, EventArgs e)
        {
            {
                if (chk_pizza.Checked == true)
                {
                    txt_pizza.Enabled = true;
                    txt_pizza.Text = "";
                    txt_pizza.Focus();
                }
                else
                {
                    txt_pizza.Enabled = false;
                    txt_pizza.Text = "0";
                }
            }
        }

        private void chk_sallad_CheckedChanged(object sender, EventArgs e)
        {
            {
                if (chk_sallad.Checked == true)
                {
                    txt_sallad.Enabled = true;
                    txt_sallad.Text = "";
                    txt_sallad.Focus();
                }
                else
                {
                    txt_sallad.Enabled = false;
                    txt_sallad.Text = "0";
                }
            }
        }

        private void chk_sandwich_CheckedChanged(object sender, EventArgs e)
        {
            {
                if (chk_sandwich.Checked == true)
                {
                    txt_sandwich.Enabled = true;
                    txt_sandwich.Text = "";
                    txt_sandwich.Focus();
                }
                else
                {
                    txt_sandwich.Enabled = false;
                    txt_sandwich.Text = "0";
                }
            }
        }

        private void chk_cola_CheckedChanged(object sender, EventArgs e)
        {
            {
                if (chk_cola.Checked == true)
                {
                    txt_cola.Enabled = true;
                    txt_cola.Text = "";
                    txt_cola.Focus();
                }
                else
                {
                    txt_cola.Enabled = false;
                    txt_cola.Text = "0";
                }
            }
        }

        private void chk_sprite_CheckedChanged(object sender, EventArgs e)
        {
            {
                if (chk_sprite.Checked == true)
                {
                    txt_sprite.Enabled = true;
                    txt_sprite.Text = "";
                    txt_sprite.Focus();
                }
                else
                {
                    txt_sprite.Enabled = false;
                    txt_sprite.Text = "0";
                }
            }
        }

        private void chk_hotchoclate_CheckedChanged(object sender, EventArgs e)
        {
            {
                if (chk_hotchoclate.Checked == true)
                {
                    txt_hotchoclate.Enabled = true;
                    txt_hotchoclate.Text = "";
                    txt_hotchoclate.Focus();
                }
                else
                {
                    txt_hotchoclate.Enabled = false;
                    txt_hotchoclate.Text = "0";
                }
            }
        }

        private void chk_coffe_CheckedChanged(object sender, EventArgs e)
        {
            {
                if (chk_coffe.Checked == true)
                {
                    txt_coffe.Enabled = true;
                    txt_coffe.Text = "";
                    txt_coffe.Focus();
                }
                else
                {
                    txt_coffe.Enabled = false;
                    txt_coffe.Text = "0";
                }
            }
        }

     

        private void cmb_payment_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmb_payment.Text == "Cash")
            {
                txt_payment.Enabled = true;
                txt_payment.Text = "";
                txt_payment.Focus();
            }
            else if (cmb_payment.Text == "Cash On Delivery")
            {
                txt_name.Enabled = true;
                txt_adress.Enabled = true;
                txt_number.Enabled = true;
                txt_name.Text = "";
                txt_number.Text = "";
                txt_adress.Text = "";
                txt_name.Focus();
                txt_adress.Focus();
                txt_number.Focus();
            }
            else
            {
                txt_payment.Enabled = false;
                txt_payment.Text = "0";
            }
        }

        private void btn_total_Click(object sender, EventArgs e)
        {
            double[] itemcost = new double[100];
            itemcost[0] = Convert.ToDouble(txt_burger.Text) * price_burger;
            itemcost[2] = Convert.ToDouble(txt_hotdog.Text) * price_hotdog;
            itemcost[3] = Convert.ToDouble(txt_pizza.Text) * price_burger;
            itemcost[4] = Convert.ToDouble(txt_sallad.Text) * price_burger;
            itemcost[5] = Convert.ToDouble(txt_sandwich.Text) * price_burger;
            itemcost[6] = Convert.ToDouble(txt_cola.Text) * price_burger;
            itemcost[7] = Convert.ToDouble(txt_sprite.Text) * price_burger;
            itemcost[8] = Convert.ToDouble(txt_fanta.Text) * price_burger;
            itemcost[9] = Convert.ToDouble(txt_hotchoclate.Text) * price_burger;
            itemcost[10] = Convert.ToDouble(txt_coffe.Text) * price_burger;

            double total, payment, cost;
            if (cmb_payment.Text == "Cash")
            {
                total = itemcost[0] + itemcost[2] + itemcost[3] + itemcost[4] + itemcost[5] + itemcost[6]
                    + itemcost[7] + itemcost[8] + itemcost[9] + itemcost[10];
                
                lbl_totalresult.Text = Convert.ToString(total);

                payment = Convert.ToInt32(txt_payment.Text);
                cost = payment - total;
                lbl_changeresult.Text = Convert.ToString(cost);
               
            }
            else
            {
                total = itemcost[0] + itemcost[2] + itemcost[3] + itemcost[4] + itemcost[5] + itemcost[6]
                + itemcost[7] + itemcost[8] + itemcost[9] + itemcost[10];

                lbl_totalresult.Text = Convert.ToString(total);
            }


        }

        private void button4_Click(object sender, EventArgs e)
        {
            RestTextBox();
            
        }
        private void RestTextBox()
        {
            Form item = new frm_item();
            item.Show();
            this.Hide();
           
        }
        private void RestCheckBox()
        {
            Action<Control.ControlCollection> func = null;

            func = (controls) =>
            {
                foreach (Control control in controls)
                    if (control is CheckBox)
                        (control as CheckBox).Text = "0";
                    else
                        func(Controls);

            };
            func(Controls);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txt_name.Text == "") 
            {
                MessageBox.Show("Please fill out the required fields!");
            }
            else if (txt_adress.Text == "")
            {
                MessageBox.Show("Please fill out the required fields!");

            }
            else if (txt_number.Text == "")
            {
                MessageBox.Show("Please fill out the required fields!");

            }
            else
            {
                MessageBox.Show("Thank you for choosing our restaurant " + txt_name.Text + ". We will deliver your order at " + txt_adress.Text + ". We will contact you at " + txt_number.Text);

            }

            //MessageBox.Show("Thank you for choosing our restaurant " + txt_name.Text + ". We will deliver your order at " + txt_adress.Text + ". We will contact you at " + txt_number.Text);
        }

        
        

      

        private void txt_name_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void txt_adress_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txt_number_TextChanged(object sender, EventArgs e)
        {
          
        }
    }
}
