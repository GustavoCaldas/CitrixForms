using System;
using System.IO;

namespace SetupVerifyCS
{
    public class HelperGetSoftwareTests
    {
        public bool pathSReturn { get; private set; }

        public void GetSoftwaresByFolderZoom(string FolderValue)
        {
            if (FolderValue == null)
            {
                this.pathSReturn = File.Exists(@"C:\Users\" + Environment.UserName + @"\AppData\Roaming\Zoom\bin\Zoom.exe") ||
                     Directory.Exists(@"C:\Users\" + Environment.UserName + @"\AppData\Roaming\Zoom") ||
                     File.Exists(@"C:\Program Files\Zoom\bin\Zoom.exe") ||
                     Directory.Exists(@"C:\Program Files\Common Files\Zoom");
            }
            else
            {
                this.pathSReturn = Directory.Exists(FolderValue);
            }
        }

    }
}
