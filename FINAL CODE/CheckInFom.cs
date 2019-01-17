using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AForge.Video;
using AForge.Video.DirectShow;
using System.Text.RegularExpressions;
using System.Configuration;
using System.Speech.Synthesis;
using System.Net.Mail;

namespace DigiDoor_UPDATED
{
    public partial class CheckInFom : Form
    {
        private SerialPort myPort;
        private string enteredPIN;
        public int invalidAttempts = 0;
        public bool activeStatus = true;
        string systemStatus = "active";
        string currentState;

        public CheckInFom()
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

        private void sendMail()
        {
            try
            {
                MailMessage mail = new MailMessage();
                SmtpClient SmtpServer = new SmtpClient("smtp.gmail.com");

                mail.From = new MailAddress("sohaibfurqan@gmail.com");
                mail.To.Add("sohaibfurqan@hotmail.com");
                mail.Subject = "Suspicious Activity Detected!";
                mail.Body = "This is an automated email from \"DIGITAL DOOR LOCK AND CONTROL SYSTEM\" to inform that the system has been disabled\nPlease log in to admin panel and reactivate.";

                SmtpServer.Port = 587;
                SmtpServer.Credentials = new System.Net.NetworkCredential("sohaibfurqan@gmail.com","adress@email.com");
                SmtpServer.EnableSsl = true;

                SmtpServer.Send(mail);
                MessageBox.Show("mail Sent");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        private void speech(string uname) // defining the function which will accept a string parameter
        {
            SpeechSynthesizer synthesizer = new SpeechSynthesizer();
            synthesizer.SelectVoiceByHints(VoiceGender.Female, VoiceAge.Adult); // to change VoiceGender and VoiceAge check out those links below
            synthesizer.Volume = 100;  // (0 - 100)
            synthesizer.Rate = 0;     // (-10 - 10)
                                      // Synchronous

            // Asynchronous
            synthesizer.SpeakAsync("Welcome" + uname); // here args = pran
        }
        private void sixButton_Click(object sender, EventArgs e)
        {
            if(ScreenLabel.Enabled==true)
            ScreenLabel.Text += "6";
        }

        private void starButton_Click(object sender, EventArgs e)
        {
            ScreenLabel.Enabled = true;
            ScreenLabel.Text += "*";
        }

        private void ZeroButton_Click(object sender, EventArgs e)
        {
            if (ScreenLabel.Enabled == true)
                ScreenLabel.Text += "0";
        }

        private void hashButton_Click(object sender, EventArgs e)
        {
            if (ScreenLabel.Enabled == true)
            {
                ScreenLabel.Text += "#";
                ScreenLabel.Enabled = false;
                authenticate();
            }
               
        }

        private void oneButton_Click(object sender, EventArgs e)
        {
            if (ScreenLabel.Enabled == true)
                ScreenLabel.Text += "1";
        }

        private void twoButton_Click(object sender, EventArgs e)
        {
            if (ScreenLabel.Enabled == true)
                ScreenLabel.Text += "2";
        }

        private void threeButton_Click(object sender, EventArgs e)
        {
            if (ScreenLabel.Enabled == true)
                ScreenLabel.Text += "3";
        }

        private void fourButton_Click(object sender, EventArgs e)
        {
            if (ScreenLabel.Enabled == true)
                ScreenLabel.Text += "4";
        }

        private void fiveButton_Click(object sender, EventArgs e)
        {
            if (ScreenLabel.Enabled == true)
                ScreenLabel.Text += "5";
        }

        private void sevenButton_Click(object sender, EventArgs e)
        {
            if (ScreenLabel.Enabled == true)
                ScreenLabel.Text += "7";
        }

        private void eightButton_Click(object sender, EventArgs e)
        {
            if (ScreenLabel.Enabled == true)
                ScreenLabel.Text += "8";
        }

        private void nineButton_Click(object sender, EventArgs e)
        {
            if (ScreenLabel.Enabled == true)
                ScreenLabel.Text += "9";
        }

        private void button1_Click(object sender, EventArgs e)
        {

            loginForm form = new loginForm();
            form.InvalidAttempt = threeTimesfalse;
            form.Show();
            this.Hide();

            if (cam.IsRunning)
            {
                cam.Stop();
            }
        }

        private void ClearAllButton_Click(object sender, EventArgs e)
        {
            if (ScreenLabel.Enabled == true)
            {
                ScreenLabel.Text = "";
                
            }
            else
            {
                ScreenLabel.Enabled = true;
                ScreenLabel.Text = "";
                ScreenLabel.Enabled = false;
            }
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            try
            {
                ScreenLabel.Text = ScreenLabel.Text.Substring(0, ScreenLabel.Text.Length - 1);
            }

            catch (Exception ex)
            {
                string lineNumber = ex.StackTrace.Substring(ex.StackTrace.Length - 7, 7);
               // MessageBox.Show(ex.Message + "\n" + lineNumber, "Exception", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

        }

        private void DoorForm_updated_KeyDown(object sender, KeyEventArgs e)
        {
            //one
            if (e.KeyCode.Equals(Keys.NumPad1))
            {
                
                oneButton.PerformClick();
            }

            //two
            if (e.KeyCode.Equals(Keys.NumPad2))
            {
                
                twoButton.PerformClick();
            }

            if (e.KeyCode.Equals(Keys.NumPad3))
            {
                
                threeButton.PerformClick();
            }

            if (e.KeyCode.Equals(Keys.NumPad4))
            {
                
                fourButton.PerformClick();
            }

            if (e.KeyCode.Equals(Keys.NumPad5))
            {
               
                fiveButton.PerformClick();
            }

            if (e.KeyCode.Equals(Keys.NumPad6))
            {
               
                sixButton.PerformClick();
            }

            if (e.KeyCode.Equals(Keys.NumPad7))
            {
               
                sevenButton.PerformClick();
            }

            if (e.KeyCode.Equals(Keys.NumPad8))
            {
               
                eightButton.PerformClick();
            }

            if (e.KeyCode.Equals(Keys.NumPad9))
            {
               
                nineButton.PerformClick();
            }

            if (e.KeyCode.Equals(Keys.NumPad0))
            {
               
                ZeroButton.PerformClick();
            }

            if (e.KeyCode.Equals(Keys.Multiply))
            {
                ScreenLabel.Enabled = true;
                starButton.PerformClick();
            }

            if(e.KeyCode.Equals(Keys.Back))
            {
                DeleteButton.PerformClick();
            }
            if(e.KeyCode.Equals(Keys.Delete))
            {
                ClearAllButton.PerformClick();
            }

            
        }

        private void DoorForm_updated_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '#')
            {
                hashButton.PerformClick();

            }
        }

        private void AuthenticateBtn_Click(object sender, EventArgs e)
        {
            
        }

        bool threeTimesfalse = false;
        private void authenticate()
        {
            try
            {
                string LoadConnString = ConfigurationManager.ConnectionStrings["DigiDoorConnString"].ConnectionString;
                SqlConnection LoadConn = new SqlConnection(LoadConnString);
                SqlCommand checkCurrentStatus = new SqlCommand("SELECT TOP 1 * FROM system_status_table ORDER BY Serial_Number DESC", LoadConn);
                LoadConn.Open();    //open connection to database
                SqlDataReader Checkreader = checkCurrentStatus.ExecuteReader();  //used with read
                Checkreader.Read();
                currentState = Checkreader[1].ToString();
                if (currentState == "Inactive")
                {
                    disableControls();
                    MessageBox.Show("System has been disabled and cannot be used! Please contact administrator!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                LoadConn.Close();


                TimeSpan ActivityTime;
                TimeSpan timeNow;
                string currentDate = DateTime.Now.ToString("MM-dd-yy");
                Regex rx = new Regex("^[*][0-9]{4}[#]$"); //*1234#
                //if (enteredPINTextBox.Text == string.Empty)
                //{
                //    MessageBox.Show("Enter a valid PIN to open door!");
                //}

                if (!rx.IsMatch(ScreenLabel.Text))
                {
                    MessageBox.Show("Enter PIN in the format : *wxyz#\n Where wxyz are numeric digits!","Incorrect Pattern",MessageBoxButtons.OK,MessageBoxIcon.Stop);
                    return;
                }

                if (cam.IsRunning)
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
                enteredPIN = ScreenLabel.Text;
                

                string ConnString = ConfigurationManager.ConnectionStrings["DigiDoorConnString"].ConnectionString;
                SqlConnection conn = new SqlConnection(ConnString);

                SqlDataReader reader;
                string allowedBegTime, allowedEndTime, NameOfUser,username;
                TimeSpan begTimeVal, EndTimeVal;


                conn.Open();

                SqlDataAdapter sda = new SqlDataAdapter("SELECT Count(*) FROM [dbo].[user_table] where passcode='" + enteredPIN + "'", conn);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                if (dt.Rows[0][0].ToString() == "1")
                {
                    // MessageBox.Show("Authentication Successful!");
                   myPort.WriteLine("A");

                    SqlCommand retrieveAllowedTime = new SqlCommand("select * from [dbo].[user_table] where passcode='" + enteredPIN + "'", conn);
                    // conn.Open();    //open connection to database
                    reader = retrieveAllowedTime.ExecuteReader();  //used with read
                    reader.Read();

                    NameOfUser = reader[1].ToString();
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
                    if (activeStatus)
                    {
                        SelectAdminOperation adminop = new SelectAdminOperation();
                        adminop.setActiveStatus = activeStatus.ToString();
                        adminop.setSystemStatus = "Active";


                        if (ActivityTime >= begTimeVal && ActivityTime <= EndTimeVal)
                        {

                            conn.Open();
                            MessageBox.Show("Door Open! You can now enter!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            speech(NameOfUser);

                            SqlCommand cmd = new SqlCommand("log_tableAddEntry", conn);
                            cmd.CommandType = CommandType.StoredProcedure;

                            cmd.Parameters.Add(new SqlParameter("user_name", username));
                            cmd.Parameters.Add(new SqlParameter("check_In_Time", ActivityTime));
                            cmd.Parameters.Add(new SqlParameter("captured_Image", img));
                            cmd.Parameters.Add(new SqlParameter("currentDate", currentDate));

                            cmd.ExecuteNonQuery();
                            conn.Close();

                            //MessageBox.Show("Welcome " + username, "success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            captureImagePB.Image = null;



                        }

                        else
                        {
                            MessageBox.Show("Sorry! You can only Log in between " + allowedBegTime + "-" + allowedEndTime, "Alert", MessageBoxButtons.OK, MessageBoxIcon.Stop);

                        }
                    }
                    else
                    {
                        MessageBox.Show("System Halted! Please contact administrator!", "Halted", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                        starButton.Enabled = false;
                        hashButton.Enabled = false;
                       // sendMail();
                        //SelectAdminOperation adminop = new SelectAdminOperation();
                        //adminop.setActiveStatus = activeStatus.ToString();
                        //adminop.setSystemStatus = "Inactive";
                        
                    }
                }
                else
                {
                    timeNow = DateTime.Now.TimeOfDay;
                    TimeSpan activityTime = new TimeSpan(timeNow.Hours, timeNow.Minutes, timeNow.Seconds);
                    invalidAttempts++;
                    if (invalidAttempts<3)
                    {
                         MessageBox.Show("No match found\n Invalid attempts = " + invalidAttempts, "Alert!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        Console.Beep();

                    }
                   
                    if(invalidAttempts >=3)
                    {
                        activeStatus = false;
                        systemStatus = "Inactive";
                        threeTimesfalse = true;
                        Console.Beep(2000,1500);
                        SqlCommand cmd = new SqlCommand("UpdateSystemStatus", conn);
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.Add(new SqlParameter("system_status", systemStatus));
                        cmd.Parameters.Add(new SqlParameter("act_time", activityTime));
                        cmd.Parameters.Add(new SqlParameter("act_date", currentDate));
                        cmd.ExecuteNonQuery();
                        conn.Close();
                        MessageBox.Show(invalidAttempts+" Invalid attempts"+"\n\nSystem Halted! Please contact administrator!","Halted",MessageBoxButtons.OK,MessageBoxIcon.Stop);
                        CheckOutButton.Enabled = false;
                        SelectAdminOperation adminop = new SelectAdminOperation();
                        adminop.setActiveStatus = activeStatus.ToString();
                        adminop.setSystemStatus = "Inactive";
                    }
                }

                ScreenLabel.Text = "";

            }
            catch (Exception ex)
            {
                string lineNumber = ex.StackTrace.Substring(ex.StackTrace.Length - 7, 7);
                MessageBox.Show(ex.Message + "\n" + lineNumber);
            }
        }

        private void DoorForm_updated_Load(object sender, EventArgs e)
        {
            string LoadConnString = ConfigurationManager.ConnectionStrings["DigiDoorConnString"].ConnectionString;
            SqlConnection LoadConn = new SqlConnection(LoadConnString);

            webcam = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            foreach (FilterInfo VideoCaptureDevice in webcam)
            {
                camName = VideoCaptureDevice.Name;
            }

            cam = new VideoCaptureDevice(webcam[0].MonikerString);
            cam.NewFrame += new NewFrameEventHandler(cam_NewFrame);
            cam.Start();

            init();

            //check current system status

            SqlCommand checkCurrentStatus = new SqlCommand("SELECT TOP 1 * FROM system_status_table ORDER BY Serial_Number DESC", LoadConn);
            LoadConn.Open();    //open connection to database
           SqlDataReader reader = checkCurrentStatus.ExecuteReader();  //used with read
            reader.Read();
            currentState = reader[1].ToString();
            if(currentState =="Inactive")
            {
                disableControls();
                MessageBox.Show("System has been disabled and cannot be used! Please contact administrator!","ERROR",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            LoadConn.Close();


        }

        private void disableControls()
        {
            foreach (Control c in this.Controls)
            {
                c.Enabled = false;
            }
            AdminPanelBtn.Enabled = true;
        }

        void cam_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            Bitmap bit = (Bitmap)eventArgs.Frame.Clone();
            captureImagePB.Image = bit;
        }

        private void DoorForm_updated_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                DialogResult dialog = MessageBox.Show("Do you really want to exit?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialog == DialogResult.Yes)
                {
                    
                    Application.ExitThread();
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

        private void ScreenLabel_Click(object sender, EventArgs e)
        {

        }

        private void CheckOutButton_Click(object sender, EventArgs e)
        {
            myPort.Close();
            CheckOutForm form = new CheckOutForm();
            form.Show();
            this.Hide();
        }
    }
}
