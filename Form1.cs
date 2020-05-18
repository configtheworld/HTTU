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

        private void aboutusbutton_Click(object sender, EventArgs e)
        {

            listpanel.Clear();
            listpanel.Add(anamenu);
            listpanel.Add(aboutuspanel);

            listpanel[index: 0].BringToFront();
            
        }

        private void backbutton3_Click(object sender, EventArgs e)
        {
            listpanel.Clear();
            listpanel.Add(anamenu);
           
            listpanel[index:0].BringToFront();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void sendmenubutton_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\doki_\OneDrive\Belgeler\hastadb.mdf;Integrated Security=True;Connect Timeout=30");
            SqlDataAdapter sqa = new SqlDataAdapter("Select count(*) From tableSign where Username ='" + nameTB.Text + "'and Password ='" + passwordTB.Text +"'",con);
            DataTable dt = new DataTable();
            sqa.Fill(dt);
            if (dt.Rows[0][0].ToString()=="1" && checkBox1.Checked)
            {
                listpanel.Clear();
                listpanel.Add(giris);
                listpanel.Add(anamenu);
                listpanel[index: 1].BringToFront();
                

            }


            if (checkBox1.Checked==false)
            {
                MessageBox.Show("Please accept the terms conditions before using the app ");
            }
            else if(dt.Rows[0][0].ToString() != "1")
            {
                MessageBox.Show("Username or Password is incorrect please try again!");

            }

            
        }

        private void statsbutton_Click(object sender, EventArgs e)
        {
            listpanel.Clear();
            listpanel.Add(anamenu);
            
            listpanel.Add(statspanel);
            listpanel[index: 0].SendToBack();
            listpanel[index:1].BringToFront();
        }

        private void aboutusbutton_Click_1(object sender, EventArgs e)
        {
            listpanel.Clear();
            listpanel.Add(anamenu);

            listpanel.Add(aboutuspanel);

            listpanel[index: 1].BringToFront();
        }

        private void symptomsbutton_Click(object sender, EventArgs e)
        {
            listpanel.Clear();
            listpanel.Add(anamenu);
            listpanel.Add(symtomspanel);
            
            listpanel[index:1].BringToFront();
        }

        private void testbutton_Click(object sender, EventArgs e)
        {
            listpanel.Clear();
            listpanel.Add(anamenu);
            listpanel.Add(testpanel1);
            
            listpanel[index:1].BringToFront();
        }

        private void backbutton2_Click(object sender, EventArgs e)
        {
            listpanel.Clear();
            listpanel.Add(anamenu);
           
            listpanel[index:0].BringToFront();
        }

        private void backbutton1_Click(object sender, EventArgs e)
        {
            listpanel.Clear();
            listpanel.Add(anamenu);
            
            listpanel[index:0].BringToFront();
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
