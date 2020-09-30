using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefaltConstrutor
{
    class ExplictConst
    {
        public ExplictConst()
        {
            Console.WriteLine("Explict constructor  is called ");
        }
        static void Main()
            {
            ExplictConst ex1 = new ExplictConst();
            ExplictConst ex2 = new ExplictConst();
            ExplictConst ex3 = new ExplictConst();
            Console.ReadLine();
        }
        }
    }
