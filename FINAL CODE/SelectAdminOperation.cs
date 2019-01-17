using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DigiDoor_UPDATED
{
    public partial class SelectAdminOperation : Form
    {
        public int invalidAttempts = 0;
        public bool activeStatus = true;
        string systemStatus = "active";

        TimeSpan ActivityTime;
        TimeSpan timeNow;

        string ConnString = ConfigurationManager.ConnectionStrings["DigiDoorConnString"].ConnectionString;
       

        public SelectAdminOperation()
        {
            InitializeComponent();
        }

        public string setActiveStatus { get; set; }
        public string setSystemStatus { get; set; }

        private void ManageUsersBtn_Click(object sender, EventArgs e)
        {
            AdminOperations op = new AdminOperations();
            op.Show();
            this.Hide();
        }

         

        private void ViewReportsBtn_Click(object sender, EventArgs e)
        {
            // RPTViewerForm form = new RPTViewerForm();
            // form.Show();
            // this.Hide();

            SelectReportForm form = new SelectReportForm();
            form.Show();
            this.Hide();
        }

        private void LogOutBtn_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Do you really want to log out?", "Log Out", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialog == DialogResult.Yes)
            {
                try
                {
                    loginForm form = new loginForm();
                    form.Show();
                    this.Hide();
                }

                catch (Exception ex)
                {
                    string lineNumber = ex.StackTrace.Substring(ex.StackTrace.Length - 7, 7);
                    MessageBox.Show(ex.Message + "\n" + lineNumber, "Exception", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }

        }

        private void SelectAdminOperation_FormClosing(object sender, FormClosingEventArgs e)
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

        private void ActivateSystemButton_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection conn = new SqlConnection(ConnString);
                setActiveStatus = "true";
                setSystemStatus = "active";
                activeStatus = false;
                systemStatus = "Active";
              //  threeTimesfalse = true;
                string currentDate = DateTime.Now.ToString("MM-dd-yy");

                timeNow = DateTime.Now.TimeOfDay;
                ActivityTime = new TimeSpan(timeNow.Hours, timeNow.Minutes, timeNow.Seconds);
                conn.Open();
                using (conn)
                {
                    SqlCommand cmd = new SqlCommand("UpdateSystemStatus", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("system_status", systemStatus));
                    cmd.Parameters.Add(new SqlParameter("act_time", ActivityTime));
                    cmd.Parameters.Add(new SqlParameter("act_date", currentDate));
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    MessageBox.Show("System activated!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                    // Console.Beep(2000, 1500);
                 
            }
            
            catch(Exception ex)
            {
                string lineNumber = ex.StackTrace.Substring(ex.StackTrace.Length - 7, 7);
                MessageBox.Show(ex.Message + "\n" + lineNumber, "Exception", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        public bool ShowEnableButton { get; set; }

        private void SelectAdminOperation_Load(object sender, EventArgs e)
        {
            //CheckInFom adminop = new CheckInFom();
            if (ShowEnableButton==true)
            {
                ActivateSystemButton.Visible = true;
            }
            string LoadConnString = ConfigurationManager.ConnectionStrings["DigiDoorConnString"].ConnectionString;
            SqlConnection LoadConn = new SqlConnection(LoadConnString);
            SqlCommand checkCurrentStatus = new SqlCommand("SELECT TOP 1 * FROM system_status_table ORDER BY Serial_Number DESC", LoadConn);
            LoadConn.Open();    //open connection to database
            SqlDataReader reader = checkCurrentStatus.ExecuteReader();  //used with read
            reader.Read();
         string   currentState = reader[1].ToString();
            if (currentState == "Inactive")
            {
                ActivateSystemButton.Enabled = true;
                ActivateSystemButton.Visible = true;
            }
            LoadConn.Close();
        }
    }
}
