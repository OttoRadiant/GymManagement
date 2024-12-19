using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace GymManagement
{
    public partial class EquipmentList : Form
    {
        public EquipmentList()
        {
            InitializeComponent();
        }

        private void EquipmentList_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source = LAPTOP-5LFC93E0\\SQLEXPRESS; Initial Catalog = GYM; Integrated Security=True; Trust Server Certificate=True";

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;

                cmd.CommandText = "Select * from Equipment";


                con.Open();
                SqlDataAdapter DA = new SqlDataAdapter(cmd);
                DataSet DS = new DataSet(); 
                DA.Fill(DS);
                
                dataGridView1.DataSource = DS.Tables[0];
            
        }
    }
}
