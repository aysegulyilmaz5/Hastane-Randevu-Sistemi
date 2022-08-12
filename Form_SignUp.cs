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
    public partial class Form_SignUp : Form
    {
        public Form_SignUp()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection();

        private void button1_Click(object sender, EventArgs e)
        {
         SqlCommand command = new SqlCommand("insert into Table_Patient(PName,PSurname,PIdentify,Pphone,PPassword,PGender) values (@p1,@p2,@p3,@p4,@p5,@p6)", con.connected());
            command.Parameters.AddWithValue("@p1", textBox_name.Text);
            command.Parameters.AddWithValue("@p2", textBox_surname.Text);
            command.Parameters.AddWithValue("@p3", textBox_identity.Text);
            command.Parameters.AddWithValue("@p4", maskedTextBox_telephone.Text);
            command.Parameters.AddWithValue("@p5", textBox_password.Text);
            command.Parameters.AddWithValue("@p6", comboBox_gender.Text);
            command.ExecuteNonQuery();
            con.connected().close();
            MessageBox.Show("Your registration has been completed Your Password:" + textBox_password.Text, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
