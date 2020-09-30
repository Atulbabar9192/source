using System;
using System.Collections.Generic;
using System.Text;

namespace DemoGenerics
{
    class Customer
    {
        public int Custid { get; set; }
        public string Name { get; set; }
        public string City { get; set; }
        public double Balance { get; set; }
        
        class TestCust
        {
            static void Main()
            {

                List<Customer> Customers = new List<Customer>();
                Customer C1= new Customer { Custid = 101, Name = "John", City = "N.Y", Balance = 3000.00 };
                Customer C2 = new Customer { Custid = 102, Name = "Smith", City = "Thane", Balance = 2000.00 };
                Customer C3 = new Customer { Custid = 103, Name = "Ram", City = "Pune", Balance = 4000.00 };
                Customer C4 = new Customer { Custid = 104, Name = "Neel", City = "Satara", Balance = 62000.00 };
                Customers.Add(C1);
                Customers.Add(C2);
                Customers.Add(C3);
                Customers.Add(C4);

                foreach(Customer obj in Customers)
                {
                    
                    Console.WriteLine(obj.Custid + " " +obj.Name+ " " + obj.City + " " + obj.Balance);
                }

                Console.ReadLine();
            }
        }
    }
}
