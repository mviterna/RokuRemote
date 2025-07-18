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
        /// <param name="disposing">true if managed resources should be disposed; otherwise false.</param>
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
            this.helpBtn = new System.Windows.Forms.Button();
            this.optionsBtn = new System.Windows.Forms.Button();
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
            this.home.Location = new System.Drawing.Point(19, 0);
            this.home.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.home.Name = "home";
            this.home.Size = new System.Drawing.Size(117, 66);
            this.home.TabIndex = 0;
            this.home.TabStop = false;
            this.home.Text = "Home";
            this.home.UseVisualStyleBackColor = true;
            this.home.Click += new System.EventHandler(this.home_Click);
            // 
            // volUp
            // 
            this.volUp.Location = new System.Drawing.Point(13, 123);
            this.volUp.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.volUp.Name = "volUp";
            this.volUp.Size = new System.Drawing.Size(153, 69);
            this.volUp.TabIndex = 1;
            this.volUp.TabStop = false;
            this.volUp.Text = "Volume Up";
            this.volUp.UseVisualStyleBackColor = true;
            this.volUp.Click += new System.EventHandler(this.volUp_Click);
            // 
            // volDown
            // 
            this.volDown.Location = new System.Drawing.Point(18, 202);
            this.volDown.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.volDown.Name = "volDown";
            this.volDown.Size = new System.Drawing.Size(153, 69);
            this.volDown.TabIndex = 2;
            this.volDown.TabStop = false;
            this.volDown.Text = "Volume Down";
            this.volDown.UseVisualStyleBackColor = true;
            this.volDown.Click += new System.EventHandler(this.volDown_Click);
            // 
            // mute
            // 
            this.mute.Location = new System.Drawing.Point(179, 123);
            this.mute.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.mute.Name = "mute";
            this.mute.Size = new System.Drawing.Size(135, 69);
            this.mute.TabIndex = 3;
            this.mute.TabStop = false;
            this.mute.Text = "Mute";
            this.mute.UseVisualStyleBackColor = true;
            this.mute.Click += new System.EventHandler(this.mute_Click);
            // 
            // upNav
            // 
            this.upNav.Location = new System.Drawing.Point(111, 281);
            this.upNav.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.upNav.Name = "upNav";
            this.upNav.Size = new System.Drawing.Size(129, 55);
            this.upNav.TabIndex = 4;
            this.upNav.TabStop = false;
            this.upNav.Text = "Up";
            this.upNav.UseVisualStyleBackColor = true;
            this.upNav.Click += new System.EventHandler(this.upNav_Click);
            // 
            // downNav
            // 
            this.downNav.Location = new System.Drawing.Point(111, 410);
            this.downNav.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.downNav.Name = "downNav";
            this.downNav.Size = new System.Drawing.Size(129, 50);
            this.downNav.TabIndex = 5;
            this.downNav.TabStop = false;
            this.downNav.Text = "Down";
            this.downNav.UseVisualStyleBackColor = true;
            this.downNav.Click += new System.EventHandler(this.downNav_Click);
            // 
            // rightNav
            // 
            this.rightNav.Location = new System.Drawing.Point(237, 346);
            this.rightNav.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rightNav.Name = "rightNav";
            this.rightNav.Size = new System.Drawing.Size(88, 54);
            this.rightNav.TabIndex = 6;
            this.rightNav.TabStop = false;
            this.rightNav.Text = "Right";
            this.rightNav.UseVisualStyleBackColor = true;
            this.rightNav.Click += new System.EventHandler(this.rightNav_Click);
            // 
            // leftNav
            // 
            this.leftNav.Location = new System.Drawing.Point(13, 346);
            this.leftNav.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.leftNav.Name = "leftNav";
            this.leftNav.Size = new System.Drawing.Size(96, 54);
            this.leftNav.TabIndex = 7;
            this.leftNav.TabStop = false;
            this.leftNav.Text = "Left";
            this.leftNav.UseVisualStyleBackColor = true;
            this.leftNav.Click += new System.EventHandler(this.leftNav_Click);
            // 
            // backNav
            // 
            this.backNav.Location = new System.Drawing.Point(144, -1);
            this.backNav.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.backNav.Name = "backNav";
            this.backNav.Size = new System.Drawing.Size(106, 66);
            this.backNav.TabIndex = 8;
            this.backNav.TabStop = false;
            this.backNav.Text = "Back";
            this.backNav.UseVisualStyleBackColor = true;
            this.backNav.Click += new System.EventHandler(this.backNav_Click);
            // 
            // playBtn
            // 
            this.playBtn.Location = new System.Drawing.Point(179, 202);
            this.playBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.playBtn.Name = "playBtn";
            this.playBtn.Size = new System.Drawing.Size(135, 69);
            this.playBtn.TabIndex = 9;
            this.playBtn.TabStop = false;
            this.playBtn.Text = "Play/Pause";
            this.playBtn.UseVisualStyleBackColor = true;
            this.playBtn.Click += new System.EventHandler(this.playBtn_Click);
            // 
            // enterBtn
            // 
            this.enterBtn.Location = new System.Drawing.Point(117, 356);
            this.enterBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.enterBtn.Name = "enterBtn";
            this.enterBtn.Size = new System.Drawing.Size(112, 35);
            this.enterBtn.TabIndex = 10;
            this.enterBtn.TabStop = false;
            this.enterBtn.Text = "Enter";
            this.enterBtn.UseVisualStyleBackColor = true;
            this.enterBtn.Click += new System.EventHandler(this.enterBtn_Click);
            // 
            // pwrBtn
            // 
            this.pwrBtn.Location = new System.Drawing.Point(258, 0);
            this.pwrBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pwrBtn.Name = "pwrBtn";
            this.pwrBtn.Size = new System.Drawing.Size(56, 42);
            this.pwrBtn.TabIndex = 11;
            this.pwrBtn.TabStop = false;
            this.pwrBtn.Text = "Pwr";
            this.pwrBtn.UseVisualStyleBackColor = true;
            this.pwrBtn.Click += new System.EventHandler(this.pwrBtn_Click);
            // 
            // helpBtn
            // 
            this.helpBtn.Location = new System.Drawing.Point(258, 52);
            this.helpBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.helpBtn.Name = "helpBtn";
            this.helpBtn.Size = new System.Drawing.Size(56, 42);
            this.helpBtn.TabIndex = 12;
            this.helpBtn.TabStop = false;
            this.helpBtn.Text = "Help";
            this.helpBtn.UseVisualStyleBackColor = true;
            this.helpBtn.Click += new System.EventHandler(this.helpBtn_Click);
            // 
            // optionsBtn
            // 
            this.optionsBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.optionsBtn.Location = new System.Drawing.Point(258, 287);
            this.optionsBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.optionsBtn.Name = "optionsBtn";
            this.optionsBtn.Size = new System.Drawing.Size(56, 42);
            this.optionsBtn.TabIndex = 13;
            this.optionsBtn.TabStop = false;
            this.optionsBtn.Text = "*";
            this.optionsBtn.UseVisualStyleBackColor = true;
            this.optionsBtn.Click += new System.EventHandler(this.optionsBtn_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(67, 75);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(151, 26);
            this.textBox1.TabIndex = 1;
            this.textBox1.TabStop = false;
            // 
            // AppWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(337, 475);
            this.Controls.Add(this.optionsBtn);
            this.Controls.Add(this.helpBtn);
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
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
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
        private System.Windows.Forms.Button helpBtn;
        private System.Windows.Forms.Button optionsBtn;
        private System.Windows.Forms.TextBox textBox1;
    }
}

