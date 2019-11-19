using System;
using System.Collections.Generic;
using System.Text;

namespace MvvMTutorial.Logic.Entities
{
    public class Employee
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FullName => $"{LastName} {FirstName}";
    }
}
