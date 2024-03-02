namespace PersonelGiris
{
    partial class MainApp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainApp));
            this.devicePort = new UsbLibrary.UsbHidPort(this.components);
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripTB_aci1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripTBAcii = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolS_baglan = new System.Windows.Forms.ToolStripSplitButton();
            this.lbl_mesaj2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.buttonAlarm = new System.Windows.Forms.Button();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.progressBarSES = new System.Windows.Forms.ProgressBar();
            this.buttonLogin = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxSurname = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxId = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.labelSound = new System.Windows.Forms.Label();
            this.buttonInfo = new System.Windows.Forms.Button();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // devicePort
            // 
            this.devicePort.ProductId = 2000;
            this.devicePort.VendorId = 1001;
            this.devicePort.OnSpecifiedDeviceArrived += new System.EventHandler(this.deviceConnection_OnSpecifiedDeviceArrived);
            this.devicePort.OnSpecifiedDeviceRemoved += new System.EventHandler(this.deviceConnection_OnSpecifiedDeviceRemoved);
            this.devicePort.OnDeviceArrived += new System.EventHandler(this.deviceConnection_OnDeviceArrived);
            this.devicePort.OnDeviceRemoved += new System.EventHandler(this.deviceConnection_OnDeviceRemoved);
            this.devicePort.OnDataRecieved += new UsbLibrary.DataRecievedEventHandler(this.deviceConnection_OnDataRecieved);
            this.devicePort.OnDataSend += new System.EventHandler(this.deviceConnection_OnDataSend);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.toolStripTB_aci1,
            this.toolStripTBAcii,
            this.toolS_baglan,
            this.lbl_mesaj2});
            this.statusStrip1.Location = new System.Drawing.Point(0, 358);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 19, 0);
            this.statusStrip1.Size = new System.Drawing.Size(789, 26);
            this.statusStrip1.TabIndex = 36;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(148, 20);
            this.toolStripStatusLabel1.Text = "Connection Waiting...";
            this.toolStripStatusLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // toolStripTB_aci1
            // 
            this.toolStripTB_aci1.Name = "toolStripTB_aci1";
            this.toolStripTB_aci1.Size = new System.Drawing.Size(0, 20);
            // 
            // toolStripTBAcii
            // 
            this.toolStripTBAcii.Name = "toolStripTBAcii";
            this.toolStripTBAcii.Size = new System.Drawing.Size(0, 20);
            // 
            // toolS_baglan
            // 
            this.toolS_baglan.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolS_baglan.Name = "toolS_baglan";
            this.toolS_baglan.Size = new System.Drawing.Size(82, 24);
            this.toolS_baglan.Text = "Connect";
            this.toolS_baglan.ButtonClick += new System.EventHandler(this.toolS_baglan_ButtonClick);
            // 
            // lbl_mesaj2
            // 
            this.lbl_mesaj2.Name = "lbl_mesaj2";
            this.lbl_mesaj2.Size = new System.Drawing.Size(0, 20);
            // 
            // buttonAlarm
            // 
            this.buttonAlarm.BackColor = System.Drawing.Color.Red;
            this.buttonAlarm.Location = new System.Drawing.Point(425, 230);
            this.buttonAlarm.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonAlarm.Name = "buttonAlarm";
            this.buttonAlarm.Size = new System.Drawing.Size(113, 42);
            this.buttonAlarm.TabIndex = 49;
            this.buttonAlarm.Text = "Alarm";
            this.buttonAlarm.UseVisualStyleBackColor = false;
            this.buttonAlarm.Click += new System.EventHandler(this.buttonAlarm_Click);
            // 
            // pictureBox
            // 
            this.pictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox.Image")));
            this.pictureBox.Location = new System.Drawing.Point(39, 16);
            this.pictureBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(235, 271);
            this.pictureBox.TabIndex = 50;
            this.pictureBox.TabStop = false;
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(425, 30);
            this.textBoxName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(329, 22);
            this.textBoxName.TabIndex = 51;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(363, 33);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 16);
            this.label3.TabIndex = 52;
            this.label3.Text = "NAME:";
            // 
            // progressBarSES
            // 
            this.progressBarSES.Location = new System.Drawing.Point(425, 297);
            this.progressBarSES.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.progressBarSES.Name = "progressBarSES";
            this.progressBarSES.Size = new System.Drawing.Size(331, 26);
            this.progressBarSES.TabIndex = 53;
            // 
            // buttonLogin
            // 
            this.buttonLogin.BackColor = System.Drawing.Color.Green;
            this.buttonLogin.Location = new System.Drawing.Point(643, 230);
            this.buttonLogin.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(113, 42);
            this.buttonLogin.TabIndex = 54;
            this.buttonLogin.Text = "Open Door";
            this.buttonLogin.UseVisualStyleBackColor = false;
            this.buttonLogin.Click += new System.EventHandler(this.buttonGiris_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(334, 70);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 16);
            this.label4.TabIndex = 56;
            this.label4.Text = "SURNAME:";
            // 
            // textBoxSurname
            // 
            this.textBoxSurname.Location = new System.Drawing.Point(425, 66);
            this.textBoxSurname.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxSurname.Name = "textBoxSurname";
            this.textBoxSurname.Size = new System.Drawing.Size(329, 22);
            this.textBoxSurname.TabIndex = 55;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(388, 107);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(23, 16);
            this.label5.TabIndex = 58;
            this.label5.Text = "ID:";
            // 
            // textBoxId
            // 
            this.textBoxId.Location = new System.Drawing.Point(425, 103);
            this.textBoxId.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxId.Name = "textBoxId";
            this.textBoxId.Size = new System.Drawing.Size(329, 22);
            this.textBoxId.TabIndex = 57;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(307, 306);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(103, 16);
            this.label6.TabIndex = 60;
            this.label6.Text = "SOUND LEVEL:";
            // 
            // labelSound
            // 
            this.labelSound.AutoSize = true;
            this.labelSound.Location = new System.Drawing.Point(585, 300);
            this.labelSound.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelSound.Name = "labelSound";
            this.labelSound.Size = new System.Drawing.Size(14, 16);
            this.labelSound.TabIndex = 61;
            this.labelSound.Text = "0";
            // 
            // buttonInfo
            // 
            this.buttonInfo.BackColor = System.Drawing.Color.Yellow;
            this.buttonInfo.Location = new System.Drawing.Point(39, 294);
            this.buttonInfo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonInfo.Name = "buttonInfo";
            this.buttonInfo.Size = new System.Drawing.Size(235, 28);
            this.buttonInfo.TabIndex = 62;
            this.buttonInfo.Text = "Card Waiting...";
            this.buttonInfo.UseVisualStyleBackColor = false;
            // 
            // MainApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(789, 384);
            this.Controls.Add(this.buttonInfo);
            this.Controls.Add(this.labelSound);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBoxId);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxSurname);
            this.Controls.Add(this.buttonLogin);
            this.Controls.Add(this.progressBarSES);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.buttonAlarm);
            this.Controls.Add(this.statusStrip1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "MainApp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Card Access Management";
            this.Load += new System.EventHandler(this.MainApp_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripTB_aci1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripTBAcii;
        private System.Windows.Forms.ToolStripSplitButton toolS_baglan;
        private System.Windows.Forms.ToolStripStatusLabel lbl_mesaj2;
        private System.Windows.Forms.Button buttonAlarm;
        public UsbLibrary.UsbHidPort devicePort;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ProgressBar progressBarSES;
        private System.Windows.Forms.Button buttonLogin;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxSurname;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxId;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label labelSound;
        private System.Windows.Forms.Button buttonInfo;
    }
}

