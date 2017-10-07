using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MedicalISDB
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Username_TextChanged(object sender, EventArgs e)
        {

        }

        private void Passcode_TextChanged(object sender, EventArgs e)
        {

        }

        private void Login_Click(object sender, EventArgs e)
        {
            if (Passcode.Text != null)
            {
                if (Username.Text == "admin")
                {
                    if (Passcode.Text == "12345")
                    {
                        var form = new Form2();
                        form.Show();
                        this.Hide();
                    }
                    else MessageBox.Show("Invalid Password");

                }
            }
            else MessageBox.Show("Input a password");
        }
    }
}
