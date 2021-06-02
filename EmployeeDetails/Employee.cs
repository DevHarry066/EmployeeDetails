using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static EmployeeDetails.Program;

namespace EmployeeDetails
{
    public class Employee
    {
        public int EmployeeId { get; set; }
        public string Name { get; set; }
        public DateTime DateOfJoining { get; set; }
        public double Salary { get; set; }
        public string DepartmentName { get; set; }
        public decimal Experience { get; set; }

        public EmployeeType EmployeeType { get; set; }
        //public List<Employee> list11 = new List<Employee>();

        public Employee()
        {

        }
        public Employee(int eid, string name, DateTime dateOfJoining, double salary, string departmentName, EmployeeType employeeType, decimal experience)
        {
            this.EmployeeId = eid;
            this.Name = name;
            this.DateOfJoining = dateOfJoining;
            this.Salary = salary;
            this.DepartmentName = departmentName;
            this.EmployeeType = employeeType;
            this.Experience = experience;
        }

        public override string ToString()
        {
            return "Employment ID : " + EmployeeId + "\n"
                  + "EmployeeName : " + Name + "\n"
                  + "Date of Joining : " + DateOfJoining + "\n"
                  + "Salary : " + Salary + "\n"
                  + "Department Name " + DepartmentName + "\n"
                  + "Experience " + Experience + "\n";
        }
    }
}
