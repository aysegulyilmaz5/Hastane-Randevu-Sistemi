
namespace ProjectHospital
{
    partial class Form_Patient_Detail
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Patient_Detail));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label_namesurname = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label_identity = new System.Windows.Forms.Label();
            this.label_name = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBox_ıd = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.linkLabel_edit = new System.Windows.Forms.LinkLabel();
            this.button_appointment = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBox_doctor = new System.Windows.Forms.ComboBox();
            this.richTextBox_complaint = new System.Windows.Forms.RichTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBox_branch = new System.Windows.Forms.ComboBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label_namesurname);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label_identity);
            this.groupBox1.Controls.Add(this.label_name);
            this.groupBox1.Location = new System.Drawing.Point(12, 11);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(272, 164);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Patient Information";
            // 
            // label_namesurname
            // 
            this.label_namesurname.AutoSize = true;
            this.label_namesurname.Location = new System.Drawing.Point(95, 76);
            this.label_namesurname.Name = "label_namesurname";
            this.label_namesurname.Size = new System.Drawing.Size(46, 13);
            this.label_namesurname.TabIndex = 18;
            this.label_namesurname.Text = "Null Null";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "Name Surname:";
            // 
            // label_identity
            // 
            this.label_identity.AutoSize = true;
            this.label_identity.Location = new System.Drawing.Point(111, 46);
            this.label_identity.Name = "label_identity";
            this.label_identity.Size = new System.Drawing.Size(73, 13);
            this.label_identity.TabIndex = 16;
            this.label_identity.Text = "00000000000";
            // 
            // label_name
            // 
            this.label_name.AutoSize = true;
            this.label_name.Location = new System.Drawing.Point(21, 46);
            this.label_name.Name = "label_name";
            this.label_name.Size = new System.Drawing.Size(84, 13);
            this.label_name.TabIndex = 15;
            this.label_name.Text = "Identity Number:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textBox_ıd);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.linkLabel_edit);
            this.groupBox2.Controls.Add(this.button_appointment);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.comboBox_doctor);
            this.groupBox2.Controls.Add(this.richTextBox_complaint);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.comboBox_branch);
            this.groupBox2.Location = new System.Drawing.Point(12, 188);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(271, 253);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Appointment Pannel";
            // 
            // textBox_ıd
            // 
            this.textBox_ıd.Enabled = false;
            this.textBox_ıd.Location = new System.Drawing.Point(98, 22);
            this.textBox_ıd.Name = "textBox_ıd";
            this.textBox_ıd.Size = new System.Drawing.Size(92, 20);
            this.textBox_ıd.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(19, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Id:";
            // 
            // linkLabel_edit
            // 
            this.linkLabel_edit.AutoSize = true;
            this.linkLabel_edit.Location = new System.Drawing.Point(6, 221);
            this.linkLabel_edit.Name = "linkLabel_edit";
            this.linkLabel_edit.Size = new System.Drawing.Size(105, 13);
            this.linkLabel_edit.TabIndex = 6;
            this.linkLabel_edit.TabStop = true;
            this.linkLabel_edit.Text = "Edit Your Information";
            this.linkLabel_edit.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel_edit_LinkClicked);
            // 
            // button_appointment
            // 
            this.button_appointment.Location = new System.Drawing.Point(116, 209);
            this.button_appointment.Name = "button_appointment";
            this.button_appointment.Size = new System.Drawing.Size(126, 36);
            this.button_appointment.TabIndex = 2;
            this.button_appointment.Text = "Take Appointment";
            this.button_appointment.UseVisualStyleBackColor = true;
            this.button_appointment.Click += new System.EventHandler(this.button_appointment_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(36, 103);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Complaint:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(33, 73);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Doctor:";
            // 
            // comboBox_doctor
            // 
            this.comboBox_doctor.FormattingEnabled = true;
            this.comboBox_doctor.Location = new System.Drawing.Point(98, 73);
            this.comboBox_doctor.Name = "comboBox_doctor";
            this.comboBox_doctor.Size = new System.Drawing.Size(92, 21);
            this.comboBox_doctor.TabIndex = 3;
            this.comboBox_doctor.SelectedIndexChanged += new System.EventHandler(this.comboBox_doctor_SelectedIndexChanged);
            // 
            // richTextBox_complaint
            // 
            this.richTextBox_complaint.Location = new System.Drawing.Point(98, 100);
            this.richTextBox_complaint.Name = "richTextBox_complaint";
            this.richTextBox_complaint.Size = new System.Drawing.Size(144, 103);
            this.richTextBox_complaint.TabIndex = 2;
            this.richTextBox_complaint.Text = "";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(33, 47);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Branch:";
            // 
            // comboBox_branch
            // 
            this.comboBox_branch.FormattingEnabled = true;
            this.comboBox_branch.Location = new System.Drawing.Point(98, 44);
            this.comboBox_branch.Name = "comboBox_branch";
            this.comboBox_branch.Size = new System.Drawing.Size(92, 21);
            this.comboBox_branch.TabIndex = 0;
            this.comboBox_branch.SelectedIndexChanged += new System.EventHandler(this.comboBox_branch_SelectedIndexChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dataGridView1);
            this.groupBox3.Location = new System.Drawing.Point(297, 11);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(491, 256);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Appointment History";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 16);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(485, 237);
            this.dataGridView1.TabIndex = 0;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.dataGridView2);
            this.groupBox4.Location = new System.Drawing.Point(298, 272);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(489, 168);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Active Appointment";
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView2.Location = new System.Drawing.Point(3, 16);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(483, 149);
            this.dataGridView2.TabIndex = 0;
            this.dataGridView2.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellDoubleClick);
            // 
            // Form_Patient_Detail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form_Patient_Detail";
            this.Text = "Form_Patient_Detail";
            this.Load += new System.EventHandler(this.Form_Patient_Detail_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label_namesurname;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label_identity;
        private System.Windows.Forms.Label label_name;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBox_doctor;
        private System.Windows.Forms.RichTextBox richTextBox_complaint;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBox_branch;
        private System.Windows.Forms.Button button_appointment;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.LinkLabel linkLabel_edit;
        private System.Windows.Forms.TextBox textBox_ıd;
        private System.Windows.Forms.Label label1;
    }
}