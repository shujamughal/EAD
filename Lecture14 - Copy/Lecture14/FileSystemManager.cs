using System;
using System.Collections.Generic;
using System.Text;
using System.IO; // types for managing the filesystem
using static System.Console;

/*
 Paths are different for Windows, macOS, and Linux, so we will start by
exploring how .NET Core handles this.
 */
/*
 Windows uses a backslash for the directory separator character. macOS and Linux
use a forward slash for the directory separator character.
 
 */

namespace Lecture14
{
    internal class FileSystemManager
    {
        static void FileSystemInfo()
        {
            WriteLine("{0,-33} {1}", "Path.PathSeparator", Path.PathSeparator);
            WriteLine("{0,-33} {1}", "Path.DirectorySeparatorChar",
            Path.DirectorySeparatorChar);
            WriteLine("{0,-33} {1}", "Path.GetTempPath()", Path.GetTempPath());

            WriteLine("{0,-33} {1}", "Directory.GetCurrentDirectory()",
            Directory.GetCurrentDirectory());
            WriteLine("{0,-33} {1}", "Environment.CurrentDirectory",
            Environment.CurrentDirectory);
            WriteLine("{0,-33} {1}", "Environment.SystemDirectory",
            Environment.SystemDirectory);
            WriteLine("{0,-33} {1}", "Environment.OSVersion",
            Environment.OSVersion);
            WriteLine("{0,-33} {1}", "Environment.ProcessorCount",
            Environment.ProcessorCount);
        }
    }
}
