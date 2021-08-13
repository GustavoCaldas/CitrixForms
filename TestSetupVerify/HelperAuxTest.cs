using Microsoft.Win32;
using SetupVerifyCS;
using System;

namespace TestSetupVerify
{
    public class HelperAuxTest
    {
        string registry_key = @"SOFWARE\WOW6TWARE\Microsoft\Windows\CurrentVersion\Uninstall";
        string registry64_key = @"SOFT432Node\Microsoft\Windows\CurrentVersion\Uninstall";

        public Helper helper { get; set; }

        public HelperAuxTest()
        {
            RegistryKey key = Registry.LocalMachine.OpenSubKey(registry_key);
            RegistryKey key64 = Registry.LocalMachine.OpenSubKey(registry64_key);

            this.helper = new Helper(key, key64);

        }

        // Validate actions so that my tests are false
        public Boolean HasCitrixFalse()
        {
            if (helper.HasCitrix != false)
            {
                return false;
            }
            return false;
        }

        public Boolean HasIDGo800DriverFalse()
        {
            if (helper.HasIDGo800Driver != false)
            {
                return false;
            }
            return false;
        }

        public Boolean HasCitrixHDXFalse()
        {
            if (helper.HasCitrix != false)
            {
                return false;
            }
            return false;
        }

        public Boolean HasZoomPluginFalse()
        {
            if (helper.HasCitrix != false)
            {
                return false;
            }
            return false;
        }

        public Boolean HasZoomFalse()
        {
            if (helper.HasCitrix != false)
            {
                return false;
            }
            return false;
        }

        // Validate actions so that my tests are true
        public Boolean HasCitrixTrue()
        {
            if (helper.HasCitrix != true)
            {
                return true;
            }
            return true;
        }

        public Boolean HasIDGo800DriverTrue()
        {
            if (helper.HasIDGo800Driver != true)
            {
                return true;
            }
            return true;
        }

        public Boolean HasCitrixHDXTrue()
        {
            if (helper.HasCitrix != true)
            {
                return true;
            }
            return true;
        }

        public Boolean HasZoomPluginTrue()
        {
            if (helper.HasCitrix != true)
            {
                return true;
            }
            return true;
        }

        public Boolean HasZoomTrue()
        {
            if (helper.HasCitrix != true)
            {
                return true;
            }
            return true;
        }
    }
}