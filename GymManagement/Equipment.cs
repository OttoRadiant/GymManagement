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
    public partial class Equipment : Form
    {
        public Equipment()
        {
            InitializeComponent();
        }

        private void Submit_Click(object sender, EventArgs e)
        {
            string Ename = EqpName.Text;
            string Description = txtDesc.Text;
            string MuscleUsed = txtMuscle.Text;
            string DeliveryDate = dateTimePickerDD.Text;
            string Cost = txtCost.Text;

            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source=LAPTOP-5LFC93E0\\SQLEXPRESS;Initial Catalog=GYM;Integrated Security=True;Trust Server Certificate=True";


            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;

                cmd.CommandText = "Insert into Equipment (Equipmentname, Description, MuscleUsed, DeliveryDate, Cost) " +
                    "values(@Ename, @Description, @MuscleUsed, @DeliveryDate, @Cost)";



                cmd.Parameters.AddWithValue("@Ename", Ename);
                cmd.Parameters.AddWithValue("@Description", Description);
                cmd.Parameters.AddWithValue("@MuscleUsed", MuscleUsed);
                cmd.Parameters.AddWithValue("@DeliveryDate", DeliveryDate);
                cmd.Parameters.AddWithValue("@Cost", Cost);


                con.Open();
                cmd.ExecuteNonQuery();

                MessageBox.Show("Data Saved Succesfully");


            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex.Message);
            }
            finally
            {
                con.Close();
            }

        }

        private void Reset_Click(object sender, EventArgs e)
        {
            EqpName.Clear();
            txtDesc.Clear();
            txtMuscle.Clear();
            txtCost.Clear();

            dateTimePickerDD.Value = DateTime.Now;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            EquipmentList EL = new EquipmentList();
            EL.Show();
        }
    }
}
