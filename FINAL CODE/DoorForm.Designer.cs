namespace DigiDoor_UPDATED
{
    partial class DoorForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DoorForm));
            this.InstructionLbl = new System.Windows.Forms.Label();
            this.LoadAdminPanelButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.enteredPINTextBox = new System.Windows.Forms.TextBox();
            this.AuthenticateBtn = new System.Windows.Forms.Button();
            this.captureImagePB = new System.Windows.Forms.PictureBox();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.captureImagePB)).BeginInit();
            this.SuspendLayout();
            // 
            // InstructionLbl
            // 
            this.InstructionLbl.BackColor = System.Drawing.SystemColors.Control;
            this.InstructionLbl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.InstructionLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InstructionLbl.Location = new System.Drawing.Point(12, 9);
            this.InstructionLbl.Name = "InstructionLbl";
            this.InstructionLbl.Size = new System.Drawing.Size(218, 30);
            this.InstructionLbl.TabIndex = 0;
            this.InstructionLbl.Text = "PIN Format: *PIN#";
            this.InstructionLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LoadAdminPanelButton
            // 
            this.LoadAdminPanelButton.Location = new System.Drawing.Point(120, 259);
            this.LoadAdminPanelButton.Name = "LoadAdminPanelButton";
            this.LoadAdminPanelButton.Size = new System.Drawing.Size(84, 35);
            this.LoadAdminPanelButton.TabIndex = 3;
            this.LoadAdminPanelButton.Text = "Admin Panel";
            this.LoadAdminPanelButton.UseVisualStyleBackColor = true;
            this.LoadAdminPanelButton.Click += new System.EventHandler(this.LoadAdminPanelButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(9, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Enter PIN:";
            // 
            // enteredPINTextBox
            // 
            this.enteredPINTextBox.Location = new System.Drawing.Point(71, 52);
            this.enteredPINTextBox.Name = "enteredPINTextBox";
            this.enteredPINTextBox.Size = new System.Drawing.Size(128, 20);
            this.enteredPINTextBox.TabIndex = 1;
            this.enteredPINTextBox.UseSystemPasswordChar = true;
            this.enteredPINTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.enteredPINTextBox_KeyPress);
            // 
            // AuthenticateBtn
            // 
            this.AuthenticateBtn.CausesValidation = false;
            this.AuthenticateBtn.Location = new System.Drawing.Point(30, 259);
            this.AuthenticateBtn.Name = "AuthenticateBtn";
            this.AuthenticateBtn.Size = new System.Drawing.Size(84, 35);
            this.AuthenticateBtn.TabIndex = 2;
            this.AuthenticateBtn.Text = "Authenticate";
            this.AuthenticateBtn.UseVisualStyleBackColor = true;
            this.AuthenticateBtn.Click += new System.EventHandler(this.AuthenticateBtn_Click);
            // 
            // captureImagePB
            // 
            this.captureImagePB.BackColor = System.Drawing.Color.Transparent;
            this.captureImagePB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.captureImagePB.Location = new System.Drawing.Point(12, 81);
            this.captureImagePB.Name = "captureImagePB";
            this.captureImagePB.Size = new System.Drawing.Size(218, 163);
            this.captureImagePB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.captureImagePB.TabIndex = 4;
            this.captureImagePB.TabStop = false;
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.FileName = "Captured_image";
            this.saveFileDialog1.InitialDirectory = "C:\\Users\\sohai\\Documents\\Visual Studio 2015\\Projects\\DigiDoor-UPDATED\\DigiDoor-UP" +
    "DATED\\temp";
            // 
            // DoorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(235, 305);
            this.Controls.Add(this.captureImagePB);
            this.Controls.Add(this.AuthenticateBtn);
            this.Controls.Add(this.enteredPINTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LoadAdminPanelButton);
            this.Controls.Add(this.InstructionLbl);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DoorForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Enter Credentials";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.DoorForm_FormClosing);
            this.Load += new System.EventHandler(this.DoorForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.captureImagePB)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label InstructionLbl;
        private System.Windows.Forms.Button LoadAdminPanelButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox enteredPINTextBox;
        private System.Windows.Forms.Button AuthenticateBtn;
        private System.Windows.Forms.PictureBox captureImagePB;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}

