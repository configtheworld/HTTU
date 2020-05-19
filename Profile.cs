using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;

namespace HTTU
{
    public partial class Profile : Form
    {
        System.Timers.Timer t;
        private int d, h, m,s;

        public Profile()
        {
            InitializeComponent();
        }

        private void bindingSource1_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void Profile_Load(object sender, EventArgs e)
        {
            t=new System.Timers.Timer();
            t.Interval = 1000;//1m
            t.Elapsed += OnTimeEvent;

        }

        private void OnTimeEvent(object sender, System.Timers.ElapsedEventArgs e)
        {
            Invoke(new Action(() =>
            {
                s += 1;
                if (s == 60)
                {
                    s =0;
                    m += 1;
                }

                if (m == 60)
                {
                    m = 0;
                    h += 1;
                }

                if (h==24)
                {
                    h = 0;
                    d += 1;
                }
           
            countdowntext.Text = string.Format("{0}:{1}:{2}:{3}", d.ToString().PadLeft(2, '0'),
                h.ToString().PadLeft(2, '0'), m.ToString().PadLeft(2, '0'), s.ToString().PadLeft(2, '0'));
            }));
        }

        private void StartTimer_Click(object sender, EventArgs e)
        {
            t.Start();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Don't forget to wash your hands :)", "Stay Alive", 
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);


        }

        private void Profile_FormClosed(object sender, FormClosedEventArgs e)
        {
            t.Stop();
            Application.DoEvents();
        }
    }
}
