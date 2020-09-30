using System;

namespace ExtensionMethod
{
    class Program
    {
        public void Test1()
        {
            Console.WriteLine("Method 1");
        }
        public void Test2()
        {
            Console.WriteLine("method 2");
        }

        static void Main(string[] args)
        {
            Program P = new Program();
            P.Test1();
            P.Test2();
           
        }
    }
}
