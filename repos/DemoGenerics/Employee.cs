using System;
using System.Collections.Generic;
using System.Text;

namespace DemoGenerics
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public string Job { get; set; }
        public decimal Salary { get; set; }
    }
    class TestEmployee
    {

        static void Main()

        {
            List<Employee> employees = new List<Employee>();


        }
    }

}