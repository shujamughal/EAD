using System;
using EMS_View;
namespace Lecture17_EMS
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--Welcome to Employee Management System--");
            EmployeeView view = new EmployeeView();
            //view.GetInput();
            view.Display();
            
            
        }
    }
}
