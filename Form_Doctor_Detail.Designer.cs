
namespace ProjectHospital
{
    partial class Form_Doctor_Detail
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
            this.groupBox_doctorinformation = new System.Windows.Forms.GroupBox();
            this.label_namesurname = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label_identity = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox_appointment = new System.Windows.Forms.GroupBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox_appointmentlist = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox_fastaccess = new System.Windows.Forms.GroupBox();
            this.button_edit = new System.Windows.Forms.Button();
            this.button_announcement = new System.Windows.Forms.Button();
            this.button_exit = new System.Windows.Forms.Button();
            this.groupBox_doctorinformation.SuspendLayout();
            this.groupBox_appointment.SuspendLayout();
            this.groupBox_appointmentlist.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox_fastaccess.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox_doctorinformation
            // 
            this.groupBox_doctorinformation.Controls.Add(this.label_namesurname);
            this.groupBox_doctorinformation.Controls.Add(this.label3);
            this.groupBox_doctorinformation.Controls.Add(this.label_identity);
            this.groupBox_doctorinformation.Controls.Add(this.label1);
            this.groupBox_doctorinformation.Location = new System.Drawing.Point(7, 12);
            this.groupBox_doctorinformation.Name = "groupBox_doctorinformation";
            this.groupBox_doctorinformation.Size = new System.Drawing.Size(301, 115);
            this.groupBox_doctorinformation.TabIndex = 0;
            this.groupBox_doctorinformation.TabStop = false;
            this.groupBox_doctorinformation.Text = "Doctor Information";
            // 
            // label_namesurname
            // 
            this.label_namesurname.AutoSize = true;
            this.label_namesurname.Location = new System.Drawing.Point(132, 58);
            this.label_namesurname.Name = "label_namesurname";
            this.label_namesurname.Size = new System.Drawing.Size(46, 13);
            this.label_namesurname.TabIndex = 3;
            this.label_namesurname.Text = "Null Null";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(42, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Name Surname:";
            // 
            // label_identity
            // 
            this.label_identity.AutoSize = true;
            this.label_identity.Location = new System.Drawing.Point(132, 36);
            this.label_identity.Name = "label_identity";
            this.label_identity.Size = new System.Drawing.Size(73, 13);
            this.label_identity.TabIndex = 1;
            this.label_identity.Text = "00000000000";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Identity Number:";
            // 
            // groupBox_appointment
            // 
            this.groupBox_appointment.Controls.Add(this.richTextBox1);
            this.groupBox_appointment.Controls.Add(this.label5);
            this.groupBox_appointment.Location = new System.Drawing.Point(7, 133);
            this.groupBox_appointment.Name = "groupBox_appointment";
            this.groupBox_appointment.Size = new System.Drawing.Size(301, 209);
            this.groupBox_appointment.TabIndex = 1;
            this.groupBox_appointment.TabStop = false;
            this.groupBox_appointment.Text = "Appointment Detail";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(5, 16);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(286, 183);
            this.richTextBox1.TabIndex = 1;
            this.richTextBox1.Text = "";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Complaint:";
            // 
            // groupBox_appointmentlist
            // 
            this.groupBox_appointmentlist.Controls.Add(this.dataGridView1);
            this.groupBox_appointmentlist.Location = new System.Drawing.Point(314, 12);
            this.groupBox_appointmentlist.Name = "groupBox_appointmentlist";
            this.groupBox_appointmentlist.Size = new System.Drawing.Size(503, 434);
            this.groupBox_appointmentlist.TabIndex = 2;
            this.groupBox_appointmentlist.TabStop = false;
            this.groupBox_appointmentlist.Text = "Appointment Lists";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 16);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(497, 415);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // groupBox_fastaccess
            // 
            this.groupBox_fastaccess.Controls.Add(this.button_edit);
            this.groupBox_fastaccess.Controls.Add(this.button_announcement);
            this.groupBox_fastaccess.Controls.Add(this.button_exit);
            this.groupBox_fastaccess.Location = new System.Drawing.Point(16, 351);
            this.groupBox_fastaccess.Name = "groupBox_fastaccess";
            this.groupBox_fastaccess.Size = new System.Drawing.Size(292, 91);
            this.groupBox_fastaccess.TabIndex = 3;
            this.groupBox_fastaccess.TabStop = false;
            this.groupBox_fastaccess.Text = "Fast Access";
            // 
            // button_edit
            // 
            this.button_edit.Location = new System.Drawing.Point(6, 19);
            this.button_edit.Name = "button_edit";
            this.button_edit.Size = new System.Drawing.Size(131, 30);
            this.button_edit.TabIndex = 3;
            this.button_edit.Text = "Edit Information";
            this.button_edit.UseVisualStyleBackColor = true;
            this.button_edit.Click += new System.EventHandler(this.button_edit_Click);
            // 
            // button_announcement
            // 
            this.button_announcement.Location = new System.Drawing.Point(152, 19);
            this.button_announcement.Name = "button_announcement";
            this.button_announcement.Size = new System.Drawing.Size(134, 30);
            this.button_announcement.TabIndex = 2;
            this.button_announcement.Text = "Announcements";
            this.button_announcement.UseVisualStyleBackColor = true;
            this.button_announcement.Click += new System.EventHandler(this.button3_Click);
            // 
            // button_exit
            // 
            this.button_exit.Location = new System.Drawing.Point(71, 55);
            this.button_exit.Name = "button_exit";
            this.button_exit.Size = new System.Drawing.Size(134, 30);
            this.button_exit.TabIndex = 0;
            this.button_exit.Text = "Exit";
            this.button_exit.UseVisualStyleBackColor = true;
            this.button_exit.Click += new System.EventHandler(this.button_exit_Click);
            // 
            // Form_Doctor_Detail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(829, 458);
            this.Controls.Add(this.groupBox_fastaccess);
            this.Controls.Add(this.groupBox_appointmentlist);
            this.Controls.Add(this.groupBox_appointment);
            this.Controls.Add(this.groupBox_doctorinformation);
            this.Name = "Form_Doctor_Detail";
            this.Text = "Form_Doctor_Detail";
            this.Load += new System.EventHandler(this.Form_Doctor_Detail_Load);
            this.groupBox_doctorinformation.ResumeLayout(false);
            this.groupBox_doctorinformation.PerformLayout();
            this.groupBox_appointment.ResumeLayout(false);
            this.groupBox_appointment.PerformLayout();
            this.groupBox_appointmentlist.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox_fastaccess.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox_doctorinformation;
        private System.Windows.Forms.Label label_namesurname;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label_identity;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox_appointment;
        private System.Windows.Forms.GroupBox groupBox_appointmentlist;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox_fastaccess;
        private System.Windows.Forms.Button button_edit;
        private System.Windows.Forms.Button button_announcement;
        private System.Windows.Forms.Button button_exit;
    }
}