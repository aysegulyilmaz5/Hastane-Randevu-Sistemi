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
    public partial class Form_EditInformation : Form
    {
        public Form_EditInformation()
        {
            InitializeComponent();
        }

        private void textBox_name_TextChanged(object sender, EventArgs e)
        {

        }
        public string identitynumber;
        SqlConnection connection = new SqlConnection();
        private void Form_EditInformation_Load(object sender, EventArgs e)
        {
            textBox_identity.Text = identitynumber;
            SqlCommand command = new SqlCommand("Select * From Table_Patient where PIdentify = @p1", connection.connected());
            command.Parameters.AddWithValue("@p1", textBox_identity.Text);
            SqlDataReader dr = command.ExecuteReader();
            while (dr.Read())
            {
                textBox_name.Text = dr[1].ToString();
                textBox_surname.Text = dr[2].ToString();
                maskedTextBox_telephone.Text = dr[4].ToString();
                textBox_password.Text = dr[5].ToString();
                comboBox_gender.Text = dr[6].ToString();
            }
            connection.connected().Close();
        }

        private void button_editinformation_Click(object sender, EventArgs e)
        {
            SqlCommand command2 = new SqlCommand("Update Table_Patient set PName=@p1,PSurname=@p2,PTelephone=@p3,PPassword=@p4,PGender=@p5 where PIdentify=@p6", conneciton.connected());
            command2.Parameters.AddWithValue("@p1", textBox_name.Text);
            command2.Parameters.AddWithValue("@p2", textBox_surname.Text);
            command2.Parameters.AddWithValue("@p3", maskedTextBox_telephone.Text);
            command2.Parameters.AddWithValue("@p4", textBox_password.Text);
            command2.Parameters.AddWithValue("@p5", comboBox_gender.Text);
            command2.Parameters.AddWithValue("@p6", textBox_identity.Text);
            command2.ExecuteNonQuery();
            connection.connected().Close();
            MessageBox.Show("Your informations are updated", "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);

        }
    }
}
