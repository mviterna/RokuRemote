using System;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Http;

namespace RokuRemote
{
    public partial class AppWindow : Form

    {
        private static readonly HttpClient client = new HttpClient();
        public AppWindow()
        {
            InitializeComponent();
            this.CenterToScreen();

            // Ensure the form receives key events before controls for keyboard shortcuts
            this.KeyPreview = true;

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

        private void optionsBtn_Click(object sender, EventArgs e)
        {
            string ip = textBox1.Text;
            string func = "http://" + ip + ":8060/keypress/Info";
            this.send_request(func);
        }

        private void helpBtn_Click(object sender, EventArgs e)
        {
            string shortcuts =
                "Keyboard Shortcuts:\n" +
                "--------------------------\n" +
                "Up/Down/Left/Right : Navigation\n" +
                "Enter              : Select\n" +
                "Backspace          : Back\n" +
                "- (minus)          : Volume Down\n" +
                "+ (plus)           : Volume Up\n" +
                "0 (zero)           : Mute\n" +
                "* (asterisk)       : Options\n";
            MessageBox.Show(shortcuts, "Roku Remote Shortcuts", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // Keyboard shortcut handling for navigation and volume
        // Arrow keys: Up/Down/Left/Right
        // Enter: Select
        // Backspace: Back
        // - (minus): Volume Down
        // + (plus): Volume Up
        // 0: Mute
        // * (asterisk): Options
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            string ip = textBox1.Text;
            string func;
            switch (keyData)
            {
                case Keys.Left: // left arrow key
                    func = "http://" + ip + ":8060/keypress/Left";
                    this.send_request(func);
                    return true;

                case Keys.Right: // right arrow key
                    func = "http://" + ip + ":8060/keypress/Right";
                    this.send_request(func);
                    return true;

                case Keys.Up: // up arrow key
                    func = "http://" + ip + ":8060/keypress/Up";
                    this.send_request(func);
                    return true;

                case Keys.Down: // down arrow key
                    func = "http://" + ip + ":8060/keypress/Down";
                    this.send_request(func);
                    return true;

                case Keys.Enter: // enter
                    func = "http://" + ip + ":8060/keypress/Select";
                    this.send_request(func);
                    return true;

                case Keys.Back: // backspace
                    func = "http://" + ip + ":8060/keypress/Back";
                    this.send_request(func);
                    return true;

                case Keys.OemMinus: // minus button
                    func = "http://" + ip + ":8060/keypress/VolumeDown";
                    this.send_request(func);
                    return true;

                case Keys.Oemplus: // plus button
                    func = "http://" + ip + ":8060/keypress/VolumeUp";
                    this.send_request(func);
                    return true;

                case Keys.D0: // zero button
                    func = "http://" + ip + ":8060/keypress/VolumeMute";
                    this.send_request(func);
                    return true;

                case Keys.Multiply: // * (asterisk) key
                    func = "http://" + ip + ":8060/keypress/Info";
                    this.send_request(func);
                    return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }
    }
}
