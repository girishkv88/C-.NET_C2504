using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QO1_while_loop
{
    internal class Program
    {
        static void PrintSeries10_12_14(int numOfTerms)//converted the for loop to while loop question  Q01
        {
            int term = 10;
            int i = 1; //Initialization: Move the initialization of the loop control variable(s) outside the loop.


            while (i <= numOfTerms)//Condition: Use the condition from the for loop as the condition for the while loop.
            {
                Console.Write($"{term} ");
                term += 2;
                i++;//Iteration: Place the increment(or decrement) operation inside the loop, typically at the end of the loop body.

            }
        }

        static void TestPrintSeries10_12_14()
        {
            Console.Write("Enter number of terms:");
            int numOfTerms = int.Parse(Console.ReadLine());
            Console.Write("Series: ");
            PrintSeries10_12_14(numOfTerms);
            Console.WriteLine();
        }

        static void Main(string[] args)
        {
            Console.WriteLine("--------------TestPrintSeries10_12_14.. Using While loop.--------------");
            TestPrintSeries10_12_14();
            Console.WriteLine("--------------End TestPrintSeries10_12_14..  Using While loop.--------------");
            Console.WriteLine("Press any key to contine...");
            Console.ReadKey();
        }
    }
}
