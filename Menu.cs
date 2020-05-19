using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HTTU
{
    
    public partial class Menu : Form
    {

        List<Panel> listpanel = new List<Panel>();
        System.Media.SoundPlayer player = new System.Media.SoundPlayer();
        public Menu()
        {
            InitializeComponent();
            player.SoundLocation = "coffin-dance-official-music-video-hd.wav";
            
        }
        // menu buttonları
        private void symptomsbutton_Click(object sender, EventArgs e)
        {
            aboutuspanel.Visible = false;
            symtomspanel.Visible = true;
            testpanel.Visible = false;
            statspanel.Visible = false;
        }

        private void aboutusbutton_Click(object sender, EventArgs e)
        {
            symtomspanel.Visible = false;
            testpanel.Visible = false;
            statspanel.Visible = false;
            aboutuspanel.Visible = false;
            aboutuspanel.Visible = true;
        }

        private void statsbutton_Click(object sender, EventArgs e)
        {
            aboutuspanel.Visible = false;
            symtomspanel.Visible = false;
            testpanel.Visible = false;
            statspanel.Visible = true;
        }
        private void testbuttondash_Click(object sender, EventArgs e)
        {
            aboutuspanel.Visible = false;
            symtomspanel.Visible = false;
            statspanel.Visible = false;
            testpanel.Visible = true;
        }

        
        private void button1_Click(object sender, EventArgs e)
        {// android back buttonu
            aboutuspanel.Visible = false;
            symtomspanel.Visible = false;
            statspanel.Visible = false;
            testpanel.Visible = true;
        }

        private void cikis_Click(object sender, EventArgs e)
        {
            // çıkıs butonu
            this.Close();
        }

        

        private void backbutton3_Click(object sender, EventArgs e)
        {
            // about us back button
            aboutuspanel.Visible = false;
            symtomspanel.Visible = false;
            testpanel.Visible = true;
            statspanel.Visible = false;
        }

        private void backbutton1_Click(object sender, EventArgs e)
        {
            // symtoms back button
            aboutuspanel.Visible = false;
            symtomspanel.Visible = false;
            testpanel.Visible = true;
            statspanel.Visible = false;
        }

        private void backbutton2_Click(object sender, EventArgs e)
        {
            // stats back button
            aboutuspanel.Visible = false;
            symtomspanel.Visible = false;
            testpanel.Visible = true;
            statspanel.Visible = false;
        }

       
        private void testbutton_Click(object sender, EventArgs e)
        {
            //testi başlatan buton
            
            Form2 form2 = new Form2();
            form2.Show();
        }
        
        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            //web browser panelinin kodu url kendisinde

        }

        private void profilebutton_Click(object sender, EventArgs e)
        {
            // profilin butonu
            Profile profile = new Profile();
            profile.Show();
        }

        private void Menu_Load(object sender, EventArgs e)
        {

        }

        bool playerstate = false;
        private void MuteButton_Click(object sender, EventArgs e)
        {
            //menunun mute butonu
           
            playerstate = mutesong.mute(player, playerstate);

        }
    }
}
