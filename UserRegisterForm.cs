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
    public partial class UserRegisterForm : Form
    {
        SqlConnection con_coordinates = new SqlConnection(@"Data Source = (localdb)\MSSQLLocalDB; Initial Catalog = coordinates; Integrated Security = True; Connect Timeout = 30; Encrypt = False; TrustServerCertificate = False; ApplicationIntent = ReadWrite; MultiSubnetFailover = False");
        SqlCommand cmd;
        int il_id;
        float Lat, Long;
        
      
       
        public UserRegisterForm()
        {
            InitializeComponent();
        }

        public void closeoperation()
        {
            this.Close();
        }
        private void UserRegisterForm_Load(object sender, EventArgs e)
        {
            con_coordinates.Open();

            Country.Items.Clear();
    
            cmd = con_coordinates.CreateCommand();
            cmd.CommandType = CommandType.Text;

            cmd.CommandText = "SELECT sehir From coordinates.dbo.iller";
            cmd.ExecuteNonQuery();

            DataTable dt_iller = new DataTable();
            SqlDataAdapter dataAdapter_iller = new SqlDataAdapter(cmd);
            dataAdapter_iller.Fill(dt_iller);

            foreach(DataRow dr in dt_iller.Rows)
            {
                Country.Items.Add(dr["sehir"].ToString());
            }


            cmd.Parameters.Clear();
            con_coordinates.Close();
        }

        private void RegisterNowButton_Click(object sender, EventArgs e)
        {
            con_coordinates.Open();
            cmd.CommandText = "SELECT lat FROM coordinates.dbo.iller where ilce=@_ilce";
            cmd.Parameters.AddWithValue("_ilce", Country.SelectedItem.ToString());
            Lat = (Int32)cmd.ExecuteScalar();
            cmd.Parameters.Clear();

            cmd.CommandText = "SELECT long FROM coordinates.dbo.iller where ilce=@_ilce";
            cmd.Parameters.AddWithValue("_ilce", Country.SelectedItem.ToString());
            Long = (Int32)cmd.ExecuteScalar();
            cmd.Parameters.Clear();



            UserAndPassControl user= new UserAndPassControl();
            user.newUser(nameTB,passwordTB,Country,Provience,ConfirmTB,Lat,Long,groupBox1);
            this.Close();
        }

        private void Confirmpass_Click(object sender, EventArgs e)
        {

        }

        private void Country_SelectedIndexChanged(object sender, EventArgs e)
        {
            con_coordinates.Open();

            cmd.CommandText = "SELECT id FROM coordinates.dbo.iller where sehir=@_sehir";
            cmd.Parameters.AddWithValue("_sehir", Country.SelectedItem.ToString());
            il_id = (Int32)cmd.ExecuteScalar();

            Provience.Items.Clear();

            cmd.CommandText = "SELECT ilce From coordinates.dbo.ilceler where il=@_ilce";
            cmd.Parameters.AddWithValue("_ilce",il_id);
            cmd.ExecuteNonQuery();

            DataTable dt_ilceler = new DataTable();
            SqlDataAdapter dataAdapter_ilceler = new SqlDataAdapter(cmd);
            dataAdapter_ilceler.Fill(dt_ilceler);

            foreach (DataRow dr in dt_ilceler.Rows)
            {
                Provience.Items.Add(dr["ilce"].ToString());
            }

            cmd.Parameters.Clear();
            con_coordinates.Close();
        }
    }
}
