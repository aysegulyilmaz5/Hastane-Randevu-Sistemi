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
    public partial class Form_Doctor_Panell : Form
    {
        public Form_Doctor_Panell()
        {
            InitializeComponent();
        }
        SqlConnection connection = new SqlConnection();
        private void Form_Doctor_Panell_Load(object sender, EventArgs e)
        {
            DataTable dt1 = new DataTable();
            SqlDataAdapter da1 = new SqlDataAdapter("Select * From Table_Doctors", connection.connected());
            da1.Fill(dt1);
            dataGridView1.DataSource = dt1;

            //Branches receive in combobox
            DataTable dt2 = new DataTable();
            SqlDataAdapter da2 = new SqlDataAdapter("Select (DName +' '+ DSurname),DBranch From Table_Doctors", connection.connected());
            da2.Fill(dt2);
            dataGridView2.DataSource = dt2;
        }

        private void button_add_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("insert into Table_Doctors (DName,DSurname,DBranch,DBranch,DPassword) values (@d1,@d2,@d3,@d4,@d5)", connection.connected());
            command.Parameters.AddWithValue("@d1", textBox_name.Text);
            command.Parameters.AddWithValue("@d2", textBox_surname.Text);
            command.Parameters.AddWithValue("@d3", comboBox_branch.Text);
            command.Parameters.AddWithValue("@d4", maskedTextBox_identity.Text);
            command.Parameters.AddWithValue("@d5", textBox_password.Text);
            command.ExecuteNonQuery();
            connection.connected().Close();
            MessageBox.Show("Doctor is added","Information",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        private void button_delete_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("Delete from Table_Doctors where DIdentify=@p1", connection.connected());
            command.Parameters.AddWithValue("@p1", maskedTextBox_identity.Text);
            command.ExecuteNonQuery();
            connection.connected().Close();
            MessageBox.Show("Recording is delete", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int selected = dataGridView1.SelectedCells[0].RowIndex;
            textBox_name.Text = dataGridView1.Rows[selected].Cells[1].Value.ToString();
            textBox_surname.Text = dataGridView1.Rows[selected].Cells[2].Value.ToString();
            comboBox_branch.Text = dataGridView1.Rows[selected].Cells[3].Value.ToString();
            maskedTextBox_identity.Text = dataGridView1.Rows[selected].Cells[4].Value.ToString();
            textBox_password.Text = dataGridView1.Rows[selected].Cells[5].Value.ToString();

        }

        private void button_update_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("Update Tabel_Doctors set DName=@d1,DSurname=@d2,DBranch=@d3,DPassword=@d5 where DIdentify=@d4", connection.connected());
            command.Parameters.AddWithValue("@d1", textBox_name.Text);
            command.Parameters.AddWithValue("@d2", textBox_surname.Text);
            command.Parameters.AddWithValue("@d3", comboBox_branch.Text);
            command.Parameters.AddWithValue("@d4", maskedTextBox_identity.Text);
            command.Parameters.AddWithValue("@d5", textBox_password.Text);
            command.ExecuteNonQuery();
            connection.connected().Close();
            MessageBox.Show("Update Doctors", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        
    }
}
