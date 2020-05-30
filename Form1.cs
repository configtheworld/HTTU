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


        System.Media.SoundPlayer player = new System.Media.SoundPlayer();
       
        
        public Form1()
        {
            InitializeComponent();
            player.SoundLocation = "coffin-dance-official-music-video-hd.wav";
           
        }
        
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
        
        private void sendmenubutton_Click(object sender, EventArgs e)
        {
            var dt = connectdatabase();
            if (dt.Rows[0][0].ToString() == "1" && checkBox1.Checked)
            {
                this.Hide();
                Menu menu = new Menu(nameTB.Text);
                menu.Show();
            }


            if (checkBox1.Checked == false)
            {
                MessageBox.Show("Please accept the terms conditions before using the app ");
            }
            else if (dt.Rows[0][0].ToString() != "1")
            {
                MessageBox.Show("Username or Password is incorrect please try again!");
            }
            
        }

        private DataTable connectdatabase()
        {
            SqlConnection con =
                new SqlConnection(
                    @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\suser\source\repos\HTTU\hastadb.mdf;Integrated Security=True;Connect Timeout=30");
            SqlDataAdapter sqa =
                new SqlDataAdapter(
                    "Select count(*) From tableSignAndLog where Username ='" + nameTB.Text + "'and Password ='" + passwordTB.Text +
                    "'", con);
            DataTable dt = new DataTable();
            sqa.Fill(dt);
            return dt;
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


        bool playerstate = false;
        private void MuteButton_Click_1(object sender, EventArgs e)
        {
            //girişin mute butonu
            
            playerstate = mutesong.mute(player, playerstate);
        }

        private void registerbutton_Click(object sender, EventArgs e)
        {
          UserRegisterForm userRegister = new UserRegisterForm();
          userRegister.ShowDialog();

        }

        private void nameTB_Enter(object sender, EventArgs e)
        {
            if (nameTB.Text=="UserName")
            {
                nameTB.Text = "";
                nameTB.ForeColor=Color.Black;
            }
        }

        private void nameTB_Leave(object sender, EventArgs e)
        {
            if (nameTB.Text=="")
            {
                nameTB.Text = "UserName";
                nameTB.ForeColor = Color.DarkGray;
            }
        }

        private void passwordTB_Enter(object sender, EventArgs e)
        {
            if (passwordTB.Text=="Password")
            {
                passwordTB.Text = "";
                passwordTB.ForeColor=Color.Black;
                passwordTB.PasswordChar = '*';
            }
        }

        private char? empty = null;
        private void passwordTB_Leave(object sender, EventArgs e)
        {
            if (passwordTB.Text=="")
            {
                passwordTB.Text = "Password";
                passwordTB.ForeColor=Color.DarkGray;
                passwordTB.PasswordChar = Convert.ToChar(empty);
            }
        }
    }
}
