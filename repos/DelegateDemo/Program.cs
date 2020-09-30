using System;

namespace DelegateDemo
{
    class Program
    { 
        //declare Delegate
        public delegate void AddDelegate(int x, int y);
        public delegate string SayDelegate(string sname);
        public void  AddNums(int a, int b)
        {
            Console.WriteLine(a + b);
        }
        public static string SayHello(string name)

        {
            return "Hello " + name;
           
        }
          
        static void Main(string[] args)
        {

            Program P = new Program();   
            AddDelegate ad = new AddDelegate(P.AddNums); // non-static method not called directly hence called by instance//
            ad.Invoke(100,500);                                 //invoke is anothe method for calling//

            // P.AddNums(10, 20);

            SayDelegate sd = new SayDelegate(SayHello);    //directly static member can access under static block//
            string str = sd.Invoke("Atul babar");

            //string Str = Program.SayHello("Atul");


            Console.WriteLine(str);
            Console.ReadLine();
        }
    }
}
