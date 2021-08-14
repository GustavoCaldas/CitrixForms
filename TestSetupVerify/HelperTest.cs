using Xunit;

namespace TestSetupVerify
{
    public class HelperTest
    {
        [Fact]
        public void UninstalledSoftwares()
        {
            // Arrange
            HelperAuxTest helperAuxTest = new HelperAuxTest();

            // Act
            bool citrix = helperAuxTest.HasCitrixFalse();
            bool idGo800Driver = helperAuxTest.HasIDGo800DriverFalse();
            bool citrixHDX = helperAuxTest.HasCitrixHDXFalse();
            bool zoomPlugin = helperAuxTest.HasZoomPluginFalse();
            bool zoom = helperAuxTest.HasZoomFalse();

            // Assert
            Assert.False(citrix);
            Assert.False(idGo800Driver);
            Assert.False(citrixHDX);
            Assert.False(zoomPlugin);
            Assert.False(zoom);
        }

        [Fact]
        public void ValidateInstalledSoftwares()
        {
            // Arrange
            HelperAuxTest helperAuxTest = new HelperAuxTest();

            // Act
            bool citrix = helperAuxTest.HasCitrixTrue();
            bool idGo800Driver = helperAuxTest.HasIDGo800DriverTrue();
            bool citrixHDX = helperAuxTest.HasCitrixHDXTrue();
            bool zoomPlugin = helperAuxTest.HasZoomPluginTrue();
            bool zoom = helperAuxTest.HasZoomTrue();

            // Assert
            Assert.True(citrix);
            Assert.True(idGo800Driver);
            Assert.True(citrixHDX);
            Assert.True(zoomPlugin);
            Assert.True(zoom);
        }

        [Fact]
        public void UninstalledCitrixSoftware()
        {
            // Arrange
            HelperAuxTest helperAuxTest = new HelperAuxTest();

            // Act
            bool citrix = helperAuxTest.HasCitrixFalse();
            bool idGo800Driver = helperAuxTest.HasIDGo800DriverTrue();
            bool citrixHDX = helperAuxTest.HasCitrixHDXTrue();
            bool zoomPlugin = helperAuxTest.HasZoomPluginTrue();
            bool zoom = helperAuxTest.HasZoomTrue();

            // Assert
            Assert.False(citrix);
            Assert.True(idGo800Driver);
            Assert.True(citrixHDX);
            Assert.True(zoomPlugin);
            Assert.True(zoom);
        }

        [Fact]
        public void UninstalledIDGo800Driver()
        {
            // Arrange
            HelperAuxTest helperAuxTest = new HelperAuxTest();

            // Act
            bool citrix = helperAuxTest.HasCitrixTrue();
            bool idGo800Driver = helperAuxTest.HasIDGo800DriverFalse();
            bool citrixHDX = helperAuxTest.HasCitrixHDXTrue();
            bool zoomPlugin = helperAuxTest.HasZoomPluginTrue();
            bool zoom = helperAuxTest.HasZoomTrue();

            // Assert
            Assert.True(citrix);
            Assert.False(idGo800Driver);
            Assert.True(citrixHDX);
            Assert.True(zoomPlugin);
            Assert.True(zoom);
        }

        [Fact]
        public void UninstalledCitrixHDXSoftware()
        {
            // Arrange
            HelperAuxTest helperAuxTest = new HelperAuxTest();

            // Act
            bool citrix = helperAuxTest.HasCitrixTrue();
            bool idGo800Driver = helperAuxTest.HasIDGo800DriverTrue();
            bool citrixHDX = helperAuxTest.HasCitrixHDXFalse();
            bool zoomPlugin = helperAuxTest.HasZoomPluginTrue();
            bool zoom = helperAuxTest.HasZoomTrue();

            // Assert
            Assert.True(citrix);
            Assert.True(idGo800Driver);
            Assert.False(citrixHDX);
            Assert.True(zoomPlugin);
            Assert.True(zoom);
        }

        [Fact]
        public void UninstalledZoomPluginSoftware()
        {
            // Arrange
            HelperAuxTest helperAuxTest = new HelperAuxTest();

            // Act
            bool citrix = helperAuxTest.HasCitrixTrue();
            bool idGo800Driver = helperAuxTest.HasIDGo800DriverTrue();
            bool citrixHDX = helperAuxTest.HasCitrixHDXTrue();
            bool zoomPlugin = helperAuxTest.HasZoomPluginFalse();
            bool zoom = helperAuxTest.HasZoomTrue();

            // Assert
            Assert.True(citrix);
            Assert.True(idGo800Driver);
            Assert.True(citrixHDX);
            Assert.False(zoomPlugin);
            Assert.True(zoom);
        }

