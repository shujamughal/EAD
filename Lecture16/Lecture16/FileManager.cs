using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using static System.Console;

namespace Lecture16
{
   internal class FileManager
    {
        internal static void ManageFiles() {

            string textFile = Path.Combine(
                Environment.CurrentDirectory,"streams.txt"
                );
            WriteLine(File.Exists(textFile));
            StreamWriter sw = File.CreateText(textFile);
            WriteLine(File.Exists(textFile));
            sw.WriteLine("This is some dummy text.");
            sw.Close();

            //
            WriteLine($"Folder Name : {Path.GetDirectoryName(textFile)}");
            WriteLine($"File Name : {Path.GetFileName(textFile)}");
            WriteLine($"File Name without Extension : {Path.GetFileNameWithoutExtension(textFile)}");
            WriteLine($"File Extension : {Path.GetExtension(textFile)}");

            var info = new FileInfo(textFile);
            WriteLine($"total bytes {info.Length}");
            WriteLine($"Last Accessed {info.LastAccessTime}");
            WriteLine($"is ReadOnly {info.IsReadOnly}");

            string backupFile = Path.Combine(Environment.CurrentDirectory, "mybackupfile.bak");

            File.Copy(sourceFileName:textFile, destFileName:backupFile, overwrite:true);
            ReadLine();
            File.Delete(textFile);

            StreamReader sr = File.OpenText(backupFile);
            WriteLine(sr.ReadToEnd());
            sr.Close();

            WriteLine(File.ReadAllText(backupFile));



        }
    }
}
