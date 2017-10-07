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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void addUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form1 = new Form5();
            form1.Show();
        }

        private void showUsersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form6 = new Form6();
            form6.Show();
        }

        private void addStockToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form7 = new Form7();
            form7.Show();
            
        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void menu1_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void avaliableStockToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form3 = new Form3();
            form3.Show();
        }

        private void sellItemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form4 = new Form4();
            form4.Show();
        }

        private void salesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form8 = new Form8();
            form8.Show();
        }
    }
}
