using EMS_BLL;
using EMS_BO;
using System;
using System.Collections.Generic;

namespace EMS_View
{
    public class EmployeeView
    {
        public void GetInput() {

            Console.WriteLine("Enter Empolyee Name: ");
            string empName = Console.ReadLine();
            Console.WriteLine("Enter Age:");
            int age = System.Convert.ToInt32( Console.ReadLine());
            EmployeeBO bo = new EmployeeBO { Name=empName,Age=age };
            EmployeeBLL bll = new EmployeeBLL();
            bll.SaveEmployee(bo);
        }
        public void Display() {
            EmployeeBLL bll = new EmployeeBLL();
            List<EmployeeBO> list = bll.ReadEmployee();
            foreach (EmployeeBO e in list) {
                Console.WriteLine($"Name : {e.Name} Age: {e.Age}  Salary: {e.Salary}");
            }


        }
    }
}
