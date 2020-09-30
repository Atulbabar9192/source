using System;
namespace DemoGenerics
{
    struct Mystruct
    {

        public void Display()
        {
            Console.WriteLine("This is Structure");
        } 

        static void Main()
        {
            Mystruct    m1 = new Mystruct();
            m1.Display();
            Console.ReadLine();
        }
    }
    
}