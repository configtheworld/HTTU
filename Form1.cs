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
            DatabaseConnection.Contodb();
            Menu menu = new Menu();
            menu.Show();
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
    }
}
