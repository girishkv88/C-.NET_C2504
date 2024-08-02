using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q04_ForLoop
{
    internal class Program
    {                                                //21_22_24_27_31_36_42_49
        static int GetNthTerm_21_22_24_27(int N)
        {
            int term = 21;
            int difference = 1;
            for (int I = 1; I <= N; I++)
            {
                if (I == N)
                {
                    break;
                }
        
                term = term + difference;
                difference = difference + 1;
            }
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
            Console.WriteLine("-----TestGetNthTerm_21_22_24_27  for loop-----");
            TestGetNthTerm_21_22_24_27();
            Console.WriteLine("-----End TestGetNthTerm_21_22_24_27  for loop-----");
            Console.WriteLine("Press any key to contine...");
            Console.ReadKey();
        }
    }
}



