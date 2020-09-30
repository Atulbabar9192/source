using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstactclass
{
    interface ITestInterface1
    {

        void Add(int a, int b);

    }
    interface ITestInterface2 : ITestInterface1
    {
        void Sub(int a, int b);
    }
    class Impletation : ITestInterface2
    {
      //  public void Add(int a, int b) //
           public void Add (int a,int b)
        {
            Console.WriteLine(a + b);
        }
        public void Sub(int a, int b)
        {
            Console.WriteLine(a - b);
        }
        static void Main()
        {
            Impletation obj = new Impletation();
            obj.Add(10,8);
            obj.Sub(10,5);
            Console.Read();
        }
    }
}

