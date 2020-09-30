using System;

namespace Firstproject
{
    class Program
    {
        int i;
        bool b;
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Program p = new Firstproject.Program();
            Console.WriteLine(p.b);
            Console.WriteLine(p.i);
            Console.ReadLine();
        }
    
}
