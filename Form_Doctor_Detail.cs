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
    public partial class Form_Doctor_Detail : Form
    {
        public Form_Doctor_Detail()
        {
            InitializeComponent();
        }

        SqlConnection connection = new SqlConnection();
        public string identity_number;

        private void button3_Click(object sender, EventArgs e)
        {
            Form_Announcements fa = new Form_Announcements();
            fa.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void Form_Doctor_Detail_Load(object sender, EventArgs e)
        {
            label_identity.Text = identity_number;

            //Doctor name-surname
            SqlCommand command = new SqlCommand("Select DName,DSurname From Tabel_Doctors where DIdentify=@p1", connection.connected());
            command.Parameters.AddWithValue("@p1", label_identity.Text);
            SqlDataReader dr = command.ExecuteNonQuery();
            while (dr.Read())
            {
                label_namesurname.Text = dr[0] + " " + dr[1];

            }
            connection.connected().Close();

            //Appointments 
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * From Table_Appointments where AppointmentDoctor='" +label_namesurname.Text + "'",connection.connected());
            da.Fill(dt);
            dataGridView1.DataSource = dt;

        }

        private void button_edit_Click(object sender, EventArgs e)
        {
            Form_Doctor_EditInformation fde = new Form_Doctor_EditInformation();
            fde.identity_number = label_identity.Text;
            fde.Show();
        }

        private void button_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int selected = dataGridView1.SelectedCells[0].RowIndex;
            richTextBox1.Text = dataGridView1.Rows[selected].Cells[7].Value.ToString();
        }
    }
}
