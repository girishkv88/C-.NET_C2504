using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q05_WhileLoop
{
    internal class Program
    {
        static int GetNthTerm_21_22_24_27(int N)
        {
            int term = 21;
            int difference = 1;
            int I = 1;  // Initialization

            while (I <= N)  // Condition
            {
                if (I == N)
                {
                    break;
                }

                term = term + difference;
                difference = difference + 1;
                I++;  // Increment
            }
            return term;
        }

        static void TestGetNthTerm_21_22_24_27()
        {
            Console.Write("Enter number of terms: ");
            int N = int.Parse(Console.ReadLine());
            int nthTerm = GetNthTerm_21_22_24_27(N);
            Console.WriteLine($"Nth term is {nthTerm}");
        }

        static void Main(string[] args)
        {
            Console.WriteLine("-----TestGetNthTerm_21_22_24_27  while loop-----");
            TestGetNthTerm_21_22_24_27();
            Console.WriteLine("-----End TestGetNthTerm_21_22_24_27  while loop-----");
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }
    }
}
