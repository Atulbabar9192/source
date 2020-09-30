using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefaltConstrutor
{
    class Program
    {
        int i; bool b;
        static void Main(string[] args) 
        {
            //defalt constructor not initialized still compiler gets value  //
         
            Program p = new Program();
            Console.WriteLine("the value of i is  " + p.i);
            Console.WriteLine("the value of b is " + p.b);
            Console.ReadLine();
        }
    }
}
