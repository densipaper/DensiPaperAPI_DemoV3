namespace DensiPaperAPI_Demo
{
    partial class Form1
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
            this.lblUser = new System.Windows.Forms.Label();
            this.txbUser = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txbPassword = new System.Windows.Forms.TextBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnCreate = new System.Windows.Forms.Button();
            this.tabStages = new System.Windows.Forms.TabControl();
            this.tabAuth = new System.Windows.Forms.TabPage();
            this.tabCreate = new System.Windows.Forms.TabPage();
            this.lbxTemplates = new System.Windows.Forms.ListBox();
            this.tabSend = new System.Windows.Forms.TabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lblTimerID = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.lblTimerName = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblTimer = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.lblTimeZone = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.lblDeviceLocaton = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.lblDeviceID = new System.Windows.Forms.Label();
            this.lblDeviceType = new System.Windows.Forms.Label();
            this.lb = new System.Windows.Forms.Label();
            this.lblDeviceName = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblExpires = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblID = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lblHeight = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblWidth = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnSend = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.lbxTimers = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lbxDevices = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lbxImages = new System.Windows.Forms.ListBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.txbURL = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabUpload = new System.Windows.Forms.TabPage();
            this.tabStages.SuspendLayout();
            this.tabAuth.SuspendLayout();
            this.tabCreate.SuspendLayout();
            this.tabSend.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Location = new System.Drawing.Point(34, 33);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(29, 13);
            this.lblUser.TabIndex = 0;
            this.lblUser.Text = "User";
            // 
            // txbUser
            // 
            this.txbUser.Location = new System.Drawing.Point(69, 33);
            this.txbUser.Name = "txbUser";
            this.txbUser.Size = new System.Drawing.Size(100, 20);
            this.txbUser.TabIndex = 1;
            this.txbUser.Text = "clugosi@densipaper";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(10, 75);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(53, 13);
            this.lblPassword.TabIndex = 2;
            this.lblPassword.Text = "Password";
            // 
            // txbPassword
            // 
            this.txbPassword.Location = new System.Drawing.Point(69, 72);
            this.txbPassword.Name = "txbPassword";
            this.txbPassword.PasswordChar = '*';
            this.txbPassword.Size = new System.Drawing.Size(100, 20);
            this.txbPassword.TabIndex = 3;
            this.txbPassword.Text = "Cannon2014!";
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(6, 128);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(75, 23);
            this.btnLogin.TabIndex = 4;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.Location = new System.Drawing.Point(87, 128);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(75, 23);
            this.btnLogout.TabIndex = 7;
            this.btnLogout.Text = "LogOut";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(23, 308);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(75, 23);
            this.btnCreate.TabIndex = 8;
            this.btnCreate.Text = "Create";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // tabStages
            // 
            this.tabStages.Controls.Add(this.tabAuth);
            this.tabStages.Controls.Add(this.tabCreate);
            this.tabStages.Controls.Add(this.tabSend);
            this.tabStages.Controls.Add(this.tabUpload);
            this.tabStages.Location = new System.Drawing.Point(12, 33);
            this.tabStages.Name = "tabStages";
            this.tabStages.SelectedIndex = 0;
            this.tabStages.Size = new System.Drawing.Size(540, 420);
            this.tabStages.TabIndex = 9;
            this.tabStages.Selected += new System.Windows.Forms.TabControlEventHandler(this.tabStages_Selected);
            // 
            // tabAuth
            // 
            this.tabAuth.Controls.Add(this.txbUser);
            this.tabAuth.Controls.Add(this.lblUser);
            this.tabAuth.Controls.Add(this.btnLogout);
            this.tabAuth.Controls.Add(this.txbPassword);
            this.tabAuth.Controls.Add(this.lblPassword);
            this.tabAuth.Controls.Add(this.btnLogin);
            this.tabAuth.Location = new System.Drawing.Point(4, 22);
            this.tabAuth.Name = "tabAuth";
            this.tabAuth.Padding = new System.Windows.Forms.Padding(3);
            this.tabAuth.Size = new System.Drawing.Size(532, 394);
            this.tabAuth.TabIndex = 0;
            this.tabAuth.Text = "Login/Logout";
            this.tabAuth.UseVisualStyleBackColor = true;
            // 
            // tabCreate
            // 
            this.tabCreate.Controls.Add(this.lbxTemplates);
            this.tabCreate.Controls.Add(this.btnCreate);
            this.tabCreate.Location = new System.Drawing.Point(4, 22);
            this.tabCreate.Name = "tabCreate";
            this.tabCreate.Padding = new System.Windows.Forms.Padding(3);
            this.tabCreate.Size = new System.Drawing.Size(532, 394);
            this.tabCreate.TabIndex = 1;
            this.tabCreate.Text = "Create";
            this.tabCreate.UseVisualStyleBackColor = true;
            this.tabCreate.MouseClick += new System.Windows.Forms.MouseEventHandler(this.tabCreate_MouseClick);
            // 
            // lbxTemplates
            // 
            this.lbxTemplates.FormattingEnabled = true;
            this.lbxTemplates.Location = new System.Drawing.Point(23, 7);
            this.lbxTemplates.Name = "lbxTemplates";
            this.lbxTemplates.Size = new System.Drawing.Size(120, 30);
            this.lbxTemplates.TabIndex = 9;
            this.lbxTemplates.MouseClick += new System.Windows.Forms.MouseEventHandler(this.lbxTemplates_MouseClick);
            // 
            // tabSend
            // 
            this.tabSend.Controls.Add(this.groupBox3);
            this.tabSend.Controls.Add(this.groupBox2);
            this.tabSend.Controls.Add(this.groupBox1);
            this.tabSend.Controls.Add(this.btnSend);
            this.tabSend.Controls.Add(this.label5);
            this.tabSend.Controls.Add(this.lbxTimers);
            this.tabSend.Controls.Add(this.label3);
            this.tabSend.Controls.Add(this.lbxDevices);
            this.tabSend.Controls.Add(this.label2);
            this.tabSend.Controls.Add(this.lbxImages);
            this.tabSend.Location = new System.Drawing.Point(4, 22);
            this.tabSend.Name = "tabSend";
            this.tabSend.Size = new System.Drawing.Size(532, 394);
            this.tabSend.TabIndex = 2;
            this.tabSend.Text = "Send";
            this.tabSend.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lblTimerID);
            this.groupBox3.Controls.Add(this.label18);
            this.groupBox3.Controls.Add(this.lblTimerName);
            this.groupBox3.Controls.Add(this.label14);
            this.groupBox3.Location = new System.Drawing.Point(312, 223);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(199, 95);
            this.groupBox3.TabIndex = 11;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Timer Properties";
            this.groupBox3.Enter += new System.EventHandler(this.groupBox3_Enter);
            // 
            // lblTimerID
            // 
            this.lblTimerID.AutoSize = true;
            this.lblTimerID.Location = new System.Drawing.Point(72, 29);
            this.lblTimerID.Name = "lblTimerID";
            this.lblTimerID.Size = new System.Drawing.Size(0, 13);
            this.lblTimerID.TabIndex = 15;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(12, 29);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(18, 13);
            this.label18.TabIndex = 14;
            this.label18.Text = "ID";
            // 
            // lblTimerName
            // 
            this.lblTimerName.AutoSize = true;
            this.lblTimerName.Location = new System.Drawing.Point(72, 16);
            this.lblTimerName.Name = "lblTimerName";
            this.lblTimerName.Size = new System.Drawing.Size(0, 13);
            this.lblTimerName.TabIndex = 13;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(12, 16);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(35, 13);
            this.label14.TabIndex = 12;
            this.label14.Text = "Name";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblTimer);
            this.groupBox2.Controls.Add(this.label17);
            this.groupBox2.Controls.Add(this.lblTimeZone);
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Controls.Add(this.lblDeviceLocaton);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.lblDeviceID);
            this.groupBox2.Controls.Add(this.lblDeviceType);
            this.groupBox2.Controls.Add(this.lb);
            this.groupBox2.Controls.Add(this.lblDeviceName);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Location = new System.Drawing.Point(312, 122);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 95);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Device Properties";
            // 
            // lblTimer
            // 
            this.lblTimer.AutoSize = true;
            this.lblTimer.Location = new System.Drawing.Point(72, 68);
            this.lblTimer.Name = "lblTimer";
            this.lblTimer.Size = new System.Drawing.Size(0, 13);
            this.lblTimer.TabIndex = 17;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(12, 68);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(33, 13);
            this.label17.TabIndex = 16;
            this.label17.Text = "Timer";
            // 
            // lblTimeZone
            // 
            this.lblTimeZone.AutoSize = true;
            this.lblTimeZone.Location = new System.Drawing.Point(72, 55);
            this.lblTimeZone.Name = "lblTimeZone";
            this.lblTimeZone.Size = new System.Drawing.Size(0, 13);
            this.lblTimeZone.TabIndex = 15;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(12, 55);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(55, 13);
            this.label15.TabIndex = 14;
            this.label15.Text = "TimeZone";
            // 
            // lblDeviceLocaton
            // 
            this.lblDeviceLocaton.AutoEllipsis = true;
            this.lblDeviceLocaton.Location = new System.Drawing.Point(72, 42);
            this.lblDeviceLocaton.Name = "lblDeviceLocaton";
            this.lblDeviceLocaton.Size = new System.Drawing.Size(120, 13);
            this.lblDeviceLocaton.TabIndex = 13;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(12, 42);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(48, 13);
            this.label13.TabIndex = 12;
            this.label13.Text = "Location";
            // 
            // lblDeviceID
            // 
            this.lblDeviceID.AutoSize = true;
            this.lblDeviceID.Location = new System.Drawing.Point(72, 79);
            this.lblDeviceID.Name = "lblDeviceID";
            this.lblDeviceID.Size = new System.Drawing.Size(0, 13);
            this.lblDeviceID.TabIndex = 11;
            // 
            // lblDeviceType
            // 
            this.lblDeviceType.AutoSize = true;
            this.lblDeviceType.Location = new System.Drawing.Point(72, 29);
            this.lblDeviceType.Name = "lblDeviceType";
            this.lblDeviceType.Size = new System.Drawing.Size(0, 13);
            this.lblDeviceType.TabIndex = 11;
            // 
            // lb
            // 
            this.lb.AutoSize = true;
            this.lb.Location = new System.Drawing.Point(12, 79);
            this.lb.Name = "lb";
            this.lb.Size = new System.Drawing.Size(18, 13);
            this.lb.TabIndex = 10;
            this.lb.Text = "ID";
            // 
            // lblDeviceName
            // 
            this.lblDeviceName.AutoSize = true;
            this.lblDeviceName.Location = new System.Drawing.Point(72, 16);
            this.lblDeviceName.Name = "lblDeviceName";
            this.lblDeviceName.Size = new System.Drawing.Size(0, 13);
            this.lblDeviceName.TabIndex = 11;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(12, 29);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(31, 13);
            this.label12.TabIndex = 10;
            this.label12.Text = "Type";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(12, 16);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(35, 13);
            this.label11.TabIndex = 10;
            this.label11.Text = "Name";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblExpires);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.lblName);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.lblID);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.lblHeight);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.lblWidth);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(312, 16);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(199, 95);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Image Properties";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // lblExpires
            // 
            this.lblExpires.AutoSize = true;
            this.lblExpires.Location = new System.Drawing.Point(66, 55);
            this.lblExpires.Name = "lblExpires";
            this.lblExpires.Size = new System.Drawing.Size(0, 13);
            this.lblExpires.TabIndex = 9;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 55);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(41, 13);
            this.label10.TabIndex = 8;
            this.label10.Text = "Expires";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(66, 16);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(0, 13);
            this.lblName.TabIndex = 7;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 16);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(35, 13);
            this.label8.TabIndex = 6;
            this.label8.Text = "Name";
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(66, 67);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(0, 13);
            this.lblID.TabIndex = 5;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 67);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(18, 13);
            this.label9.TabIndex = 4;
            this.label9.Text = "ID";
            // 
            // lblHeight
            // 
            this.lblHeight.AutoSize = true;
            this.lblHeight.Location = new System.Drawing.Point(66, 42);
            this.lblHeight.Name = "lblHeight";
            this.lblHeight.Size = new System.Drawing.Size(0, 13);
            this.lblHeight.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 42);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(38, 13);
            this.label7.TabIndex = 2;
            this.label7.Text = "Height";
            // 
            // lblWidth
            // 
            this.lblWidth.AutoSize = true;
            this.lblWidth.Location = new System.Drawing.Point(66, 29);
            this.lblWidth.Name = "lblWidth";
            this.lblWidth.Size = new System.Drawing.Size(0, 13);
            this.lblWidth.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 29);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Width";
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(321, 333);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(75, 23);
            this.btnSend.TabIndex = 8;
            this.btnSend.Text = "Send";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(48, 223);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Timers";
            // 
            // lbxTimers
            // 
            this.lbxTimers.FormattingEnabled = true;
            this.lbxTimers.Location = new System.Drawing.Point(111, 223);
            this.lbxTimers.Name = "lbxTimers";
            this.lbxTimers.Size = new System.Drawing.Size(132, 95);
            this.lbxTimers.TabIndex = 6;
            this.lbxTimers.Click += new System.EventHandler(this.lbxTimers_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(48, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Devices";
            // 
            // lbxDevices
            // 
            this.lbxDevices.FormattingEnabled = true;
            this.lbxDevices.Location = new System.Drawing.Point(111, 122);
            this.lbxDevices.Name = "lbxDevices";
            this.lbxDevices.Size = new System.Drawing.Size(132, 95);
            this.lbxDevices.TabIndex = 2;
            this.lbxDevices.MouseClick += new System.Windows.Forms.MouseEventHandler(this.lbxDevices_MouseClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(48, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Images";
            // 
            // lbxImages
            // 
            this.lbxImages.FormattingEnabled = true;
            this.lbxImages.Location = new System.Drawing.Point(111, 16);
            this.lbxImages.Name = "lbxImages";
            this.lbxImages.Size = new System.Drawing.Size(182, 95);
            this.lbxImages.TabIndex = 0;
            this.lbxImages.Click += new System.EventHandler(this.lbxImages_Click);
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(114, 410);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(0, 13);
            this.lblStatus.TabIndex = 9;
            // 
            // txbURL
            // 
            this.txbURL.Location = new System.Drawing.Point(96, 9);
            this.txbURL.Name = "txbURL";
            this.txbURL.Size = new System.Drawing.Size(384, 20);
            this.txbURL.TabIndex = 10;
            this.txbURL.Text = "https://portal.densipaper.com";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(55, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Address";
            // 
            // tabUpload
            // 
            this.tabUpload.Location = new System.Drawing.Point(4, 22);
            this.tabUpload.Name = "tabUpload";
            this.tabUpload.Padding = new System.Windows.Forms.Padding(3);
            this.tabUpload.Size = new System.Drawing.Size(532, 394);
            this.tabUpload.TabIndex = 3;
            this.tabUpload.Text = "Upload Image";
            this.tabUpload.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(604, 490);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txbURL);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.tabStages);
            this.Name = "Form1";
            this.Text = "DensiPaper API";
            this.tabStages.ResumeLayout(false);
            this.tabAuth.ResumeLayout(false);
            this.tabAuth.PerformLayout();
            this.tabCreate.ResumeLayout(false);
            this.tabSend.ResumeLayout(false);
            this.tabSend.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.TextBox txbUser;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txbPassword;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.TabControl tabStages;
        private System.Windows.Forms.TabPage tabAuth;
        private System.Windows.Forms.TabPage tabCreate;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.TextBox txbURL;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lbxTemplates;
        private System.Windows.Forms.TabPage tabSend;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListBox lbxTimers;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox lbxDevices;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox lbxImages;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblWidth;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblHeight;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblExpires;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblDeviceName;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lblDeviceID;
        private System.Windows.Forms.Label lblDeviceType;
        private System.Windows.Forms.Label lb;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lblTimer;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label lblTimeZone;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label lblDeviceLocaton;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label lblTimerID;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label lblTimerName;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TabPage tabUpload;
    }
}

