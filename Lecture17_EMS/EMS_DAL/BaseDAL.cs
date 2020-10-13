using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using EMS_BO;

namespace EMS_DAL
{
    public class BaseDAL
    {
        public void Save(string text, string fileName)
        {
            string filePath = Path.Combine(Environment.CurrentDirectory,
                fileName);
            StreamWriter sw = new StreamWriter(filePath, append:true);
            sw.WriteLine(text);
            sw.Close();
        
        }

       

    }
}
