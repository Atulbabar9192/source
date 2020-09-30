using System;

namespace DemoGenerics
{
    class Program
    {
        static void Main(string[] args)
        {
            Generics1 obj = new Generics1();
            bool result = obj.Compare(10, 10);
            Console.WriteLine(result);

            Console.ReadLine();
        }
    }
}
