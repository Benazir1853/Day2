using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoopApp
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int i, j;
            for (i = 20; i <= 30; i++)
            {
                for (j = 2; j <= (i/j); j++)
                
                    if ((i/j) == 0)
                        break;
                    if (j > (i/j))
                        Console.WriteLine(+i+ " is a Prime Number");
                

               
            }
            Console.ReadLine();
        }
    }
}