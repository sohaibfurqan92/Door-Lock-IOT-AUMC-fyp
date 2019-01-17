namespace DigiDoor_UPDATED
{
    partial class SelectReportForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SelectReportForm));
            this.ReportMenuStrip = new System.Windows.Forms.MenuStrip();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.checkInReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adminLoginReportToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripSeparator();
            this.userDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.systemStatusReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.CRYRPTViewer = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.printReportDocument = new System.Drawing.Printing.PrintDocument();
            this.backButton = new System.Windows.Forms.Button();
            this.ReportMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // ReportMenuStrip
            // 
            this.ReportMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.optionsToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.ReportMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.ReportMenuStrip.Name = "ReportMenuStrip";
            this.ReportMenuStrip.Size = new System.Drawing.Size(976, 24);
            this.ReportMenuStrip.TabIndex = 0;
            this.ReportMenuStrip.Text = "menuStrip1";
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem,
            this.closeFileToolStripMenuItem,
            this.toolStripMenuItem2,
            this.exitToolStripMenuItem1});
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.optionsToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.checkInReportToolStripMenuItem,
            this.adminLoginReportToolStripMenuItem1,
            this.toolStripMenuItem3,
            this.userDetailsToolStripMenuItem,
            this.systemStatusReportToolStripMenuItem});
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.exitToolStripMenuItem.Text = "Generate Report";
            // 
            // checkInReportToolStripMenuItem
            // 
            this.checkInReportToolStripMenuItem.Name = "checkInReportToolStripMenuItem";
            this.checkInReportToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.checkInReportToolStripMenuItem.Text = "Check-In Report";
            this.checkInReportToolStripMenuItem.Click += new System.EventHandler(this.checkInReportToolStripMenuItem_Click);
            // 
            // adminLoginReportToolStripMenuItem1
            // 
            this.adminLoginReportToolStripMenuItem1.Name = "adminLoginReportToolStripMenuItem1";
            this.adminLoginReportToolStripMenuItem1.Size = new System.Drawing.Size(181, 22);
            this.adminLoginReportToolStripMenuItem1.Text = "Admin Login Report";
            this.adminLoginReportToolStripMenuItem1.Click += new System.EventHandler(this.adminLoginReportToolStripMenuItem1_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(178, 6);
            // 
            // userDetailsToolStripMenuItem
            // 
            this.userDetailsToolStripMenuItem.Name = "userDetailsToolStripMenuItem";
            this.userDetailsToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.userDetailsToolStripMenuItem.Text = "User Details";
            this.userDetailsToolStripMenuItem.Click += new System.EventHandler(this.userDetailsToolStripMenuItem_Click);
            // 
            // systemStatusReportToolStripMenuItem
            // 
            this.systemStatusReportToolStripMenuItem.Name = "systemStatusReportToolStripMenuItem";
            this.systemStatusReportToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.systemStatusReportToolStripMenuItem.Text = "System status report";
            this.systemStatusReportToolStripMenuItem.Click += new System.EventHandler(this.systemStatusReportToolStripMenuItem_Click);
            // 
            // closeFileToolStripMenuItem
            // 
            this.closeFileToolStripMenuItem.Name = "closeFileToolStripMenuItem";
            this.closeFileToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.closeFileToolStripMenuItem.Text = "Close File";
            this.closeFileToolStripMenuItem.Click += new System.EventHandler(this.closeFileToolStripMenuItem_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(156, 6);
            // 
            // exitToolStripMenuItem1
            // 
            this.exitToolStripMenuItem1.Name = "exitToolStripMenuItem1";
            this.exitToolStripMenuItem1.Size = new System.Drawing.Size(159, 22);
            this.exitToolStripMenuItem1.Text = "Exit";
            this.exitToolStripMenuItem1.Click += new System.EventHandler(this.exitToolStripMenuItem1_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem1});
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.aboutToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem1
            // 
            this.aboutToolStripMenuItem1.Name = "aboutToolStripMenuItem1";
            this.aboutToolStripMenuItem1.Size = new System.Drawing.Size(107, 22);
            this.aboutToolStripMenuItem1.Text = "About";
            this.aboutToolStripMenuItem1.Click += new System.EventHandler(this.aboutToolStripMenuItem1_Click);
            // 
            // CRYRPTViewer
            // 
            this.CRYRPTViewer.ActiveViewIndex = -1;
            this.CRYRPTViewer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CRYRPTViewer.Cursor = System.Windows.Forms.Cursors.Default;
            this.CRYRPTViewer.DisplayStatusBar = false;
            this.CRYRPTViewer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CRYRPTViewer.Location = new System.Drawing.Point(0, 24);
            this.CRYRPTViewer.Name = "CRYRPTViewer";
            this.CRYRPTViewer.ShowCloseButton = false;
            this.CRYRPTViewer.ShowCopyButton = false;
            this.CRYRPTViewer.ShowExportButton = false;
            this.CRYRPTViewer.ShowGroupTreeButton = false;
            this.CRYRPTViewer.ShowLogo = false;
            this.CRYRPTViewer.ShowPageNavigateButtons = false;
            this.CRYRPTViewer.ShowParameterPanelButton = false;
            this.CRYRPTViewer.ShowTextSearchButton = false;
            this.CRYRPTViewer.ShowZoomButton = false;
            this.CRYRPTViewer.Size = new System.Drawing.Size(976, 452);
            this.CRYRPTViewer.TabIndex = 1;
            this.CRYRPTViewer.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // printDialog1
            // 
            this.printDialog1.UseEXDialog = true;
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // printReportDocument
            // 
            this.printReportDocument.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printReportDocument_PrintPage);
            // 
            // backButton
            // 
            this.backButton.Location = new System.Drawing.Point(197, 25);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(75, 23);
            this.backButton.TabIndex = 6;
            this.backButton.Text = "Back";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // SelectReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(976, 476);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.CRYRPTViewer);
            this.Controls.Add(this.ReportMenuStrip);
            this.MainMenuStrip = this.ReportMenuStrip;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SelectReportForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Select Report";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SelectReportForm_FormClosing);
            this.ReportMenuStrip.ResumeLayout(false);
            this.ReportMenuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip ReportMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem1;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer CRYRPTViewer;
        private System.Windows.Forms.PrintDialog printDialog1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Drawing.Printing.PrintDocument printReportDocument;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem checkInReportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem adminLoginReportToolStripMenuItem1;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem closeFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem1;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.ToolStripMenuItem userDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem systemStatusReportToolStripMenuItem;
    }
}