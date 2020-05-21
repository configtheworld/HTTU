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
    public partial class Form2 : Form
    {
        List<Panel> listpanel=new List<Panel>();
        private int Counter;

        Test aday= new Test();
        
        public Form2()
        {
            InitializeComponent();
        }
        // test clasımız
        class Test
        {
            private int numberOfYes=0;
            private int numberOfquite=0;

            public Test(/*int yes, int quite*/)
            {
                /*this.numberOfYes = yes;
                this.numberOfquite = quite;*/
            }

            public int getnumberOfYes()
            {
                return numberOfYes;
            }

            public void setnumberOfYes(int yesnumber)
            {
                this.numberOfYes = yesnumber;
            }
            public int getnumberOfquite()
            {
                return numberOfquite;
            }

            public void setnumberOfquite(int quitenumber)
            {
                this.numberOfquite = quitenumber;
            }


            public string TestMethod(int numberyes ,int numberquite)
            {
                int score;
                
                this.numberOfYes = numberyes;
                this.numberOfquite = numberquite;
                score = numberquite * 1 + numberyes * 3;
                if (score > 35 && score <= 39)
                {
                    return "En yakın zamanda hastaneye gitmelisiniz";
                }
                else
                {
                    return "turp gibisiiniz";
                }
            }
        }
        private void Form2_Load(object sender, EventArgs e)
        { 
            // all panels need to added here!111111

            listpanel.Add(bilgipanel);
            listpanel.Add(panel12);
            listpanel.Add(panel11);
            listpanel.Add(panel10);
            listpanel.Add(panel9);
            listpanel.Add(panel8);
            listpanel.Add(panel7);
            listpanel.Add(panel6);
            listpanel.Add(panel5);
            listpanel.Add(panel4);
            listpanel.Add(panel2);
            listpanel.Add(panel1);
            listpanel.Add(sonucpanel);
            Counter = 1;
        }

        private void evet_Click(object sender, EventArgs e)
        {
            aday.setnumberOfYes(aday.getnumberOfYes() + 1);
           
                
                if (Counter!= listpanel.Count)
                {
                    listpanel[index: Counter].Visible = true;
                    listpanel[index: Counter - 1].Visible = false;

                    Counter++;
                }
                else
                {
                    listpanel[index: Counter - 1].Visible = false;
                    sonucpanel.BringToFront(); 
                    sonucpanel.Visible=true;
                }
                

        }

        private void biraz_Click(object sender, EventArgs e)
        {
            aday.setnumberOfquite(aday.getnumberOfquite()+1);

            if (Counter != listpanel.Count)
            {
                listpanel[index: Counter].Visible = true;
                listpanel[index: Counter - 1].Visible = false;

                Counter++;
            }
            else
            {
                listpanel[index: Counter - 1].Visible = false;
                sonucpanel.BringToFront();
                sonucpanel.Visible = true;
            }
        }

        private void hayır_Click(object sender, EventArgs e)
        {
            // do nothing
            if (Counter != listpanel.Count)
            {
                listpanel[index: Counter].Visible = true;
                listpanel[index: Counter - 1].Visible = false;

                Counter++;
            }
            else
            {
                listpanel[index: Counter-1].Visible = false;
                sonucpanel.BringToFront();
                sonucpanel.Visible = true;
                
            }

        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void resultbutton_Click(object sender, EventArgs e)
        {
            String a=aday.TestMethod(aday.getnumberOfYes(), aday.getnumberOfquite());
            if (a.Equals("En yakın zamanda hastaneye gitmelisiniz"))
            {
                MessageBox.Show("Don't forget to wash your hands :)", "Stay Alive",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
            else if(a.Equals("turp gibisiiniz"))
            {

            }
            
        }
        
    }
}
