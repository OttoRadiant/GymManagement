using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GymManagement
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text == "Admin" && txtPass.Text == "Admin")
            {
                Form1 Fm = new Form1();
                Fm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Incorrect User ID or Password ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
