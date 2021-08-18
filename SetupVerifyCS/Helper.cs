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

        // Search on register subkeys if there's required softwares installed.
        public void FindRequiredSoftwares()
        {
            foreach (string subkey_name in Key1.GetSubKeyNames())
            {
                RegistryKey subkey = Key1.OpenSubKey(subkey_name);
                if (subkey.GetValue("DisplayName") != null)
                    GetSoftwaresByRegisterKey(subkey);
            }

            foreach (string subkey64_name in Key2.GetSubKeyNames())
            {
                RegistryKey subkey64 = Key2.OpenSubKey(subkey64_name);
                if (subkey64.GetValue("DisplayName") != null)
                    GetSoftwaresByRegisterKey(subkey64);
            }

            if ( !(HasCitrix && HasIDGo800Driver && HasCitrixHDX && HasZoomPlugin && HasZoom) )
                GetSoftwaresByFolder();
        }

        // Try to get softwares listed on this.Softwares through RegisterKey.
        public void GetSoftwaresByRegisterKey(RegistryKey subkey)
        {
            this.HasCitrix = this.HasCitrix || subkey.GetValue("DisplayName").ToString().Contains(this.Softwares[0]);
            this.HasIDGo800Driver = this.HasIDGo800Driver || subkey.GetValue("DisplayName").ToString().Contains(this.Softwares[1]);
            this.HasCitrixHDX = this.HasCitrixHDX || subkey.GetValue("DisplayName").ToString().Contains(this.Softwares[2]);
            this.HasZoomPlugin = this.HasZoomPlugin || subkey.GetValue("DisplayName").ToString().Contains(this.Softwares[3]);
        }

        // Try to get softwares listed on this.Softwares through Folders.
        public void GetSoftwaresByFolder()
        {
            if (!HasCitrix)
                this.HasCitrix = this.HasCitrix || 
                File.Exists(@"C:\Program Files (x86)\Citrix\ICA Client\SelfServicePlugin\SelfService.exe");
            
            // There's no folder
            if (!HasIDGo800Driver) {  }
            // There's no folder
            if (!HasCitrixHDX) {  }

            if (!HasZoomPlugin)
                this.HasZoomPlugin = this.HasZoomPlugin || 
                Directory.Exists(@"C:\Program Files (x86)\ZoomCitrixHDXMediaPlugin");
            
            if (!HasZoom)
                this.HasZoom = this.HasZoom ||
                    File.Exists(@"C:\Users\" + Environment.UserName + @"\AppData\Roaming\Zoom\bin\Zoom.exe") ||
                    Directory.Exists(@"C:\Users\" + Environment.UserName + @"\AppData\Roaming\Zoom") ||
                    File.Exists(@"C:\Program Files\Zoom\bin\Zoom.exe") ||
                    Directory.Exists(@"C:\Program Files\Common Files\Zoom") ||
                    Directory.Exists(@"C:\Program Files (x86)\ZoomVDI\bin");
        }

        // If there's all softwares installed return true.
        public bool HasSoftwaresInstalled()
        {
            return HasCitrix && HasIDGo800Driver && HasCitrixHDX && HasZoomPlugin && HasZoom;
        }
    }
}