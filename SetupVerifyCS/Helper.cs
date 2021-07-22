using Microsoft.Win32;
using System;
using System.IO;

namespace SetupVerifyCS
{
    public sealed class Helper
    {
        public bool HasCitrix { get; private set; }
        public bool HasIDGo800Driver { get; private set; }
        public bool HasCitrixHDX { get; private set; }
        public bool HasZoomPlugin { get; private set; }
        public bool HasZoom { get; private set; }
        public RegistryKey Key1 { get; private set; }
        public RegistryKey Key2 { get; private set; }
        public string[] Softwares { get; private set; }

        public Helper(RegistryKey key1, RegistryKey key2)
        {
            this.Key1 = key1;
            this.Key2 = key2;
            this.HasCitrix = false;
            this.HasIDGo800Driver = false;
            this.HasCitrixHDX = false;
            this.HasZoomPlugin = false;
            this.HasZoom = false;
            this.Softwares = new string[]
            {
                "Citrix Workspace",
                "IDGo 800 Minidriver",
                "Citrix HDX RealTime Media Engine",
                "Zoom Plugin for Citrix Receiver"
            };
        }

        public void FindRequiredSoftwares()
        {
            foreach (string subkey_name in Key1.GetSubKeyNames())
            {
                RegistryKey subkey = Key1.OpenSubKey(subkey_name);
                if (subkey.GetValue("DisplayName") != null)
                {
                    // Console.WriteLine(subkey.GetValue("DisplayName"));
                    GetSoftwares(subkey);
                }
            }
            foreach (string subkey64_name in Key2.GetSubKeyNames())
            {
                RegistryKey subkey64 = Key2.OpenSubKey(subkey64_name);
                if (subkey64.GetValue("DisplayName") != null)
                {
                    // Console.WriteLine(subkey64.GetValue("DisplayName"));
                    GetSoftwares(subkey64);
                }
            }
            if (!HasCitrix || !HasIDGo800Driver || !HasCitrixHDX || !HasZoomPlugin || !HasZoom)
                FindMissingSoftwares();
        }

        private void GetSoftwares(RegistryKey subkey)
        {
            if (subkey.GetValue("DisplayName").ToString().Contains(this.Softwares[0]))
                this.HasCitrix = true;

            if (subkey.GetValue("DisplayName").ToString().Contains(this.Softwares[1]))
                this.HasIDGo800Driver = true;

            if (subkey.GetValue("DisplayName").ToString().Contains(this.Softwares[2]))
                this.HasCitrixHDX = true;

            if (subkey.GetValue("DisplayName").ToString().Contains(this.Softwares[3]))
                this.HasZoomPlugin = true;
        }

        private void FindMissingSoftwares()
        {
            if (!HasCitrix)
            {
                if (File.Exists(@"C:\Program Files (x86)\Citrix\ICA Client\SelfServicePlugin\SelfService.exe"))
                    this.HasCitrix = true;
            }
            if (!HasIDGo800Driver)
            {
                // There is no Folder
            }
            if (!HasCitrixHDX)
            {
                // There is no Folder
            }
            if (!HasZoomPlugin)
            {
                if (Directory.Exists(@"C:\Program Files (x86)\ZoomCitrixHDXMediaPlugin"))
                    this.HasZoomPlugin = true;
            }
            if (!HasZoom)
            {
                if (File.Exists(@"C:\Users\"+ Environment.UserName + @"\AppData\Roaming\Zoom\bin\Zoom.exe"))
                    this.HasZoom = true;
            }
        }
    }
}