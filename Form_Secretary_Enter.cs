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
    public partial class Form_Secretary_Enter : Form
    {
        public Form_Secretary_Enter()
        {
            InitializeComponent();
        }

        SqlConnection connection = new SqlConnection();

        private void button_enter_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("Select * From Table_Secretary where SIdentify=@p1 and SPassword= @p2", connection.connected());
            command.Parameters.AddWithValue("@p1", maskedTextBox_identity.Text);
            command.Parameters.AddWithValue("@p2", textBox_password);
            SqlDataReader dr = command.ExecuteReader();
            if (dr.Read())
            {
                Form_Secretary_Detail frs = new Form_Secretary_Detail();
                frs.Identitynumber = maskedTextBox_identity.Text;
                frs.Show();
                this.Hide();
                
            }
            else
            {
                MessageBox.Show("Incorrect Identity number and Password");
            }
            connection.connected().Close();
        }
    }
}
