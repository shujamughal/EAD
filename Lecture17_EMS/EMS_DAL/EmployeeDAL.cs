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

        public List<EmployeeBO> ReadEmployee() {
            List<String> stringList = Read("EmployeeData.csv");
            List<EmployeeBO> empList = new List<EmployeeBO>();
            foreach (string s in stringList) {

                string[] data = s.Split(",");
                EmployeeBO e = new EmployeeBO();
                e.Name = data[0];
                e.Age = System.Convert.ToInt32( data[1]);
                e.Salary =System.Convert.ToDecimal( data[2]);
                empList.Add(e);
            }

            return empList;
        
        }
        
        
        
    }
}
