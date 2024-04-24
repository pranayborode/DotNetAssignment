using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.TheorySession.Crud
{
    internal class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Salary { get; set; }
    }

    public class EmployeeMain
    {
        static List<Employee> elist = new List<Employee>();
        static void Main(string[] args)
        {
          
            bool exit = false;
            while (!exit)
            {
                Console.WriteLine("-----------Movie------------");
                Console.WriteLine("1.Add Employee Details");
                Console.WriteLine("2.Update Employee Details");
                Console.WriteLine("3.Delete Employee");
                Console.WriteLine("4.Display Employee Details by Id");
                Console.WriteLine("5.Display Employee List");
                Console.WriteLine("6.Exit");
                Console.WriteLine("Enter Your Choice:");
                int choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        AddEmployee();
                        break;
                    case 2:
                        UpdateEmployee();
                        break;
                    case 3:
                        DeleteEmployee();
                        break;
                    case 4:
                        DisplayEmployeeById();
                        break;
                    case 5:
                        DisplayEmployeeList();
                        break;
                    case 6:
                        exit = true;
                        break;
                    default:
                        Console.WriteLine("Invalid Choice...");
                        break;


                }
            }
        }

        public static void AddEmployee()
        {
            Employee emp = new Employee();
            Console.WriteLine("Enter Employee Id:");
            emp.Id  = Convert.ToInt32(Console.ReadLine()); 
            Console.WriteLine("Enter Employee Name:");
            emp.Name = Console.ReadLine();
            Console.WriteLine("Enter Employee Salary:");
            emp.Salary = Convert.ToDouble(Console.ReadLine());

            elist.Add(emp);
            Console.WriteLine("Employee Added Successfully...");

        }

        public static void UpdateEmployee()
        {
            Console.WriteLine("Enter Employee Id to Update:");
            int id = Convert.ToInt32(Console.ReadLine());
            int index = FindEmployeeById(id);

            if(index != -1)
            {
                Console.WriteLine("Enter Employee Name:");
                elist[index].Name = Console.ReadLine();
                Console.WriteLine("Enter Employee Salary:");
                elist[index].Salary = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Employee Updated successfully");


            }else 
            {
                Console.WriteLine("Employee not found with given Id..");
            }

        }

        public static void DeleteEmployee()
        {
            Console.WriteLine("Enter Employee Id to Delete:");
            int id = Convert.ToInt32(Console.ReadLine());
            int index = FindEmployeeById(id);
            if(index != -1)
            {
                elist.RemoveAt(index);
                Console.WriteLine("Employee Deleted Successfully..");
            }
            else
            {
                Console.WriteLine("Employee not found with given Id..");
            }
        }

        public static void DisplayEmployeeList() 
        {
            Console.WriteLine("Employee List:");
            foreach(Employee emp in elist) 
            {
                Console.WriteLine($"Id: {emp.Id}, Name: {emp.Name}, Salary: {emp.Salary}");
            }
        }

        public static void DisplayEmployeeById()
        {

            Console.WriteLine("Enter Employee Id to Display:");
            int id = Convert.ToInt32(Console.ReadLine());
            int index = FindEmployeeById(id);

            if (index != -1)
            {
                Employee emp = elist[index];
                Console.WriteLine($"Id: {emp.Id}, Name: {emp.Name}, Salary: {emp.Salary}");
            }
            else
            {
                Console.WriteLine("Employee not found with given Id..");
            }
        }

        public static int FindEmployeeById(int id) 
        {
            for (int i = 0; i < elist.Count; i++)
            {
                if (elist[i].Id == id)
                {
                    return i;
                }
            }

            return -1;
        }
    }

    
}
