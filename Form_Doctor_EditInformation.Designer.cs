
namespace ProjectHospital
{
    partial class Form_Doctor_EditInformation
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
            this.label_password = new System.Windows.Forms.Label();
            this.label_identity = new System.Windows.Forms.Label();
            this.label_surname = new System.Windows.Forms.Label();
            this.label_name = new System.Windows.Forms.Label();
            this.textBox_name = new System.Windows.Forms.TextBox();
            this.textBox_surname = new System.Windows.Forms.TextBox();
            this.textBox_password = new System.Windows.Forms.TextBox();
            this.textBox_identity = new System.Windows.Forms.TextBox();
            this.comboBox_branch = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button_update = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label_password
            // 
            this.label_password.AutoSize = true;
            this.label_password.Location = new System.Drawing.Point(45, 175);
            this.label_password.Name = "label_password";
            this.label_password.Size = new System.Drawing.Size(56, 13);
            this.label_password.TabIndex = 31;
            this.label_password.Text = "Password:";
            // 
            // label_identity
            // 
            this.label_identity.AutoSize = true;
            this.label_identity.Location = new System.Drawing.Point(39, 102);
            this.label_identity.Name = "label_identity";
            this.label_identity.Size = new System.Drawing.Size(84, 13);
            this.label_identity.TabIndex = 29;
            this.label_identity.Text = "Identity Number:";
            // 
            // label_surname
            // 
            this.label_surname.AutoSize = true;
            this.label_surname.Location = new System.Drawing.Point(45, 64);
            this.label_surname.Name = "label_surname";
            this.label_surname.Size = new System.Drawing.Size(52, 13);
            this.label_surname.TabIndex = 28;
            this.label_surname.Text = "Surname:";
            // 
            // label_name
            // 
            this.label_name.AutoSize = true;
            this.label_name.Location = new System.Drawing.Point(45, 32);
            this.label_name.Name = "label_name";
            this.label_name.Size = new System.Drawing.Size(38, 13);
            this.label_name.TabIndex = 27;
            this.label_name.Text = "Name:";
            // 
            // textBox_name
            // 
            this.textBox_name.Location = new System.Drawing.Point(129, 29);
            this.textBox_name.Name = "textBox_name";
            this.textBox_name.Size = new System.Drawing.Size(134, 20);
            this.textBox_name.TabIndex = 26;
            // 
            // textBox_surname
            // 
            this.textBox_surname.Location = new System.Drawing.Point(129, 61);
            this.textBox_surname.Name = "textBox_surname";
            this.textBox_surname.Size = new System.Drawing.Size(134, 20);
            this.textBox_surname.TabIndex = 25;
            // 
            // textBox_password
            // 
            this.textBox_password.Location = new System.Drawing.Point(129, 168);
            this.textBox_password.Name = "textBox_password";
            this.textBox_password.Size = new System.Drawing.Size(134, 20);
            this.textBox_password.TabIndex = 24;
            // 
            // textBox_identity
            // 
            this.textBox_identity.Location = new System.Drawing.Point(129, 95);
            this.textBox_identity.Name = "textBox_identity";
            this.textBox_identity.Size = new System.Drawing.Size(134, 20);
            this.textBox_identity.TabIndex = 23;
            // 
            // comboBox_branch
            // 
            this.comboBox_branch.FormattingEnabled = true;
            this.comboBox_branch.Location = new System.Drawing.Point(129, 133);
            this.comboBox_branch.Name = "comboBox_branch";
            this.comboBox_branch.Size = new System.Drawing.Size(134, 21);
            this.comboBox_branch.TabIndex = 32;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 141);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 33;
            this.label1.Text = "Branch:";
            // 
            // button_update
            // 
            this.button_update.BackColor = System.Drawing.SystemColors.HotTrack;
            this.button_update.Location = new System.Drawing.Point(102, 224);
            this.button_update.Name = "button_update";
            this.button_update.Size = new System.Drawing.Size(161, 25);
            this.button_update.TabIndex = 34;
            this.button_update.Text = "Update";
            this.button_update.UseVisualStyleBackColor = false;
            this.button_update.Click += new System.EventHandler(this.button_update_Click);
            // 
            // Form_Doctor_EditInformation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(353, 286);
            this.Controls.Add(this.button_update);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox_branch);
            this.Controls.Add(this.label_password);
            this.Controls.Add(this.label_identity);
            this.Controls.Add(this.label_surname);
            this.Controls.Add(this.label_name);
            this.Controls.Add(this.textBox_name);
            this.Controls.Add(this.textBox_surname);
            this.Controls.Add(this.textBox_password);
            this.Controls.Add(this.textBox_identity);
            this.Name = "Form_Doctor_EditInformation";
            this.Text = "Form_Doctor_EditInformation";
            this.Load += new System.EventHandler(this.Form_Doctor_EditInformation_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_password;
        private System.Windows.Forms.Label label_identity;
        private System.Windows.Forms.Label label_surname;
        private System.Windows.Forms.Label label_name;
        private System.Windows.Forms.TextBox textBox_name;
        private System.Windows.Forms.TextBox textBox_surname;
        private System.Windows.Forms.TextBox textBox_password;
        private System.Windows.Forms.TextBox textBox_identity;
        private System.Windows.Forms.ComboBox comboBox_branch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_update;
    }
}