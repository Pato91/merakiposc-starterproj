using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


using System.Data.Sql;
using System.Threading;
using System.Configuration;

namespace MedicalISDB
{

    public partial class Form5 : Form
    {
        SqlConnection myConnection = new SqlConnection();
        SqlCommand myCommand = new SqlCommand();
       // SqlDataReader myReader;
        public Form5()
        {
            InitializeComponent();
        }

        private void Form5_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
      

           // string name = Name1.Text;
           // string password = Passcode1.Text;

            if (Name1.Text == "" & Passcode1.Text=="")
            {
                MessageBox.Show("Name and password", "Warning");
                return;
            }

            SqlConnection bright = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=|DataDirectory|\PharmarcyDb.mdf;Integrated Security=True");
            {
                

                try
                {
                    SqlCommand EnterValues = new SqlCommand("INSERT INTO [Users] (UserName, UserPasscode, WorkTitle, DateOfBirth, Location, UserSalary) VALUES (@UserName, @UserPasscode, @WorkTitle, @DateOfBirth, @Location, @UserSalary)", bright);
                    EnterValues.Parameters.AddWithValue("@UserName", Name1.Text);
                    EnterValues.Parameters.AddWithValue("@UserPasscode", Passcode1.Text);
                    EnterValues.Parameters.AddWithValue("@WorkTitle", WorkTitle1.Text);
                    EnterValues.Parameters.AddWithValue("@DateOfBirth", DateOfBirth1.Text);
                    EnterValues.Parameters.AddWithValue("@Location", Location1.Text);
                    EnterValues.Parameters.AddWithValue("@UserSalary", Salary1.Text);

                    bright.Open();
                    EnterValues.ExecuteNonQuery();

                    MessageBox.Show("Saved Successfuly", "DONE!", MessageBoxButtons.OK);
                }
                catch (System.Data.SqlClient.SqlException sqlException)
                {
                    // Try to close the connection
                    if (bright != null)
                        bright.Dispose();

                    //
                    //can't connect
                    //
                    System.Windows.Forms.MessageBox.Show(sqlException.Message);
                    // Stop here
                    MessageBox.Show("Not entered");
                } 
               
         
            }

            DialogResult myResult = MessageBox.Show("Do you want to add a new Item?", "OK", MessageBoxButtons.YesNo);
            if (myResult == DialogResult.Yes)
            {
                this.Dispose();
                Form5 reload = new Form5();
                reload.ShowDialog();
            }
            else
            { this.Close(); }

        }
        

        private void Name1_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Passcode1_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
       
    }
}
