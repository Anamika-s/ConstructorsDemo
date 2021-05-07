using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassDemo
{
    struct Address
    {
        public string streetno;
        string city;
        string state;
        string pincode;
    }
    class Employee
    {
        // instance varibles from id to salary
        int id;
        string name;
        string dept;
        string manager;
        float salary;
        Address address;
        // static variable
        static string companyname;

        // default constructor
        public Employee()
        {
            
        }

        // parameretized
        public Employee(string name , string dept)
        {
            this.name = name;
            this.dept = dept;
            Console.WriteLine("Enter Id");
            id = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Manager");
            manager = Console.ReadLine();
            Console.WriteLine("Enter Salary");
            salary = float.Parse(Console.ReadLine());
        }
        // parameterized
        public Employee(int id, string name, string dept, string manager)
        {
            this.name = name;
            this.dept = dept;
            this.id = id;
            this.manager = manager;
            Console.WriteLine("Enter Salary");
            salary = float.Parse(Console.ReadLine());
        }
        // fully parameterized
        public Employee(int id, string name, string dept, string manager , float salary)
        {
            this.name = name;
            this.dept = dept;

            this.id = id;
            this.manager = manager;
            this.salary = salary;
        }
        static Employee()
        {
            companyname = "CTS";
        }
        public void GetDetails()
        {
            Console.WriteLine("Enter Id");
            id = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Name");
            name = Console.ReadLine();
            Console.WriteLine("Enter Department");
            dept = Console.ReadLine();
            Console.WriteLine("Enter Manager");
            manager = Console.ReadLine();
            Console.WriteLine("Enter Salary");
            salary = float.Parse(Console.ReadLine());
            Console.WriteLine("ENter Address");
            Console.WriteLine("Nter Street No");
            address.streetno = Console.ReadLine();
        }
        public void DisplayDetails()
        {
            //Console.WriteLine("Company Name is " + companyname);
            Console.WriteLine("ID is " + id);
            Console.WriteLine("Name is " + name);
            Console.WriteLine("Department is " + dept);
            Console.WriteLine("Manager Name is" + manager);
            Console.WriteLine("Salary is " + salary);
        }
        public Employee(Employee employee)
        {
            Console.WriteLine("Enter Id");
            id = int.Parse(Console.ReadLine());

            this.name = employee.name;
            this.dept = employee.dept;
            this.manager = employee.manager;
            this.salary = employee.salary;
        }
        public static void DisplayCompmayName()
        {
         //   companyname = "CTS";
            Console.WriteLine("COMPANY NAME IS : "+ companyname);
        }
    }
}
