namespace DigiDoor_UPDATED
{
    partial class LogForm
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
            this.logGridView = new System.Windows.Forms.DataGridView();
            this.entryidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usernameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.checkInTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.capturedImageDataGridViewImageColumn = new System.Windows.Forms.DataGridViewImageColumn();
            this.logtableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.logTableDataSet = new DigiDoor_UPDATED.LogTableDataSet();
            this.ClearLogBtn = new System.Windows.Forms.Button();
            this.backBtn = new System.Windows.Forms.Button();
            this.log_tableTableAdapter = new DigiDoor_UPDATED.LogTableDataSetTableAdapters.log_tableTableAdapter();
            this.LogOutBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.logGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logtableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logTableDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // logGridView
            // 
            this.logGridView.AllowUserToAddRows = false;
            this.logGridView.AutoGenerateColumns = false;
            this.logGridView.BackgroundColor = System.Drawing.Color.White;
            this.logGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.logGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.entryidDataGridViewTextBoxColumn,
            this.usernameDataGridViewTextBoxColumn,
            this.checkInTimeDataGridViewTextBoxColumn,
            this.capturedImageDataGridViewImageColumn});
            this.logGridView.DataSource = this.logtableBindingSource;
            this.logGridView.Location = new System.Drawing.Point(12, 12);
            this.logGridView.Name = "logGridView";
            this.logGridView.Size = new System.Drawing.Size(345, 330);
            this.logGridView.TabIndex = 0;
            // 
            // entryidDataGridViewTextBoxColumn
            // 
            this.entryidDataGridViewTextBoxColumn.DataPropertyName = "entry_id";
            this.entryidDataGridViewTextBoxColumn.HeaderText = "entry_id";
            this.entryidDataGridViewTextBoxColumn.Name = "entryidDataGridViewTextBoxColumn";
            this.entryidDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // usernameDataGridViewTextBoxColumn
            // 
            this.usernameDataGridViewTextBoxColumn.DataPropertyName = "username";
            this.usernameDataGridViewTextBoxColumn.HeaderText = "username";
            this.usernameDataGridViewTextBoxColumn.Name = "usernameDataGridViewTextBoxColumn";
            // 
            // checkInTimeDataGridViewTextBoxColumn
            // 
            this.checkInTimeDataGridViewTextBoxColumn.DataPropertyName = "checkInTime";
            this.checkInTimeDataGridViewTextBoxColumn.HeaderText = "checkInTime";
            this.checkInTimeDataGridViewTextBoxColumn.Name = "checkInTimeDataGridViewTextBoxColumn";
            // 
            // capturedImageDataGridViewImageColumn
            // 
            this.capturedImageDataGridViewImageColumn.DataPropertyName = "CapturedImage";
            this.capturedImageDataGridViewImageColumn.HeaderText = "CapturedImage";
            this.capturedImageDataGridViewImageColumn.Name = "capturedImageDataGridViewImageColumn";
            this.capturedImageDataGridViewImageColumn.Visible = false;
            // 
            // logtableBindingSource
            // 
            this.logtableBindingSource.DataMember = "log_table";
            this.logtableBindingSource.DataSource = this.logTableDataSet;
            // 
            // logTableDataSet
            // 
            this.logTableDataSet.DataSetName = "LogTableDataSet";
            this.logTableDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ClearLogBtn
            // 
            this.ClearLogBtn.Location = new System.Drawing.Point(69, 362);
            this.ClearLogBtn.Name = "ClearLogBtn";
            this.ClearLogBtn.Size = new System.Drawing.Size(75, 23);
            this.ClearLogBtn.TabIndex = 1;
            this.ClearLogBtn.Text = "Clear Log";
            this.ClearLogBtn.UseVisualStyleBackColor = true;
            this.ClearLogBtn.Click += new System.EventHandler(this.ClearLogBtn_Click);
            // 
            // backBtn
            // 
            this.backBtn.Location = new System.Drawing.Point(150, 362);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(75, 23);
            this.backBtn.TabIndex = 2;
            this.backBtn.Text = "Back";
            this.backBtn.UseVisualStyleBackColor = true;
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // log_tableTableAdapter
            // 
            this.log_tableTableAdapter.ClearBeforeFill = true;
            // 
            // LogOutBtn
            // 
            this.LogOutBtn.Location = new System.Drawing.Point(231, 363);
            this.LogOutBtn.Name = "LogOutBtn";
            this.LogOutBtn.Size = new System.Drawing.Size(75, 23);
            this.LogOutBtn.TabIndex = 3;
            this.LogOutBtn.Text = "Log Out";
            this.LogOutBtn.UseVisualStyleBackColor = true;
            this.LogOutBtn.Click += new System.EventHandler(this.LogOutBtn_Click);
            // 
            // LogForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(375, 398);
            this.Controls.Add(this.LogOutBtn);
            this.Controls.Add(this.backBtn);
            this.Controls.Add(this.ClearLogBtn);
            this.Controls.Add(this.logGridView);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "LogForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manage Logs";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.LogForm_FormClosing);
            this.Load += new System.EventHandler(this.LogForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.logGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logtableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logTableDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView logGridView;
        private System.Windows.Forms.Button ClearLogBtn;
        private System.Windows.Forms.Button backBtn;
        private LogTableDataSet logTableDataSet;
        private System.Windows.Forms.BindingSource logtableBindingSource;
        private LogTableDataSetTableAdapters.log_tableTableAdapter log_tableTableAdapter;
        private System.Windows.Forms.DataGridViewImageColumn capturedImageDataGridViewImageColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn checkInTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn usernameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn entryidDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button LogOutBtn;
    }
}