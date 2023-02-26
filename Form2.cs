using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace The_Bank
{
    public partial class Form2 : Form
    {
        double c1 = 500;
        double c2 = 500;
        double savings = 500;
        string username, address, postalcode;

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lblchange_Click(object sender, EventArgs e)
        {
            gbchange.Visible = true;
        }

        private void label8_Click(object sender, EventArgs e)
        {
            //change info
            username = txtname2.Text;
            address = txtadd2.Text;
            postalcode = txtpost2.Text;
            lblname.Text = username;
            lbladdress.Text = address;
            lblpostal.Text = postalcode;
            gbchange.Visible = false;
        }

        private void cbto_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbto.SelectedIndex == 3) { gbpayee.Visible = true; }
            else { gbpayee.Visible = false; }

        }

        private void btntransfer_Click(object sender, EventArgs e)
        {
            //get the amount
            double amount = double.Parse(txtamount.Text);

            //c1 to c2
            if (cbfrom.SelectedIndex == 0 && cbto.SelectedIndex == 1)
            {
                c1 = c1 - amount;
                c2 = c2 + amount;
                lblcheq1.Text = "$" + c1;
                lblcheq2.Text = "$" + c2;
                MessageBox.Show("You have successfully transfered $" + amount + " from chequing 1 to chequing 2");
            }
            //c1 to savings
            if (cbfrom.SelectedIndex == 0 && cbto.SelectedIndex == 2)
            {
                c1 = c1 - amount;
                savings = savings + amount;
                lblcheq1.Text = "$" + c1;
                lblsavings.Text = "$" + savings;
                MessageBox.Show("You have successfully transfered $" + amount + " from chequing 1 to savings");
            }
            //c1 to payee
            if (cbfrom.SelectedIndex == 0 && cbto.SelectedIndex == 3)
            {
                c1 = c1 - amount;
                lblcheq1.Text = "$" + c1;
                MessageBox.Show("You have successfully transfered $" + amount + " from chequing 1 to payee");
            }
            //c2 to c1
            if (cbfrom.SelectedIndex == 1 && cbto.SelectedIndex == 0)
            {
                c2 = c2 - amount;
                c1 = c1 + amount;
                lblcheq2.Text = "$" + c2;
                lblcheq1.Text = "$" + c1;
                MessageBox.Show("You have successfully transfered $" + amount + " from chequing 2 to chequing 1");
            }
            //c2 to savings
            if (cbfrom.SelectedIndex == 1 && cbto.SelectedIndex == 2)
            {
                c2 = c2 - amount;
                savings = savings + amount;
                lblcheq2.Text = "$" + c2;
                lblsavings.Text = "$" + savings;
                MessageBox.Show("You have successfully transfered $" + amount + " from chequing 2 to savings");
            }
            //c2 to payee
            if (cbfrom.SelectedIndex == 1 && cbto.SelectedIndex == 3)
            {
                c2 = c2 - amount;
                lblcheq2.Text = "$" + c2;
                MessageBox.Show("You have successfully transfered $" + amount + " from chequing 2 to payee");

            }
            //savings to c1
            if (cbfrom.SelectedIndex == 2 && cbto.SelectedIndex == 0)
            {
                savings = savings - amount;
                c1 = c1 + amount;
                lblsavings.Text = "$" + savings;
                lblcheq1.Text = "$" + c1;
                MessageBox.Show("You have successfully transfered $" + amount + " from savings to chequinq 1");
            }
            //savings to c2
            if (cbfrom.SelectedIndex == 2 && cbto.SelectedIndex == 1)
            {
                savings = savings - amount;
                c1 = c1 + amount;
                lblsavings.Text = "$" + savings;
                lblcheq2.Text = "$" + c2;
                MessageBox.Show("You have successfully transfered $" + amount + " from savings to chequinq 2");
            }
            //savings to payee
            if (cbfrom.SelectedIndex == 2 && cbto.SelectedIndex == 3)
            {
                savings = savings - amount;
                lblsavings.Text = "$" + savings;
                MessageBox.Show("You have successfully transfered $" + amount + " from savings to payee");
            }

        }





            public Form2(string a, string b, string c)
            {
                InitializeComponent();
                username = a;
                address = b;
                postalcode = c;
                lblname.Text = username;
                lbladdress.Text = address;
                lblpostal.Text = postalcode;
            }

            private void Form2_Load(object sender, EventArgs e)
            {

            }
        }
    }
