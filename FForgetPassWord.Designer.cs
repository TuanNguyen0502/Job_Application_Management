namespace Job_Application_Management
{
    partial class FForgetPassword
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
            this.button_Login = new System.Windows.Forms.Button();
            this.button_ResetPassword = new System.Windows.Forms.Button();
            this.textBox_Password = new System.Windows.Forms.TextBox();
            this.textBox_UserName = new System.Windows.Forms.TextBox();
            this.label_Password = new System.Windows.Forms.Label();
            this.label_UserName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_ConfirmPassword = new System.Windows.Forms.TextBox();
            this.label_ConfirmPassword = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button_Login
            // 
            this.button_Login.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Login.Location = new System.Drawing.Point(95, 48);
            this.button_Login.Name = "button_Login";
            this.button_Login.Size = new System.Drawing.Size(134, 42);
            this.button_Login.TabIndex = 0;
            this.button_Login.Text = "< Go Back";
            this.button_Login.UseVisualStyleBackColor = true;
            // 
            // button_ResetPassword
            // 
            this.button_ResetPassword.Font = new System.Drawing.Font("Consolas", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_ResetPassword.Location = new System.Drawing.Point(350, 380);
            this.button_ResetPassword.Name = "button_ResetPassword";
            this.button_ResetPassword.Size = new System.Drawing.Size(174, 67);
            this.button_ResetPassword.TabIndex = 13;
            this.button_ResetPassword.Text = "Continue";
            this.button_ResetPassword.UseVisualStyleBackColor = true;
            // 
            // textBox_Password
            // 
            this.textBox_Password.Font = new System.Drawing.Font("Consolas", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_Password.Location = new System.Drawing.Point(350, 251);
            this.textBox_Password.Name = "textBox_Password";
            this.textBox_Password.Size = new System.Drawing.Size(244, 40);
            this.textBox_Password.TabIndex = 11;
            // 
            // textBox_UserName
            // 
            this.textBox_UserName.Font = new System.Drawing.Font("Consolas", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_UserName.Location = new System.Drawing.Point(350, 190);
            this.textBox_UserName.Name = "textBox_UserName";
            this.textBox_UserName.Size = new System.Drawing.Size(244, 40);
            this.textBox_UserName.TabIndex = 12;
            // 
            // label_Password
            // 
            this.label_Password.AutoSize = true;
            this.label_Password.Font = new System.Drawing.Font("Consolas", 14F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Password.Location = new System.Drawing.Point(89, 258);
            this.label_Password.Name = "label_Password";
            this.label_Password.Size = new System.Drawing.Size(195, 33);
            this.label_Password.TabIndex = 9;
            this.label_Password.Text = "New Password";
            // 
            // label_UserName
            // 
            this.label_UserName.AutoSize = true;
            this.label_UserName.Font = new System.Drawing.Font("Consolas", 14F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_UserName.Location = new System.Drawing.Point(89, 197);
            this.label_UserName.Name = "label_UserName";
            this.label_UserName.Size = new System.Drawing.Size(150, 33);
            this.label_UserName.TabIndex = 10;
            this.label_UserName.Text = "User Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(87, 114);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(438, 47);
            this.label1.TabIndex = 6;
            this.label1.Text = "Reset Your Password";
            // 
            // textBox_ConfirmPassword
            // 
            this.textBox_ConfirmPassword.Font = new System.Drawing.Font("Consolas", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_ConfirmPassword.Location = new System.Drawing.Point(350, 315);
            this.textBox_ConfirmPassword.Name = "textBox_ConfirmPassword";
            this.textBox_ConfirmPassword.Size = new System.Drawing.Size(244, 40);
            this.textBox_ConfirmPassword.TabIndex = 15;
            // 
            // label_ConfirmPassword
            // 
            this.label_ConfirmPassword.AutoSize = true;
            this.label_ConfirmPassword.Font = new System.Drawing.Font("Consolas", 14F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_ConfirmPassword.Location = new System.Drawing.Point(89, 322);
            this.label_ConfirmPassword.Name = "label_ConfirmPassword";
            this.label_ConfirmPassword.Size = new System.Drawing.Size(255, 33);
            this.label_ConfirmPassword.TabIndex = 14;
            this.label_ConfirmPassword.Text = "Confirm Password";
            // 
            // FForgetPassWord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1013, 592);
            this.Controls.Add(this.textBox_ConfirmPassword);
            this.Controls.Add(this.label_ConfirmPassword);
            this.Controls.Add(this.button_ResetPassword);
            this.Controls.Add(this.textBox_Password);
            this.Controls.Add(this.textBox_UserName);
            this.Controls.Add(this.label_Password);
            this.Controls.Add(this.label_UserName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_Login);
            this.Name = "FForgetPassWord";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Forget Password";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_Login;
        private System.Windows.Forms.Button button_ResetPassword;
        private System.Windows.Forms.TextBox textBox_Password;
        private System.Windows.Forms.TextBox textBox_UserName;
        private System.Windows.Forms.Label label_Password;
        private System.Windows.Forms.Label label_UserName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_ConfirmPassword;
        private System.Windows.Forms.Label label_ConfirmPassword;
    }
}