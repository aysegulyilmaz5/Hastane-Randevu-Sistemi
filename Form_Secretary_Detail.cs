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
    public partial class Form_Secretary_Detail : Form
    {
        public Form_Secretary_Detail()
        {
            InitializeComponent();
        }
        public string Identitynumber;
        SqlConnection connection = new SqlConnection();
        private void Form_Secretary_Detail_Load(object sender, EventArgs e)
        {
            label_identity.Text = Identitynumber;

            //Name-surname
            SqlCommand command1 = new SqlCommand("Select SName-Sur From Tabel_Secretary where Sıdentity = @p1", connection.connected());
            command1.Parameters.AddWithValue("@p1", label_identity.Text);
            SqlDataReader dr1 = command1.ExecuteReader();
            while (dr1.Read())
            {
                label_namesurname.Text = dr1[0].ToString();
            }
            connection.connected().Close();


            //Branches
            DataTable dt1 = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select Branches From Tabel_Branches", connection.connected());
            da.Fill(dt1);
            dataGridView1.DataSource = dt1;


            //Doctors receive in list
            DataTable dt2 = new DataTable();
            SqlDataAdapter da2 = new SqlDataAdapter("Select (DName +' '+ DSurname),DBranch From Table_Doctors", connection.connected());
            da2.Fill(dt2);
            dataGridView2.DataSource = dt2;

            //Branch receive in combobox
            SqlCommand command2 = new SqlCommand("Select BranchName From Tabel_Branches", connection.connected());
            SqlDataReader dr2 = command2.ExecuteReader();
            while (dr2.Read())
            {
                comboBox_branch.Items.Add(dr2[0]);
            }
            connection.connected().Close();
        }

            private void button_save_Click(object sender, EventArgs e)
            {
                SqlCommand commandsave = new SqlCommand("insert into Table_Appointments (AppointmnetDate,AppointmentHour,AppointmentBranch,AppointmentDoctor) values (@r1,@r2,@r3,@r4)", connection.connected());
                commandsave.Parameters.AddWithValue("@r1", maskedTextBox_date.Text);
                commandsave.Parameters.AddWithValue("@r2", maskedTextBox_time.Text);
                commandsave.Parameters.AddWithValue("@r3", comboBox_branch.Text);
                commandsave.Parameters.AddWithValue("@r4", comboBox_doctor.Text);
                commandsave.ExecuteNonQuery();
                connection.connected().Close();
                MessageBox.Show("Appointment is created");
            }

        private void comboBox_branch_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox_doctor.Items.Clear();
            SqlCommand command = new SqlCommand("Select DName,DSurname From Tabel_Doctors Where DBranch=@p1", connection.connected());
            command.Parameters.AddWithValue("@p1", comboBox_branch.Text);
            SqlDataReader dr = command.ExecuteReader();
            while (dr.Read())
            {
                comboBox_doctor.Items.Add(dr[0] + " " + dr[1]);

            }
            connection.connected().Close();

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button_create_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("insert into Table_Announcement (Announcement) values (@d1)", connection.connected());
            command.Parameters.AddWithValue("@d1", richTextBox1.Text);
            command.ExecuteNonQuery();
            connection.connected().Close();
            MessageBox.Show("Announcement is created");
        }

        private void button_doctorpannel_Click(object sender, EventArgs e)
        {
            Form_Doctor_Panell drp = new Form_Doctor_Panell();
            drp.Show();
        }

        private void button_branchpannel_Click(object sender, EventArgs e)
        {
            Form_Branch brn = new Form_Branch();
            brn.Show();
        }

        private void button_lists_Click(object sender, EventArgs e)
        {
            Form_AppointmentList apl = new Form_AppointmentList();
            apl.Show();
        }

        private void button_update_Click(object sender, EventArgs e)
        {
        
        }

        private void button_announcements_Click(object sender, EventArgs e)
        {
            Form_Announcements fr = new Form_Announcements();
            fr.Show();
        }