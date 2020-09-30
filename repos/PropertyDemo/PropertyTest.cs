using System;
using System.Collections.Generic;
using System.Text;

namespace PropertyDemo
{
    class PropertyTest
    {
        static void Main()
        {
            Customer obj = new Customer(101,"Shon",false,5400.25);
            Console.WriteLine("Custid :" + obj.Custid);
                Console.ReadLine();
            Console.ReadKey();
            //
            //obj.Custid = 104;
            Console.WriteLine("Custid :" + obj.Custid);

        }
        
    }
}
