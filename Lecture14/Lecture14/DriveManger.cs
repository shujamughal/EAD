using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using static System.Console;

namespace Lecture14
{
    internal class DriveManger
    {
        internal static void GetDriveInformation() {

            var drives = DriveInfo.GetDrives();
            foreach (DriveInfo drive in drives)
            {
                if (drive.IsReady)
                {
                    WriteLine(drive.Name + " : " +
                               drive.DriveType + " : " +
                               drive.TotalSize + " : " +
                               drive.DriveFormat + " : " +
                               drive.AvailableFreeSpace);
                }
                else {
                    WriteLine(drive.Name + ":"+ drive.DriveType);
                }
            }
        
        }
    }
}
