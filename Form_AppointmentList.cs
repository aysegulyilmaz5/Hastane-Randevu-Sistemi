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
    public partial class Form_AppointmentList : Form
    {
        public Form_AppointmentList()
        {
            InitializeComponent();
        }
        SqlConnection connection = new SqlConnection();

        private void Form_AppointmentList_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * From Tbale_Appointments", conneciton.connected());
            da.Fill(dt);
            connection.connected().Close();

        }
     
        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            
            selected = dataGridView1.SelectedCells[0].RowIndex;


        }
    }
}
