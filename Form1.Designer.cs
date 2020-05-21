namespace HTTU
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.giris = new System.Windows.Forms.Panel();
            this.forgotpass = new System.Windows.Forms.LinkLabel();
            this.registerbutton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.passwordTB = new System.Windows.Forms.TextBox();
            this.nameTB = new System.Windows.Forms.TextBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.sendmenubutton = new System.Windows.Forms.Button();
            this.cikis = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.MuteButton = new System.Windows.Forms.Button();
            this.giris.SuspendLayout();
            this.SuspendLayout();
            // 
            // giris
            // 
            this.giris.Controls.Add(this.forgotpass);
            this.giris.Controls.Add(this.registerbutton);
            this.giris.Controls.Add(this.label3);
            this.giris.Controls.Add(this.label2);
            this.giris.Controls.Add(this.passwordTB);
            this.giris.Controls.Add(this.nameTB);
            this.giris.Controls.Add(this.checkBox1);
            this.giris.Controls.Add(this.sendmenubutton);
            this.giris.Location = new System.Drawing.Point(240, 123);
            this.giris.Name = "giris";
            this.giris.Size = new System.Drawing.Size(601, 379);
            this.giris.TabIndex = 2;
            // 
            // forgotpass
            // 
            this.forgotpass.ActiveLinkColor = System.Drawing.Color.Red;
            this.forgotpass.AutoSize = true;
            this.forgotpass.LinkColor = System.Drawing.Color.Red;
            this.forgotpass.Location = new System.Drawing.Point(59, 195);
            this.forgotpass.Name = "forgotpass";
            this.forgotpass.Size = new System.Drawing.Size(209, 23);
            this.forgotpass.TabIndex = 7;
            this.forgotpass.TabStop = true;
            this.forgotpass.Text = "Forgot my password";
            // 
            // registerbutton
            // 
            this.registerbutton.FlatAppearance.BorderSize = 0;
            this.registerbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.registerbutton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.registerbutton.Image = ((System.Drawing.Image)(resources.GetObject("registerbutton.Image")));
            this.registerbutton.Location = new System.Drawing.Point(341, 267);
            this.registerbutton.Name = "registerbutton";
            this.registerbutton.Size = new System.Drawing.Size(164, 75);
            this.registerbutton.TabIndex = 6;
            this.registerbutton.Text = "Sign up";
            this.registerbutton.UseVisualStyleBackColor = true;
            this.registerbutton.Click += new System.EventHandler(this.registerbutton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(97, 143);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Password";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(97, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "UserName";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // passwordTB
            // 
            this.passwordTB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.passwordTB.ForeColor = System.Drawing.Color.DarkGray;
            this.passwordTB.Location = new System.Drawing.Point(211, 137);
            this.passwordTB.Name = "passwordTB";
            this.passwordTB.Size = new System.Drawing.Size(182, 25);
            this.passwordTB.TabIndex = 3;
            this.passwordTB.Text = "Password";
            this.passwordTB.TextChanged += new System.EventHandler(this.passwordTB_TextChanged);
            this.passwordTB.Enter += new System.EventHandler(this.passwordTB_Enter);
            this.passwordTB.Leave += new System.EventHandler(this.passwordTB_Leave);
            // 
            // nameTB
            // 
            this.nameTB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.nameTB.ForeColor = System.Drawing.Color.DarkGray;
            this.nameTB.Location = new System.Drawing.Point(211, 80);
            this.nameTB.Name = "nameTB";
            this.nameTB.Size = new System.Drawing.Size(182, 25);
            this.nameTB.TabIndex = 2;
            this.nameTB.Text = "UserName";
            this.nameTB.TextChanged += new System.EventHandler(this.nameTB_TextChanged);
            this.nameTB.Enter += new System.EventHandler(this.nameTB_Enter);
            this.nameTB.Leave += new System.EventHandler(this.nameTB_Leave);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox1.Location = new System.Drawing.Point(181, 238);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(232, 23);
            this.checkBox1.TabIndex = 1;
            this.checkBox1.Text = "Accept Terms and Conditions";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // sendmenubutton
            // 
            this.sendmenubutton.FlatAppearance.BorderSize = 0;
            this.sendmenubutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sendmenubutton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.sendmenubutton.Image = ((System.Drawing.Image)(resources.GetObject("sendmenubutton.Image")));
            this.sendmenubutton.Location = new System.Drawing.Point(86, 267);
            this.sendmenubutton.Name = "sendmenubutton";
            this.sendmenubutton.Size = new System.Drawing.Size(164, 75);
            this.sendmenubutton.TabIndex = 0;
            this.sendmenubutton.Text = "Sign in";
            this.sendmenubutton.UseVisualStyleBackColor = true;
            this.sendmenubutton.Click += new System.EventHandler(this.sendmenubutton_Click);
            // 
            // cikis
            // 
            this.cikis.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cikis.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.cikis.Image = ((System.Drawing.Image)(resources.GetObject("cikis.Image")));
            this.cikis.Location = new System.Drawing.Point(957, 473);
            this.cikis.Name = "cikis";
            this.cikis.Size = new System.Drawing.Size(80, 79);
            this.cikis.TabIndex = 7;
            this.cikis.UseVisualStyleBackColor = true;
            this.cikis.Click += new System.EventHandler(this.cikis_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.Location = new System.Drawing.Point(418, 6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(274, 111);
            this.panel1.TabIndex = 1;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // MuteButton
            // 
            this.MuteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MuteButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.MuteButton.Image = ((System.Drawing.Image)(resources.GetObject("MuteButton.Image")));
            this.MuteButton.Location = new System.Drawing.Point(32, 489);
            this.MuteButton.Name = "MuteButton";
            this.MuteButton.Size = new System.Drawing.Size(90, 63);
            this.MuteButton.TabIndex = 9;
            this.MuteButton.UseVisualStyleBackColor = true;
            this.MuteButton.Click += new System.EventHandler(this.MuteButton_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(1058, 564);
            this.Controls.Add(this.MuteButton);
            this.Controls.Add(this.giris);
            this.Controls.Add(this.cikis);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.Info;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.giris.ResumeLayout(false);
            this.giris.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel giris;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox passwordTB;
        private System.Windows.Forms.TextBox nameTB;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button sendmenubutton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button cikis;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button MuteButton;
        private System.Windows.Forms.Button registerbutton;
        private System.Windows.Forms.LinkLabel forgotpass;
    }
}

