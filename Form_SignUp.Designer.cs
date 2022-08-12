
namespace ProjectHospital
{
    partial class Form_SignUp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_SignUp));
            this.textBox_identity = new System.Windows.Forms.TextBox();
            this.textBox_password = new System.Windows.Forms.TextBox();
            this.textBox_surname = new System.Windows.Forms.TextBox();
            this.textBox_name = new System.Windows.Forms.TextBox();
            this.label_name = new System.Windows.Forms.Label();
            this.label_surname = new System.Windows.Forms.Label();
            this.label_identity = new System.Windows.Forms.Label();
            this.label_telephone = new System.Windows.Forms.Label();
            this.label_password = new System.Windows.Forms.Label();
            this.comboBox_gender = new System.Windows.Forms.ComboBox();
            this.label_gender = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.maskedTextBox_telephone = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // textBox_identity
            // 
            this.textBox_identity.Location = new System.Drawing.Point(111, 95);
            this.textBox_identity.Name = "textBox_identity";
            this.textBox_identity.Size = new System.Drawing.Size(134, 20);
            this.textBox_identity.TabIndex = 3;
            // 
            // textBox_password
            // 
            this.textBox_password.Location = new System.Drawing.Point(111, 167);
            this.textBox_password.Name = "textBox_password";
            this.textBox_password.Size = new System.Drawing.Size(134, 20);
            this.textBox_password.TabIndex = 5;
            // 
            // textBox_surname
            // 
            this.textBox_surname.Location = new System.Drawing.Point(111, 61);
            this.textBox_surname.Name = "textBox_surname";
            this.textBox_surname.Size = new System.Drawing.Size(134, 20);
            this.textBox_surname.TabIndex = 2;
            // 
            // textBox_name
            // 
            this.textBox_name.Location = new System.Drawing.Point(111, 29);
            this.textBox_name.Name = "textBox_name";
            this.textBox_name.Size = new System.Drawing.Size(134, 20);
            this.textBox_name.TabIndex = 1;
            // 
            // label_name
            // 
            this.label_name.AutoSize = true;
            this.label_name.Location = new System.Drawing.Point(27, 32);
            this.label_name.Name = "label_name";
            this.label_name.Size = new System.Drawing.Size(38, 13);
            this.label_name.TabIndex = 14;
            this.label_name.Text = "Name:";
            // 
            // label_surname
            // 
            this.label_surname.AutoSize = true;
            this.label_surname.Location = new System.Drawing.Point(27, 64);
            this.label_surname.Name = "label_surname";
            this.label_surname.Size = new System.Drawing.Size(52, 13);
            this.label_surname.TabIndex = 15;
            this.label_surname.Text = "Surname:";
            // 
            // label_identity
            // 
            this.label_identity.AutoSize = true;
            this.label_identity.Location = new System.Drawing.Point(27, 98);
            this.label_identity.Name = "label_identity";
            this.label_identity.Size = new System.Drawing.Size(84, 13);
            this.label_identity.TabIndex = 16;
            this.label_identity.Text = "Identity Number:";
            // 
            // label_telephone
            // 
            this.label_telephone.AutoSize = true;
            this.label_telephone.Location = new System.Drawing.Point(27, 134);
            this.label_telephone.Name = "label_telephone";
            this.label_telephone.Size = new System.Drawing.Size(61, 13);
            this.label_telephone.TabIndex = 17;
            this.label_telephone.Text = "Telephone:";
            // 
            // label_password
            // 
            this.label_password.AutoSize = true;
            this.label_password.Location = new System.Drawing.Point(27, 167);
            this.label_password.Name = "label_password";
            this.label_password.Size = new System.Drawing.Size(56, 13);
            this.label_password.TabIndex = 18;
            this.label_password.Text = "Password:";
            // 
            // comboBox_gender
            // 
            this.comboBox_gender.FormattingEnabled = true;
            this.comboBox_gender.Items.AddRange(new object[] {
            "Female",
            "Male"});
            this.comboBox_gender.Location = new System.Drawing.Point(111, 200);
            this.comboBox_gender.Name = "comboBox_gender";
            this.comboBox_gender.Size = new System.Drawing.Size(133, 21);
            this.comboBox_gender.TabIndex = 6;
            // 
            // label_gender
            // 
            this.label_gender.AutoSize = true;
            this.label_gender.Location = new System.Drawing.Point(27, 200);
            this.label_gender.Name = "label_gender";
            this.label_gender.Size = new System.Drawing.Size(45, 13);
            this.label_gender.TabIndex = 20;
            this.label_gender.Text = "Gender:";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.button1.Location = new System.Drawing.Point(99, 244);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(161, 25);
            this.button1.TabIndex = 21;
            this.button1.Text = "Create Account";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // maskedTextBox_telephone
            // 
            this.maskedTextBox_telephone.Location = new System.Drawing.Point(111, 132);
            this.maskedTextBox_telephone.Mask = "(999) 000-0000";
            this.maskedTextBox_telephone.Name = "maskedTextBox_telephone";
            this.maskedTextBox_telephone.Size = new System.Drawing.Size(133, 20);
            this.maskedTextBox_telephone.TabIndex = 4;
            // 
            // Form_SignUp
            // 
            this.AcceptButton = this.button1;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(333, 338);
            this.Controls.Add(this.maskedTextBox_telephone);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label_gender);
            this.Controls.Add(this.comboBox_gender);
            this.Controls.Add(this.label_password);
            this.Controls.Add(this.label_telephone);
            this.Controls.Add(this.label_identity);
            this.Controls.Add(this.label_surname);
            this.Controls.Add(this.label_name);
            this.Controls.Add(this.textBox_name);
            this.Controls.Add(this.textBox_surname);
            this.Controls.Add(this.textBox_password);
            this.Controls.Add(this.textBox_identity);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form_SignUp";
            this.Text = "Form_Patient_SignUp";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_identity;
        private System.Windows.Forms.TextBox textBox_password;
        private System.Windows.Forms.TextBox textBox_surname;
        private System.Windows.Forms.TextBox textBox_name;
        private System.Windows.Forms.Label label_name;
        private System.Windows.Forms.Label label_surname;
        private System.Windows.Forms.Label label_identity;
        private System.Windows.Forms.Label label_telephone;
        private System.Windows.Forms.Label label_password;
        private System.Windows.Forms.ComboBox comboBox_gender;
        private System.Windows.Forms.Label label_gender;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.MaskedTextBox maskedTextBox_telephone;
    }
}