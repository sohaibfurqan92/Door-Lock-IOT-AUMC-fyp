using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Speech.Synthesis;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DigiDoor_UPDATED
{
    public partial class CheckOutForm : Form
    {
        private SerialPort myPort;
        private string enteredPIN;

        public CheckOutForm()
        {
            InitializeComponent();
        }

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
            synthesizer.SpeakAsync("GoodBye" + uname); // here args = pran
        }

        private void disableControls()
        {
            foreach (Control c in this.Controls)
            {
                c.Enabled = false;
            }
            AdminPanelBtn.Enabled = true;
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

        private void sixButton_Click(object sender, EventArgs e)
        {
            if (ScreenLabel.Enabled == true)
                ScreenLabel.Text += "6";
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

        private void AdminPanelBtn_Click(object sender, EventArgs e)
        {
            loginForm form = new loginForm();
            form.Show();
            this.Hide();
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

        private void DeleteButton_KeyDown(object sender, KeyEventArgs e)
        {
            
        }

        private void CheckOutForm_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '#')
            {
                hashButton.PerformClick();

            }
        }

        private void authenticate()
        {
            try
            {
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
                    MessageBox.Show("Enter PIN in the format : *wxyz#\n Where wxyz are numeric digits!", "Incorrect Pattern", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    return;
                }




                enteredPIN = ScreenLabel.Text;
                

                string ConnString = ConfigurationManager.ConnectionStrings["DigiDoorConnString"].ConnectionString;
                SqlConnection conn = new SqlConnection(ConnString);

                SqlDataReader reader;
                string allowedBegTime, allowedEndTime, NameOfUser, username;
                

                conn.Open();

                SqlDataAdapter sda = new SqlDataAdapter("SELECT Count(*) FROM [dbo].[user_table] where passcode='" + enteredPIN + "'", conn);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                if (dt.Rows[0][0].ToString() == "1")
                {
                    // MessageBox.Show("Authentication Successful!");
                   myPort.WriteLine("A");

                    SqlCommand retrievePIN = new SqlCommand("select * from [dbo].[user_table] where passcode='" + enteredPIN + "'", conn);
                        
                    reader = retrievePIN.ExecuteReader();  //used with read
                    reader.Read();

                    NameOfUser = reader[1].ToString();
                    username = reader[2].ToString();
                    timeNow = DateTime.Now.TimeOfDay;
                    ActivityTime = new TimeSpan(timeNow.Hours, timeNow.Minutes, timeNow.Seconds);
                    //allowedBegTime = reader[5].ToString();
                    //allowedEndTime = reader[6].ToString();
                    reader.Close();

                    SqlCommand command = new SqlCommand("InsertCheckOut", conn);
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.Add(new SqlParameter("user_name", username));
                    command.Parameters.Add(new SqlParameter("checkOutTime", ActivityTime));

                    command.Parameters.Add(new SqlParameter("checkOutDate", currentDate));
                    

                    command.ExecuteNonQuery();
                    conn.Close();
                   // MessageBox.Show("Goodbye!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    speech(NameOfUser);
                }
                else
                {
                    MessageBox.Show("You need to check-in first!", "Alert!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }

                ScreenLabel.Text = "";

            }
            catch (Exception ex)
            {
                string lineNumber = ex.StackTrace.Substring(ex.StackTrace.Length - 7, 7);
                MessageBox.Show(ex.Message + "\n" + lineNumber);
            }
        }

        private void CheckOutForm_KeyDown(object sender, KeyEventArgs e)
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

            if (e.KeyCode.Equals(Keys.Back))
            {
                DeleteButton.PerformClick();
            }
            if (e.KeyCode.Equals(Keys.Delete))
            {
                ClearAllButton.PerformClick();
            }
        }

        private void CheckOutForm_FormClosing(object sender, FormClosingEventArgs e)
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

        private void CheckOutButton_Click(object sender, EventArgs e)
        {
            myPort.Close();
            CheckInFom form = new CheckInFom();
            form.Show();
            this.Hide();
        }

        private void CheckOutForm_Load(object sender, EventArgs e)
        {
            string LoadConnString = ConfigurationManager.ConnectionStrings["DigiDoorConnString"].ConnectionString;
            SqlConnection LoadConn = new SqlConnection(LoadConnString);
            init();

            //check current system status

            SqlCommand checkCurrentStatus = new SqlCommand("SELECT TOP 1 * FROM system_status_table ORDER BY Serial_Number DESC", LoadConn);
            LoadConn.Open();    //open connection to database
            SqlDataReader reader = checkCurrentStatus.ExecuteReader();  //used with read
            reader.Read();
           string currentState = reader[1].ToString();
            if (currentState == "Inactive")
            {
                disableControls();
                MessageBox.Show("System has been disabled and cannot be used! Please contact administrator!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            LoadConn.Close();
        }
    }
    
}
