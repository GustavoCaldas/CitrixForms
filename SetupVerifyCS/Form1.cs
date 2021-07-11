using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SetupVerifyCS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string registry_key = @"SOFTWARE\Microsoft\Windows\CurrentVersion\Uninstall";
            string registry64_key = @"SOFTWARE\WOW6432Node\Microsoft\Windows\CurrentVersion\Uninstall";

            RegistryKey key = Registry.LocalMachine.OpenSubKey(registry_key);
            RegistryKey key64 = Registry.LocalMachine.OpenSubKey(registry64_key);

            Helper helper = new Helper(key, key64);
            helper.FindRequiredSoftwares();

            if (helper.HasCitrix)
                checkBox1.Checked = true;
            if (helper.HasIDGo800Driver)
                checkBox2.Checked = true;
            if (helper.HasCitrixHDX)
                checkBox3.Checked = true;
            if (helper.HasZoomPlugin)
                checkBox4.Checked = true;

            if(!helper.HasCitrix ||
                !helper.HasIDGo800Driver ||
                !helper.HasCitrixHDX ||
                !helper.HasZoomPlugin)
            {
                this.label5.Text = "Oh! You are missing some required softwares!";
                this.label5.ForeColor = Color.Red;
            }
            else
            {
                this.label5.Text = "All Good!";
                this.label5.ForeColor = Color.Green;
            }
        }
    }
}
