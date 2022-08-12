
namespace ProjectHospital
{
    partial class Form_Patient_Enter
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Patient_Enter));
            this.label_enter = new System.Windows.Forms.Label();
            this.label_identity = new System.Windows.Forms.Label();
            this.label_password = new System.Windows.Forms.Label();
            this.maskedTextBox_identity = new System.Windows.Forms.MaskedTextBox();
            this.textBox_password = new System.Windows.Forms.TextBox();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.button_enter = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label_enter
            // 
            this.label_enter.AutoSize = true;
            this.label_enter.Font = new System.Drawing.Font("Segoe Print", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_enter.Location = new System.Drawing.Point(31, 29);
            this.label_enter.Name = "label_enter";
            this.label_enter.Size = new System.Drawing.Size(229, 37);
            this.label_enter.TabIndex = 0;
            this.label_enter.Text = "Patient Enter Panel";
            // 
            // label_identity
            // 
            this.label_identity.AutoSize = true;
            this.label_identity.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_identity.Location = new System.Drawing.Point(12, 81);
            this.label_identity.Name = "label_identity";
            this.label_identity.Size = new System.Drawing.Size(141, 20);
            this.label_identity.TabIndex = 1;
            this.label_identity.Text = "Identity Number:";
            // 
            // label_password
            // 
            this.label_password.AutoSize = true;
            this.label_password.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_password.Location = new System.Drawing.Point(62, 112);
            this.label_password.Name = "label_password";
            this.label_password.Size = new System.Drawing.Size(91, 20);
            this.label_password.TabIndex = 2;
            this.label_password.Text = "Password:";
            // 
            // maskedTextBox_identity
            // 
            this.maskedTextBox_identity.Location = new System.Drawing.Point(159, 83);
            this.maskedTextBox_identity.Mask = "00000000000";
            this.maskedTextBox_identity.Name = "maskedTextBox_identity";
            this.maskedTextBox_identity.Size = new System.Drawing.Size(133, 20);
            this.maskedTextBox_identity.TabIndex = 3;
            // 
            // textBox_password
            // 
            this.textBox_password.Location = new System.Drawing.Point(159, 114);
            this.textBox_password.Name = "textBox_password";
            this.textBox_password.Size = new System.Drawing.Size(134, 20);
            this.textBox_password.TabIndex = 4;
            this.textBox_password.UseSystemPasswordChar = true;
            this.textBox_password.TextChanged += new System.EventHandler(this.textBox_password_TextChanged);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(279, 168);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(48, 13);
            this.linkLabel1.TabIndex = 5;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = " Sign Up";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // button_enter
            // 
            this.button_enter.Location = new System.Drawing.Point(159, 156);
            this.button_enter.Name = "button_enter";
            this.button_enter.Size = new System.Drawing.Size(62, 37);
            this.button_enter.TabIndex = 6;
            this.button_enter.Text = "Enter";
            this.button_enter.UseVisualStyleBackColor = true;
            this.button_enter.Click += new System.EventHandler(this.button_enter_Click);
            // 
            // Form_Patient_Enter
            // 
            this.AcceptButton = this.button_enter;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(339, 263);
            this.Controls.Add(this.button_enter);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.textBox_password);
            this.Controls.Add(this.maskedTextBox_identity);
            this.Controls.Add(this.label_password);
            this.Controls.Add(this.label_identity);
            this.Controls.Add(this.label_enter);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form_Patient_Enter";
            this.Text = "Form_Patient_Enter";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_enter;
        private System.Windows.Forms.Label label_identity;
        private System.Windows.Forms.Label label_password;
        private System.Windows.Forms.MaskedTextBox maskedTextBox_identity;
        private System.Windows.Forms.TextBox textBox_password;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Button button_enter;
    }
}