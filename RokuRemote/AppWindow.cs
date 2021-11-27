using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System;
using System.Net;
using System.IO;
using System.Net.Http;

namespace SystemTrayApp
{
    public partial class AppWindow : Form

    {
        private static readonly HttpClient client = new HttpClient();
        public AppWindow()
        {
            InitializeComponent();
            this.CenterToScreen();

            textBox1.Text = "192.168.1.100";

            // To provide your own custom icon image, go to:
            //   1. Project > Properties... > Resources
            //   2. Change the resource filter to icons
            //   3. Remove the Default resource and add your own
            //   4. Modify the next line to Properties.Resources.<YourResource>
            this.Icon = Properties.Resources.Default;
            this.SystemTrayIcon.Icon = Properties.Resources.Default;

            // Change the Text property to the name of your application
            this.SystemTrayIcon.Text = "Roku Remote";
            this.SystemTrayIcon.Visible = true;

            // Modify the right-click menu of your system tray icon here
            ContextMenu menu = new ContextMenu();
            menu.MenuItems.Add("Exit", ContextMenuExit);
            this.SystemTrayIcon.ContextMenu = menu;

            this.Resize += WindowResize;
            this.FormClosing += WindowClosing;
        }
        
        private void SystemTrayIconDoubleClick(object sender, MouseEventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
            this.Show();
            this.WindowState = FormWindowState.Normal;
        }

        private void ContextMenuExit(object sender, EventArgs e)
        {
            this.SystemTrayIcon.Visible = false;
            Application.Exit();
            Environment.Exit(0);
        }

        private void WindowResize(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)
            {
                this.Hide();
            }
        }

        private void WindowClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            this.Hide();
        }

        private async Task send_request(string func)
        {
            string ip = textBox1.Text;
            string sURL;
            sURL = func;
            var response = await client.PostAsync(sURL, null);

        }

        private void home_Click(object sender, EventArgs e)
        {
            string ip = textBox1.Text;
            string func = "http://" + ip + ":8060/keypress/home";
            this.send_request(func);
        }

        private void volUp_Click(object sender, EventArgs e)
        {
            string ip = textBox1.Text;
            string func = "http://" + ip + ":8060/keypress/VolumeUp";
            this.send_request(func);

        }

        private void volDown_Click(object sender, EventArgs e)
        {
            string ip = textBox1.Text;
            string func = "http://" + ip + ":8060/keypress/VolumeDown";
            this.send_request(func);
        }

        private void mute_Click(object sender, EventArgs e)
        {
            string ip = textBox1.Text;
            string func = "http://" + ip + ":8060/keypress/VolumeMute";
            this.send_request(func);
        }

        private void upNav_Click(object sender, EventArgs e)
        {
            string ip = textBox1.Text;
            string func = "http://" + ip + ":8060/keypress/Up";
            this.send_request(func);
        }

        private void leftNav_Click(object sender, EventArgs e)
        {
            string ip = textBox1.Text;
            string func = "http://" + ip + ":8060/keypress/Left";
            this.send_request(func);
        }

        private void rightNav_Click(object sender, EventArgs e)
        {
            string ip = textBox1.Text;
            string func = "http://" + ip + ":8060/keypress/Right";
            this.send_request(func);
        }

        private void downNav_Click(object sender, EventArgs e)
        {
            string ip = textBox1.Text;
            string func = "http://" + ip + ":8060/keypress/Down";
            this.send_request(func);
        }

        private void backNav_Click(object sender, EventArgs e)
        {
            string ip = textBox1.Text;
            string func = "http://" + ip + ":8060/keypress/Back";
            this.send_request(func);
        }

        private void playBtn_Click(object sender, EventArgs e)
        {
            string ip = textBox1.Text;
            string func = "http://" + ip + ":8060/keypress/Play";
            this.send_request(func);
        }

        private void enterBtn_Click(object sender, EventArgs e)
        {
            string ip = textBox1.Text;
            string func = "http://" + ip + ":8060/keypress/Select";
            this.send_request(func);
        }

        private void pwrBtn_Click(object sender, EventArgs e)
        {
            string ip = textBox1.Text;
            string func = "http://" + ip +  ":8060/keypress/Power";
            this.send_request(func);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
