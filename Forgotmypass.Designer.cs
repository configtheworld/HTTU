namespace HTTU
{
    partial class Forgotmypass
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
            this.UpdateButton = new System.Windows.Forms.Button();
            this.UserNameForgotPass = new System.Windows.Forms.Label();
            this.Usernameforgot = new System.Windows.Forms.TextBox();
            this.Confirmpassforgot = new System.Windows.Forms.TextBox();
            this.ConfirmForgotpass = new System.Windows.Forms.Label();
            this.ForgotPass = new System.Windows.Forms.Label();
            this.Passwordforgot = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // UpdateButton
            // 
            this.UpdateButton.Location = new System.Drawing.Point(518, 341);
            this.UpdateButton.Name = "UpdateButton";
            this.UpdateButton.Size = new System.Drawing.Size(92, 38);
            this.UpdateButton.TabIndex = 0;
            this.UpdateButton.Text = "Update";
            this.UpdateButton.UseVisualStyleBackColor = true;
            this.UpdateButton.Click += new System.EventHandler(this.UpdateButton_Click);
            // 
            // UserNameForgotPass
            // 
            this.UserNameForgotPass.AutoSize = true;
            this.UserNameForgotPass.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserNameForgotPass.Location = new System.Drawing.Point(107, 85);
            this.UserNameForgotPass.Name = "UserNameForgotPass";
            this.UserNameForgotPass.Size = new System.Drawing.Size(85, 20);
            this.UserNameForgotPass.TabIndex = 10;
            this.UserNameForgotPass.Text = "UserName";
            // 
            // Usernameforgot
            // 
            this.Usernameforgot.Location = new System.Drawing.Point(253, 85);
            this.Usernameforgot.Name = "Usernameforgot";
            this.Usernameforgot.Size = new System.Drawing.Size(182, 22);
            this.Usernameforgot.TabIndex = 9;
            // 
            // Confirmpassforgot
            // 
            this.Confirmpassforgot.Location = new System.Drawing.Point(253, 192);
            this.Confirmpassforgot.Name = "Confirmpassforgot";
            this.Confirmpassforgot.PasswordChar = '*';
            this.Confirmpassforgot.Size = new System.Drawing.Size(182, 22);
            this.Confirmpassforgot.TabIndex = 15;
            // 
            // ConfirmForgotpass
            // 
            this.ConfirmForgotpass.AutoSize = true;
            this.ConfirmForgotpass.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConfirmForgotpass.Location = new System.Drawing.Point(107, 194);
            this.ConfirmForgotpass.Name = "ConfirmForgotpass";
            this.ConfirmForgotpass.Size = new System.Drawing.Size(140, 20);
            this.ConfirmForgotpass.TabIndex = 14;
            this.ConfirmForgotpass.Text = "Confirm Password";
            // 
            // ForgotPass
            // 
            this.ForgotPass.AutoSize = true;
            this.ForgotPass.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForgotPass.Location = new System.Drawing.Point(107, 149);
            this.ForgotPass.Name = "ForgotPass";
            this.ForgotPass.Size = new System.Drawing.Size(79, 20);
            this.ForgotPass.TabIndex = 13;
            this.ForgotPass.Text = "Password";
            // 
            // Passwordforgot
            // 
            this.Passwordforgot.Location = new System.Drawing.Point(253, 149);
            this.Passwordforgot.Name = "Passwordforgot";
            this.Passwordforgot.PasswordChar = '*';
            this.Passwordforgot.Size = new System.Drawing.Size(182, 22);
            this.Passwordforgot.TabIndex = 12;
            // 
            // Forgotmypass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Confirmpassforgot);
            this.Controls.Add(this.ConfirmForgotpass);
            this.Controls.Add(this.ForgotPass);
            this.Controls.Add(this.Passwordforgot);
            this.Controls.Add(this.UserNameForgotPass);
            this.Controls.Add(this.Usernameforgot);
            this.Controls.Add(this.UpdateButton);
            this.Name = "Forgotmypass";
            this.Text = "Forgotmypass";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button UpdateButton;
        private System.Windows.Forms.Label UserNameForgotPass;
        private System.Windows.Forms.TextBox Usernameforgot;
        private System.Windows.Forms.TextBox Confirmpassforgot;
        private System.Windows.Forms.Label ConfirmForgotpass;
        private System.Windows.Forms.Label ForgotPass;
        private System.Windows.Forms.TextBox Passwordforgot;
    }
}