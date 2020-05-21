using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HTTU
{
   class DatabaseConnection
    {
        public static void Contodb()
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
    }
}
