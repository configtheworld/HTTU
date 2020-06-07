using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Messaging;

namespace HTTU
{
    public partial class Form2 : Form
    {
        static String _loggedUserName;
        List<Panel> listpanel=new List<Panel>();
        private int Counter;

        Test aday = new Test();

        public Form2(String loggedUsername)
        {
            InitializeComponent();
            _loggedUserName = loggedUsername;
        }
        // test clasımız
        class Test
        {
            
            private int numberOfYes=0;
            private int numberOfquite=0;

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


            public string TestMethod()
            {
                int score;

               
                score =  getnumberOfquite()* 1 + getnumberOfYes() * 3;
                if (score > 35 && score <= 39)
                {


                    SqlConnection con =
                        new SqlConnection(
                            @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\doki_\source\repos\HTTUsunum7haziran\hastadb.mdf;Integrated Security=True;Connect Timeout=30");
                    con.Open();
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = con;
                    cmd.CommandText = "UPDATE dbo.tableSignAndLog SET Sick = @sick Where Username = @username ";
                    cmd.Parameters.AddWithValue("@sick", 1);
                    cmd.Parameters.AddWithValue("@username", Form2._loggedUserName );
                    cmd.ExecuteNonQuery();
                    con.Close();

                    return "En yakın zamanda hastaneye gitmelisiniz";
                }
                else if (score > 28 && score <= 35)
                {
                    return "Eğer belirtiler artar ise hastaneye gidebilirsiniz";
                }
                else if (score > 20 && score <= 28)
                {
                    return "evde kalıp beslenmenize ve hijyeninize dikkat edebilirsiniz";
                }
                else if(score<=20)
                {
                    return "Sağlıklı gözüküyorsunuz evde kalın .Ecdadünü skrim haaa";
                }
                else
                {
                    return "";
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
                    listpanel.Add(suser);
                    suser.Visible = true;
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
                listpanel.Add(suser);
                suser.Visible = true;
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
                listpanel.Add(suser);
                suser.Visible = true;

            }

        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void resultbutton_Click(object sender, EventArgs e)
        {
            sonucbox.Text = aday.TestMethod(/*aday.getnumberOfYes(), aday.getnumberOfquite()*/);

            listpanel.Add(sonucekrani);
            sonucekrani.Visible = true;
            sonucekrani.BringToFront();
            


        }

        private void cikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
