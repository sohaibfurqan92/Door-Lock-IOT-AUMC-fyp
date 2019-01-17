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
using System.Configuration;

namespace DigiDoor_UPDATED
{
    public partial class loginForm : Form
    {
        //auto complete username
        AutoCompleteStringCollection autoComplete = new AutoCompleteStringCollection();

        public loginForm()
        {
            InitializeComponent();
        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            CheckInFom form = new CheckInFom();
            form.Show();
            this.Hide();
        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            EnteredUnameTextBox.Text = "";
            EnteredPINTextBox.Text = "";
        }

        private void LoginBtn_Click(object sender, EventArgs e)
        {
            try
            {
                string enteredUName, enteredPIN;

                enteredUName = EnteredUnameTextBox.Text;
                enteredPIN = EnteredPINTextBox.Text;

                if (EnteredUnameTextBox.Text == string.Empty)
                {
                    errorProvider1.SetError(EnteredUnameTextBox, "Enter username!");
                }
                if (EnteredPINTextBox.Text == string.Empty)
                {
                    errorProvider1.SetError(EnteredPINTextBox, "Enter a valid PIN");
                }

                string ConnString = ConfigurationManager.ConnectionStrings["DigiDoorConnString"].ConnectionString;
                SqlConnection conn = new SqlConnection(ConnString);

                SqlDataAdapter sda = new SqlDataAdapter("SELECT Count(*) FROM [dbo].[user_table] where user_name ='" + enteredUName + "' AND passcode='" + enteredPIN + "' AND category ='"+"Admin"+"' ", conn);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                if (dt.Rows[0][0].ToString() == "1")
                {
                    TimeSpan    timeNow = DateTime.Now.TimeOfDay;
                    TimeSpan LoginTime = new TimeSpan(timeNow.Hours, timeNow.Minutes, timeNow.Seconds);
                    string currentDate = DateTime.Now.ToString("MM-dd-yy");

                    if (conn.State != ConnectionState.Open)
                    {
                        conn.Open();
                    }

                    
                    SqlCommand cmd = new SqlCommand("AdminLoginTable_AddEntry", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("user_name",enteredUName));
                    cmd.Parameters.Add(new SqlParameter("login_time", LoginTime));
                    cmd.Parameters.Add(new SqlParameter("@login_date",currentDate));
                    

                    cmd.ExecuteNonQuery();
                    conn.Close();

                    //MessageBox.Show("Login successful!");
                    SelectAdminOperation from = new SelectAdminOperation();
                    from.ShowEnableButton = InvalidAttempt;
                    from.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Login Failed.Please try again","Alert!",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
                }

                autoComplete.Add(EnteredUnameTextBox.Text);
            }
            catch (Exception ex)
            {
                string lineNumber = ex.StackTrace.Substring(ex.StackTrace.Length - 7, 7);
                MessageBox.Show(ex.Message + "\n" + lineNumber ,"Exception!",MessageBoxButtons.OK,MessageBoxIcon.Stop);
            }
        }

        public bool InvalidAttempt { get; set; }

        private void loginForm_Load(object sender, EventArgs e)
        {
            EnteredUnameTextBox.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            EnteredUnameTextBox.AutoCompleteSource = AutoCompleteSource.CustomSource;
            EnteredUnameTextBox.AutoCompleteCustomSource = autoComplete;
        }

        private void loginForm_FormClosing(object sender, FormClosingEventArgs e)
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
    }
}
