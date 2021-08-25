namespace CureItImproved
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.SideBar = new System.Windows.Forms.Panel();
            this.detectBtn = new System.Windows.Forms.Button();
            this.copyright = new System.Windows.Forms.Label();
            this.creditsLabel = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dCount = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.appLogo = new System.Windows.Forms.PictureBox();
            this.header = new System.Windows.Forms.Panel();
            this.minimizeBtn = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.closeBtn = new System.Windows.Forms.PictureBox();
            this.mainContainer = new System.Windows.Forms.Panel();
            this.procStatus = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dSize = new System.Windows.Forms.Label();
            this.dName = new System.Windows.Forms.Label();
            this.UsedSpace = new CircularProgressBar.CircularProgressBar();
            this.freeSpace = new CircularProgressBar.CircularProgressBar();
            this.cureBtn = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.flashList = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SideBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.appLogo)).BeginInit();
            this.header.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.minimizeBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.closeBtn)).BeginInit();
            this.mainContainer.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // SideBar
            // 
            this.SideBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(221)))));
            this.SideBar.Controls.Add(this.detectBtn);
            this.SideBar.Controls.Add(this.copyright);
            this.SideBar.Controls.Add(this.creditsLabel);
            this.SideBar.Controls.Add(this.pictureBox2);
            this.SideBar.Controls.Add(this.label3);
            this.SideBar.Controls.Add(this.dCount);
            this.SideBar.Controls.Add(this.panel1);
            this.SideBar.Dock = System.Windows.Forms.DockStyle.Left;
            this.SideBar.Location = new System.Drawing.Point(0, 0);
            this.SideBar.Name = "SideBar";
            this.SideBar.Size = new System.Drawing.Size(137, 312);
            this.SideBar.TabIndex = 0;
            // 
            // detectBtn
            // 
            this.detectBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.detectBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.detectBtn.ForeColor = System.Drawing.Color.White;
            this.detectBtn.Image = global::CureItImproved.Properties.Resources.flash;
            this.detectBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.detectBtn.Location = new System.Drawing.Point(30, 212);
            this.detectBtn.Name = "detectBtn";
            this.detectBtn.Size = new System.Drawing.Size(75, 27);
            this.detectBtn.TabIndex = 7;
            this.detectBtn.Text = "   Detect";
            this.detectBtn.UseVisualStyleBackColor = true;
            this.detectBtn.Click += new System.EventHandler(this.DetectBtn_Click);
            // 
            // copyright
            // 
            this.copyright.AutoSize = true;
            this.copyright.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.copyright.ForeColor = System.Drawing.Color.White;
            this.copyright.Location = new System.Drawing.Point(5, 287);
            this.copyright.Name = "copyright";
            this.copyright.Size = new System.Drawing.Size(66, 15);
            this.copyright.TabIndex = 5;
            this.copyright.Text = "© 2017 CP";
            // 
            // creditsLabel
            // 
            this.creditsLabel.AutoSize = true;
            this.creditsLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.creditsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.creditsLabel.ForeColor = System.Drawing.Color.White;
            this.creditsLabel.Location = new System.Drawing.Point(5, 256);
            this.creditsLabel.Name = "creditsLabel";
            this.creditsLabel.Size = new System.Drawing.Size(50, 16);
            this.creditsLabel.TabIndex = 4;
            this.creditsLabel.Text = "Credits";
            this.creditsLabel.Click += new System.EventHandler(this.CreditsLabel_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::CureItImproved.Properties.Resources.minus;
            this.pictureBox2.Location = new System.Drawing.Point(5, 103);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(126, 27);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(12, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "Devices Detected";
            // 
            // dCount
            // 
            this.dCount.AutoSize = true;
            this.dCount.Font = new System.Drawing.Font("Calibri", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dCount.ForeColor = System.Drawing.Color.White;
            this.dCount.Location = new System.Drawing.Point(43, 150);
            this.dCount.Name = "dCount";
            this.dCount.Size = new System.Drawing.Size(49, 59);
            this.dCount.TabIndex = 1;
            this.dCount.Text = "0";
            this.dCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.appLogo);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(137, 113);
            this.panel1.TabIndex = 0;
            // 
            // appLogo
            // 
            this.appLogo.Image = global::CureItImproved.Properties.Resources.USB_Flash_Card;
            this.appLogo.Location = new System.Drawing.Point(19, 9);
            this.appLogo.Name = "appLogo";
            this.appLogo.Size = new System.Drawing.Size(96, 96);
            this.appLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.appLogo.TabIndex = 0;
            this.appLogo.TabStop = false;
            this.appLogo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.LogoMouseDown);
            // 
            // header
            // 
            this.header.BackColor = System.Drawing.SystemColors.Control;
            this.header.Controls.Add(this.minimizeBtn);
            this.header.Controls.Add(this.label1);
            this.header.Controls.Add(this.closeBtn);
            this.header.Dock = System.Windows.Forms.DockStyle.Top;
            this.header.Location = new System.Drawing.Point(137, 0);
            this.header.Name = "header";
            this.header.Size = new System.Drawing.Size(314, 41);
            this.header.TabIndex = 1;
            this.header.MouseDown += new System.Windows.Forms.MouseEventHandler(this.HeaderMouseDown);
            // 
            // minimizeBtn
            // 
            this.minimizeBtn.Image = global::CureItImproved.Properties.Resources.substract;
            this.minimizeBtn.Location = new System.Drawing.Point(243, 17);
            this.minimizeBtn.Name = "minimizeBtn";
            this.minimizeBtn.Size = new System.Drawing.Size(34, 20);
            this.minimizeBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.minimizeBtn.TabIndex = 2;
            this.minimizeBtn.TabStop = false;
            this.minimizeBtn.Click += new System.EventHandler(this.MinimizeBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.label1.Location = new System.Drawing.Point(6, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "Cure It! USB Healer";
            this.label1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TopLableMouseDown);
            // 
            // closeBtn
            // 
            this.closeBtn.Image = global::CureItImproved.Properties.Resources.cancel;
            this.closeBtn.Location = new System.Drawing.Point(285, 9);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(24, 26);
            this.closeBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.closeBtn.TabIndex = 0;
            this.closeBtn.TabStop = false;
            this.closeBtn.Click += new System.EventHandler(this.CloseBtn_Click);
            // 
            // mainContainer
            // 
            this.mainContainer.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.mainContainer.Controls.Add(this.procStatus);
            this.mainContainer.Controls.Add(this.groupBox1);
            this.mainContainer.Controls.Add(this.cureBtn);
            this.mainContainer.Controls.Add(this.panel2);
            this.mainContainer.Controls.Add(this.flashList);
            this.mainContainer.Controls.Add(this.label4);
            this.mainContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainContainer.Location = new System.Drawing.Point(137, 41);
            this.mainContainer.Name = "mainContainer";
            this.mainContainer.Size = new System.Drawing.Size(314, 271);
            this.mainContainer.TabIndex = 2;
            // 
            // procStatus
            // 
            this.procStatus.AutoSize = true;
            this.procStatus.ForeColor = System.Drawing.Color.Blue;
            this.procStatus.Location = new System.Drawing.Point(195, 48);
            this.procStatus.Name = "procStatus";
            this.procStatus.Size = new System.Drawing.Size(0, 13);
            this.procStatus.TabIndex = 8;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dSize);
            this.groupBox1.Controls.Add(this.dName);
            this.groupBox1.Controls.Add(this.UsedSpace);
            this.groupBox1.Controls.Add(this.freeSpace);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(11, 74);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(291, 120);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Device Info";
            // 
            // dSize
            // 
            this.dSize.AutoSize = true;
            this.dSize.Location = new System.Drawing.Point(2, 51);
            this.dSize.Name = "dSize";
            this.dSize.Size = new System.Drawing.Size(0, 15);
            this.dSize.TabIndex = 8;
            // 
            // dName
            // 
            this.dName.AutoSize = true;
            this.dName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dName.Location = new System.Drawing.Point(2, 21);
            this.dName.Name = "dName";
            this.dName.Size = new System.Drawing.Size(0, 15);
            this.dName.TabIndex = 6;
            // 
            // UsedSpace
            // 
            this.UsedSpace.AnimationFunction = ((WinFormAnimation.AnimationFunctions.Function)(resources.GetObject("UsedSpace.AnimationFunction")));
            this.UsedSpace.AnimationSpeed = 500;
            this.UsedSpace.BackColor = System.Drawing.Color.Transparent;
            this.UsedSpace.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UsedSpace.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.UsedSpace.InnerColor = System.Drawing.Color.White;
            this.UsedSpace.InnerMargin = 2;
            this.UsedSpace.InnerWidth = -1;
            this.UsedSpace.Location = new System.Drawing.Point(187, 17);
            this.UsedSpace.MarqueeAnimationSpeed = 2000;
            this.UsedSpace.Name = "UsedSpace";
            this.UsedSpace.OuterColor = System.Drawing.Color.LightGray;
            this.UsedSpace.OuterMargin = -25;
            this.UsedSpace.OuterWidth = 26;
            this.UsedSpace.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.UsedSpace.ProgressWidth = 5;
            this.UsedSpace.SecondaryFont = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UsedSpace.Size = new System.Drawing.Size(98, 92);
            this.UsedSpace.StartAngle = 270;
            this.UsedSpace.SubscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.UsedSpace.SubscriptMargin = new System.Windows.Forms.Padding(10, -35, 0, 0);
            this.UsedSpace.SubscriptText = "";
            this.UsedSpace.SuperscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.UsedSpace.SuperscriptMargin = new System.Windows.Forms.Padding(-30, 35, 0, 0);
            this.UsedSpace.SuperscriptText = "12GB";
            this.UsedSpace.TabIndex = 5;
            this.UsedSpace.Text = "Used Space";
            this.UsedSpace.TextMargin = new System.Windows.Forms.Padding(8, -3, 0, 0);
            this.UsedSpace.Value = 68;
            // 
            // freeSpace
            // 
            this.freeSpace.AnimationFunction = ((WinFormAnimation.AnimationFunctions.Function)(resources.GetObject("freeSpace.AnimationFunction")));
            this.freeSpace.AnimationSpeed = 500;
            this.freeSpace.BackColor = System.Drawing.Color.Transparent;
            this.freeSpace.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.freeSpace.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.freeSpace.InnerColor = System.Drawing.Color.White;
            this.freeSpace.InnerMargin = 0;
            this.freeSpace.InnerWidth = 0;
            this.freeSpace.Location = new System.Drawing.Point(86, 17);
            this.freeSpace.MarqueeAnimationSpeed = 2000;
            this.freeSpace.Name = "freeSpace";
            this.freeSpace.OuterColor = System.Drawing.Color.LightGray;
            this.freeSpace.OuterMargin = -25;
            this.freeSpace.OuterWidth = 26;
            this.freeSpace.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(221)))));
            this.freeSpace.ProgressWidth = 5;
            this.freeSpace.SecondaryFont = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.freeSpace.Size = new System.Drawing.Size(98, 92);
            this.freeSpace.StartAngle = 270;
            this.freeSpace.SubscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.freeSpace.SubscriptMargin = new System.Windows.Forms.Padding(10, -35, 0, 0);
            this.freeSpace.SubscriptText = "";
            this.freeSpace.SuperscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(221)))));
            this.freeSpace.SuperscriptMargin = new System.Windows.Forms.Padding(-30, 35, 0, 0);
            this.freeSpace.SuperscriptText = "20GB";
            this.freeSpace.TabIndex = 4;
            this.freeSpace.Text = "Free Space";
            this.freeSpace.TextMargin = new System.Windows.Forms.Padding(8, -3, 0, 0);
            this.freeSpace.Value = 68;
            // 
            // cureBtn
            // 
            this.cureBtn.BackColor = System.Drawing.Color.Green;
            this.cureBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cureBtn.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cureBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.cureBtn.Image = global::CureItImproved.Properties.Resources.tool1;
            this.cureBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cureBtn.Location = new System.Drawing.Point(95, 39);
            this.cureBtn.Name = "cureBtn";
            this.cureBtn.Size = new System.Drawing.Size(91, 30);
            this.cureBtn.TabIndex = 3;
            this.cureBtn.Text = "     Cure It!";
            this.cureBtn.UseVisualStyleBackColor = false;
            this.cureBtn.Click += new System.EventHandler(this.CureBtn_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.pictureBox3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 182);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(314, 89);
            this.panel2.TabIndex = 2;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox3.Image = global::CureItImproved.Properties.Resources.blue_curves___Copy;
            this.pictureBox3.Location = new System.Drawing.Point(0, 0);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(314, 89);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 0;
            this.pictureBox3.TabStop = false;
            // 
            // flashList
            // 
            this.flashList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.flashList.FormattingEnabled = true;
            this.flashList.Location = new System.Drawing.Point(97, 12);
            this.flashList.Name = "flashList";
            this.flashList.Size = new System.Drawing.Size(196, 21);
            this.flashList.TabIndex = 1;
            this.flashList.SelectedIndexChanged += new System.EventHandler(this.DriveSelected);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label4.Location = new System.Drawing.Point(8, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 18);
            this.label4.TabIndex = 0;
            this.label4.Text = "Select Drive:";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(451, 312);
            this.Controls.Add(this.mainContainer);
            this.Controls.Add(this.header);
            this.Controls.Add(this.SideBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CureIt! USB Healer";
            this.Load += new System.EventHandler(this.OnAppLoad);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.OnMouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.FormDrag);
            this.SideBar.ResumeLayout(false);
            this.SideBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.appLogo)).EndInit();
            this.header.ResumeLayout(false);
            this.header.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.minimizeBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.closeBtn)).EndInit();
            this.mainContainer.ResumeLayout(false);
            this.mainContainer.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel SideBar;
        private System.Windows.Forms.Panel header;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox appLogo;
        private System.Windows.Forms.PictureBox closeBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox minimizeBtn;
        private System.Windows.Forms.Label dCount;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel mainContainer;
        private System.Windows.Forms.ComboBox flashList;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Button cureBtn;
        private CircularProgressBar.CircularProgressBar UsedSpace;
        private CircularProgressBar.CircularProgressBar freeSpace;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label dSize;
        private System.Windows.Forms.Label dName;
        private System.Windows.Forms.Label procStatus;
        private System.Windows.Forms.Label creditsLabel;
        private System.Windows.Forms.Label copyright;
        private System.Windows.Forms.Button detectBtn;
    }
}

