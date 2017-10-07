using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MedicalISDB
{
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void Form7_Load(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void AddProduct_Click(object sender, EventArgs e)
        {
             if (ProductName1.Text == ""/* & Barcode1.Text==""*/)
            {
                MessageBox.Show("Poduct Name and Barcode", "Warning");
                return;
            }

            SqlConnection ayebale = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=|DataDirectory|\PharmarcyDb.mdf;Integrated Security=True");
            {
                

                try
                {
                    SqlCommand AddInventory = new SqlCommand("INSERT INTO [Inventory] (ProductName, ProductDescription, Manufacturer, DateOfEntry, DateOfExit, Category, ExpiryDate, ProductPrice) VALUES (@ProductName, @ProductDescription, @Manufacturer, @DateOfEntry, @DateOfExit, @Category, @ExpiryDate, @ProductPrice)", ayebale);
                    AddInventory.Parameters.AddWithValue("@ProductName", ProductName1.Text);
                    AddInventory.Parameters.AddWithValue("@ProductDescription", ProductDescription1.Text);
                    AddInventory.Parameters.AddWithValue("@Manufacturer", Manufacturer1.Text);
                    AddInventory.Parameters.AddWithValue("@DateOfEntry", DateOfEntry1.Text);
                    AddInventory.Parameters.AddWithValue("@DateOfExit", DateOfExit1.Text);
                    AddInventory.Parameters.AddWithValue("@Category", Category1.Text);
                    AddInventory.Parameters.AddWithValue("@ExpiryDate", ExpiryDate1.Text);
                    AddInventory.Parameters.AddWithValue("@ProductPrice", ProductPrice1.Text);

                    ayebale.Open();
                    AddInventory.ExecuteNonQuery();

                    MessageBox.Show("Saved Successfuly", "DONE!", MessageBoxButtons.OK);
                }
                catch (System.Data.SqlClient.SqlException sqlException)
                {
                    // Try to close the connection
                    if (ayebale != null)
                        ayebale.Dispose();

                    //
                    //can't connect
                    //
                    System.Windows.Forms.MessageBox.Show(sqlException.Message);
                    // Stop here
                    MessageBox.Show("Not saved, please resave");
                } 
               
         
            }

            DialogResult myResult = MessageBox.Show("Do you want to add a new Item?", "OK", MessageBoxButtons.YesNo);
            if (myResult == DialogResult.Yes)
            {
                this.Dispose();
                Form7 reload = new Form7();
                reload.ShowDialog();
            }
            else
            { this.Close(); }

        
        }
    }
}
