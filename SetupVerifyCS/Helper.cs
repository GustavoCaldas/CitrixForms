using Microsoft.Win32;
using System;

namespace SetupVerifyCS
{
    public sealed class Helper
    {
        public bool HasCitrix { get; private set; }
        public bool HasIDGo800Driver { get; private set; }
        public bool HasCitrixHDX { get; private set; }
        public bool HasZoomPlugin { get; private set; }
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
            this.Softwares = new string[]
            {
                "Citrix Workspace 1912",
                "IDGo 800 Minidriver",
                "Citrix HDX RealTime Media Engine 2.8",
                "Zoom Plugin for Citrix Receiver"
            };
        }
        public void FindRequiredSoftwares()
        {
            foreach (string subkey_name in Key1.GetSubKeyNames())
            {
                RegistryKey subkey = Key1.OpenSubKey(subkey_name);
                Console.WriteLine(subkey.GetValue("DisplayName"));
                if(subkey.GetValue("DisplayName") != null)
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
            }
            foreach (string subkey64_name in Key2.GetSubKeyNames())
            {
                RegistryKey subkey64 = Key2.OpenSubKey(subkey64_name);
                Console.WriteLine(subkey64.GetValue("DisplayName"));
                if (subkey64.GetValue("DisplayName") != null)
                {
                    if (subkey64.GetValue("DisplayName").ToString().Contains(this.Softwares[0]))
                        this.HasCitrix = true;                   

                    if (subkey64.GetValue("DisplayName").ToString().Contains(this.Softwares[1]))
                        this.HasIDGo800Driver = true;

                    if (subkey64.GetValue("DisplayName").ToString().Contains(this.Softwares[2]))
                        this.HasCitrixHDX = true;

                    if (subkey64.GetValue("DisplayName").ToString().Contains(this.Softwares[3]))
                        this.HasZoomPlugin = true;
                }
            }
        }
    }
}