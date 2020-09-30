using System;
using System.Collections.Generic;
using System.Text;

namespace ExtensionMethod
{
    static class StatClass
    {
        public static void Test3(this Program P)
        {
            Console.WriteLine("Method 3");
        }

    }
}
