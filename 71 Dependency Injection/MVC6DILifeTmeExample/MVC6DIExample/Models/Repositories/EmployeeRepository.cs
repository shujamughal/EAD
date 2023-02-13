using MVC6DIExample.Models.Interfaces;

namespace MVC6DIExample.Models.Repositories
{
    public class EmployeeRepository : IEmployee
    {
        private List<Employee> employees;
        public EmployeeRepository()
        {
            employees = new List<Employee>()
                {
                new Employee()
                { ID = 1, Name = "Abubakar"           },
                new Employee() { ID = 2, Name = "Ismail" },
                new Employee() {ID = 3,  Name = "Peter"  }
                }
        }
        public List<Employee> GetAllEmployee()
        {
            return employees;
        }
       
        
    }
}
