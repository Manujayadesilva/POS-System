using POS_System;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POS_System
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            
            string enteredUsername = textBox1.Text.Trim();
            string enteredPassword = textBox2.Text.Trim();

            if (enteredUsername.Equals("pos", StringComparison.OrdinalIgnoreCase) && enteredPassword == "pos")
            {
               
                MessageBox.Show("Login successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                ManagementProduct product = new ManagementProduct();
                product.Show();
                this.Hide();


            }
            else
            {
               
                MessageBox.Show("Invalid username or password. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonHome_Click(object sender, EventArgs e)
        {
            Start start = new Start();
            start.Show();
            this.Hide();
        }
    }
}
