using EMS_BO;
using EMS_DAL;
using System;
using System.Collections.Generic;
using System.Text;

namespace EMS_BLL
{
    public class EmployeeBLL
    {
        public void SaveEmployee(EmployeeBO bo) {

            if (bo.Age <= 20)
            {
                bo.Salary = 10000;
            }
            else if (bo.Age > 20 && bo.Age < 50)
            {
                bo.Salary = 40000;
            }
            else {
                bo.Salary = 70000;
            }

            EmployeeDAL dal = new EmployeeDAL();
            dal.SaveEmployee(bo);
        }
    }
}
