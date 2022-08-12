using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectHospital
{
    public partial class Form_Enter : Form
    {
        public Form_Enter()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Form_Patient_Enter fr = new Form_Patient_Enter();
            fr.Show();
            this.Hide();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Form_Doctor_Enter fr = new Form_Doctor_Enter();
            fr.Show();
            this.Hide();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Form_Secretary_Enter fr = new Form_Secretary_Enter();
            fr.Show();
            this.Hide();
        }

        private void Form_Enter_Load(object sender, EventArgs e)
        {

        }
    }
}
