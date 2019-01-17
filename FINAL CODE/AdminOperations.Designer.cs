namespace DigiDoor_UPDATED
{
    partial class AdminOperations
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminOperations));
            this.UserInfoGroupBox = new System.Windows.Forms.GroupBox();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.BrowseImgBtn = new System.Windows.Forms.Button();
            this.BackToAddModeBtn = new System.Windows.Forms.Button();
            this.userImagePB = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.EndTimePicker = new System.Windows.Forms.DateTimePicker();
            this.BeginTimePicker = new System.Windows.Forms.DateTimePicker();
            this.UserCategoryComboBox = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.PINTextBox = new System.Windows.Forms.TextBox();
            this.usernameTextBox = new System.Windows.Forms.TextBox();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.deleteRecordBtn = new System.Windows.Forms.Button();
            this.updateRecordBtn = new System.Windows.Forms.Button();
            this.SaveBtn = new System.Windows.Forms.Button();
            this.ClearBtn = new System.Windows.Forms.Button();
            this.userInfoGrid = new System.Windows.Forms.DataGridView();
            this.usernumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameOfUserDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usernameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.passcodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.begintimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.endtimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userimageDataGridViewImageColumn = new System.Windows.Forms.DataGridViewImageColumn();
            this.status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usertableBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.userinfoGridBindingSource = new DigiDoor_UPDATED.UserinfoGridBindingSource();
            this.usertableBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.usertableDataset = new DigiDoor_UPDATED.usertableDataset();
            this.usertableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.digiDoorDataSet = new DigiDoor_UPDATED.DigiDoorDataSet();
            this.ManageLogBtn = new System.Windows.Forms.Button();
            this.LogOutBtn = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.user_tableTableAdapter = new DigiDoor_UPDATED.DigiDoorDataSetTableAdapters.user_tableTableAdapter();
            this.BackBtn = new System.Windows.Forms.Button();
            this.user_tableTableAdapter1 = new DigiDoor_UPDATED.usertableDatasetTableAdapters.user_tableTableAdapter();
            this.user_tableTableAdapter2 = new DigiDoor_UPDATED.UserinfoGridBindingSourceTableAdapters.user_tableTableAdapter();
            this.UserInfoGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userImagePB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userInfoGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usertableBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userinfoGridBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usertableBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usertableDataset)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usertableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.digiDoorDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // UserInfoGroupBox
            // 
            this.UserInfoGroupBox.BackColor = System.Drawing.Color.Transparent;
            this.UserInfoGroupBox.Controls.Add(this.emailTextBox);
            this.UserInfoGroupBox.Controls.Add(this.label7);
            this.UserInfoGroupBox.Controls.Add(this.BrowseImgBtn);
            this.UserInfoGroupBox.Controls.Add(this.BackToAddModeBtn);
            this.UserInfoGroupBox.Controls.Add(this.userImagePB);
            this.UserInfoGroupBox.Controls.Add(this.label6);
            this.UserInfoGroupBox.Controls.Add(this.label5);
            this.UserInfoGroupBox.Controls.Add(this.EndTimePicker);
            this.UserInfoGroupBox.Controls.Add(this.BeginTimePicker);
            this.UserInfoGroupBox.Controls.Add(this.UserCategoryComboBox);
            this.UserInfoGroupBox.Controls.Add(this.label4);
            this.UserInfoGroupBox.Controls.Add(this.label3);
            this.UserInfoGroupBox.Controls.Add(this.label2);
            this.UserInfoGroupBox.Controls.Add(this.PINTextBox);
            this.UserInfoGroupBox.Controls.Add(this.usernameTextBox);
            this.UserInfoGroupBox.Controls.Add(this.NameTextBox);
            this.UserInfoGroupBox.Controls.Add(this.label1);
            this.UserInfoGroupBox.Controls.Add(this.deleteRecordBtn);
            this.UserInfoGroupBox.Controls.Add(this.updateRecordBtn);
            this.UserInfoGroupBox.Controls.Add(this.SaveBtn);
            this.UserInfoGroupBox.Controls.Add(this.ClearBtn);
            this.UserInfoGroupBox.Location = new System.Drawing.Point(12, 49);
            this.UserInfoGroupBox.Name = "UserInfoGroupBox";
            this.UserInfoGroupBox.Size = new System.Drawing.Size(249, 507);
            this.UserInfoGroupBox.TabIndex = 0;
            this.UserInfoGroupBox.TabStop = false;
            this.UserInfoGroupBox.Text = "Enter details";
            // 
            // emailTextBox
            // 
            this.emailTextBox.Enabled = false;
            this.emailTextBox.Location = new System.Drawing.Point(95, 201);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(137, 20);
            this.emailTextBox.TabIndex = 16;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(16, 201);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Email Address";
            // 
            // BrowseImgBtn
            // 
            this.BrowseImgBtn.Location = new System.Drawing.Point(14, 242);
            this.BrowseImgBtn.Name = "BrowseImgBtn";
            this.BrowseImgBtn.Size = new System.Drawing.Size(92, 23);
            this.BrowseImgBtn.TabIndex = 14;
            this.BrowseImgBtn.Text = "Browse Image";
            this.BrowseImgBtn.UseVisualStyleBackColor = true;
            this.BrowseImgBtn.Click += new System.EventHandler(this.uploadImgButton_Click);
            // 
            // BackToAddModeBtn
            // 
            this.BackToAddModeBtn.Location = new System.Drawing.Point(14, 478);
            this.BackToAddModeBtn.Name = "BackToAddModeBtn";
            this.BackToAddModeBtn.Size = new System.Drawing.Size(156, 23);
            this.BackToAddModeBtn.TabIndex = 13;
            this.BackToAddModeBtn.Text = "Back To Add";
            this.BackToAddModeBtn.UseVisualStyleBackColor = true;
            this.BackToAddModeBtn.Visible = false;
            this.BackToAddModeBtn.Click += new System.EventHandler(this.BackToAddModeBtn_Click);
            // 
            // userImagePB
            // 
            this.userImagePB.BackColor = System.Drawing.SystemColors.Control;
            this.userImagePB.Enabled = false;
            this.userImagePB.Location = new System.Drawing.Point(14, 271);
            this.userImagePB.Name = "userImagePB";
            this.userImagePB.Size = new System.Drawing.Size(218, 163);
            this.userImagePB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.userImagePB.TabIndex = 9;
            this.userImagePB.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(29, 174);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "End Time";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(29, 148);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Begin Time";
            // 
            // EndTimePicker
            // 
            this.EndTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.EndTimePicker.Location = new System.Drawing.Point(95, 168);
            this.EndTimePicker.Name = "EndTimePicker";
            this.EndTimePicker.ShowUpDown = true;
            this.EndTimePicker.Size = new System.Drawing.Size(137, 20);
            this.EndTimePicker.TabIndex = 6;
            // 
            // BeginTimePicker
            // 
            this.BeginTimePicker.CustomFormat = "HH:mm:ss tt";
            this.BeginTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.BeginTimePicker.Location = new System.Drawing.Point(95, 142);
            this.BeginTimePicker.Name = "BeginTimePicker";
            this.BeginTimePicker.ShowUpDown = true;
            this.BeginTimePicker.Size = new System.Drawing.Size(137, 20);
            this.BeginTimePicker.TabIndex = 5;
            // 
            // UserCategoryComboBox
            // 
            this.UserCategoryComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.UserCategoryComboBox.FormattingEnabled = true;
            this.UserCategoryComboBox.Items.AddRange(new object[] {
            "Admin",
            "Family Members",
            "Workers"});
            this.UserCategoryComboBox.Location = new System.Drawing.Point(95, 115);
            this.UserCategoryComboBox.Name = "UserCategoryComboBox";
            this.UserCategoryComboBox.Size = new System.Drawing.Size(137, 21);
            this.UserCategoryComboBox.TabIndex = 4;
            this.UserCategoryComboBox.SelectedIndexChanged += new System.EventHandler(this.UserCategoryComboBox_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 118);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Select Category";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Enter PIN";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Enter Username";
            // 
            // PINTextBox
            // 
            this.PINTextBox.Location = new System.Drawing.Point(95, 91);
            this.PINTextBox.Name = "PINTextBox";
            this.PINTextBox.Size = new System.Drawing.Size(137, 20);
            this.PINTextBox.TabIndex = 3;
            this.PINTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PINTextBox_KeyPress);
            // 
            // usernameTextBox
            // 
            this.usernameTextBox.Location = new System.Drawing.Point(95, 63);
            this.usernameTextBox.Name = "usernameTextBox";
            this.usernameTextBox.Size = new System.Drawing.Size(137, 20);
            this.usernameTextBox.TabIndex = 2;
            this.usernameTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.usernameTextBox_KeyPress);
            // 
            // NameTextBox
            // 
            this.NameTextBox.Location = new System.Drawing.Point(95, 37);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(137, 20);
            this.NameTextBox.TabIndex = 1;
            this.NameTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NameTextBox_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter Name";
            // 
            // deleteRecordBtn
            // 
            this.deleteRecordBtn.Location = new System.Drawing.Point(95, 449);
            this.deleteRecordBtn.Name = "deleteRecordBtn";
            this.deleteRecordBtn.Size = new System.Drawing.Size(75, 23);
            this.deleteRecordBtn.TabIndex = 12;
            this.deleteRecordBtn.Text = "Delete";
            this.deleteRecordBtn.UseVisualStyleBackColor = true;
            this.deleteRecordBtn.Visible = false;
            this.deleteRecordBtn.Click += new System.EventHandler(this.deleteRecordBtn_Click);
            // 
            // updateRecordBtn
            // 
            this.updateRecordBtn.Location = new System.Drawing.Point(14, 449);
            this.updateRecordBtn.Name = "updateRecordBtn";
            this.updateRecordBtn.Size = new System.Drawing.Size(75, 23);
            this.updateRecordBtn.TabIndex = 11;
            this.updateRecordBtn.Text = "Update";
            this.updateRecordBtn.UseVisualStyleBackColor = true;
            this.updateRecordBtn.Visible = false;
            this.updateRecordBtn.Click += new System.EventHandler(this.updateRecordBtn_Click);
            // 
            // SaveBtn
            // 
            this.SaveBtn.Location = new System.Drawing.Point(14, 449);
            this.SaveBtn.Name = "SaveBtn";
            this.SaveBtn.Size = new System.Drawing.Size(75, 23);
            this.SaveBtn.TabIndex = 8;
            this.SaveBtn.Text = "Save";
            this.SaveBtn.UseVisualStyleBackColor = true;
            this.SaveBtn.Click += new System.EventHandler(this.SaveBtn_Click);
            // 
            // ClearBtn
            // 
            this.ClearBtn.Location = new System.Drawing.Point(95, 449);
            this.ClearBtn.Name = "ClearBtn";
            this.ClearBtn.Size = new System.Drawing.Size(75, 23);
            this.ClearBtn.TabIndex = 9;
            this.ClearBtn.Text = "Clear";
            this.ClearBtn.UseVisualStyleBackColor = true;
            this.ClearBtn.Click += new System.EventHandler(this.ClearBtn_Click);
            // 
            // userInfoGrid
            // 
            this.userInfoGrid.AllowUserToAddRows = false;
            this.userInfoGrid.AutoGenerateColumns = false;
            this.userInfoGrid.BackgroundColor = System.Drawing.Color.White;
            this.userInfoGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.userInfoGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.usernumberDataGridViewTextBoxColumn,
            this.nameOfUserDataGridViewTextBoxColumn,
            this.usernameDataGridViewTextBoxColumn,
            this.passcodeDataGridViewTextBoxColumn,
            this.categoryDataGridViewTextBoxColumn,
            this.begintimeDataGridViewTextBoxColumn,
            this.endtimeDataGridViewTextBoxColumn,
            this.userimageDataGridViewImageColumn,
            this.status,
            this.email});
            this.userInfoGrid.DataSource = this.usertableBindingSource2;
            this.userInfoGrid.Location = new System.Drawing.Point(277, 49);
            this.userInfoGrid.Name = "userInfoGrid";
            this.userInfoGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.userInfoGrid.Size = new System.Drawing.Size(544, 467);
            this.userInfoGrid.TabIndex = 12;
            this.userInfoGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.userInfoGrid_CellContentClick);
            this.userInfoGrid.MouseClick += new System.Windows.Forms.MouseEventHandler(this.userInfoGrid_MouseClick);
            // 
            // usernumberDataGridViewTextBoxColumn
            // 
            this.usernumberDataGridViewTextBoxColumn.DataPropertyName = "user_number";
            this.usernumberDataGridViewTextBoxColumn.HeaderText = "User Number";
            this.usernumberDataGridViewTextBoxColumn.Name = "usernumberDataGridViewTextBoxColumn";
            this.usernumberDataGridViewTextBoxColumn.ReadOnly = true;
            this.usernumberDataGridViewTextBoxColumn.Visible = false;
            // 
            // nameOfUserDataGridViewTextBoxColumn
            // 
            this.nameOfUserDataGridViewTextBoxColumn.DataPropertyName = "NameOfUser";
            this.nameOfUserDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameOfUserDataGridViewTextBoxColumn.Name = "nameOfUserDataGridViewTextBoxColumn";
            // 
            // usernameDataGridViewTextBoxColumn
            // 
            this.usernameDataGridViewTextBoxColumn.DataPropertyName = "user_name";
            this.usernameDataGridViewTextBoxColumn.HeaderText = "Username";
            this.usernameDataGridViewTextBoxColumn.Name = "usernameDataGridViewTextBoxColumn";
            // 
            // passcodeDataGridViewTextBoxColumn
            // 
            this.passcodeDataGridViewTextBoxColumn.DataPropertyName = "passcode";
            this.passcodeDataGridViewTextBoxColumn.HeaderText = "PIN";
            this.passcodeDataGridViewTextBoxColumn.Name = "passcodeDataGridViewTextBoxColumn";
            this.passcodeDataGridViewTextBoxColumn.Visible = false;
            // 
            // categoryDataGridViewTextBoxColumn
            // 
            this.categoryDataGridViewTextBoxColumn.DataPropertyName = "category";
            this.categoryDataGridViewTextBoxColumn.HeaderText = "Category";
            this.categoryDataGridViewTextBoxColumn.Name = "categoryDataGridViewTextBoxColumn";
            // 
            // begintimeDataGridViewTextBoxColumn
            // 
            this.begintimeDataGridViewTextBoxColumn.DataPropertyName = "begin_time";
            this.begintimeDataGridViewTextBoxColumn.HeaderText = "Begin Time";
            this.begintimeDataGridViewTextBoxColumn.Name = "begintimeDataGridViewTextBoxColumn";
            // 
            // endtimeDataGridViewTextBoxColumn
            // 
            this.endtimeDataGridViewTextBoxColumn.DataPropertyName = "end_time";
            this.endtimeDataGridViewTextBoxColumn.HeaderText = "End Time";
            this.endtimeDataGridViewTextBoxColumn.Name = "endtimeDataGridViewTextBoxColumn";
            // 
            // userimageDataGridViewImageColumn
            // 
            this.userimageDataGridViewImageColumn.DataPropertyName = "user_image";
            this.userimageDataGridViewImageColumn.HeaderText = "Image";
            this.userimageDataGridViewImageColumn.Name = "userimageDataGridViewImageColumn";
            this.userimageDataGridViewImageColumn.Visible = false;
            // 
            // status
            // 
            this.status.DataPropertyName = "status";
            this.status.HeaderText = "status";
            this.status.Name = "status";
            // 
            // email
            // 
            this.email.DataPropertyName = "email";
            this.email.HeaderText = "email address";
            this.email.Name = "email";
            // 
            // usertableBindingSource2
            // 
            this.usertableBindingSource2.DataMember = "user_table";
            this.usertableBindingSource2.DataSource = this.userinfoGridBindingSource;
            // 
            // userinfoGridBindingSource
            // 
            this.userinfoGridBindingSource.DataSetName = "UserinfoGridBindingSource";
            this.userinfoGridBindingSource.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // usertableBindingSource1
            // 
            this.usertableBindingSource1.DataMember = "user_table";
            this.usertableBindingSource1.DataSource = this.usertableDataset;
            // 
            // usertableDataset
            // 
            this.usertableDataset.DataSetName = "usertableDataset";
            this.usertableDataset.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // usertableBindingSource
            // 
            this.usertableBindingSource.DataMember = "user_table";
            this.usertableBindingSource.DataSource = this.digiDoorDataSet;
            // 
            // digiDoorDataSet
            // 
            this.digiDoorDataSet.DataSetName = "DigiDoorDataSet";
            this.digiDoorDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ManageLogBtn
            // 
            this.ManageLogBtn.Location = new System.Drawing.Point(572, 20);
            this.ManageLogBtn.Name = "ManageLogBtn";
            this.ManageLogBtn.Size = new System.Drawing.Size(75, 23);
            this.ManageLogBtn.TabIndex = 10;
            this.ManageLogBtn.Text = "Manage Log";
            this.ManageLogBtn.UseVisualStyleBackColor = true;
            this.ManageLogBtn.Click += new System.EventHandler(this.ManageLogBtn_Click);
            // 
            // LogOutBtn
            // 
            this.LogOutBtn.Location = new System.Drawing.Point(653, 20);
            this.LogOutBtn.Name = "LogOutBtn";
            this.LogOutBtn.Size = new System.Drawing.Size(75, 23);
            this.LogOutBtn.TabIndex = 11;
            this.LogOutBtn.Text = "Log Out";
            this.LogOutBtn.UseVisualStyleBackColor = true;
            this.LogOutBtn.Click += new System.EventHandler(this.LogOutBtn_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // user_tableTableAdapter
            // 
            this.user_tableTableAdapter.ClearBeforeFill = true;
            // 
            // BackBtn
            // 
            this.BackBtn.Location = new System.Drawing.Point(491, 20);
            this.BackBtn.Name = "BackBtn";
            this.BackBtn.Size = new System.Drawing.Size(75, 23);
            this.BackBtn.TabIndex = 13;
            this.BackBtn.Text = "Back";
            this.BackBtn.UseVisualStyleBackColor = true;
            this.BackBtn.Click += new System.EventHandler(this.BackBtn_Click);
            // 
            // user_tableTableAdapter1
            // 
            this.user_tableTableAdapter1.ClearBeforeFill = true;
            // 
            // user_tableTableAdapter2
            // 
            this.user_tableTableAdapter2.ClearBeforeFill = true;
            // 
            // AdminOperations
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(838, 568);
            this.Controls.Add(this.BackBtn);
            this.Controls.Add(this.LogOutBtn);
            this.Controls.Add(this.ManageLogBtn);
            this.Controls.Add(this.userInfoGrid);
            this.Controls.Add(this.UserInfoGroupBox);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AdminOperations";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin Operations";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AdminOperations_FormClosing);
            this.Load += new System.EventHandler(this.AdminOperations_Load);
            this.UserInfoGroupBox.ResumeLayout(false);
            this.UserInfoGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userImagePB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userInfoGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usertableBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userinfoGridBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usertableBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usertableDataset)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usertableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.digiDoorDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox UserInfoGroupBox;
        private System.Windows.Forms.Button ClearBtn;
        private System.Windows.Forms.Button SaveBtn;
        private System.Windows.Forms.PictureBox userImagePB;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker EndTimePicker;
        private System.Windows.Forms.DateTimePicker BeginTimePicker;
        private System.Windows.Forms.ComboBox UserCategoryComboBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox PINTextBox;
        private System.Windows.Forms.TextBox usernameTextBox;
        private System.Windows.Forms.TextBox NameTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView userInfoGrid;
        private System.Windows.Forms.Button ManageLogBtn;
        private System.Windows.Forms.Button LogOutBtn;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private DigiDoorDataSet digiDoorDataSet;
        private System.Windows.Forms.BindingSource usertableBindingSource;
        private DigiDoorDataSetTableAdapters.user_tableTableAdapter user_tableTableAdapter;
        private System.Windows.Forms.Button deleteRecordBtn;
        private System.Windows.Forms.Button updateRecordBtn;
        private System.Windows.Forms.Button BackToAddModeBtn;
        private System.Windows.Forms.Button BrowseImgBtn;
        private System.Windows.Forms.Button BackBtn;
        private System.Windows.Forms.DataGridViewTextBoxColumn usernumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameOfUserDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn usernameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn passcodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoryDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn begintimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn endtimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewImageColumn userimageDataGridViewImageColumn;
        private usertableDataset usertableDataset;
        private System.Windows.Forms.BindingSource usertableBindingSource1;
        private usertableDatasetTableAdapters.user_tableTableAdapter user_tableTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn status;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.Label label7;
        private UserinfoGridBindingSource userinfoGridBindingSource;
        private System.Windows.Forms.BindingSource usertableBindingSource2;
        private UserinfoGridBindingSourceTableAdapters.user_tableTableAdapter user_tableTableAdapter2;
        private System.Windows.Forms.DataGridViewTextBoxColumn email;
    }
}