using Beacon.Properties;
using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace Beacon
{
    public partial class mainFrm : Form
    {
        public mainFrm()
        {
            InitializeComponent();
        }
        bool running = false;
        private void broad_Click(object sender, EventArgs e)
        {
            string ssid;
            string key;
            int l = keyT.Text.Length;
            if (ssidT.Text == "")
            {
                MessageBox.Show("Please don't leave the SSID box empty.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ssidT.Text = "Beacon";
                return;
            }
            else
                ssid = ssidT.Text;
            if ((l > 0 && l < 8) || l > 64)
            {
                MessageBox.Show("The key, if set, has to be at least 8 but not more than 64 bytes.\n(NOTE: ASCII characters are 1 byte each).", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                keyT.Text = "beakey" + (new Random()).Next(1000, 9999);
                return;
            }
            else
                key = keyT.Text;
            try
            {
                ExecCommand(string.Format("/cnetsh wlan set hostednetwork ssid={0} key={1} mode=allow&netsh wlan start hostednetwork", ssid, key));
                running = true;
            }
            catch (Exception ex)
            { MessageBox.Show("Hardware error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); return; }
            halt.Enabled = haltContMen.Enabled = true;
            broad.Enabled = broadContMen.Enabled = false;
        }

        private void halt_Click(object sender, EventArgs e)
        {
            try
            {
                ExecCommand("/cnetsh wlan stop hostednetwork");
                running = false;
            }
            catch (Exception ex)
            { MessageBox.Show("Hardware error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); return; }
            halt.Enabled = haltContMen.Enabled = false;
            broad.Enabled = broadContMen.Enabled = true;
        }

        private static void ExecCommand(string c)
        {
            Process p = new Process();
            p.StartInfo.FileName = "cmd.exe";
            p.StartInfo.Arguments = c;
            p.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
            p.Start();
        }

        private void ssidT_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                broad_Click(this, EventArgs.Empty);
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                e.Cancel = true;
                notiIco.Visible = true;
                ShowInTaskbar = false;
                Hide();
                notiIco.ShowBalloonTip(1000, "Psst", "I'm still here.\nYour network is " + (running ? "on." : "off."), ToolTipIcon.Info);                
            }
        }

        private void exit_btn_Click(object sender, EventArgs e)
        {
            if (hoe_cb.Checked)
                halt_Click(this, EventArgs.Empty);
            Settings.Default.HaltOnExit = hoe_cb.Checked;
            Settings.Default.Save();
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            hoe_cb.Checked = Settings.Default.HaltOnExit;
        }

        private void notiIco_Click(object sender, EventArgs e)
        {
        }

        private void notiIco_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ShowWnd();
            }
        }

        private void notiIco_BalloonTipClicked(object sender, EventArgs e)
        {
            ShowWnd();
        }

        private void ShowWnd()
        {
            notiIco.Visible = false;
            ShowInTaskbar = true;
            Show();
        }
    }
}