        [Fact]
        public void UninstalledZoomSoftware()
        {
            // Arrange
            HelperAuxTest helperAuxTest = new HelperAuxTest();

            // Act
            bool citrix = helperAuxTest.HasCitrixTrue();
            bool idGo800Driver = helperAuxTest.HasIDGo800DriverTrue();
            bool citrixHDX = helperAuxTest.HasCitrixHDXTrue();
            bool zoomPlugin = helperAuxTest.HasZoomPluginTrue();
            bool zoom = helperAuxTest.HasZoomFalse();

            // Assert
            Assert.True(citrix);
            Assert.True(idGo800Driver);
            Assert.True(citrixHDX);
            Assert.True(zoomPlugin);
            Assert.False(zoom);
        }

        [Fact]
        public void UninstalledCitrixAndZoomSoftware()
        {
            // Arrange
            HelperAuxTest helperAuxTest = new HelperAuxTest();

            // Act
            bool citrix = helperAuxTest.HasCitrixFalse();
            bool idGo800Driver = helperAuxTest.HasIDGo800DriverTrue();
            bool citrixHDX = helperAuxTest.HasCitrixHDXTrue();
            bool zoomPlugin = helperAuxTest.HasZoomPluginTrue();
            bool zoom = helperAuxTest.HasZoomFalse();

            // Assert
            Assert.False(citrix);
            Assert.True(idGo800Driver);
            Assert.True(citrixHDX);
            Assert.True(zoomPlugin);
            Assert.False(zoom);
        }

        [Fact]
        public void UninstalledIDGo800DriverAndZoomSoftware()
        {
            // Arrange
            HelperAuxTest helperAuxTest = new HelperAuxTest();

            // Act
            bool citrix = helperAuxTest.HasCitrixTrue();
            bool idGo800Driver = helperAuxTest.HasIDGo800DriverFalse();
            bool citrixHDX = helperAuxTest.HasCitrixHDXTrue();
            bool zoomPlugin = helperAuxTest.HasZoomPluginTrue();
            bool zoom = helperAuxTest.HasZoomFalse();

            // Assert
            Assert.True(citrix);
            Assert.False(idGo800Driver);
            Assert.True(citrixHDX);
            Assert.True(zoomPlugin);
            Assert.False(zoom);
        }

        [Fact]
        public void UninstalledVitrixHDXAndZoomSoftware()
        {
            // Arrange
            HelperAuxTest helperAuxTest = new HelperAuxTest();

            // Act
            bool citrix = helperAuxTest.HasCitrixTrue();
            bool idGo800Driver = helperAuxTest.HasIDGo800DriverTrue();
            bool citrixHDX = helperAuxTest.HasCitrixHDXFalse();
            bool zoomPlugin = helperAuxTest.HasZoomPluginTrue();
            bool zoom = helperAuxTest.HasZoomFalse();

            // Assert
            Assert.True(citrix);
            Assert.True(idGo800Driver);
            Assert.False(citrixHDX);
            Assert.True(zoomPlugin);
            Assert.False(zoom);
        }

        [Fact]
        public void UninstalledZoompPluginAndZoomSoftware()
        {
            // Arrange
            HelperAuxTest helperAuxTest = new HelperAuxTest();

            // Act
            bool citrix = helperAuxTest.HasCitrixTrue();
            bool idGo800Driver = helperAuxTest.HasIDGo800DriverTrue();
            bool citrixHDX = helperAuxTest.HasCitrixHDXTrue();
            bool zoomPlugin = helperAuxTest.HasZoomPluginFalse();
            bool zoom = helperAuxTest.HasZoomFalse();

            // Assert
            Assert.True(citrix);
            Assert.True(idGo800Driver);
            Assert.True(citrixHDX);
            Assert.False(zoomPlugin);
            Assert.False(zoom);
        }

