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
            listpanel.Clear();
            listpanel.Add(giris);
            listpanel.Add(anamenu);
            listpanel[index: 1].BringToFront();
            
           
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
    }
}
