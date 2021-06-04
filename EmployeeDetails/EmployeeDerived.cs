using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeDetails
{
    public class EmployeeDerived : IEmployeee
    {

        List<Employee> list = new List<Employee>();
        public Employee Add(Employee e)
        {
            
            int id = e.EmployeeId;
            foreach (var employee in list)
                {
                    if (employee.EmployeeId == id)
                    {
                        Console.WriteLine("Entered id is present in list so it's not get added\n\nThe Details you entered are ");
                    return e;
                    }
                }
            string name = e.Name;
            DateTime d = e.DateOfJoining;
            double s = e.Salary;
            string dept = e.DepartmentName;
            decimal ex = e.Experience;
            EmployeeType et = e.EmployeeType;
            list.Add(new Employee{ EmployeeId=id, Name=name, DateOfJoining=d, Salary=s, DepartmentName=dept, EmployeeType=et, Experience=ex });
            Console.WriteLine("\nEmployee details added");
            return e;
        }

        public List<Employee> GetEmployees()
        {
            if (list.Count == 0) Console.WriteLine("List is empty");
            return list;
        }

        public Employee GetEmployeeById(int id)
        {
            var e = list.Find(u => u.EmployeeId == id);
            if (e == null)
            {
                return null;
            }
            Console.WriteLine("Employee Id is " + e.EmployeeId);
            return e;
        }

        public Employee UpdateEmployee(Employee e1, int id)
        {
            var e = list.Find(u => u.EmployeeId == id);
            if(e==null)
            {
                return null;
            }
            e.EmployeeId = e1.EmployeeId;
            e.Name = e1.Name;
            e.DateOfJoining = e1.DateOfJoining;
            e.Salary = e1.Salary;
            e.DepartmentName = e1.DepartmentName;
            e.EmployeeType = e1.EmployeeType;
            e.Experience = e1.Experience;

            Console.WriteLine("Updated Employee ");
            return e;
        }

        public Employee DeleteEmployee(int id)
        {
            var e = list.Find(u => u.EmployeeId == id);
            if (e == null) return null;
            list.Remove(e);
            Console.WriteLine("Employee with id " + id + " is deleted");
            return e;
        }

    }
}
