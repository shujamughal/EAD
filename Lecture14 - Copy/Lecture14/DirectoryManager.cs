using System;
using System.Collections.Generic;
using System.Text;
using static System.Console;
using System.IO;

/*To manage directories, 
use the Directory, Path, and Environment static classes.*/
namespace Lecture14
{
    internal class DirectoryManager
    {
        internal static void WorkWithDirectories()
        {
            // define a directory path for a new folder
            // starting in the user's folder
            var newFolder = Path.Combine(Directory.GetCurrentDirectory(),
                "MyNewFolder");
            WriteLine($"Working with: {newFolder}");
            // check if it exists
            WriteLine($"Does it exist? {Directory.Exists(newFolder)}");
            // create directory
            WriteLine("Creating it...");
            Directory.CreateDirectory(newFolder);
            WriteLine($"Does it exist? {Directory.Exists(newFolder)}");
            Write("Confirm the directory exists, and then press ENTER: ");
            ReadLine();
            // delete directory
            WriteLine("Deleting it...");
            Directory.Delete(newFolder, recursive: true);
            WriteLine($"Does it exist? {Directory.Exists(newFolder)}");
        }
    }
}
