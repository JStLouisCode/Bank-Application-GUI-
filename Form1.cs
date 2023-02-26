using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace The_Bank
{
    public partial class Form1 : Form
    {
        string username, address, postalcode;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            //log in
            username = txtname.Text;
            address = txtaddy.Text;
            postalcode = txtposty.Text;

            //new code for next form
            Form2 main = new Form2(username, address, postalcode);
            main.Show();
            this.Hide();
        }
    }
}
