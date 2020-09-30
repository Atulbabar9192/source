using System;
using System.Collections.Generic;
using System.Text;

namespace AnonymusDemo
{
    class GenericDelegate
    {
     //public delegate void Delegate1(int x, float y, double z);
     //public delegate double Delegate2(int x, float y, double z);
     //public delegate bool  Delegate3(string str);


        //public static void AddNum1(int x, float y, double z)
        //{
        //    Console.WriteLine(x + y + z);
        //}
        //public static double AddNum2(int x, float y, double z)
        //{
        //    return x + y + z;
        //}
        //public static bool AddNum3(string str)
        //{
        //    if (str.Length > 6)
        //      return true;
        //   else return false;
        //}
         static void Main()
        {
            Action<int, float, double> obj1 = (x, y, z) =>
              {
                  Console.WriteLine(x + y + z);
              };
            obj1.Invoke(10, 65.45f, 45.55);

            Func<int, float, double, double> obj2 = (x, y, z) =>
            {
                return x + y + z;
            };

            double result = obj2.Invoke (30,45.8f,45.12);
            Console.WriteLine(result);

            Predicate<string> obj3 = (str) =>
            {
                if (str.Length > 6)
                    return true;
                else return false;
            };

            bool status = obj3.Invoke("Calenderthis");
            Console.WriteLine(status);
            Console.ReadLine();
        }
    } 
    
}
