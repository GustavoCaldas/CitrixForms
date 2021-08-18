using Microsoft.Win32;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace SetupVerifyCS
{
    public partial class CheckSetup : Form
    {
        public CheckSetup()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // When button is clicked
            string registry_key = @"SOFTWARE\Microsoft\Windows\CurrentVersion\Uninstall";
            string registry64_key = @"SOFTWARE\WOW6432Node\Microsoft\Windows\CurrentVersion\Uninstall";

            RegistryKey key = Registry.LocalMachine.OpenSubKey(registry_key);
            RegistryKey key64 = Registry.LocalMachine.OpenSubKey(registry64_key);

            string[] software = null;

            Helper helper = new Helper(key, key64, software);
            helper.FindRequiredSoftwares();

            checkBox1.Checked = helper.HasCitrix;
            checkBox2.Checked = helper.HasIDGo800Driver;
            checkBox3.Checked = helper.HasCitrixHDX;
            checkBox4.Checked = helper.HasZoomPlugin;
            checkBox5.Checked = helper.HasZoom;

            if (helper.HasSoftwaresInstalled())
            {
                this.label5.Text = "All Good!";
                this.label5.ForeColor = Color.Green;
                return;
            }

            this.label5.Text = "Oh! You are missing some required softwares!";
            this.label5.ForeColor = Color.Red;

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        // Arrasta o fomulário

        bool mouseClicked;
        Point clickedAt;

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseClicked)
            {
                this.Location = new Point(Cursor.Position.X - clickedAt.X, Cursor.Position.Y - clickedAt.Y);
            }
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left)
                return;

            mouseClicked = true;
            clickedAt = e.Location;
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            mouseClicked = false;
        }
    }
}
