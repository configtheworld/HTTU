using GMap.NET;
using GMap.NET.MapProviders;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;
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
    public partial class MapForm : Form
    {
        String _loggedUserName;
        SqlDataReader dataReader;
        String conStr = @" Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=C:\USERS\SUSER\SOURCE\REPOS\HTTU\HASTADB.MDF;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        
        public MapForm(String loggedUsername)
        {
            InitializeComponent();

            SqlConnection tableSignAndLog_connection = new SqlConnection(conStr);

            String sql_command = "Select Lat, Long From dbo.tableSignAndLog";

            _loggedUserName = loggedUsername;


            Bitmap circleMarker = (Bitmap)Image.FromFile("circle.png");
            PointLatLng[] point = new PointLatLng[255];
            GMapMarker[] marker = new GMarkerGoogle[255];
            GMapOverlay markers = new GMapOverlay("infected");


            try
            {
                MessageBox.Show(_loggedUserName);
                tableSignAndLog_connection.Open();
                SqlCommand command = new SqlCommand(sql_command, tableSignAndLog_connection);
                dataReader = command.ExecuteReader();
                int i = 0;
                while (dataReader.Read())
                {
                  
                    point[i] = new PointLatLng(Convert.ToDouble(dataReader.GetValue(0)), Convert.ToDouble(dataReader.GetValue(1)));

                    marker[i] = new GMarkerGoogle(point[i],circleMarker);
                    markers.Markers.Add(marker[i]);

                    i++;
                }
                dataReader.Close();
                command.Dispose();
                tableSignAndLog_connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Can not open connection ! ");
            }


            Map.MapProvider = GMapProviders.GoogleMap;
            Map.Position = new PointLatLng(39, 35); //map e türkiyeyi oturtmak için görünmez bir nokta
            Map.MinZoom = 1;
            Map.MaxZoom = 100;
            Map.Zoom = 5;
            Map.ShowCenter = false;

            Map.Overlays.Add(markers);
        }

      
    }
}
