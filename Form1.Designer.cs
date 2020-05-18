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
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.giris = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.passwordTB = new System.Windows.Forms.TextBox();
            this.nameTB = new System.Windows.Forms.TextBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.sendmenubutton = new System.Windows.Forms.Button();
            this.anamenu = new System.Windows.Forms.Panel();
            this.aboutusbutton = new System.Windows.Forms.Button();
            this.statsbutton = new System.Windows.Forms.Button();
            this.testbutton = new System.Windows.Forms.Button();
            this.symptomsbutton = new System.Windows.Forms.Button();
            this.aboutuspanel = new System.Windows.Forms.Panel();
            this.backbutton3 = new System.Windows.Forms.Button();
            this.testpanel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.statspanel = new System.Windows.Forms.Panel();
            this.backbutton2 = new System.Windows.Forms.Button();
            this.backbutton1 = new System.Windows.Forms.Button();
            this.symtomspanel = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.giris.SuspendLayout();
            this.anamenu.SuspendLayout();
            this.aboutuspanel.SuspendLayout();
            this.testpanel1.SuspendLayout();
            this.statspanel.SuspendLayout();
            this.symtomspanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.label1.Location = new System.Drawing.Point(65, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "H T T U";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(440, 29);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(252, 82);
            this.panel1.TabIndex = 1;
            // 
            // giris
            // 
            this.giris.Controls.Add(this.label3);
            this.giris.Controls.Add(this.label2);
            this.giris.Controls.Add(this.passwordTB);
            this.giris.Controls.Add(this.nameTB);
            this.giris.Controls.Add(this.checkBox1);
            this.giris.Controls.Add(this.sendmenubutton);
            this.giris.Location = new System.Drawing.Point(3, 0);
            this.giris.Name = "giris";
            this.giris.Size = new System.Drawing.Size(601, 379);
            this.giris.TabIndex = 2;
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
            this.label2.Location = new System.Drawing.Point(52, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(153, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Name and Surname";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // passwordTB
            // 
            this.passwordTB.Location = new System.Drawing.Point(211, 137);
            this.passwordTB.Name = "passwordTB";
            this.passwordTB.Size = new System.Drawing.Size(182, 32);
            this.passwordTB.TabIndex = 3;
            // 
            // nameTB
            // 
            this.nameTB.Location = new System.Drawing.Point(211, 74);
            this.nameTB.Name = "nameTB";
            this.nameTB.Size = new System.Drawing.Size(182, 32);
            this.nameTB.TabIndex = 2;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox1.Location = new System.Drawing.Point(101, 232);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(232, 23);
            this.checkBox1.TabIndex = 1;
            this.checkBox1.Text = "Accept Terms and Conditions";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // sendmenubutton
            // 
            this.sendmenubutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sendmenubutton.Location = new System.Drawing.Point(101, 274);
            this.sendmenubutton.Name = "sendmenubutton";
            this.sendmenubutton.Size = new System.Drawing.Size(115, 53);
            this.sendmenubutton.TabIndex = 0;
            this.sendmenubutton.Text = "Sign in";
            this.sendmenubutton.UseVisualStyleBackColor = true;
            this.sendmenubutton.Click += new System.EventHandler(this.sendmenubutton_Click);
            // 
            // anamenu
            // 
            this.anamenu.Controls.Add(this.aboutusbutton);
            this.anamenu.Controls.Add(this.statsbutton);
            this.anamenu.Controls.Add(this.testbutton);
            this.anamenu.Controls.Add(this.symptomsbutton);
            this.anamenu.Location = new System.Drawing.Point(248, 124);
            this.anamenu.Name = "anamenu";
            this.anamenu.Size = new System.Drawing.Size(601, 370);
            this.anamenu.TabIndex = 3;
            // 
            // aboutusbutton
            // 
            this.aboutusbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.aboutusbutton.Location = new System.Drawing.Point(14, 237);
            this.aboutusbutton.Name = "aboutusbutton";
            this.aboutusbutton.Size = new System.Drawing.Size(204, 62);
            this.aboutusbutton.TabIndex = 3;
            this.aboutusbutton.Text = "About Us";
            this.aboutusbutton.UseVisualStyleBackColor = true;
            this.aboutusbutton.Click += new System.EventHandler(this.aboutusbutton_Click_1);
            // 
            // statsbutton
            // 
            this.statsbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.statsbutton.Location = new System.Drawing.Point(14, 130);
            this.statsbutton.Name = "statsbutton";
            this.statsbutton.Size = new System.Drawing.Size(204, 62);
            this.statsbutton.TabIndex = 2;
            this.statsbutton.Text = "covid 19 stats";
            this.statsbutton.UseVisualStyleBackColor = true;
            this.statsbutton.Click += new System.EventHandler(this.statsbutton_Click);
            // 
            // testbutton
            // 
            this.testbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.testbutton.Location = new System.Drawing.Point(304, 17);
            this.testbutton.Name = "testbutton";
            this.testbutton.Size = new System.Drawing.Size(217, 282);
            this.testbutton.TabIndex = 1;
            this.testbutton.Text = "Test";
            this.testbutton.UseVisualStyleBackColor = true;
            this.testbutton.Click += new System.EventHandler(this.testbutton_Click);
            // 
            // symptomsbutton
            // 
            this.symptomsbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.symptomsbutton.Location = new System.Drawing.Point(14, 17);
            this.symptomsbutton.Name = "symptomsbutton";
            this.symptomsbutton.Size = new System.Drawing.Size(204, 62);
            this.symptomsbutton.TabIndex = 0;
            this.symptomsbutton.Text = "covid 19 symptoms";
            this.symptomsbutton.UseVisualStyleBackColor = true;
            this.symptomsbutton.Click += new System.EventHandler(this.symptomsbutton_Click);
            // 
            // aboutuspanel
            // 
            this.aboutuspanel.Controls.Add(this.backbutton3);
            this.aboutuspanel.Location = new System.Drawing.Point(251, 124);
            this.aboutuspanel.Name = "aboutuspanel";
            this.aboutuspanel.Size = new System.Drawing.Size(601, 370);
            this.aboutuspanel.TabIndex = 6;
            // 
            // backbutton3
            // 
            this.backbutton3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backbutton3.Location = new System.Drawing.Point(14, 237);
            this.backbutton3.Name = "backbutton3";
            this.backbutton3.Size = new System.Drawing.Size(204, 62);
            this.backbutton3.TabIndex = 3;
            this.backbutton3.Text = "About us";
            this.backbutton3.UseVisualStyleBackColor = true;
            this.backbutton3.Click += new System.EventHandler(this.backbutton3_Click);
            // 
            // testpanel1
            // 
            this.testpanel1.Controls.Add(this.giris);
            this.testpanel1.Controls.Add(this.label4);
            this.testpanel1.Location = new System.Drawing.Point(0, 3);
            this.testpanel1.Name = "testpanel1";
            this.testpanel1.Size = new System.Drawing.Size(601, 370);
            this.testpanel1.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(118, 57);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(194, 23);
            this.label4.TabIndex = 0;
            this.label4.Text = "test panelleri sırala";
            // 
            // statspanel
            // 
            this.statspanel.Controls.Add(this.backbutton2);
            this.statspanel.Location = new System.Drawing.Point(257, 121);
            this.statspanel.Name = "statspanel";
            this.statspanel.Size = new System.Drawing.Size(601, 370);
            this.statspanel.TabIndex = 5;
            // 
            // backbutton2
            // 
            this.backbutton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backbutton2.Location = new System.Drawing.Point(14, 130);
            this.backbutton2.Name = "backbutton2";
            this.backbutton2.Size = new System.Drawing.Size(204, 62);
            this.backbutton2.TabIndex = 2;
            this.backbutton2.Text = "covid 19 stats";
            this.backbutton2.UseVisualStyleBackColor = true;
            this.backbutton2.Click += new System.EventHandler(this.backbutton2_Click);
            // 
            // backbutton1
            // 
            this.backbutton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backbutton1.Location = new System.Drawing.Point(14, 17);
            this.backbutton1.Name = "backbutton1";
            this.backbutton1.Size = new System.Drawing.Size(204, 62);
            this.backbutton1.TabIndex = 0;
            this.backbutton1.Text = "covid 19 symptoms";
            this.backbutton1.UseVisualStyleBackColor = true;
            this.backbutton1.Click += new System.EventHandler(this.backbutton1_Click);
            // 
            // symtomspanel
            // 
            this.symtomspanel.Controls.Add(this.testpanel1);
            this.symtomspanel.Controls.Add(this.backbutton1);
            this.symtomspanel.Location = new System.Drawing.Point(254, 121);
            this.symtomspanel.Name = "symtomspanel";
            this.symtomspanel.Size = new System.Drawing.Size(601, 382);
            this.symtomspanel.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(1138, 539);
            this.Controls.Add(this.symtomspanel);
            this.Controls.Add(this.anamenu);
            this.Controls.Add(this.aboutuspanel);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.statspanel);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.Info;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.giris.ResumeLayout(false);
            this.giris.PerformLayout();
            this.anamenu.ResumeLayout(false);
            this.aboutuspanel.ResumeLayout(false);
            this.testpanel1.ResumeLayout(false);
            this.testpanel1.PerformLayout();
            this.statspanel.ResumeLayout(false);
            this.symtomspanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel giris;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox passwordTB;
        private System.Windows.Forms.TextBox nameTB;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button sendmenubutton;
        private System.Windows.Forms.Panel anamenu;
        private System.Windows.Forms.Button statsbutton;
        private System.Windows.Forms.Button testbutton;
        private System.Windows.Forms.Button symptomsbutton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel statspanel;
        private System.Windows.Forms.Button backbutton2;
        private System.Windows.Forms.Button aboutusbutton;
        private System.Windows.Forms.Panel aboutuspanel;
        private System.Windows.Forms.Button backbutton3;
        private System.Windows.Forms.Panel testpanel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button backbutton1;
        private System.Windows.Forms.Panel symtomspanel;
    }
}

