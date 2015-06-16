using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GMap.NET.MapProviders;
using GMap.NET;
using MySql.Data.MySqlClient;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;
using System.Net;
using System.IO;

namespace Test
{
    public partial class frmTester : Form
    {
        private double latitude;
        private double longitude;
        private int priority;
        private double radius;

        public frmTester()
        {
            InitializeComponent();
        }

        private void frmTester_Load(object sender, EventArgs e)
        {
            gmap.MapProvider = GMap.NET.MapProviders.GoogleMapProvider.Instance;
            GMap.NET.GMaps.Instance.Mode = GMap.NET.AccessMode.ServerOnly;
            gmap.SetPositionByKeywords("Louisville");
            gmap.MinZoom = 1;
            gmap.MaxZoom = 17;
            gmap.Zoom = 9;
            gmap.CanDragMap = true;
        }

        private void btnGo_Click(object sender, EventArgs e)
        {
            //Make sure that user keyed in all fields.
            if(txtAlertTitle.Text == string.Empty || txtAlertDescription.Text == string.Empty || !checkRadioButtons())
            {
                MessageBox.Show("Please enter all required field");
            }
            //if the user entered in all of the required feilds, now butild sql query
            else
            {
                string format = "yyyy-M-d h:mm:ss";

                //get the priority
                setPriorityAndRadius();
                
                //build the sql query
                string query = "INSERT INTO a7798723_alertU.alerts (title, description, createdAt, latitude, longitude, priority, radius) VALUES ";
                query = string.Format(query + "('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}')", txtAlertTitle.Text, txtAlertDescription.Text, DateTime.Now.ToString(format), latitude, longitude, priority, radius);
                try
                {
                    string url = "http://alertu.net63.net/AlertU/runquery.php";
                    string str = query;

                    HttpWebRequest req = (HttpWebRequest)WebRequest.Create(url);
                    req.Method = "POST";
                    string Data = "message=" + str;
                    byte[] postBytes = Encoding.ASCII.GetBytes(Data);
                    req.ContentType = "application/x-www-form-urlencoded";
                    req.ContentLength = postBytes.Length;
                    Stream requestStream = req.GetRequestStream();
                    requestStream.Write(postBytes, 0, postBytes.Length);
                    requestStream.Close();

                    HttpWebResponse response = (HttpWebResponse)req.GetResponse();
                    Stream resStream = response.GetResponseStream();

                    var sr = new StreamReader(response.GetResponseStream());
                    string responseText = sr.ReadToEnd();
                    MessageBox.Show(responseText);
                    Console.WriteLine(responseText);

                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }
                /*
                //connectiong string for database
                string cs = @"Server=mysql1.000webhost.com; Database=a7798723_alertU; Uid=a7798723_cheese; Pwd=BigCheese#1";
                //sql connection object
                MySqlConnection conn = null;

                try
                {
                    //start to open the connection
                    conn = new MySqlConnection(cs);
                    conn.Open();

                    MySqlCommand cmd = new MySqlCommand();
                    cmd.Connection = conn;
                    cmd.CommandText = query;
                    cmd.Prepare();
                    //execute the query
                    cmd.ExecuteNonQuery();
                }
                //if any errors are thrown, catch them and display them to the user
                catch (Exception ex)
                {
                    Console.WriteLine("Error: {0}", ex.Message);
                    using(frmError er = new frmError("Failed to issue alert, " + ex.Message))
                    {
                        er.ShowDialog();
                    }
                }
                finally
                {
                    if (conn != null)
                    {
                        conn.Close();
                    }
                }
                 */

            }
        }

        private void setPriorityAndRadius()
        {
            if(rb1.Checked)
            {
                priority = 1;
            }
            else if(rb2.Checked)
            {
                priority = 2;
            }
            else if(rb3.Checked)
            {
                priority = 3;
            }
            else if(rb4.Checked)
            {
                priority = 4;
            }
            else if(rb5.Checked)
            {
                priority = 5;
            }

            radius = .5;
        }

        private bool checkRadioButtons()
        {
            //if one of the 5 radio buttons are checked then this function will return true
            if (rb1.Checked || rb2.Checked || rb3.Checked || rb4.Checked || rb5.Checked)
            {
                return true;
            }
            //if none are checked, then GG this will return false.
            else
            {
                return false;
            }
        }

        private void gmap_MouseClick(object sender, MouseEventArgs e)
        {
            var p = gmap.FromLocalToLatLng(MousePosition.X, MousePosition.Y);
            latitude = p.Lat;
            longitude = p.Lng;
            GMapOverlay markersOverlay = new GMapOverlay("markers");
            GMarkerGoogle marker = new GMarkerGoogle(p,GMarkerGoogleType.red);
            markersOverlay.Markers.Add(marker);
            gmap.Overlays.Add(markersOverlay);
        }
    }

    public struct Alert
    {
        private string title;
        private string description;
        private DateTime createdAt;
        private double latitude;
        private double longitude;
        private int priority;
        private double radius;

        public Alert (string title, string description, DateTime createdAt, double latitude, double longitude, int priority, double radius)
	    {
            this.title = title;
            this.description = description;
            this.createdAt = createdAt;
            this.latitude = latitude;
            this.longitude = longitude;
            this.priority = priority;
            this.radius = radius;
	    }
    }
}
