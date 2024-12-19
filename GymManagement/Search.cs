using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace GymManagement
{
    public partial class Search : Form
    {
        public Search()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
                try
                {
                    
                    int result = Convert.ToInt32(txtSearch.Text);  

                    SqlConnection con = new SqlConnection();
                    con.ConnectionString = "Data Source = LAPTOP-5LFC93E0\\SQLEXPRESS; Initial Catalog = GYM; Integrated Security = True; Trust Server Certificate = True";

                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = con;


                    cmd.CommandText = " Select * from NewMember where MID = " + txtSearch.Text + "";

                    SqlDataAdapter DA = new SqlDataAdapter(cmd);
                    DataSet DS = new DataSet();
                    DA.Fill(DS);

                    dataGridView1.DataSource = DS.Tables[0];

                }
                catch (FormatException)
                {

                    MessageBox.Show("Please enter a valid numeric value.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception ex)
                {
                    
                    MessageBox.Show("An unexpected error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            
            

        }

        private void Search_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source = LAPTOP-5LFC93E0\\SQLEXPRESS; Initial Catalog = GYM; Integrated Security = True; Trust Server Certificate = True";

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;


            cmd.CommandText = " Select * from NewMember ";

            SqlDataAdapter DA = new SqlDataAdapter(cmd);
            DataSet DS = new DataSet();
            DA.Fill(DS);

            dataGridView1.DataSource = DS.Tables[0];
        }
    }
}
