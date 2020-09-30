using System;
using System.Text;
using System.Diagnostics;

namespace StringBuilderDemo
{
    class Program
    {
        static void Main(string[] args)
        {

            string s = "";
            Stopwatch sp1 = new Stopwatch();
            sp1.Start();
            for(int i=1; i<=100000; i++)
            {
                s = s + i;
            }
            sp1.Stop();
            StringBuilder sb = new StringBuilder();
            Stopwatch sp2 = new Stopwatch();
            sp2.Start();
            for (int i = 1; i <= 100000; i++)
            {
                sb.Append(i);
            }
            sp2.Stop();
            Console.WriteLine("Time required for string:" + sp1.ElapsedMilliseconds);
            Console.WriteLine("Time required for stringBuilder :" +sp2.ElapsedMilliseconds);
            
        }
    }
}
