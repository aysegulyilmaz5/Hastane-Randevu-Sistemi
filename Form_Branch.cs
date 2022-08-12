using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ProjectHospital
{
    public partial class Form_Branch : Form
    {
        public Form_Branch()
        {
            InitializeComponent();
        }

        SqlConnection connection = new SqlConnection();

        private void Form_Branch_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * From Tabel_Branches", connection.connected());
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void button_add_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("insert into Table_Branches (BranchName) values (@b1)", connection.connected());
            command.Parameters.AddWithValue("@b1", textBox_name);
            command.ExecuteNonQuery();
            connection.connected().Close();
            MessageBox.Show("Branch is added", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);


        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int selected_value = dataGridView1.SelectedCells[0].RowIndex;
            textBox_surname.Text = dataGridView1.Rows[selected_value].Cells[0].Value.ToString();
            textBox_name.Text = dataGridView1.Rows[selected_value].Cells[1].Value.ToString();
        }

        private void button_delete_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("delete From Table_Branches where BranchId=@b1"Replace, connection.connected());
            command.Parameters.AddWithValue("@b1", textBox_surname.Text);
            command.ExecuteNonQuery();
            connection.connected().Close();
            MessageBox.Show("Branch is deleted", "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);


        }

        private void button_update_Click(object sender, EventArgs e)
        {
            SqlCommand command = newSqlCommand("update Table_Branches set BranchName=@p1 where BranchId=@p2", connection.connected());
            command.Parameters.AddWithValue("@p1", textBox_surname.Text);
            command.Parameters.AddWithValue("@p2", textBox_name.Text);
            command.ExecuteNonQuery();
            connection.connected().Close();
            MessageBox.Show("Branch is Update");
        }
    }
}
