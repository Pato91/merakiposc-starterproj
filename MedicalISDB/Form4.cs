using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Windows;
using System.Data.SqlClient;
using System.Security;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MedicalISDB
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

       
        public void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
       /* private static void OnSqlRowsTransfer(object sender, SqlRowsCopiedEventArgs e)
        {
            MessageBox.Show("Item Transfered");
        }*/
 
        private void CheckOut_Click(object sender, EventArgs e)
        {
            /* if (ProductID.Text == "" & Barcode1.Text=="")
             {
                 MessageBox.Show("Poduct Name and Barcode", "Warning");
                 return;
             }*/

            #region soldItemsDbAndCalc


            string connectionString = @"Data Source=(LocalDB)\v11.0;AttachDbFilename=|DataDirectory|\PharmarcyDb.mdf;Integrated Security=True";
            // get the source data
            using (SqlConnection johnson =
                    new SqlConnection(connectionString))
            {
                int value = int.Parse(ProductID.Text);
                
                SqlCommand myCommand = new SqlCommand("INSERT INTO [SoldItems] (ItemBarcode, ItemName, ItemPrice) (SELECT Barcode as_required, ProductName, ProductPrice FROM [Inventory] WHERE Barcode=@value  ) ", johnson);
                myCommand.Parameters.Add("value", SqlDbType.Int).Value = value;
                
                johnson.Open();
                
                myCommand.ExecuteReader();
            }

            this.soldItemsTableAdapter.Fill(this.pharmarcyDbDataSet3.SoldItems);
            this.dataGridView1.DataSource = this.pharmarcyDbDataSet3.SoldItems;
            this.dataGridView1.Refresh();
            using (SqlConnection totals = new SqlConnection(connectionString))
            {
                totals.Open();
                SqlCommand total = new SqlCommand("SELECT SUM(ItemPrice) AS ItemPrice FROM [SoldItems]", totals);

                int sum = Convert.ToInt32(total.ExecuteScalar());
                label5.Text = sum.ToString();
                ProductID.Clear();
            }
            

            #endregion
        }

        
        private void Form4_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'pharmarcyDbDataSet3.SoldItems' table. You can move, or remove it, as needed.
            
            //this.soldItemsTableAdapter.Fill(this.pharmarcyDbDataSet3.SoldItems);
                
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void buttonRegister_Click(object sender, EventArgs e)
        {
            string connectionSource = @"Data Source=(LocalDB)\v11.0;AttachDbFilename=|DataDirectory|\PharmarcyDb.mdf;Integrated Security=True";

            int PaidAmount = Convert.ToInt32(PaidAmount1.Text);
            int sum = Convert.ToInt32(label5.Text);
            if (PaidAmount >= sum)
            {
                using (SqlConnection Transfer = new SqlConnection(connectionSource))
                {
                    SqlCommand TransferTransaction = new SqlCommand("SELECT * FROM [Inventory] WHERE EXISTS (SELECT * FROM [SoldItems] WHERE ItemBarcode = Barcode)", Transfer);
                    Transfer.Open();

                    SqlDataReader reader = TransferTransaction.ExecuteReader();

                    using (SqlBulkCopy copyAll = new SqlBulkCopy(Transfer.ConnectionString))
                    {
                        copyAll.BatchSize = dataGridView1.Rows.Count;
                        copyAll.NotifyAfter = dataGridView1.Rows.Count;
                        //copyAll.SqlRowsCopied += new SqlRowsCopiedEventHandler(copyAll_SqlRowsCopied);      
                        copyAll.DestinationTableName = "Sales";
                        copyAll.WriteToServer(reader);

                    }

                    Transfer.Close();

                    for (int i = 1; i <= dataGridView1.Rows.Count; i++)
                    {
                        Transfer.Open();
                        SqlCommand deleteInventory = new SqlCommand("DELETE FROM [Inventory] WHERE EXISTS (SELECT * FROM [SoldItems] WHERE ItemBarcode = Barcode)", Transfer);
                        deleteInventory.ExecuteNonQuery();
                        SqlCommand deleteSold = new SqlCommand("DELETE FROM [SoldItems] WHERE EXISTS (SELECT * FROM [Inventory] WHERE Barcode = ItemBarcode)", Transfer);
                        deleteSold.ExecuteNonQuery();
                        Transfer.Close();
                    }
                }
                int change = PaidAmount - sum;
                labelChange.Text = change.ToString();
                PaidAmount1.Clear();


            }

            else MessageBox.Show("Insufficient amount paid!");
        }

        private void PaidAmount1_TextChanged(object sender, EventArgs e)
        {

        }

       
    }
}
