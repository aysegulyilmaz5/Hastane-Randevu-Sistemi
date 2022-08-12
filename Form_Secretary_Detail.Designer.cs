
namespace ProjectHospital
{
    partial class Form_Secretary_Detail
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
            this.groupBox_secretaryinf = new System.Windows.Forms.GroupBox();
            this.label_namesurname = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label_identity = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.button_create = new System.Windows.Forms.Button();
            this.groupBox_appointment = new System.Windows.Forms.GroupBox();
            this.button_save = new System.Windows.Forms.Button();
            this.checkBox_situation = new System.Windows.Forms.CheckBox();
            this.maskedTextBox_identity = new System.Windows.Forms.MaskedTextBox();
            this.comboBox_doctor = new System.Windows.Forms.ComboBox();
            this.comboBox_branch = new System.Windows.Forms.ComboBox();
            this.maskedTextBox_time = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBox_date = new System.Windows.Forms.MaskedTextBox();
            this.textBox_id = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox_branches = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox_doctors = new System.Windows.Forms.GroupBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.groupBox_fast = new System.Windows.Forms.GroupBox();
            this.button_lists = new System.Windows.Forms.Button();
            this.button_branchpannel = new System.Windows.Forms.Button();
            this.button_doctorpannel = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.button_announcements = new System.Windows.Forms.Button();
            this.groupBox_secretaryinf.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox_appointment.SuspendLayout();
            this.groupBox_branches.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox_doctors.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.groupBox_fast.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox_secretaryinf
            // 
            this.groupBox_secretaryinf.Controls.Add(this.label_namesurname);
            this.groupBox_secretaryinf.Controls.Add(this.label3);
            this.groupBox_secretaryinf.Controls.Add(this.label_identity);
            this.groupBox_secretaryinf.Controls.Add(this.label2);
            this.groupBox_secretaryinf.Controls.Add(this.label1);
            this.groupBox_secretaryinf.Location = new System.Drawing.Point(7, 14);
            this.groupBox_secretaryinf.Name = "groupBox_secretaryinf";
            this.groupBox_secretaryinf.Size = new System.Drawing.Size(271, 141);
            this.groupBox_secretaryinf.TabIndex = 0;
            this.groupBox_secretaryinf.TabStop = false;
            this.groupBox_secretaryinf.Text = "Secretary Information";
            // 
            // label_namesurname
            // 
            this.label_namesurname.AutoSize = true;
            this.label_namesurname.Location = new System.Drawing.Point(144, 75);
            this.label_namesurname.Name = "label_namesurname";
            this.label_namesurname.Size = new System.Drawing.Size(46, 13);
            this.label_namesurname.TabIndex = 7;
            this.label_namesurname.Text = "Null Null";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(54, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Name Surname:";
            // 
            // label_identity
            // 
            this.label_identity.AutoSize = true;
            this.label_identity.Location = new System.Drawing.Point(144, 53);
            this.label_identity.Name = "label_identity";
            this.label_identity.Size = new System.Drawing.Size(73, 13);
            this.label_identity.TabIndex = 5;
            this.label_identity.Text = "00000000000";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(54, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Identity Number:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.richTextBox1);
            this.groupBox2.Controls.Add(this.button_create);
            this.groupBox2.Location = new System.Drawing.Point(9, 167);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(268, 209);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Create Announcements";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(6, 19);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(244, 125);
            this.richTextBox1.TabIndex = 1;
            this.richTextBox1.Text = "";
            this.richTextBox1.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // button_create
            // 
            this.button_create.Location = new System.Drawing.Point(6, 150);
            this.button_create.Name = "button_create";
            this.button_create.Size = new System.Drawing.Size(244, 45);
            this.button_create.TabIndex = 0;
            this.button_create.Text = "Create";
            this.button_create.UseVisualStyleBackColor = true;
            this.button_create.Click += new System.EventHandler(this.button_create_Click);
            // 
            // groupBox_appointment
            // 
            this.groupBox_appointment.Controls.Add(this.button_save);
            this.groupBox_appointment.Controls.Add(this.checkBox_situation);
            this.groupBox_appointment.Controls.Add(this.maskedTextBox_identity);
            this.groupBox_appointment.Controls.Add(this.comboBox_doctor);
            this.groupBox_appointment.Controls.Add(this.comboBox_branch);
            this.groupBox_appointment.Controls.Add(this.maskedTextBox_time);
            this.groupBox_appointment.Controls.Add(this.maskedTextBox_date);
            this.groupBox_appointment.Controls.Add(this.textBox_id);
            this.groupBox_appointment.Controls.Add(this.label9);
            this.groupBox_appointment.Controls.Add(this.label8);
            this.groupBox_appointment.Controls.Add(this.label7);
            this.groupBox_appointment.Controls.Add(this.label6);
            this.groupBox_appointment.Controls.Add(this.label5);
            this.groupBox_appointment.Controls.Add(this.label4);
            this.groupBox_appointment.Location = new System.Drawing.Point(294, 12);
            this.groupBox_appointment.Name = "groupBox_appointment";
            this.groupBox_appointment.Size = new System.Drawing.Size(242, 361);
            this.groupBox_appointment.TabIndex = 2;
            this.groupBox_appointment.TabStop = false;
            this.groupBox_appointment.Text = "Appointment Pannel";
            // 
            // button_save
            // 
            this.button_save.Location = new System.Drawing.Point(50, 273);
            this.button_save.Name = "button_save";
            this.button_save.Size = new System.Drawing.Size(147, 43);
            this.button_save.TabIndex = 14;
            this.button_save.Text = "Save";
            this.button_save.UseVisualStyleBackColor = true;
            this.button_save.Click += new System.EventHandler(this.button_save_Click);
            // 
            // checkBox_situation
            // 
            this.checkBox_situation.AutoSize = true;
            this.checkBox_situation.Location = new System.Drawing.Point(89, 207);
            this.checkBox_situation.Name = "checkBox_situation";
            this.checkBox_situation.Size = new System.Drawing.Size(67, 17);
            this.checkBox_situation.TabIndex = 13;
            this.checkBox_situation.Text = "Situation";
            this.checkBox_situation.UseVisualStyleBackColor = true;
            // 
            // maskedTextBox_identity
            // 
            this.maskedTextBox_identity.Location = new System.Drawing.Point(89, 174);
            this.maskedTextBox_identity.Mask = "00000000000";
            this.maskedTextBox_identity.Name = "maskedTextBox_identity";
            this.maskedTextBox_identity.Size = new System.Drawing.Size(108, 20);
            this.maskedTextBox_identity.TabIndex = 12;
            // 
            // comboBox_doctor
            // 
            this.comboBox_doctor.FormattingEnabled = true;
            this.comboBox_doctor.Location = new System.Drawing.Point(89, 139);
            this.comboBox_doctor.Name = "comboBox_doctor";
            this.comboBox_doctor.Size = new System.Drawing.Size(108, 21);
            this.comboBox_doctor.TabIndex = 11;
            // 
            // comboBox_branch
            // 
            this.comboBox_branch.FormattingEnabled = true;
            this.comboBox_branch.Location = new System.Drawing.Point(89, 107);
            this.comboBox_branch.Name = "comboBox_branch";
            this.comboBox_branch.Size = new System.Drawing.Size(108, 21);
            this.comboBox_branch.TabIndex = 10;
            this.comboBox_branch.SelectedIndexChanged += new System.EventHandler(this.comboBox_branch_SelectedIndexChanged);
            // 
            // maskedTextBox_time
            // 
            this.maskedTextBox_time.Location = new System.Drawing.Point(89, 81);
            this.maskedTextBox_time.Mask = "00:00";
            this.maskedTextBox_time.Name = "maskedTextBox_time";
            this.maskedTextBox_time.Size = new System.Drawing.Size(108, 20);
            this.maskedTextBox_time.TabIndex = 9;
            this.maskedTextBox_time.ValidatingType = typeof(System.DateTime);
            // 
            // maskedTextBox_date
            // 
            this.maskedTextBox_date.Location = new System.Drawing.Point(89, 55);
            this.maskedTextBox_date.Mask = "00/00/0000";
            this.maskedTextBox_date.Name = "maskedTextBox_date";
            this.maskedTextBox_date.Size = new System.Drawing.Size(108, 20);
            this.maskedTextBox_date.TabIndex = 8;
            this.maskedTextBox_date.ValidatingType = typeof(System.DateTime);
            // 
            // textBox_id
            // 
            this.textBox_id.Location = new System.Drawing.Point(89, 25);
            this.textBox_id.Name = "textBox_id";
            this.textBox_id.Size = new System.Drawing.Size(108, 20);
            this.textBox_id.TabIndex = 7;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 177);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(84, 13);
            this.label9.TabIndex = 5;
            this.label9.Text = "Identity Number:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(41, 147);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(42, 13);
            this.label8.TabIndex = 4;
            this.label8.Text = "Doctor:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(39, 115);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 13);
            this.label7.TabIndex = 3;
            this.label7.Text = "Branch:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(39, 84);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(33, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "Time:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(39, 57);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Date:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(39, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(21, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "ID:";
            // 
            // groupBox_branches
            // 
            this.groupBox_branches.Controls.Add(this.dataGridView1);
            this.groupBox_branches.Location = new System.Drawing.Point(549, 12);
            this.groupBox_branches.Name = "groupBox_branches";
            this.groupBox_branches.Size = new System.Drawing.Size(243, 194);
            this.groupBox_branches.TabIndex = 3;
            this.groupBox_branches.TabStop = false;
            this.groupBox_branches.Text = "Branches";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 16);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(237, 175);
            this.dataGridView1.TabIndex = 0;
            // 
            // groupBox_doctors
            // 
            this.groupBox_doctors.Controls.Add(this.dataGridView2);
            this.groupBox_doctors.Location = new System.Drawing.Point(552, 233);
            this.groupBox_doctors.Name = "groupBox_doctors";
            this.groupBox_doctors.Size = new System.Drawing.Size(243, 205);
            this.groupBox_doctors.TabIndex = 4;
            this.groupBox_doctors.TabStop = false;
            this.groupBox_doctors.Text = "Doctors";
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView2.Location = new System.Drawing.Point(3, 16);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(237, 186);
            this.dataGridView2.TabIndex = 0;
            // 
            // groupBox_fast
            // 
            this.groupBox_fast.Controls.Add(this.button_announcements);
            this.groupBox_fast.Controls.Add(this.button_lists);
            this.groupBox_fast.Controls.Add(this.button_branchpannel);
            this.groupBox_fast.Controls.Add(this.button_doctorpannel);
            this.groupBox_fast.Location = new System.Drawing.Point(7, 385);
            this.groupBox_fast.Name = "groupBox_fast";
            this.groupBox_fast.Size = new System.Drawing.Size(529, 83);
            this.groupBox_fast.TabIndex = 5;
            this.groupBox_fast.TabStop = false;
            this.groupBox_fast.Text = "Fast Access";
            // 
            // button_lists
            // 
            this.button_lists.Location = new System.Drawing.Point(270, 35);
            this.button_lists.Name = "button_lists";
            this.button_lists.Size = new System.Drawing.Size(117, 28);
            this.button_lists.TabIndex = 18;
            this.button_lists.Text = "Appointment Lists";
            this.button_lists.UseVisualStyleBackColor = true;
            this.button_lists.Click += new System.EventHandler(this.button_lists_Click);
            // 
            // button_branchpannel
            // 
            this.button_branchpannel.Location = new System.Drawing.Point(147, 35);
            this.button_branchpannel.Name = "button_branchpannel";
            this.button_branchpannel.Size = new System.Drawing.Size(117, 28);
            this.button_branchpannel.TabIndex = 17;
            this.button_branchpannel.Text = "Branch Pannel";
            this.button_branchpannel.UseVisualStyleBackColor = true;
            this.button_branchpannel.Click += new System.EventHandler(this.button_branchpannel_Click);
            // 
            // button_doctorpannel
            // 
            this.button_doctorpannel.Location = new System.Drawing.Point(20, 35);
            this.button_doctorpannel.Name = "button_doctorpannel";
            this.button_doctorpannel.Size = new System.Drawing.Size(117, 28);
            this.button_doctorpannel.TabIndex = 16;
            this.button_doctorpannel.Text = "Doctor Pannel";
            this.button_doctorpannel.UseVisualStyleBackColor = true;
            this.button_doctorpannel.Click += new System.EventHandler(this.button_doctorpannel_Click);
            // 
            // button_announcements
            // 
            this.button_announcements.Location = new System.Drawing.Point(406, 35);
            this.button_announcements.Name = "button_announcements";
            this.button_announcements.Size = new System.Drawing.Size(117, 28);
            this.button_announcements.TabIndex = 19;
            this.button_announcements.Text = "Announcements";
            this.button_announcements.UseVisualStyleBackColor = true;
            this.button_announcements.Click += new System.EventHandler(this.button_announcements_Click);
            // 
            // Form_Secretary_Detail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 480);
            this.Controls.Add(this.groupBox_fast);
            this.Controls.Add(this.groupBox_doctors);
            this.Controls.Add(this.groupBox_branches);
            this.Controls.Add(this.groupBox_appointment);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox_secretaryinf);
            this.Name = "Form_Secretary_Detail";
            this.Text = "Form_Secretary_Detail";
            this.Load += new System.EventHandler(this.Form_Secretary_Detail_Load);
            this.groupBox_secretaryinf.ResumeLayout(false);
            this.groupBox_secretaryinf.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox_appointment.ResumeLayout(false);
            this.groupBox_appointment.PerformLayout();
            this.groupBox_branches.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox_doctors.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.groupBox_fast.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox_secretaryinf;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label_namesurname;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label_identity;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button button_create;
        private System.Windows.Forms.GroupBox groupBox_appointment;
        private System.Windows.Forms.Button button_save;
        private System.Windows.Forms.CheckBox checkBox_situation;
        private System.Windows.Forms.MaskedTextBox maskedTextBox_identity;
        private System.Windows.Forms.ComboBox comboBox_doctor;
        private System.Windows.Forms.ComboBox comboBox_branch;
        private System.Windows.Forms.MaskedTextBox maskedTextBox_time;
        private System.Windows.Forms.MaskedTextBox maskedTextBox_date;
        private System.Windows.Forms.TextBox textBox_id;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox_branches;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox_doctors;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.GroupBox groupBox_fast;
        private System.Windows.Forms.Button button_lists;
        private System.Windows.Forms.Button button_branchpannel;
        private System.Windows.Forms.Button button_doctorpannel;
        private System.Windows.Forms.Button button_announcements;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}