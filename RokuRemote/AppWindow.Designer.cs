namespace RokuRemote
{
    partial class AppWindow
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
            this.SystemTrayIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.home = new System.Windows.Forms.Button();
            this.volUp = new System.Windows.Forms.Button();
            this.volDown = new System.Windows.Forms.Button();
            this.mute = new System.Windows.Forms.Button();
            this.upNav = new System.Windows.Forms.Button();
            this.downNav = new System.Windows.Forms.Button();
            this.rightNav = new System.Windows.Forms.Button();
            this.leftNav = new System.Windows.Forms.Button();
            this.backNav = new System.Windows.Forms.Button();
            this.playBtn = new System.Windows.Forms.Button();
            this.enterBtn = new System.Windows.Forms.Button();
            this.pwrBtn = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // SystemTrayIcon
            // 
            this.SystemTrayIcon.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.SystemTrayIcon.Visible = true;
            this.SystemTrayIcon.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.SystemTrayIconDoubleClick);
            // 
            // home
            // 
            this.home.Location = new System.Drawing.Point(0, 0);
            this.home.Name = "home";
            this.home.Size = new System.Drawing.Size(78, 43);
            this.home.TabIndex = 0;
            this.home.TabStop = false;
            this.home.Text = "Home";
            this.home.UseVisualStyleBackColor = true;
            this.home.Click += new System.EventHandler(this.home_Click);
            // 
            // volUp
            // 
            this.volUp.Location = new System.Drawing.Point(0, 80);
            this.volUp.Name = "volUp";
            this.volUp.Size = new System.Drawing.Size(102, 45);
            this.volUp.TabIndex = 1;
            this.volUp.TabStop = false;
            this.volUp.Text = "Volume Up";
            this.volUp.UseVisualStyleBackColor = true;
            this.volUp.Click += new System.EventHandler(this.volUp_Click);
            // 
            // volDown
            // 
            this.volDown.Location = new System.Drawing.Point(0, 131);
            this.volDown.Name = "volDown";
            this.volDown.Size = new System.Drawing.Size(102, 45);
            this.volDown.TabIndex = 2;
            this.volDown.TabStop = false;
            this.volDown.Text = "Volume Down";
            this.volDown.UseVisualStyleBackColor = true;
            this.volDown.Click += new System.EventHandler(this.volDown_Click);
            // 
            // mute
            // 
            this.mute.Location = new System.Drawing.Point(108, 80);
            this.mute.Name = "mute";
            this.mute.Size = new System.Drawing.Size(90, 45);
            this.mute.TabIndex = 3;
            this.mute.TabStop = false;
            this.mute.Text = "Mute";
            this.mute.UseVisualStyleBackColor = true;
            this.mute.Click += new System.EventHandler(this.mute_Click);
            // 
            // upNav
            // 
            this.upNav.Location = new System.Drawing.Point(63, 195);
            this.upNav.Name = "upNav";
            this.upNav.Size = new System.Drawing.Size(86, 42);
            this.upNav.TabIndex = 4;
            this.upNav.TabStop = false;
            this.upNav.Text = "Up";
            this.upNav.UseVisualStyleBackColor = true;
            this.upNav.Click += new System.EventHandler(this.upNav_Click);
            // 
            // downNav
            // 
            this.downNav.Location = new System.Drawing.Point(63, 284);
            this.downNav.Name = "downNav";
            this.downNav.Size = new System.Drawing.Size(86, 42);
            this.downNav.TabIndex = 5;
            this.downNav.TabStop = false;
            this.downNav.Text = "Down";
            this.downNav.UseVisualStyleBackColor = true;
            this.downNav.Click += new System.EventHandler(this.downNav_Click);
            // 
            // rightNav
            // 
            this.rightNav.Location = new System.Drawing.Point(152, 243);
            this.rightNav.Name = "rightNav";
            this.rightNav.Size = new System.Drawing.Size(59, 35);
            this.rightNav.TabIndex = 6;
            this.rightNav.TabStop = false;
            this.rightNav.Text = "Right";
            this.rightNav.UseVisualStyleBackColor = true;
            this.rightNav.Click += new System.EventHandler(this.rightNav_Click);
            // 
            // leftNav
            // 
            this.leftNav.Location = new System.Drawing.Point(0, 243);
            this.leftNav.Name = "leftNav";
            this.leftNav.Size = new System.Drawing.Size(64, 35);
            this.leftNav.TabIndex = 7;
            this.leftNav.TabStop = false;
            this.leftNav.Text = "Left";
            this.leftNav.UseVisualStyleBackColor = true;
            this.leftNav.Click += new System.EventHandler(this.leftNav_Click);
            // 
            // backNav
            // 
            this.backNav.Location = new System.Drawing.Point(78, 0);
            this.backNav.Name = "backNav";
            this.backNav.Size = new System.Drawing.Size(71, 43);
            this.backNav.TabIndex = 8;
            this.backNav.TabStop = false;
            this.backNav.Text = "Back";
            this.backNav.UseVisualStyleBackColor = true;
            this.backNav.Click += new System.EventHandler(this.backNav_Click);
            // 
            // playBtn
            // 
            this.playBtn.Location = new System.Drawing.Point(108, 131);
            this.playBtn.Name = "playBtn";
            this.playBtn.Size = new System.Drawing.Size(90, 45);
            this.playBtn.TabIndex = 9;
            this.playBtn.TabStop = false;
            this.playBtn.Text = "Play/Pause";
            this.playBtn.UseVisualStyleBackColor = true;
            this.playBtn.Click += new System.EventHandler(this.playBtn_Click);
            // 
            // enterBtn
            // 
            this.enterBtn.Location = new System.Drawing.Point(71, 249);
            this.enterBtn.Name = "enterBtn";
            this.enterBtn.Size = new System.Drawing.Size(75, 23);
            this.enterBtn.TabIndex = 10;
            this.enterBtn.TabStop = false;
            this.enterBtn.Text = "Enter";
            this.enterBtn.UseVisualStyleBackColor = true;
            this.enterBtn.Click += new System.EventHandler(this.enterBtn_Click);
            // 
            // pwrBtn
            // 
            this.pwrBtn.Location = new System.Drawing.Point(164, 8);
            this.pwrBtn.Name = "pwrBtn";
            this.pwrBtn.Size = new System.Drawing.Size(34, 27);
            this.pwrBtn.TabIndex = 11;
            this.pwrBtn.TabStop = false;
            this.pwrBtn.Text = "Pwr";
            this.pwrBtn.UseVisualStyleBackColor = true;
            this.pwrBtn.Click += new System.EventHandler(this.pwrBtn_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(30, 49);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(102, 20);
            this.textBox1.TabIndex = 1;
            this.textBox1.TabStop = false;
            // 
            // AppWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(210, 338);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.pwrBtn);
            this.Controls.Add(this.enterBtn);
            this.Controls.Add(this.playBtn);
            this.Controls.Add(this.backNav);
            this.Controls.Add(this.leftNav);
            this.Controls.Add(this.rightNav);
            this.Controls.Add(this.downNav);
            this.Controls.Add(this.upNav);
            this.Controls.Add(this.mute);
            this.Controls.Add(this.volDown);
            this.Controls.Add(this.volUp);
            this.Controls.Add(this.home);
            this.KeyPreview = true;
            this.Name = "AppWindow";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NotifyIcon SystemTrayIcon;
        private System.Windows.Forms.Button home;
        private System.Windows.Forms.Button volUp;
        private System.Windows.Forms.Button volDown;
        private System.Windows.Forms.Button mute;
        private System.Windows.Forms.Button upNav;
        private System.Windows.Forms.Button downNav;
        private System.Windows.Forms.Button rightNav;
        private System.Windows.Forms.Button leftNav;
        private System.Windows.Forms.Button backNav;
        private System.Windows.Forms.Button playBtn;
        private System.Windows.Forms.Button enterBtn;
        private System.Windows.Forms.Button pwrBtn;
        private System.Windows.Forms.TextBox textBox1;
    }
}

