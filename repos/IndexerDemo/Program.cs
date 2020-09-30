using System;

namespace IndexerDemo
{
    class Program
    {
        public class Employee
        {
            int Id;
            string Name, Dname, Location;
            double Salary;
            public Employee(int Id, string Name, string Dname, string Location, double Salary)
            {
                this.Id = Id;
                this.Name = Name;
                this.Dname = Dname;
                this.Location = Location;
                this.Salary = Salary;
            }

            static void Main()
            {

                Employee Emp = new Employee(101, "Scott", "sales", "Mumbai", 4500.20);
                Console.WriteLine(Emp.Name + " " + Emp.Dname);
                Console.ReadLine();
            }

        }

    }
}
