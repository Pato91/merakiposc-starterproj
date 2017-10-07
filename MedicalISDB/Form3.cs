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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'pharmarcyDbDataSet2.Inventory' table. You can move, or remove it, as needed.
            this.inventoryTableAdapter.Fill(this.pharmarcyDbDataSet2.Inventory);

        }
    }
}
