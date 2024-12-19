//using System;
//using System.Collections.Generic;
//using System.ComponentModel;
//using System.Data;
//using System.Drawing;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using System.Windows.Forms;
//using Microsoft.Data.SqlClient;

//namespace GymManagement
//{
//    public partial class NewMember : Form
//    {

//        public NewMember()
//        {
//            InitializeComponent();
//        }

//        private void Submit_Click(object sender, EventArgs e)
//        {
//            String Fname = txtFname.Text;
//            String Lname = txtLname.Text;

//            String Gender = "";
//            bool isCheked = radioButton1.Checked;

//            if (isCheked)
//            {
//                Gender = radioButton1.Text;
//            }
//            else
//            {
//                Gender = radioButton2.Text;
//            }

//            String DOB = dateTimePicker1.Text;

//            Int64 Mobile = Int64.Parse(MobNo.Text);
//            String Email = txtEmail.Text;
//            String Joindate = dateTimePicker2.Text;

//            String gymtime = GymcomboBox.Text;
//            String Address = txtAddress.Text;
//            String Membershiptime = MshipcomboBox.Text;

//            SqlConnection con = new SqlConnection();
//            //con.ConnectionString = "data source = LAPTOP-5LFC93E0\\SQLEXPRESS; database = GYM; integrated security=True";
//            //con.ConnectionString = "data source = LAPTOP-5LFC93E0\\SQLEXPRESS; database = GYM; integrated security=True";
//            con.ConnectionString = "Data Source=LAPTOP-5LFC93E0\\SQLEXPRESS;Initial Catalog=GYM;Integrated Security=True;Trust Server Certificate=True";
//            SqlCommand cmd = new SqlCommand();
//               cmd.Connection = con;

//            cmd.CommandText = "Insert into NewMember(Fname, Lname,  Gender, DOB, Mobile, Email, Joindate, gymtime, Address, Membershiptime) " +
//                "values ("+Fname+", "+Lname+","+Gender+","+DOB+","+Mobile+","+Email+","+Joindate+","+gymtime+","+Address+","+Membershiptime+")";
//            SqlDataAdapter DA = new SqlDataAdapter(cmd);

//            DataSet DS = new DataSet();
//            DA.Fill(DS);
//            MessageBox.Show("Data Saved Succesfully");
//        }

//    }
//}

using System;
using System.Data;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace GymManagement
{
    public partial class NewMember : Form
    {
        public NewMember()
        {
            InitializeComponent();
        }

        private void Submit_Click(object sender, EventArgs e)
        {

            String Fname = txtFname.Text;
            String Lname = txtLname.Text;

            String Gender = radioButton1.Checked ? radioButton1.Text : radioButton2.Text;


            DateTime DOB = dateTimePicker1.Value;
            DateTime Joindate = dateTimePicker2.Value;


            String Mobile = MobNo.Text;

            String Email = txtEmail.Text;
            String gymtime = GymcomboBox.Text;
            String Address = txtAddress.Text;
            String Membershiptime = MshipcomboBox.Text;

            // Establish SQL connection
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source=LAPTOP-5LFC93E0\\SQLEXPRESS;Initial Catalog=GYM;Integrated Security=True;Trust Server Certificate=True";

            try
            {
                // Create a SQL command using parameterized query
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;

                // Use parameterized queries to prevent SQL injection
                cmd.CommandText = "INSERT INTO NewMember (Fname, Lname, Gender, DOB, Mobile, Email, Joindate, gymtime, Maddress, Membershiptime) " +
                                  "VALUES (@Fname, @Lname, @Gender, @DOB, @Mobile, @Email, @Joindate, @gymtime, @Address, @Membershiptime)";

                // Add parameters to the command
                cmd.Parameters.AddWithValue("@Fname", Fname);
                cmd.Parameters.AddWithValue("@Lname", Lname);
                cmd.Parameters.AddWithValue("@Gender", Gender);
                cmd.Parameters.AddWithValue("@DOB", DOB);
                cmd.Parameters.AddWithValue("@Mobile", Mobile);
                cmd.Parameters.AddWithValue("@Email", Email);
                cmd.Parameters.AddWithValue("@Joindate", Joindate);
                cmd.Parameters.AddWithValue("@gymtime", gymtime);
                cmd.Parameters.AddWithValue("@Address", Address);
                cmd.Parameters.AddWithValue("@Membershiptime", Membershiptime);

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

            GymcomboBox.ResetText();
            MshipcomboBox.ResetText();

            dateTimePicker1.Value = DateTime.Now;
            dateTimePicker2.Value = DateTime.Now;   
                

        }
    }
}
