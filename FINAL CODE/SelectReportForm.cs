using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CrystalDecisions.CrystalReports.Engine;
using System.Data.SqlClient;
using System.Configuration;

namespace DigiDoor_UPDATED
{
    public partial class SelectReportForm : Form
    {
        ReportDocument cryrpt = new ReportDocument();
        string ConnString = ConfigurationManager.ConnectionStrings["DigiDoorConnString"].ConnectionString;

        public SelectReportForm()
        {
            InitializeComponent();
        }

        public enum ReportType
        {
            LogReport = 1,
            AdminLoginReport = 2 
        }

        private void chooseReportToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void loginInformationReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        

        private void exitToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void closeFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cryrpt.Dispose();
            cryrpt.Close();
        }

        private void checkInReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cryrpt.Load(@"C:\Users\sohai\Documents\Visual Studio 2015\Projects\DigiDoor-UPDATED - Copy\CheckInReport.rpt");
            CRYRPTViewer.ReportSource = cryrpt;
            this.CRYRPTViewer.RefreshReport();
        }

        private void printToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void printPreviewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.Document = printReportDocument;
            printPreviewDialog1.ShowDialog();
        }

        private void printReportDocument_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            
        }

        private void adminLoginReportToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            cryrpt.Load(@"C:\Users\sohai\Documents\Visual Studio 2015\Projects\DigiDoor-UPDATED - Copy\AdminLoginReport.rpt");
            CRYRPTViewer.ReportSource = cryrpt;
            
            
            this.CRYRPTViewer.RefreshReport();
        }

        private void reportByNameToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            
            // string ReportType = null;
            
        }

        private void SelectReportForm_FormClosing(object sender, FormClosingEventArgs e)
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

        private void aboutToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Developed by Sohaib Furqan as Final Year Project\nfor Air University Multan Campus (AUMC)\n\nCredits: Dr.M.Sanaullah\n\n\n© 2016","About",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            SelectAdminOperation form = new SelectAdminOperation();
            form.Show();
            this.Hide();
        }

        private void userDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cryrpt.Load(@"C:\Users\sohai\Documents\Visual Studio 2015\Projects\DigiDoor-UPDATED - Copy\UserDetailsReport.rpt");
            CRYRPTViewer.ReportSource = cryrpt;
            this.CRYRPTViewer.RefreshReport();
        }

        private void systemStatusReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cryrpt.Load(@"C:\Users\sohai\Documents\Visual Studio 2015\Projects\DigiDoor-UPDATED - Copy\SystemStatusReport.rpt");
            CRYRPTViewer.ReportSource = cryrpt;
            this.CRYRPTViewer.RefreshReport();
        }
    }
}
