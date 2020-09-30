using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefaltConstrutor
{
    class StaticNonStatic
    {
        static int y;
        int x;
        static StaticNonStatic()
        {
            Console.WriteLine("Static constructor  is called");
        }
        public StaticNonStatic(int x)
        {
           this.x = x;
            Console.WriteLine("Non static constructor  is called");
        }
        static void Main()
        {
            StaticNonStatic s1 = new StaticNonStatic(10);
            StaticNonStatic s2 = new StaticNonStatic(20);
            StaticNonStatic s3 = new StaticNonStatic(30);
            Console.WriteLine("y" + y);
            Console.WriteLine( s1.x +" "+s2.x+" "+s3.x);
            Console.ReadLine();
        }

    }   
}
