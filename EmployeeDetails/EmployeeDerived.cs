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
            string name = e.Name;
            DateTime d = e.DateOfJoining;
            double s = e.Salary;
            string dept = e.DepartmentName;
            decimal ex = e.Experience;             
            list.Add(new Employee{ EmployeeId=id, Name=name, DateOfJoining=d, Salary=s, DepartmentName=dept, Experience=ex });
            
            //list.Add(e);
            
            Console.WriteLine("\nEmployee details added");
            return e;
        }

        public List<Employee> GetEmployees()
        {
            Console.WriteLine("Hii");
            return list;
        }

        public Employee GetEmployeeById(int id)
        {
            Console.WriteLine("cw");
            var e = list.Find(u => u.EmployeeId == id);
            if (e == null)
            {
                Console.WriteLine("Null");
            }
            Console.WriteLine("Employee Id is " + e.EmployeeId);
            return e;
        }

        public Employee UpdateEmployee(Employee e1, int id)
        {
            var e = list.Find(u => u.EmployeeId == id);
            e.EmployeeId = e1.EmployeeId;
            e.Name = e1.Name;
            e.DateOfJoining = e1.DateOfJoining;
            e.Salary = e1.Salary;
            e.DepartmentName = e1.DepartmentName;
            e.Experience = e1.Experience;

            Console.WriteLine("Updated Employee ");
            return e;
        }

        public Employee DeleteEmployee(int id)
        {
            var e = list.Find(u => u.EmployeeId == id);
            list.Remove(e);
            Console.WriteLine("Employee with " + id + " is deleted");
            return e;
        }

    }
}
