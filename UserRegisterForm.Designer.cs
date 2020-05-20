namespace HTTU
{
    partial class UserRegisterForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.PasswordRegister = new System.Windows.Forms.Label();
            this.UserNameRegister = new System.Windows.Forms.Label();
            this.passwordTB = new System.Windows.Forms.TextBox();
            this.nameTB = new System.Windows.Forms.TextBox();
            this.Confirmpass = new System.Windows.Forms.Label();
            this.ConfirmTB = new System.Windows.Forms.TextBox();
            this.RegisterNowButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.RegisterNowButton);
            this.groupBox1.Controls.Add(this.ConfirmTB);
            this.groupBox1.Controls.Add(this.Confirmpass);
            this.groupBox1.Controls.Add(this.PasswordRegister);
            this.groupBox1.Controls.Add(this.UserNameRegister);
            this.groupBox1.Controls.Add(this.passwordTB);
            this.groupBox1.Controls.Add(this.nameTB);
            this.groupBox1.Location = new System.Drawing.Point(47, 34);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(692, 368);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // PasswordRegister
            // 
            this.PasswordRegister.AutoSize = true;
            this.PasswordRegister.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasswordRegister.Location = new System.Drawing.Point(172, 130);
            this.PasswordRegister.Name = "PasswordRegister";
            this.PasswordRegister.Size = new System.Drawing.Size(79, 20);
            this.PasswordRegister.TabIndex = 9;
            this.PasswordRegister.Text = "Password";
            // 
            // UserNameRegister
            // 
            this.UserNameRegister.AutoSize = true;
            this.UserNameRegister.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserNameRegister.Location = new System.Drawing.Point(166, 77);
            this.UserNameRegister.Name = "UserNameRegister";
            this.UserNameRegister.Size = new System.Drawing.Size(85, 20);
            this.UserNameRegister.TabIndex = 8;
            this.UserNameRegister.Text = "UserName";
            // 
            // passwordTB
            // 
            this.passwordTB.Location = new System.Drawing.Point(296, 130);
            this.passwordTB.Name = "passwordTB";
            this.passwordTB.PasswordChar = '*';
            this.passwordTB.Size = new System.Drawing.Size(182, 22);
            this.passwordTB.TabIndex = 7;
            // 
            // nameTB
            // 
            this.nameTB.Location = new System.Drawing.Point(296, 77);
            this.nameTB.Name = "nameTB";
            this.nameTB.Size = new System.Drawing.Size(182, 22);
            this.nameTB.TabIndex = 6;
            // 
            // Confirmpass
            // 
            this.Confirmpass.AutoSize = true;
            this.Confirmpass.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Confirmpass.Location = new System.Drawing.Point(140, 192);
            this.Confirmpass.Name = "Confirmpass";
            this.Confirmpass.Size = new System.Drawing.Size(140, 20);
            this.Confirmpass.TabIndex = 10;
            this.Confirmpass.Text = "Confirm Password";
            // 
            // ConfirmTB
            // 
            this.ConfirmTB.Location = new System.Drawing.Point(296, 192);
            this.ConfirmTB.Name = "ConfirmTB";
            this.ConfirmTB.PasswordChar = '*';
            this.ConfirmTB.Size = new System.Drawing.Size(182, 22);
            this.ConfirmTB.TabIndex = 11;
            // 
            // RegisterNowButton
            // 
            this.RegisterNowButton.Location = new System.Drawing.Point(336, 264);
            this.RegisterNowButton.Name = "RegisterNowButton";
            this.RegisterNowButton.Size = new System.Drawing.Size(142, 60);
            this.RegisterNowButton.TabIndex = 12;
            this.RegisterNowButton.Text = "Register Now";
            this.RegisterNowButton.UseVisualStyleBackColor = true;
            this.RegisterNowButton.Click += new System.EventHandler(this.RegisterNowButton_Click);
            // 
            // UserRegisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Name = "UserRegisterForm";
            this.Text = "UserRegisterForm";
            this.Load += new System.EventHandler(this.UserRegisterForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox ConfirmTB;
        private System.Windows.Forms.Label Confirmpass;
        private System.Windows.Forms.Label PasswordRegister;
        private System.Windows.Forms.Label UserNameRegister;
        private System.Windows.Forms.TextBox passwordTB;
        private System.Windows.Forms.TextBox nameTB;
        private System.Windows.Forms.Button RegisterNowButton;
    }
}