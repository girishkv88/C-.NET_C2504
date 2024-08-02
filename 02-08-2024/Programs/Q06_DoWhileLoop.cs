using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q06_DoWhileLoop
{
    internal class Program
    {
        static int GetNthTerm_21_22_24_27(int N)
        {
            int term = 21;
            int difference = 1;
            int I = 1;

            do
            {
                if (I == N)
                {
                    break;
                }

                term = term + difference;
                difference = difference + 1;
                I++;
            }
            while (I <= N);

            return term;
        }

        static void TestGetNthTerm_21_22_24_27()
        {
            Console.Write("Enter number of terms:");
            int N = int.Parse(Console.ReadLine());
            int nthTerm = GetNthTerm_21_22_24_27(N);
            Console.WriteLine($"Nth term is {nthTerm}");
        }

        static void Main(string[] args)
        {
            Console.WriteLine("-----TestGetNthTerm_21_22_24_27  do while loop-----");
            TestGetNthTerm_21_22_24_27();
            Console.WriteLine("-----End TestGetNthTerm_21_22_24_27  do while  loop-----");
            Console.WriteLine("Press any key to contine...");
            Console.ReadKey();
        }
    }
}
