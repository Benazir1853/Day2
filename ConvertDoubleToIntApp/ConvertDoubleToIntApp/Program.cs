using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConvertDoubleToIntApp
{
    class Program
    {
        static void Main(string[] args)
        {
            double d = 5673.74;
            int i;

            // cast double to int.
            i = (int)d;
            Console.WriteLine("Given Value:" + d);
            Console.WriteLine("Converted Integer:" +i);
            Console.ReadKey();
        }
    }
}