        [Fact]
        public void UninstalledCitrixAndZoomPluginSoftware()
        {
            // Arrange
            HelperAuxTest helperAuxTest = new HelperAuxTest();

            // Act
            bool citrix = helperAuxTest.HasCitrixFalse();
            bool idGo800Driver = helperAuxTest.HasIDGo800DriverTrue();
            bool citrixHDX = helperAuxTest.HasCitrixHDXTrue();
            bool zoomPlugin = helperAuxTest.HasZoomPluginFalse();
            bool zoom = helperAuxTest.HasZoomPluginTrue();

            // Assert
            Assert.False(citrix);
            Assert.True(idGo800Driver);
            Assert.True(citrixHDX);
            Assert.False(zoomPlugin);
            Assert.True(zoom);
        }

        [Fact]
        public void UninstalledIDGo800DriverAndZoomPluginSoftware()
        {
            // Arrange
            HelperAuxTest helperAuxTest = new HelperAuxTest();

            // Act
            bool citrix = helperAuxTest.HasCitrixTrue();
            bool idGo800Driver = helperAuxTest.HasIDGo800DriverFalse();
            bool citrixHDX = helperAuxTest.HasCitrixHDXTrue();
            bool zoomPlugin = helperAuxTest.HasZoomPluginFalse();
            bool zoom = helperAuxTest.HasZoomPluginTrue();

            // Assert
            Assert.True(citrix);
            Assert.False(idGo800Driver);
            Assert.True(citrixHDX);
            Assert.False(zoomPlugin);
            Assert.True(zoom);
        }

        [Fact]
        public void UninstalledCitrixHDXAndZoomPluginSoftware()
        {
            // Arrange
            HelperAuxTest helperAuxTest = new HelperAuxTest();

            // Act
            bool citrix = helperAuxTest.HasCitrixTrue();
            bool idGo800Driver = helperAuxTest.HasIDGo800DriverTrue();
            bool citrixHDX = helperAuxTest.HasCitrixHDXFalse();
            bool zoomPlugin = helperAuxTest.HasZoomPluginFalse();
            bool zoom = helperAuxTest.HasZoomPluginTrue();

            // Assert
            Assert.True(citrix);
            Assert.True(idGo800Driver);
            Assert.False(citrixHDX);
            Assert.False(zoomPlugin);
            Assert.True(zoom);
        }

        [Fact]
        public void UninstalledCitrixAndCitrixHDXSoftware()
        {
            // Arrange
            HelperAuxTest helperAuxTest = new HelperAuxTest();

            // Act
            bool citrix = helperAuxTest.HasCitrixFalse();
            bool idGo800Driver = helperAuxTest.HasIDGo800DriverTrue();
            bool citrixHDX = helperAuxTest.HasCitrixHDXFalse();
            bool zoomPlugin = helperAuxTest.HasZoomPluginTrue();
            bool zoom = helperAuxTest.HasZoomPluginTrue();

            // Assert
            Assert.False(citrix);
            Assert.True(idGo800Driver);
            Assert.False(citrixHDX);
            Assert.True(zoomPlugin);
            Assert.True(zoom);
        }

        [Fact]
        public void UninstalledIDGo800DriverAndCitrixHDXSoftware()
        {
            // Arrange
            HelperAuxTest helperAuxTest = new HelperAuxTest();

            // Act
            bool citrix = helperAuxTest.HasCitrixTrue();
            bool idGo800Driver = helperAuxTest.HasIDGo800DriverFalse();
            bool citrixHDX = helperAuxTest.HasCitrixHDXFalse();
            bool zoomPlugin = helperAuxTest.HasZoomPluginTrue();
            bool zoom = helperAuxTest.HasZoomPluginTrue();

            // Assert
            Assert.True(citrix);
            Assert.False(idGo800Driver);
            Assert.False(citrixHDX);
            Assert.True(zoomPlugin);
            Assert.True(zoom);
        }

        [Fact]
        public void UninstalledICitrixAndIDGo800DriverSoftware()
        {
            // Arrange
            HelperAuxTest helperAuxTest = new HelperAuxTest();

            // Act
            bool citrix = helperAuxTest.HasCitrixFalse();
            bool idGo800Driver = helperAuxTest.HasIDGo800DriverFalse();
            bool citrixHDX = helperAuxTest.HasCitrixHDXTrue();
            bool zoomPlugin = helperAuxTest.HasZoomPluginTrue();
            bool zoom = helperAuxTest.HasZoomPluginTrue();

            // Assert
            Assert.False(citrix);
            Assert.False(idGo800Driver);
            Assert.True(citrixHDX);
            Assert.True(zoomPlugin);
            Assert.True(zoom);
        }
    }
}