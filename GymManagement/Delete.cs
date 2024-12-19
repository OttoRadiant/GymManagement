using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace GymManagement
{
    public partial class Delete : Form
    {
        public Delete()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {



            try
            {
                int result = Convert.ToInt32(txtDelete.Text);

                if (MessageBox.Show("This will delete your data. Confirm?", "Delete Data", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    SqlConnection con = new SqlConnection();
                    con.ConnectionString = "Data Source= LAPTOP-5LFC93E0\\SQLEXPRESS; Initial Catalog = GYM; Integrated Security = True; Trust Server Certificate = True";

                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = con;
                    con.Open();

                    cmd.CommandText = "Delete from NewMember Where MID = " + txtDelete.Text + "";
                    cmd.ExecuteNonQuery();
                    con.Close();

                    SqlDataAdapter DA = new SqlDataAdapter(cmd);
                    DataSet DS = new DataSet();
                    DA.Fill(DS);

                    
                }
                else
                {
                    this.Activate();
                    SqlConnection con = new SqlConnection();
                    con.ConnectionString = "Data Source= LAPTOP-5LFC93E0\\SQLEXPRESS; Initial Catalog = GYM; Integrated Security = True; Trust Server Certificate = True";

                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = con;
                    con.Open();

                    cmd.CommandText = "Select * from NewMember ";
                    cmd.ExecuteNonQuery();
                    con.Close();

                    SqlDataAdapter DA = new SqlDataAdapter(cmd);
                    DataSet DS = new DataSet();
                    DA.Fill(DS);

                    dataGridView1.DataSource = DS.Tables[0];
                }

            


            }
            catch (FormatException)
            {
                MessageBox.Show("Enter a valid ID", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch(Exception ex)
            {
                MessageBox.Show("Unwanted error occured " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void Delete_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source= LAPTOP-5LFC93E0\\SQLEXPRESS; Initial Catalog = GYM; Integrated Security = True; Trust Server Certificate = True";

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            con.Open();

            cmd.CommandText = "Select * from NewMember ";
            cmd.ExecuteNonQuery();
            con.Close();

            SqlDataAdapter DA = new SqlDataAdapter(cmd);
            DataSet DS = new DataSet();
            DA.Fill(DS);

            dataGridView1.DataSource = DS.Tables[0];
        }
    }
}