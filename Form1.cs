using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HTTU
{
    public partial class Form1 : Form
    {
        List<Panel> listpanel = new List<Panel>();
        
        
        
        public Form1()
        {
            InitializeComponent();

        }

        private void label2_Click(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void sendmenubutton_Click(object sender, EventArgs e)
        {
            contodb();
        }

        private void contodb()
        {
            /*SqlConnection con =
                new SqlConnection(
                    @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\berk_\source\repos\HTTU\hastadb.mdf;Integrated Security=True;Connect Timeout=30");
            SqlDataAdapter sqa =
                new SqlDataAdapter(
                    "Select count(*) From tableSign where Username ='" + nameTB.Text + "'and Password ='" + passwordTB.Text +
                    "'", con);
            DataTable dt = new DataTable();
            sqa.Fill(dt);
            if (dt.Rows[0][0].ToString() == "1" && checkBox1.Checked)
            {
                */Menu menu = new Menu();
                menu.Show();/*
            }


            if (checkBox1.Checked == false)
            {
                MessageBox.Show("Please accept the terms conditions before using the app ");
            }
            else if (dt.Rows[0][0].ToString() != "1")
            {
                MessageBox.Show("Username or Password is incorrect please try again!");
            }*/
        }

        private void cikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void nameTB_TextChanged(object sender, EventArgs e)
        {

        }

        private void passwordTB_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
