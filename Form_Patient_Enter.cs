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
    public partial class Form_Patient_Enter : Form
    {
        public Form_Patient_Enter()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection();
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form_SignUp fr = new Form_SignUp();
            fr.Show();
        }

        private void button_enter_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("Select * From Table_Patient Where PIdentity=@p1 and PPassword=@p2", con.connected());
            command.Parameters.AddWithValue("@p1", maskedTextBox_identity.Text);
            command.Parameters.AddWithValue("@p2", textBox_password.Text);
            SqlDataReader dr = command.ExecuteReader();
            if(dr.Read())
            {
                Form_Patient_Detail fr = new Form_Patient_Detail();
                fr.Identity = maskedTextBox_identity.Text;
                fr.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Incorrect Identity number and password");
            }

            con.connected().Close();
        }

        private void textBox_password_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
