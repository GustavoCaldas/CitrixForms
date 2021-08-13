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

            Helper helper = new Helper(key, key64);
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
    }
}
