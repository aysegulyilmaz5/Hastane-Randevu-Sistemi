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
    public partial class Form_Patient_Detail : Form
    {
        public Form_Patient_Detail()
        {
            InitializeComponent();
        }

        public string Identity;
        SqlConnection con = new SqlConnection();

        private void Form_Patient_Detail_Load(object sender, EventArgs e)
        {
            label_identity.Text = Identity;

            SqlCommand command = new SqlCommand("Select PName,PSurname From Table_Patient where PIdentity = @p1", con.connected());
            command.Parameters.AddWithValue("@p1", label_identity.Text);
            SqlDataReader dr = command.ExecuteReader();
            while (dr.Read())
            {
                label_namesurname.Text = dr[0] +" " + dr[1];
            }
            con.connected().Close();

            //Appointment
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * From Table_Appointments where PIdentity=" + Identity, con.connected());
            da.Fill(dt);
            dataGridView1.DataSource = dt;

            //Branch
            SqlCommand command2 = new SqlCommand("Select BranchName From Table_Branches",con.connected());
            SqlDataReader dr2 = command2.ExecuteReader();
            while (dr2.Read())
            {
                comboBox_branch.Items.Add(dr[0]);
            }
            con.connected().Close();
        }

        private void comboBox_branch_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox_doctor.Items.Clear();
            SqlCommand command3 = new SqlCommand("Select DName,DSurname From Table_Doctors where DBranch=@p1", connection.connected());
            command3.Parameters.AddWithValue("@p1", comboBox_branch.Text);
            SqlDataReader dr1 = command3.ExecuteReader();
            while (dr3.Read())
            {
                comboBox_doctor.Items.Add(dr3[0] + " " + dr3[1]);

            }
            ConnectionState.connected().Close();
        }

        private void comboBox_doctor_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * From Table_Appointments where AppointmentBranch='" + comboBox_branch.Text + "'" + " and AppointmentDoctor='" + comboBox_doctor.Text + "' and AppointmentSituation=0", connection.connected());
            da.Fill(dt);
            dataGridView2.DataSource = dt;

        }

        private void linkLabel_edit_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form_EditInformation fr = new Form_EditInformation();
            fr.identitynumber = label_identity.Text;
            fr.Show();
        }

        private void dataGridView2_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int selected = dataGridView2.SelectedCells[0].RowIndex;
            textBox_ıd.Text = dataGridView2.Rows[selected].Cells[0].Value.ToString();

        }

        private void button_appointment_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("Update Table_Appointments set AppointmentSituation=1,PatientIdentify=@p1,Compliment=@p2 where AppointmentId=@p3", connection.connected());
            command.Parameters.AddWithValue("@p1", label_identity.Text);
            command.Parameters.AddWithValue("@p2", richTextBox_complaint.Text);
            command.Parameters.AddWithValue("@p3", textBox_ıd.Text);
            command.ExecuteNonQuery();
            connection.connected().Close();
            MessageBox.Show("Appointment is took", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }
}
