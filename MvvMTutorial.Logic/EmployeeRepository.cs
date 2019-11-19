using System;
using System.Collections.Generic;
using System.Text;

namespace MvvMTutorial.Logic
{
    public class EmployeeRepository
    {
        private static List<Entities.Employee> employees;

        static EmployeeRepository()
        {
            employees = new List<Entities.Employee>()
            {
                new Entities.Employee {LastName = "Müller", FirstName = "Zeki"},
                new Entities.Employee {LastName = "Seidl", FirstName = "Martin"},
                new Entities.Employee {LastName = "Hofer", FirstName = "Florian"}
            };
        }

        public static Entities.Employee[] GetEmployees()
        {
            return employees.ToArray();
        }

        public static void Add(string lastName, string firstName)
        {
            employees.Add(new Entities.Employee { FirstName = firstName, LastName = lastName });
        }
    }
}
