using EMS_BO;
using System;
using System.Collections.Generic;
using System.Text;

namespace EMS_DAL
{
    public class EmployeeDAL :BaseDAL
    {
        public void SaveEmployee(EmployeeBO bo)
        {
            string text = $"{bo.Name},{bo.Age},{bo.Salary}";
            Save(text,"EmployeeData.csv");
        }

        
        
        
    }
}
