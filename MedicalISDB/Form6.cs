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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'pharmarcyDbDataSet1.Users' table. You can move, or remove it, as needed.
            this.usersTableAdapter1.Fill(this.pharmarcyDbDataSet1.Users);
            // TODO: This line of code loads data into the 'pharmarcyDbDataSet.Users' table. You can move, or remove it, as needed.
            this.usersTableAdapter.Fill(this.pharmarcyDbDataSet.Users);

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void usersBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void vScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {

        }
    }
}
