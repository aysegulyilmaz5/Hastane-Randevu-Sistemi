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
    public partial class Form_Doctor_Enter : Form
    {
        public Form_Doctor_Enter()
        {
            InitializeComponent();
        }
        SqlConnection connection = new SqlConnection();

        private void button_enter_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("Select * From Tabel_Doctors where DIdentify=@p1 and DPassword=@p2", connection.connected());
            command.Parameters.AddWithValue("@p1", maskedTextBox_identity.Text);
            command.Parameters.AddWithValue("@p2", textBox_password.Text);
            SqlDataReader dr = command.ExecuteReader();
            if(dr.Read()){
                Form_Doctor_Detail fr = new Form_Doctor_Detail();
                fr.Show();
                this.Hide();


            }
            else
            {
                MessageBox.Show("Incorrect name or password");
            }
            connection.connected().Close();
        }
    }
}
