using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using static System.Console;
namespace Lecture14
{
    internal class DirectoryManager
    {

        static internal void WorkingWithDirectories() {

            var newFolder = Path.Combine(Directory.GetCurrentDirectory(),"MyNewFolder");
            WriteLine(Directory.GetCurrentDirectory());
            WriteLine(Directory.Exists(newFolder));
            Directory.CreateDirectory(newFolder);
            WriteLine(Directory.Exists(newFolder));
            Directory.Delete(newFolder, recursive:true);
            WriteLine(Directory.Exists(newFolder));

        }
    }
}
