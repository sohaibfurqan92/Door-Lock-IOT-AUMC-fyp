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
    public partial class LogForm : Form
    {
        public LogForm()
        {
            InitializeComponent();
        }

        static string ConnString = ConfigurationManager.ConnectionStrings["DigiDoorConnString"].ConnectionString;

        private void backBtn_Click(object sender, EventArgs e)
        {
            AdminOperations form = new AdminOperations();
            form.Show();
            this.Hide();
        }

        public void refreshGrid()
        {

            LogForm loadForm = new LogForm();
            loadForm.Show();
            this.Hide();


        }


        private void LogForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'logTableDataSet.log_table' table. You can move, or remove it, as needed.
            this.log_tableTableAdapter.Fill(this.logTableDataSet.log_table);

        }

        private void ClearLogBtn_Click(object sender, EventArgs e)
        {
         DialogResult dialog =   MessageBox.Show("This will clear the Log. The operation can not be undone\n\nDo you want to proceed?","Clear Log" ,MessageBoxButtons.YesNo ,MessageBoxIcon.Question);
            if(dialog == DialogResult.Yes)
            {
                try
                {
                    SqlConnection SCon = new SqlConnection(ConnString);
                    SqlCommand cmd = new SqlCommand("log_tableClearEntries", SCon);
                    cmd.CommandType = CommandType.StoredProcedure;
                    SCon.Open();
                    cmd.ExecuteNonQuery();
                    SCon.Close();
                    MessageBox.Show("Log Cleared!","Success",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    refreshGrid();
                }

                catch (Exception ex)
                {
                    string lineNumber = ex.StackTrace.Substring(ex.StackTrace.Length - 7, 7);
                    MessageBox.Show(ex.Message + "\n" + lineNumber, "Exception", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
           
            
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

        private void LogForm_FormClosing(object sender, FormClosingEventArgs e)
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
