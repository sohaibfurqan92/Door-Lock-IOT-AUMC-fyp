using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DigiDoor_UPDATED
{
    public partial class AdminOperations : Form
    {
        static string ConnString = ConfigurationManager.ConnectionStrings["DigiDoorConnString"].ConnectionString;
        SqlConnection conn = new SqlConnection(ConnString);
        //SqlCommand cmd = new SqlCommand();
        //SqlDataReader dr;
        string imgloc;  //to save picture location
        byte[] img = null;
        BinaryReader br;
        FileStream fs;

       



        public AdminOperations()
        {
            InitializeComponent();
        }

        public void refreshGrid()
        {
           
            AdminOperations loadForm = new AdminOperations();
            loadForm.Show();
            this.Hide();
          
            
        }

        //void FillDataGridView()
        //{
        //    digiDoorDataSet.Clear();
        //    SqlCommand refreshCmd = new SqlCommand("UserTable_SelectRecords", conn);
        //    refreshCmd.CommandType = CommandType.StoredProcedure;

        //    SqlDataAdapter DA = new SqlDataAdapter(refreshCmd);
        //    DA.Fill(digiDoorDataSet);
        //    this.userInfoGrid.DataSource = digiDoorDataSet;
        //}
        private void uploadImgButton_Click(object sender, EventArgs e)
        {
            try
            {
               
                
                   
                    //checkbox is checked
                    OpenFileDialog dlg = new OpenFileDialog();
                    dlg.Filter = "JPG Files (.jpg)|*.jpg|GIF Files (*.gif)|*.gif|All Files(*.*)|*.*)";
                    dlg.Title = "Select Picture";
                     if(dlg.ShowDialog() == DialogResult.OK)
                     {
                        imgloc = dlg.FileName.ToString();
                        userImagePB.ImageLocation = imgloc;
                     }
                  
                }
            catch(Exception ex)
            {
                string lineNumber = ex.StackTrace.Substring(ex.StackTrace.Length - 7, 7);
                MessageBox.Show(ex.Message + "\n" + lineNumber);
            }
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            try
            {
                string username, userPIN, NameOfUser, emailAddress, category = null;
                Regex rx = new Regex("^[*][0-9]{4}[#]$"); //*1234#
                Regex emailRegex = new Regex(@"^([a-zA-Z0-9_\-\.]+)@((\[[0-9]{1,3}" +
         @"\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([a-zA-Z0-9\-]+\" +
         @".)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$");

                if (!rx.IsMatch(PINTextBox.Text))
                {
                    MessageBox.Show("Enter PIN in the format : *wxyz#\n Where wxyz are numeric digits!","Incorrect Pattern",MessageBoxButtons.OK,MessageBoxIcon.Stop);
                }

              
                    if (!emailRegex.IsMatch(emailTextBox.Text) && emailTextBox.Text!="")
                    {
                        MessageBox.Show("Entered email is not valid.\nInput format:abc123@xyz.com");
                    }
                

                else
                {
                    if(NameTextBox.Text==string.Empty)
                    {
                        errorProvider1.SetError(NameTextBox,"Please enter a name for the user!");
                    }

                    if (usernameTextBox.Text == string.Empty)
                    {
                        errorProvider1.SetError(NameTextBox, "Please enter a unique username for the user!");
                    }

                    if (PINTextBox.Text == string.Empty)
                    {
                        errorProvider1.SetError(NameTextBox, "Please enter a PIN for the user\n Format: *wxyz#\nWhere WXYZ are numeric digits!");
                    }
                    if (UserCategoryComboBox.SelectedIndex == -1)
                    {
                        errorProvider1.SetError(NameTextBox, "Please Select a category for the user!");
                    }
                    if(BeginTimePicker.Text.Equals(EndTimePicker.Text))
                    {
                        MessageBox.Show("Begin and end times cannot be the same.\n\n\n Please specify different begin and end times","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                        return;
                    }
                    NameOfUser = NameTextBox.Text;
                    username = usernameTextBox.Text;
                    userPIN = PINTextBox.Text;
                    if (UserCategoryComboBox.SelectedIndex == 0)  //Admin selected
                    {
                        category = "Admin";
                    }

                    if (UserCategoryComboBox.SelectedIndex == 1)   //Family Members selected
                    {
                        category = "Family Members";
                    }

                    if (UserCategoryComboBox.SelectedIndex == 2)    //workers selected
                    {
                        category = "Workers";
                    }

                    if (userImagePB.Image != null)
                    {
                        MemoryStream ms = new MemoryStream();
                        userImagePB.Image.Save(ms, userImagePB.Image.RawFormat);
                        img = ms.GetBuffer();
                        ms.Close();
                    }

                    SqlConnection SCon = new SqlConnection(ConnString);
                    
                    SqlCommand cmd = new SqlCommand("User_TableAddRecord", SCon);
                    cmd.CommandType = CommandType.StoredProcedure;

                    SCon.Open();    //open connection to database
                                    
                    cmd.Parameters.Add(new SqlParameter("@NameOfUser", NameOfUser));
                    cmd.Parameters.Add(new SqlParameter("@UserName", username));
                    cmd.Parameters.Add(new SqlParameter("@Pin", userPIN));
                    cmd.Parameters.Add(new SqlParameter("@Category", category));
                    cmd.Parameters.Add(new SqlParameter("@beginTime", BeginTimePicker.Text));
                    cmd.Parameters.Add(new SqlParameter("@endTime", EndTimePicker.Text));
                    //cmd.Parameters.AddWithValue("@img",img);
                    cmd.Parameters.Add(new SqlParameter("@img", img));
                    cmd.Parameters.Add(new SqlParameter("@emailAddr", emailTextBox.Text));
                    cmd.ExecuteNonQuery();  //used with insert, update, delete
                    userImagePB.Image = null;
                    MessageBox.Show("Record Entered Successfully!","Success",MessageBoxButtons.OK,MessageBoxIcon.Information);

                    SCon.Close();
                    userInfoGrid.DataSource = usertableBindingSource1;
                    userInfoGrid.Refresh();
                    userInfoGrid.Update();
                    refreshGrid();

                  

                   
                }
            }
            catch (Exception ex)
            {
               
                string lineNumber = ex.StackTrace.Substring(ex.StackTrace.Length - 7, 7);
                MessageBox.Show(ex.Message + "\n" + lineNumber, "Success", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void ClearBtn_Click(object sender, EventArgs e)
        {
            NameTextBox.Text = "";
            usernameTextBox.Text = "";
            PINTextBox.Text = "";
            UserCategoryComboBox.Text = "Select an option";
            BeginTimePicker.Text = "";
            EndTimePicker.Text = "";
            emailTextBox.Text = "";
            NameTextBox.Focus();

        }

        private void ManageLogBtn_Click(object sender, EventArgs e)
        {
            LogForm logform = new LogForm();
            logform.Show();
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

        private void userInfoGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void NameTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(char.IsLetter(e.KeyChar)||char.IsWhiteSpace(e.KeyChar))
            {

            }
            else
            {
                e.Handled = e.KeyChar != (char)Keys.Back;
            }
        }

        private void usernameTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar))
            {

            }
            else
            {
                e.Handled = e.KeyChar != (char)Keys.Back;
            }
        }

        private void PINTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar) || e.KeyChar == '*' || e.KeyChar == '#')
            {

            }
            else
            {
                e.Handled = e.KeyChar != (char)Keys.Back;
            }
        }
        DataTable dt = new DataTable();
        private void AdminOperations_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'userinfoGridBindingSource.user_table' table. You can move, or remove it, as needed.
            this.user_tableTableAdapter2.Fill(this.userinfoGridBindingSource.user_table);
            // TODO: This line of code loads data into the 'usertableDataset.user_table' table. You can move, or remove it, as needed.
            this.user_tableTableAdapter1.Fill(this.usertableDataset.user_table);
            // TODO: This line of code loads data into the 'digiDoorDataSet.user_table' table. You can move, or remove it, as needed.
            this.user_tableTableAdapter.Fill(this.digiDoorDataSet.user_table);
            dt = this.digiDoorDataSet.user_table;
            
           
        }

        private void userInfoGrid_MouseClick(object sender, MouseEventArgs e)
        {
            
            NameTextBox.Text = userInfoGrid.SelectedRows[0].Cells[1].Value.ToString();
            usernameTextBox.Text = userInfoGrid.SelectedRows[0].Cells[2].Value.ToString();
            PINTextBox.Text = userInfoGrid.SelectedRows[0].Cells[3].Value.ToString();
            UserCategoryComboBox.Text = userInfoGrid.SelectedRows[0].Cells[4].Value.ToString();
           BeginTimePicker.Text = userInfoGrid.SelectedRows[0].Cells[5].Value.ToString();
            EndTimePicker.Text = userInfoGrid.SelectedRows[0].Cells[6].Value.ToString();
            //userImagePB.Image= (Image)userInfoGrid.SelectedRows[0].Cells[7].Value;
            //MemoryStream MS = new MemoryStream();
            emailTextBox.Text = userInfoGrid.SelectedRows[0].Cells[9].Value.ToString();

            byte[] Img = (byte[])dt.Rows[userInfoGrid.SelectedRows[0].Index]["user_image"];
            MemoryStream MSS = new MemoryStream(Img);
           // Img = (byte[])dt.Rows[0]["user_image"];
            userImagePB.Image = Image.FromStream(MSS);
            SaveBtn.Visible = false;
            ClearBtn.Visible = false;
            updateRecordBtn.Visible = true;
            deleteRecordBtn.Visible = true;
            BackToAddModeBtn.Visible = true;

            //change username textbox to read only (can't be changed)
            usernameTextBox.ReadOnly=true;



        }

        private void BackToAddModeBtn_Click(object sender, EventArgs e)
        {
            SaveBtn.Visible = true;
            ClearBtn.Visible = true;
            updateRecordBtn.Visible = false;
            deleteRecordBtn.Visible = false;
            BackToAddModeBtn.Visible = false;

            //clear all fields
            NameTextBox.Text = "";
            usernameTextBox.Text = "";
            PINTextBox.Text = "";
            UserCategoryComboBox.SelectedIndex = -1;
            BeginTimePicker.Text = "";
            EndTimePicker.Text = "";
            emailTextBox.Text = "";
            NameTextBox.Focus();
        }

        private void updateRecordBtn_Click(object sender, EventArgs e)
        {
            try
            {
                string username, userPIN, NameOfUser, category = null;
                Regex rx = new Regex("^[*][0-9]{4}[#]$"); //*1234#

                Regex emailRegex = new Regex(@"^([a-zA-Z0-9_\-\.]+)@((\[[0-9]{1,3}" +
         @"\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([a-zA-Z0-9\-]+\" +
         @".)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$");

                if (!rx.IsMatch(PINTextBox.Text))
                {
                    MessageBox.Show("Enter PIN in the format : *wxyz#\n Where wxyz are numeric digits!", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
              
                    if (!emailRegex.IsMatch(emailTextBox.Text) &&emailTextBox.Text!="")
                    {
                        MessageBox.Show("Entered email is not valid.\nInput format:abc123@xyz.com");
                    }

                
                
                else
                {
                    if (NameTextBox.Text == string.Empty)
                    {
                        errorProvider1.SetError(NameTextBox, "Please enter a name for the user!");
                    }

                    if (usernameTextBox.Text == string.Empty)
                    {
                        errorProvider1.SetError(NameTextBox, "Please enter a unique username for the user!");
                    }

                    if (PINTextBox.Text == string.Empty)
                    {
                        errorProvider1.SetError(NameTextBox, "Please enter a PIN for the user\n Format: *wxyz#\nWhere WXYZ are numeric digits!");
                    }
                    if (UserCategoryComboBox.SelectedIndex == -1)
                    {
                        errorProvider1.SetError(NameTextBox, "Please Select a category for the user!");
                    }

                    if (BeginTimePicker.Text.Equals(EndTimePicker.Text))
                    {
                        MessageBox.Show("Begin and end times cannot be the same.\n\n\n Please specify different begin and end times", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    NameOfUser = NameTextBox.Text;
                    username = usernameTextBox.Text;
                    userPIN = PINTextBox.Text;
                    if (UserCategoryComboBox.SelectedIndex == 0)  //Admin selected
                    {
                        category = "Admin";
                    }

                    if (UserCategoryComboBox.SelectedIndex == 1)   //Family Members selected
                    {
                        category = "Family Members";
                    }

                    if (UserCategoryComboBox.SelectedIndex == 2)    //workers selected
                    {
                        category = "Workers";
                    }

                    if (userImagePB.Image != null)
                    {

                        fs = new FileStream(imgloc, FileMode.Open, FileAccess.Read);
                        br = new BinaryReader(fs);
                        img = br.ReadBytes((int)fs.Length);
                    }
                    // string nullstr = null;
                    SqlConnection SCon = new SqlConnection(ConnString);

                    SqlCommand cmd = new SqlCommand("user_tableUpdateRecord", SCon);
                    cmd.CommandType = CommandType.StoredProcedure;

                    SCon.Open();    //open connection to database

                    cmd.Parameters.Add(new SqlParameter("@NameOfUser", NameOfUser));
                    cmd.Parameters.Add(new SqlParameter("@UserName", username));
                    cmd.Parameters.Add(new SqlParameter("@Pin", userPIN));
                    cmd.Parameters.Add(new SqlParameter("@Category", category));
                    cmd.Parameters.Add(new SqlParameter("@beginTime", BeginTimePicker.Text));
                    cmd.Parameters.Add(new SqlParameter("@endTime", EndTimePicker.Text));
                    cmd.Parameters.Add(new SqlParameter("@img", img));
                    cmd.Parameters.Add(new SqlParameter("@emailAddr",emailTextBox.Text));
                    cmd.ExecuteNonQuery();  //used with insert, update, delete
                    userImagePB.Image = null;
                    MessageBox.Show("Record updated Successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    SCon.Close();

                    userInfoGrid.DataSource = usertableBindingSource1;
                    userInfoGrid.Refresh();
                    userInfoGrid.Update();
                    refreshGrid();
                }
            }

            catch (Exception ex)
            {
                string lineNumber = ex.StackTrace.Substring(ex.StackTrace.Length - 7, 7);
                MessageBox.Show(ex.Message + "\n" + lineNumber, "Exception", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void deleteRecordBtn_Click(object sender, EventArgs e)
        {
           try
            {
                string username = usernameTextBox.Text;
                string userPIN = "0000";

                SqlConnection SCon = new SqlConnection(ConnString);

                SqlCommand cmd = new SqlCommand("user_tableDeleteRecord", SCon);
                cmd.CommandType = CommandType.StoredProcedure;

                SCon.Open();    //open connection to database

                cmd.Parameters.Add(new SqlParameter("@UserName", username));
                cmd.Parameters.Add(new SqlParameter("@Pin", userPIN));

                cmd.ExecuteNonQuery();
                SCon.Close();

                MessageBox.Show("Record Deleted!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                userInfoGrid.DataSource = usertableBindingSource1;
                userInfoGrid.Refresh();
                userInfoGrid.Update();
                refreshGrid();
            }

            catch(Exception ex)
            {
                string lineNumber = ex.StackTrace.Substring(ex.StackTrace.Length - 7, 7);
                MessageBox.Show(ex.Message + "\n" + lineNumber, "Exception", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            SelectAdminOperation op = new SelectAdminOperation();
            op.Show();
            this.Hide();
        }

        private void AdminOperations_FormClosing(object sender, FormClosingEventArgs e)
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

        private void UserCategoryComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(UserCategoryComboBox.SelectedIndex==0)
            {
                emailTextBox.Enabled = true;
            }
            else if(UserCategoryComboBox.SelectedIndex==1)
            {
                emailTextBox.Enabled = false;
            }
            else
            {
                emailTextBox.Enabled = false;
            }
        }
    }
}
