using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            //Employee.companyname = "CTS";
            Employee.DisplayCompmayName();

           // Console.WriteLine(Employee.companyname);
            // it will invoke default
            Employee employee1 = new Employee();
            Console.WriteLine("Object which invoked def con");
            ;          employee1.GetDetails();
            employee1.DisplayDetails();
            // it will invoke para const
            Console.WriteLine("Object which invoked para con");
            ;
            Employee employee2 = new Employee(name:"Ajay", dept: "HR");
            employee2.DisplayDetails();
            // it will invoke para const
            Console.WriteLine("Object which invoked para con");
            ;
            Employee employee3 = new Employee(2, "Paras", "Deepak", "HR");
            employee3.DisplayDetails();
            // it will invoke para const
            Console.WriteLine("Object which invoked fully para  con");
            ;
            Employee employee4 = new Employee(3, "Paras", "Deepak", "HR", 90000);
            employee4.DisplayDetails();

            // It invokes copy constr
            Employee employee5 = new Employee(employee4);
            employee5.DisplayDetails();

            // Structure variable
            record record = new record();
            record.GetDetails();
            record.DisplayDetails();


        }
    }
}
