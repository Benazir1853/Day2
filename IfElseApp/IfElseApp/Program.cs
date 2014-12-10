using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IfElseApp
{
    internal class Program
    {
        private static void Main(string[] args)
        {
        static void Main  (string[] args)
            {
                int a = Convert.ToInt32(Console.ReadLine());
                int b = Convert.ToInt32(Console.ReadLine());

                switch (a)
                {
                    case 100:
                        Console.WriteLine("This is part of outer switch ");
                        switch (b)
                        {
                            case 200:
                                Console.WriteLine("This is part of inner switch ");
                                break;
                        }
                        break;
                }
                Console.WriteLine("Exact value of a is : {0}", a);
                Console.WriteLine("Exact value of b is : {0}", b);
                Console.ReadLine();
            }
        }
    }
