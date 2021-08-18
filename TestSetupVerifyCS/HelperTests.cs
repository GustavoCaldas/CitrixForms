using Microsoft.Win32;
using SetupVerifyCS;
using Xunit;

namespace TestSetupVerifyCS
{
    public class HelperTests
    {
        [Fact]
        public void Helper_Everything_Passes()
        {
            //Arrange
            string registry_key = @"SOFTWARE\Microsoft\Windows\CurrentVersion\Uninstall";
            string registry64_key = @"SOFTWARE\WOW6432Node\Microsoft\Windows\CurrentVersion\Uninstall";

            RegistryKey key = Registry.LocalMachine.OpenSubKey(registry_key);
            RegistryKey key64 = Registry.LocalMachine.OpenSubKey(registry64_key);

            string[] Softwares = new string[]
            {
                "Extension",
                "Extension",
                "Extension",
                "Extension"
            };

            Helper helper = new Helper(key, key64, Softwares);
            HelperGetSoftwareTests helperGetSoftwareTests = new HelperGetSoftwareTests();

            string pathSoftware = @"C:\Program Files";

            helper.FindRequiredSoftwares();
            helperGetSoftwareTests.GetSoftwaresByFolderZoom(pathSoftware);

            //Act
            bool test1 = helper.HasCitrix;
            bool test2 = helper.HasIDGo800Driver;
            bool test3 = helper.HasCitrixHDX;
            bool test4 = helper.HasZoomPlugin;
            bool test5 = helperGetSoftwareTests.pathSReturn;

            //Assert
            Assert.True(test1);
            Assert.True(test2);
            Assert.True(test3);
            Assert.True(test4);
            Assert.True(test5);
        }

        [Fact]
        public void Helper_Dont_Pass_Nothing()
        {
            //Arrange
            string registry_key = @"SOFTWARE\Microsoft\Windows\CurrentVersion\Uninstall";
            string registry64_key = @"SOFTWARE\WOW6432Node\Microsoft\Windows\CurrentVersion\Uninstall";

            RegistryKey key = Registry.LocalMachine.OpenSubKey(registry_key);
            RegistryKey key64 = Registry.LocalMachine.OpenSubKey(registry64_key);

            string[] Softwares = new string[]
            {
                "Tarzan",
                "Jane",
                "Chita",
                "Archimedes"
            };

            Helper helper = new Helper(key, key64, Softwares);
            HelperGetSoftwareTests helperGetSoftwareTests = new HelperGetSoftwareTests();

            string pathSoftware = @"C:\RenatoAragao";

            helper.FindRequiredSoftwares();
            helperGetSoftwareTests.GetSoftwaresByFolderZoom(pathSoftware);

            //Act
            bool test1 = helper.HasCitrix;
            bool test2 = helper.HasIDGo800Driver;
            bool test3 = helper.HasCitrixHDX;
            bool test4 = helper.HasZoomPlugin;
            bool test5 = helperGetSoftwareTests.pathSReturn;

            //Assert
            Assert.False(test1);
            Assert.False(test2);
            Assert.False(test3);
            Assert.False(test4);
            Assert.False(test5);
        }
    }
}
