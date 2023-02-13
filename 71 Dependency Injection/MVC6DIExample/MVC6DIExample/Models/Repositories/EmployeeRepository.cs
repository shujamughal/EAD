using MVC6DIExample.Models.Interfaces;

namespace MVC6DIExample.Models.Repositories
{
    public class EmployeeRepository : IEmployee
    {
        public List<Employee> GetAllEmployee()
        {
            var employees = new List<Employee>()
        {
            new Employee()
            {
                ID = 1,
                Name = "Abubakar"
               

            },
            new Employee()
            {
                ID = 2,
                Name = "Ismail" },
            new Employee()
            {
                ID = 3,
                Name = "Peter"

            }
        };
            return employees;
        }
    }
}
