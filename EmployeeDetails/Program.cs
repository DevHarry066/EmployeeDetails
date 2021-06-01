using System;
using System.Collections.Generic;
using System.Globalization;

namespace EmployeeDetails
{
    class Program
    {
        static void Main(string[] args)
        {
           //int ch;
            Console.WriteLine("Hello");
            while (true)
            {


                Employee e = new Employee();
                EmployeeDerived ed = new EmployeeDerived();
                
                Console.WriteLine("Enter 1 for Add Employee");
                Console.WriteLine("Enter 2 for Get Employee Details");
                Console.WriteLine("Enter 3 for Get an Employee by Id");
                Console.WriteLine("Enter 4 to update an Employee");
                Console.WriteLine("Enter 5 to delete an Employee");
                Console.WriteLine("Press enter or 0 to Exit");

                int choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Enter Employee Id");
                        int Eid = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter Employee Name");
                        string name = Console.ReadLine();
                        Console.WriteLine("Enter Date Of Joining");
                        DateTime dateOfJoining = Convert.ToDateTime(Console.ReadLine());
                        Console.WriteLine("Enter Employee Salary");
                        double salary = Convert.ToInt64(Console.ReadLine());
                        Console.WriteLine("Enter Department Name");
                        string depName = Console.ReadLine();
                        decimal experience = (DateTime.Now - dateOfJoining).Days / 365;
                        Employee e1=new Employee(Eid,name,dateOfJoining,salary,depName,experience);
                        

                        Employee er = ed.Add(e1);
                        Console.WriteLine("Employee Id is " + er.EmployeeId);
                        Console.WriteLine("Employee Name is " + er.Name);
                        Console.WriteLine("Employee Date of Joining is " + er.DateOfJoining);
                        Console.WriteLine("Employee Salary is " + er.Salary);
                        Console.WriteLine("Employee Department Name is " + er.DepartmentName);
                        Console.WriteLine("Employee Experinece is " + er.Experience);
                        break;

                    case 2:
                        var employees = ed.GetEmployees();
                        Console.WriteLine("Here");
                        foreach (var employee in employees)
                        {
                            Console.WriteLine("Hello");
                            Console.WriteLine("Employee Id is " + employee.EmployeeId);
                            Console.WriteLine("Employee Name is " + employee.Name);
                            Console.WriteLine("Employee Date of Joining is " + employee.DateOfJoining);
                            Console.WriteLine("Employee Salary is " + employee.Salary);
                            Console.WriteLine("Employee Department Name is " + employee.DepartmentName);
                            Console.WriteLine("Employee Experinece is " + employee.Experience);

                        }

                        break;

                    case 3:
                        Console.WriteLine("Enter id to get info about Employee");
                        int id = Convert.ToInt32(Console.ReadLine());
                        var ee=ed.GetEmployeeById(id);
                        Console.WriteLine("Employee Id is " + ee.EmployeeId);
                        Console.WriteLine("Employee Name is " + ee.Name);
                        Console.WriteLine("Employee Date of Joining is " + ee.DateOfJoining);
                        Console.WriteLine("Employee Salary is " + ee.Salary);
                        Console.WriteLine("Employee Department Name is " + ee.DepartmentName);
                        Console.WriteLine("Employee Experinece is " + ee.Experience);
                        break;
                        
                    case 4:
                        Console.WriteLine("Enter info about Employee to update");
                        Console.WriteLine("Enter Employee Id");
                        e.EmployeeId = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter Employee Name");
                        e.Name = Console.ReadLine();
                        Console.WriteLine("Enter Date Of Joining");
                        e.DateOfJoining = Convert.ToDateTime(Console.ReadLine());
                        Console.WriteLine("Enter Employee Salary");
                        e.Salary = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter Department Name");
                        e.DepartmentName = Console.ReadLine();

                        decimal experience1 = (DateTime.Now - e.DateOfJoining).Days / 365;
                        e.Experience = experience1;

                        Console.WriteLine("Enter Employee Id you want to update");
                        int id1 = Convert.ToInt32(Console.ReadLine());
                        var ee1=ed.UpdateEmployee(e,id1);
                        Console.WriteLine("Employee Id is " + ee1.EmployeeId);
                        Console.WriteLine("Employee Name is " + ee1.Name);
                        Console.WriteLine("Employee Date of Joining is " + ee1.DateOfJoining);
                        Console.WriteLine("Employee Salary is " + ee1.Salary);
                        Console.WriteLine("Employee Department Name is " + ee1.DepartmentName);
                        Console.WriteLine("Employee Experinece is " + ee1.Experience);



                        break;
                    case 5:
                        Console.WriteLine("Enter id of Employee you want to delete: ");
                        int id2 = Convert.ToInt32(Console.ReadLine());
                        var ee2=ed.DeleteEmployee(id2);
                        Console.WriteLine("Employee Id is " + ee2.EmployeeId);
                        Console.WriteLine("Employee Name is " + ee2.Name);
                        Console.WriteLine("Employee Date of Joining is " + ee2.DateOfJoining);
                        Console.WriteLine("Employee Salary is " + ee2.Salary);
                        Console.WriteLine("Employee Department Name is " + ee2.DepartmentName);
                        Console.WriteLine("Employee Experinece is " + ee2.Experience);
                        break;
                        
                    default:
                        Console.WriteLine("Enter correct choice please\n");
                        break;

                }

                //Console.WriteLine("Do you want to continue");
                //ch = Convert.ToInt32(Console.ReadLine());

            }
        }

    }
}

