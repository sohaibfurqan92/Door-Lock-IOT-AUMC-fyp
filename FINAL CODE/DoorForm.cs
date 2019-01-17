using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Speech.Synthesis;
using System.Text.RegularExpressions;
using AForge.Video;
using AForge.Video.DirectShow;
using System.IO;

namespace DigiDoor_UPDATED
{
    public partial class DoorForm : Form
    {

        private SerialPort myPort;
        private string enteredPIN;

        public DoorForm()
        {
            InitializeComponent();
        }

        private FilterInfoCollection webcam;
        private VideoCaptureDevice cam;
        string camName;

        string imgloc;
        byte[] img = null;



        private void init()
        {
            myPort = new SerialPort();
            //myPort.BuadRate = 9600;
            myPort.PortName = "COM6";
            myPort.Open();
        }

        private void speech(string uname) // defining the function which will accept a string parameter
        {
            SpeechSynthesizer synthesizer = new SpeechSynthesizer();
            synthesizer.SelectVoiceByHints(VoiceGender.Female, VoiceAge.Adult); // to change VoiceGender and VoiceAge check out those links below
            synthesizer.Volume = 100;  // (0 - 100)
            synthesizer.Rate = 0;     // (-10 - 10)
                                      // Synchronous
            
            // Asynchronous
            synthesizer.SpeakAsync("Welcome" +uname); // here args = pran
        }

        private void LoadAdminPanelButton_Click(object sender, EventArgs e)
        {
            loginForm form = new loginForm();
            form.Show();
            this.Hide();

            if(cam.IsRunning)
            {
                cam.Stop();
            }
        }

        private void AuthenticateBtn_Click(object sender, EventArgs e)
        {
           try
            {
                TimeSpan ActivityTime;
                TimeSpan timeNow;
                Regex rx = new Regex("^[*][0-9]{4}[#]$"); //*1234#
                if (enteredPINTextBox.Text == string.Empty)
                {
                    MessageBox.Show("Enter a valid PIN to open door!");
                }

                if(!rx.IsMatch(enteredPINTextBox.Text))
                {
                    MessageBox.Show("Enter PIN in the format : *wxyz#\n Where wxyz are numeric digits!");
                }

                if(cam.IsRunning)
                {
                    cam.Stop();
                    captureImagePB.Image.Save(saveFileDialog1.FileName);
                    imgloc = saveFileDialog1.FileName.ToString();
                    captureImagePB.ImageLocation = imgloc;
                }

                else
                {
                    cam.Start();
                }
                enteredPIN = enteredPINTextBox.Text;

                string ConnString = ConfigurationManager.ConnectionStrings["DigiDoorConnString"].ConnectionString;
                SqlConnection conn = new SqlConnection(ConnString);

                SqlDataReader reader;
                string allowedBegTime, allowedEndTime, username;
                TimeSpan begTimeVal, EndTimeVal;

                conn.Open();

                SqlDataAdapter sda = new SqlDataAdapter("SELECT Count(*) FROM [dbo].[user_table] where passcode='" + enteredPIN + "'", conn);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                if (dt.Rows[0][0].ToString() == "1")
                {
                    // MessageBox.Show("Authentication Successful!");
                    // myPort.WriteLine("A");

                    SqlCommand retrieveAllowedTime = new SqlCommand("select * from [dbo].[user_table] where passcode='" + enteredPIN + "'", conn);
                    // conn.Open();    //open connection to database
                    reader = retrieveAllowedTime.ExecuteReader();  //used with read
                    reader.Read();

                    username = reader[2].ToString();
                    allowedBegTime = reader[5].ToString();
                    allowedEndTime = reader[6].ToString();

                    begTimeVal = TimeSpan.Parse(allowedBegTime);
                    EndTimeVal = TimeSpan.Parse(allowedEndTime);

                    conn.Close();


                    timeNow = DateTime.Now.TimeOfDay;
                    ActivityTime = new TimeSpan(timeNow.Hours, timeNow.Minutes, timeNow.Seconds);


                    if (captureImagePB.Image != null)
                    {

                        FileStream fs = new FileStream(imgloc, FileMode.Open, FileAccess.Read);
                        BinaryReader br = new BinaryReader(fs);
                        img = br.ReadBytes((int)fs.Length);
                    }

                    if (ActivityTime >= begTimeVal && ActivityTime <= EndTimeVal)
                    {
                        
                        conn.Open();
                        MessageBox.Show("Door Open! You can now enter!");
                        speech(username);
                        
                        SqlCommand cmd = new SqlCommand("log_tableAddEntry", conn);
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.Add(new SqlParameter("user_name", username));
                        cmd.Parameters.Add(new SqlParameter("check_In_Time", ActivityTime));
                        cmd.Parameters.Add(new SqlParameter("captured_Image", img));

                        cmd.ExecuteNonQuery();
                        conn.Close();

                        MessageBox.Show("Welcome " + username);
                        captureImagePB.Image = null;

                      

                    }

                    else
                    {
                        MessageBox.Show("Sorry! You can only Log in between " + allowedBegTime + "-" + allowedEndTime);

                    }
                }

                enteredPINTextBox.Text = "";
                enteredPINTextBox.Focus();
            }
            catch (Exception ex)
            {
                string lineNumber = ex.StackTrace.Substring(ex.StackTrace.Length - 7, 7);
                MessageBox.Show(ex.Message + "\n" + lineNumber);
            }

        }

        private void DoorForm_Load(object sender, EventArgs e)
        {
            webcam = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            foreach(FilterInfo VideoCaptureDevice in webcam)
            {
                camName = VideoCaptureDevice.Name;
            }

            cam = new VideoCaptureDevice(webcam[0].MonikerString);
            cam.NewFrame += new NewFrameEventHandler(cam_NewFrame);
            cam.Start();

        }

        private void enteredPINTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(char.IsNumber(e.KeyChar) || e.KeyChar=='*' || e.KeyChar=='#')
            {

            }
            else
            {
                e.Handled = e.KeyChar != (char)Keys.Back;
            }
        }

        void cam_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            Bitmap bit = (Bitmap)eventArgs.Frame.Clone();
            captureImagePB.Image = bit;
        }

        private void DoorForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                DialogResult dialog = MessageBox.Show("Do you really want to exit?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialog == DialogResult.Yes)
                {


                    Application.Exit();
                }
                else
                {
                    e.Cancel = true;
                }
            }


            catch (Exception ex)
            {
                string lineNumber = ex.StackTrace.Substring(ex.StackTrace.Length - 7, 7);
                MessageBox.Show(ex.Message + "\n" + lineNumber, "Exception", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}
