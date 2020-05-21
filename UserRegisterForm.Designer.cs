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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserRegisterForm));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.RegisterNowButton = new System.Windows.Forms.Button();
            this.ConfirmTB = new System.Windows.Forms.TextBox();
            this.Confirmpass = new System.Windows.Forms.Label();
            this.PasswordRegister = new System.Windows.Forms.Label();
            this.UserNameRegister = new System.Windows.Forms.Label();
            this.passwordTB = new System.Windows.Forms.TextBox();
            this.nameTB = new System.Windows.Forms.TextBox();
            this.Country = new System.Windows.Forms.ComboBox();
            this.Country_label = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Provience = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Provience);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.Country_label);
            this.groupBox1.Controls.Add(this.Country);
            this.groupBox1.Controls.Add(this.RegisterNowButton);
            this.groupBox1.Controls.Add(this.ConfirmTB);
            this.groupBox1.Controls.Add(this.Confirmpass);
            this.groupBox1.Controls.Add(this.PasswordRegister);
            this.groupBox1.Controls.Add(this.UserNameRegister);
            this.groupBox1.Controls.Add(this.passwordTB);
            this.groupBox1.Controls.Add(this.nameTB);
            this.groupBox1.Location = new System.Drawing.Point(53, 42);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.ForeColor = System.Drawing.Color.MediumSpringGreen;
            this.groupBox1.Location = new System.Drawing.Point(47, 34);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(778, 460);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Registration Page";
            // 
            // RegisterNowButton
            // 
            this.RegisterNowButton.FlatAppearance.BorderSize = 0;
            this.RegisterNowButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RegisterNowButton.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RegisterNowButton.ForeColor = System.Drawing.SystemColors.Info;
            this.RegisterNowButton.Image = ((System.Drawing.Image)(resources.GetObject("RegisterNowButton.Image")));
            this.RegisterNowButton.Location = new System.Drawing.Point(336, 264);
            this.RegisterNowButton.Name = "RegisterNowButton";
            this.RegisterNowButton.Size = new System.Drawing.Size(142, 60);
            this.RegisterNowButton.TabIndex = 12;
            this.RegisterNowButton.Text = "Register Now";
            this.RegisterNowButton.UseVisualStyleBackColor = true;
            this.RegisterNowButton.Click += new System.EventHandler(this.RegisterNowButton_Click);
            // 
            // ConfirmTB
            // 
            this.ConfirmTB.Location = new System.Drawing.Point(296, 192);
            this.ConfirmTB.Name = "ConfirmTB";
            this.ConfirmTB.PasswordChar = '*';
            this.ConfirmTB.Size = new System.Drawing.Size(182, 22);
            this.ConfirmTB.TabIndex = 11;
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
            // RegisterNowButton
            // 
            this.RegisterNowButton.Location = new System.Drawing.Point(466, 334);
            this.RegisterNowButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.RegisterNowButton.Name = "RegisterNowButton";
            this.RegisterNowButton.Size = new System.Drawing.Size(160, 75);
            this.RegisterNowButton.TabIndex = 12;
            this.RegisterNowButton.Text = "Register Now";
            this.RegisterNowButton.UseVisualStyleBackColor = true;
            this.RegisterNowButton.Click += new System.EventHandler(this.RegisterNowButton_Click);
            // 
            // ConfirmTB
            // 
            this.ConfirmTB.Location = new System.Drawing.Point(168, 344);
            this.ConfirmTB.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ConfirmTB.Name = "ConfirmTB";
            this.ConfirmTB.PasswordChar = '*';
            this.ConfirmTB.Size = new System.Drawing.Size(204, 26);
            this.ConfirmTB.TabIndex = 11;
            // 
            // Confirmpass
            // 
            this.Confirmpass.AutoSize = true;
            this.Confirmpass.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Confirmpass.Location = new System.Drawing.Point(29, 353);
            this.Confirmpass.Name = "Confirmpass";
            this.Confirmpass.Size = new System.Drawing.Size(112, 17);
            this.Confirmpass.TabIndex = 10;
            this.Confirmpass.Text = "Confirm Password";
            this.Confirmpass.Click += new System.EventHandler(this.Confirmpass_Click);
            // 
            // PasswordRegister
            // 
            this.PasswordRegister.AutoSize = true;
            this.PasswordRegister.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasswordRegister.Location = new System.Drawing.Point(29, 296);
            this.PasswordRegister.Name = "PasswordRegister";
            this.PasswordRegister.Size = new System.Drawing.Size(63, 17);
            this.PasswordRegister.TabIndex = 9;
            this.PasswordRegister.Text = "Password";
            // 
            // UserNameRegister
            // 
            this.UserNameRegister.AutoSize = true;
            this.UserNameRegister.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserNameRegister.Location = new System.Drawing.Point(29, 87);
            this.UserNameRegister.Name = "UserNameRegister";
            this.UserNameRegister.Size = new System.Drawing.Size(69, 17);
            this.UserNameRegister.TabIndex = 8;
            this.UserNameRegister.Text = "UserName";
            // 
            // passwordTB
            // 
            this.passwordTB.Location = new System.Drawing.Point(168, 296);
            this.passwordTB.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.passwordTB.Name = "passwordTB";
            this.passwordTB.PasswordChar = '*';
            this.passwordTB.Size = new System.Drawing.Size(204, 26);
            this.passwordTB.TabIndex = 7;
            // 
            // nameTB
            // 
            this.nameTB.Location = new System.Drawing.Point(125, 87);
            this.nameTB.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.nameTB.Name = "nameTB";
            this.nameTB.Size = new System.Drawing.Size(204, 26);
            this.nameTB.TabIndex = 6;
            // 
            // Country
            // 
            this.Country.FormattingEnabled = true;
            this.Country.Location = new System.Drawing.Point(125, 151);
            this.Country.Name = "Country";
            this.Country.Size = new System.Drawing.Size(121, 28);
            this.Country.TabIndex = 14;
            this.Country.SelectedIndexChanged += new System.EventHandler(this.Country_SelectedIndexChanged);
            // 
            // Country_label
            // 
            this.Country_label.AutoSize = true;
            this.Country_label.Location = new System.Drawing.Point(28, 151);
            this.Country_label.Name = "Country_label";
            this.Country_label.Size = new System.Drawing.Size(64, 20);
            this.Country_label.TabIndex = 15;
            this.Country_label.Text = "Country";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 209);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 20);
            this.label1.TabIndex = 16;
            this.label1.Text = "Provience";
            // 
            // Provience
            // 
            this.Provience.FormattingEnabled = true;
            this.Provience.Location = new System.Drawing.Point(125, 209);
            this.Provience.Name = "Provience";
            this.Provience.Size = new System.Drawing.Size(121, 28);
            this.Provience.TabIndex = 17;
            // 
            // UserRegisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ClientSize = new System.Drawing.Size(900, 562);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
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
        private System.Windows.Forms.ComboBox Provience;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Country_label;
        private System.Windows.Forms.ComboBox Country;
    }
}