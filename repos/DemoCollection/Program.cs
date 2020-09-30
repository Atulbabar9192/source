using System;
using System.Collections;

namespace DemoCollection
{
    class Program
    {
        static void Main(string[] args)
        {

            ArrayList al = new ArrayList(10);
            al.Add(200);
            al.Add(400);
            al.Add(600);
            al.Add(800);
            Console.WriteLine(al.Capacity);
            Console.ReadLine();
            foreach(Object obj  in al)
                Console.WriteLine(obj + " ");
            al.Insert(3, 450);
            al.Remove(200);
            foreach(Object obj  in al)
                Console.WriteLine("new obj" +obj + " ");
        }
    }
}
