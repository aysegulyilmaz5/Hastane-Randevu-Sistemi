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
    public partial class Form_Doctor_EditInformation : Form
    {
        public Form_Doctor_EditInformation()
        {
            InitializeComponent();
        }

        SqlConnection connection = new SqlConnection();
        public string identity_number;
        private void Form_Doctor_EditInformation_Load(object sender, EventArgs e)
        {
            textBox_identity.Text = identity_number;

            SqlCommand command = new SqlCommand("Select * From Table_Doctors where DIdentify=@p1", connection.connected());
            command.Parameters.AddWithValue("@p1", textBox_identity.Text);
            SqlDataReader dr = command.ExecuteNonQuery();
            while(dr.Read())
            {
                textBox_name.Text = dr[1].ToString();
                textBox_surname.Text = dr[2].ToString();
                comboBox_branch.Text = dr[3].ToString();
                textBox_password.Text = dr[5].ToString();

            }
            connection.connected().Close();

        }

        private void button_update_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("Update Table_Doctors set DName=@p1,DSurname=@p2,DBranch=@p3,DPassword = @p4 where DIdentify=@p5", connection.connected());
            command.Parameters.AddWithValue("@p1", textBox_name.Text);
            command.Parameters.AddWithValue("@p2", textBox_surname.Text);
            command.Parameters.AddWithValue("@p3", comboBox_branch.Text);
            command.Parameters.AddWithValue("@p4", textBox_password.Text);
            command.Parameters.AddWithValue("@p5", textBox_identity.Text);
            command.ExecuteNonQuery();
            connection.connected().Close();
            MessageBox.Show("Recording is update");
        }
    }
}
