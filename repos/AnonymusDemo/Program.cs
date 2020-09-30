using System;

namespace AnonymusDemo
{
    class Program
    {
        public delegate string GreetingsDelegate(string sname);
        //public static string  Greetings(string name)
        //{
        //    return "Hello " + name + " A very Good Morning";
        //}
          static void Main(string[] args)
        {
            GreetingsDelegate obj = delegate (string name) // Anonymus method 
            {
                return "Hello " + name + " A very Good Morning";
            };
            //  string result = Greetings("Atul");
            //string str = Greetings("Atul");
            string str = obj.Invoke("Atul");
            Console.WriteLine(str);
            Console.ReadLine();
        }
    }
}
