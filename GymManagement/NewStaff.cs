using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace GymManagement
{
    public partial class NewStaff : Form
    {
        public NewStaff()
        {
            InitializeComponent();
        }

        private void Submit_Click(object sender, EventArgs e)
        {
            String Fname = txtFname.Text;
            String Lname = txtLname.Text;

            String Gender = radioButton1.Checked ? radioButton1.Text : radioButton2.Text;


            DateTime DOB = dateTimePickerDOB.Value;
            DateTime Joindate = dateTimePickerJD.Value;


            String Mobile = MobNo.Text;

            String Email = txtEmail.Text;
            String Designation = DesgcomboBox.Text;
            String Address = txtAddress.Text;

            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source=LAPTOP-5LFC93E0\\SQLEXPRESS;Initial Catalog=GYM;Integrated Security=True;Trust Server Certificate=True";

            try
            {
                // Create a SQL command using parameterized query
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;

                // Use parameterized queries to prevent SQL injection
                cmd.CommandText = "INSERT INTO NewStaff (Fname, Lname, Gender, DOB, Mobile, Email, JoinDate, Designation, Address) " +
                                  "VALUES (@Fname, @Lname, @Gender, @DOB, @Mobile, @Email, @Joindate, @Designation, @Address)";

                // Add parameters to the command
                cmd.Parameters.AddWithValue("@Fname", Fname);
                cmd.Parameters.AddWithValue("@Lname", Lname);
                cmd.Parameters.AddWithValue("@Gender", Gender);
                cmd.Parameters.AddWithValue("@DOB", DOB);
                cmd.Parameters.AddWithValue("@Mobile", Mobile);
                cmd.Parameters.AddWithValue("@Email", Email);
                cmd.Parameters.AddWithValue("@Joindate", Joindate);
                cmd.Parameters.AddWithValue("@Designation", Designation);
                cmd.Parameters.AddWithValue("@Address", Address);

                // Open the connection and execute the query
                con.Open();
                cmd.ExecuteNonQuery(); // Execute the command

                // Show success message
                MessageBox.Show("Data Saved Successfully");
            }
            catch (Exception ex)
            {
                // Handle any errors that occur
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                // Close the connection
                con.Close();
            }

        }

        private void Reset_Click(object sender, EventArgs e)
        {
            txtFname.Clear();
            txtLname.Clear();

            radioButton1.Checked = false;
            radioButton2.Checked = false;

            MobNo.Clear();
            txtEmail.Clear();
            txtAddress.Clear();

            DesgcomboBox.ResetText();
            

            dateTimePickerDOB.Value = DateTime.Now;
            dateTimePickerJD.Value = DateTime.Now;
        }
    }
}
