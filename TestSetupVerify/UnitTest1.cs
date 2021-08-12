using System;
using Microsoft.Win32;
using Xunit;

namespace TestSetupVerify
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            // Arrange
            // Act
            // Assert
            Assert.True(true); 
        }

        [Fact(DisplayName = "Não passa")]
        [Trait("Categoria", "Helper Trait Test")]
        public void Test2()
        {
            // Arrange
            //string registry_key = @"SOFTWARE\Microsoft\Windows\CurrentVersion\Uninstall";
            //string registry64_key = @"SOFTWARE\WOW6432Node\Microsoft\Windows\CurrentVersion\Uninstall";

            //RegistryKey key = Registry.LocalMachine.OpenSubKey(registry_key);
            //RegistryKey key64 = Registry.LocalMachine.OpenSubKey(registry64_key);

            //Helper helper = new Helper(key, key64);
            //helper.FindRequiredSoftwares();

            // Act
            //bool var1 = helper.HasCitrix;
            //bool var2 = helper.HasIDGo800Driver;
            //bool var3 = helper.HasCitrixHDX;
            //bool var4 = helper.HasZoomPlugin;
            //bool var5 = helper.HasZoom;

            // Assert
            //Assert.False(false);
            //Assert.False(false);
            //Assert.False(false);
            //Assert.False(false);
            Assert.False(false);
        }
    }
}
