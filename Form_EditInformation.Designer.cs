
namespace ProjectHospital
{
    partial class Form_EditInformation
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_EditInformation));
            this.maskedTextBox_telephone = new System.Windows.Forms.MaskedTextBox();
            this.button_editinformation = new System.Windows.Forms.Button();
            this.label_gender = new System.Windows.Forms.Label();
            this.comboBox_gender = new System.Windows.Forms.ComboBox();
            this.label_password = new System.Windows.Forms.Label();
            this.label_telephone = new System.Windows.Forms.Label();
            this.label_identity = new System.Windows.Forms.Label();
            this.label_surname = new System.Windows.Forms.Label();
            this.label_name = new System.Windows.Forms.Label();
            this.textBox_name = new System.Windows.Forms.TextBox();
            this.textBox_surname = new System.Windows.Forms.TextBox();
            this.textBox_password = new System.Windows.Forms.TextBox();
            this.textBox_identity = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // maskedTextBox_telephone
            // 
            this.maskedTextBox_telephone.Location = new System.Drawing.Point(141, 131);
            this.maskedTextBox_telephone.Mask = "(999) 000-0000";
            this.maskedTextBox_telephone.Name = "maskedTextBox_telephone";
            this.maskedTextBox_telephone.Size = new System.Drawing.Size(133, 20);
            this.maskedTextBox_telephone.TabIndex = 4;
            // 
            // button_editinformation
            // 
            this.button_editinformation.BackColor = System.Drawing.SystemColors.HotTrack;
            this.button_editinformation.Location = new System.Drawing.Point(129, 243);
            this.button_editinformation.Name = "button_editinformation";
            this.button_editinformation.Size = new System.Drawing.Size(161, 25);
            this.button_editinformation.TabIndex = 34;
            this.button_editinformation.Text = "Update";
            this.button_editinformation.UseVisualStyleBackColor = false;
            this.button_editinformation.Click += new System.EventHandler(this.button_editinformation_Click);
            // 
            // label_gender
            // 
            this.label_gender.AutoSize = true;
            this.label_gender.Location = new System.Drawing.Point(57, 199);
            this.label_gender.Name = "label_gender";
            this.label_gender.Size = new System.Drawing.Size(45, 13);
            this.label_gender.TabIndex = 33;
            this.label_gender.Text = "Gender:";
            // 
            // comboBox_gender
            // 
            this.comboBox_gender.FormattingEnabled = true;
            this.comboBox_gender.Items.AddRange(new object[] {
            "Female",
            "Male"});
            this.comboBox_gender.Location = new System.Drawing.Point(141, 199);
            this.comboBox_gender.Name = "comboBox_gender";
            this.comboBox_gender.Size = new System.Drawing.Size(133, 21);
            this.comboBox_gender.TabIndex = 6;
            // 
            // label_password
            // 
            this.label_password.AutoSize = true;
            this.label_password.Location = new System.Drawing.Point(57, 166);
            this.label_password.Name = "label_password";
            this.label_password.Size = new System.Drawing.Size(56, 13);
            this.label_password.TabIndex = 31;
            this.label_password.Text = "Password:";
            // 
            // label_telephone
            // 
            this.label_telephone.AutoSize = true;
            this.label_telephone.Location = new System.Drawing.Point(57, 133);
            this.label_telephone.Name = "label_telephone";
            this.label_telephone.Size = new System.Drawing.Size(61, 13);
            this.label_telephone.TabIndex = 30;
            this.label_telephone.Text = "Telephone:";
            // 
            // label_identity
            // 
            this.label_identity.AutoSize = true;
            this.label_identity.Location = new System.Drawing.Point(57, 97);
            this.label_identity.Name = "label_identity";
            this.label_identity.Size = new System.Drawing.Size(84, 13);
            this.label_identity.TabIndex = 29;
            this.label_identity.Text = "Identity Number:";
            // 
            // label_surname
            // 
            this.label_surname.AutoSize = true;
            this.label_surname.Location = new System.Drawing.Point(57, 63);
            this.label_surname.Name = "label_surname";
            this.label_surname.Size = new System.Drawing.Size(52, 13);
            this.label_surname.TabIndex = 28;
            this.label_surname.Text = "Surname:";
            // 
            // label_name
            // 
            this.label_name.AutoSize = true;
            this.label_name.Location = new System.Drawing.Point(57, 31);
            this.label_name.Name = "label_name";
            this.label_name.Size = new System.Drawing.Size(38, 13);
            this.label_name.TabIndex = 27;
            this.label_name.Text = "Name:";
            // 
            // textBox_name
            // 
            this.textBox_name.Location = new System.Drawing.Point(141, 28);
            this.textBox_name.Name = "textBox_name";
            this.textBox_name.Size = new System.Drawing.Size(134, 20);
            this.textBox_name.TabIndex = 1;
            this.textBox_name.TextChanged += new System.EventHandler(this.textBox_name_TextChanged);
            // 
            // textBox_surname
            // 
            this.textBox_surname.Location = new System.Drawing.Point(141, 60);
            this.textBox_surname.Name = "textBox_surname";
            this.textBox_surname.Size = new System.Drawing.Size(134, 20);
            this.textBox_surname.TabIndex = 2;
            // 
            // textBox_password
            // 
            this.textBox_password.Location = new System.Drawing.Point(141, 166);
            this.textBox_password.Name = "textBox_password";
            this.textBox_password.Size = new System.Drawing.Size(134, 20);
            this.textBox_password.TabIndex = 5;
            // 
            // textBox_identity
            // 
            this.textBox_identity.Location = new System.Drawing.Point(141, 94);
            this.textBox_identity.Name = "textBox_identity";
            this.textBox_identity.Size = new System.Drawing.Size(134, 20);
            this.textBox_identity.TabIndex = 3;
            // 
            // Form_EditInformation
            // 
            this.AcceptButton = this.button_editinformation;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(381, 307);
            this.Controls.Add(this.maskedTextBox_telephone);
            this.Controls.Add(this.button_editinformation);
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
            this.Name = "Form_EditInformation";
            this.Text = "Form_EditInformation";
            this.Load += new System.EventHandler(this.Form_EditInformation_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox maskedTextBox_telephone;
        private System.Windows.Forms.Button button_editinformation;
        private System.Windows.Forms.Label label_gender;
        private System.Windows.Forms.ComboBox comboBox_gender;
        private System.Windows.Forms.Label label_password;
        private System.Windows.Forms.Label label_telephone;
        private System.Windows.Forms.Label label_identity;
        private System.Windows.Forms.Label label_surname;
        private System.Windows.Forms.Label label_name;
        private System.Windows.Forms.TextBox textBox_name;
        private System.Windows.Forms.TextBox textBox_surname;
        private System.Windows.Forms.TextBox textBox_password;
        private System.Windows.Forms.TextBox textBox_identity;
    }
}