using EMS_BLL;
using EMS_BO;
using System;

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
    }
}
