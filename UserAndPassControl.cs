using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace HTTU
{
    class UserAndPassControl
    {
        
        SqlConnection con =
            new SqlConnection(
                @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\suser\source\repos\HTTU\hastadb.mdf;Integrated Security=True;Connect Timeout=30");

        private SqlCommand cmd;
        private SqlDataReader reader;
        public void newUser(TextBox Username,ComboBox Country,ComboBox Provience , TextBox Password,TextBox repassword,float Lat,float Long, GroupBox group)
        {
            con.Open();
            cmd=new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "select *from tableSignAndLog where Username= '" + Username.Text + "'";
            reader = cmd.ExecuteReader();
            if (reader.Read()==false)
            {
                
                if (Password.Text == repassword.Text)
                {
                    con.Close();
                    con.Open();
                    cmd = new SqlCommand();
                    cmd.Connection = con;
                    cmd.CommandText = "insert into tableSignAndLog values('" + Username.Text + "','" + Country.Text+ "','" + Provience.Text+"','" + Password.Text + "','" + Lat + "','" + Long + "','" + "0" + "')";
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("User Added!");
                    foreach (Control item in group.Controls)
                    {
                        if (item is TextBox)
                        {
                            item.Text = "";
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Passwords don't match please check again", "Error");
                } 
            }
            else
            {
                MessageBox.Show("Username already exists");
            }
        }

        public bool newpass(TextBox Username,TextBox Password,TextBox Repassword)
        {
            if (Password.Text == Repassword.Text)
            {
                con.Open();
                cmd = new SqlCommand("select *from tableSignAndLog where  Username= '" + Username.Text + "'" , con);
                reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    con.Close();
                    con.Open();
                    cmd=new SqlCommand("update tableSignAndLog set Password= '"+Password.Text+"'where Username='"+Username.Text+"'",con);
                    cmd.ExecuteScalar();
                    con.Close();
                    if (Password.Text!="")
                    {
                        MessageBox.Show("User successfully added");
                        return true;
                    }
                    else
                    {
                        MessageBox.Show("Password must be filled");
                        return false;
                    }
                    
                }
                else
                {
                    MessageBox.Show("Please enter your Account Username", "error");
                    con.Close();
                    return false;
                    
                }
            }
            else
            {
                MessageBox.Show("Passwords dont match!", "error");
                return false;
            }
        }
    }
}
