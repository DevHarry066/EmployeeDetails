using System.Collections.Generic;

namespace EmployeeDetails
{
    public interface IEmployeee
    {
        Employee Add(Employee e);
        Employee DeleteEmployee(int id);
        Employee GetEmployeeById(int id);
        List<Employee> GetEmployees();
        Employee UpdateEmployee(Employee e1, int id);
    }
}