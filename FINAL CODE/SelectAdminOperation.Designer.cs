namespace DigiDoor_UPDATED
{
    partial class SelectAdminOperation
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SelectAdminOperation));
            this.TitleLabel = new System.Windows.Forms.Label();
            this.ManageUsersBtn = new System.Windows.Forms.Button();
            this.ViewReportsBtn = new System.Windows.Forms.Button();
            this.LogOutBtn = new System.Windows.Forms.Button();
            this.ActivateSystemButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TitleLabel
            // 
            this.TitleLabel.BackColor = System.Drawing.Color.Transparent;
            this.TitleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitleLabel.Location = new System.Drawing.Point(1, 20);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(387, 34);
            this.TitleLabel.TabIndex = 0;
            this.TitleLabel.Text = "Select an operation:";
            this.TitleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ManageUsersBtn
            // 
            this.ManageUsersBtn.Location = new System.Drawing.Point(148, 57);
            this.ManageUsersBtn.Name = "ManageUsersBtn";
            this.ManageUsersBtn.Size = new System.Drawing.Size(117, 27);
            this.ManageUsersBtn.TabIndex = 1;
            this.ManageUsersBtn.Text = "Manage Users";
            this.ManageUsersBtn.UseVisualStyleBackColor = true;
            this.ManageUsersBtn.Click += new System.EventHandler(this.ManageUsersBtn_Click);
            // 
            // ViewReportsBtn
            // 
            this.ViewReportsBtn.Location = new System.Drawing.Point(148, 90);
            this.ViewReportsBtn.Name = "ViewReportsBtn";
            this.ViewReportsBtn.Size = new System.Drawing.Size(117, 24);
            this.ViewReportsBtn.TabIndex = 2;
            this.ViewReportsBtn.Text = "View Reports";
            this.ViewReportsBtn.UseVisualStyleBackColor = true;
            this.ViewReportsBtn.Click += new System.EventHandler(this.ViewReportsBtn_Click);
            // 
            // LogOutBtn
            // 
            this.LogOutBtn.Location = new System.Drawing.Point(148, 120);
            this.LogOutBtn.Name = "LogOutBtn";
            this.LogOutBtn.Size = new System.Drawing.Size(117, 23);
            this.LogOutBtn.TabIndex = 3;
            this.LogOutBtn.Text = "Log Out";
            this.LogOutBtn.UseVisualStyleBackColor = true;
            this.LogOutBtn.Click += new System.EventHandler(this.LogOutBtn_Click);
            // 
            // ActivateSystemButton
            // 
            this.ActivateSystemButton.Location = new System.Drawing.Point(148, 149);
            this.ActivateSystemButton.Name = "ActivateSystemButton";
            this.ActivateSystemButton.Size = new System.Drawing.Size(117, 32);
            this.ActivateSystemButton.TabIndex = 4;
            this.ActivateSystemButton.Text = "Enable System";
            this.ActivateSystemButton.UseVisualStyleBackColor = true;
            this.ActivateSystemButton.Visible = false;
            this.ActivateSystemButton.Click += new System.EventHandler(this.ActivateSystemButton_Click);
            // 
            // SelectAdminOperation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(389, 184);
            this.Controls.Add(this.ActivateSystemButton);
            this.Controls.Add(this.LogOutBtn);
            this.Controls.Add(this.ViewReportsBtn);
            this.Controls.Add(this.ManageUsersBtn);
            this.Controls.Add(this.TitleLabel);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SelectAdminOperation";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Select Operation";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SelectAdminOperation_FormClosing);
            this.Load += new System.EventHandler(this.SelectAdminOperation_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label TitleLabel;
        private System.Windows.Forms.Button ManageUsersBtn;
        private System.Windows.Forms.Button ViewReportsBtn;
        private System.Windows.Forms.Button LogOutBtn;
        private System.Windows.Forms.Button ActivateSystemButton;
    }
}