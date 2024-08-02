using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q01_do_while
{
    internal class Program
    {
        static void PrintSeries10_12_14(int numOfTerms)
        {
            int term = 10;
            int i = 1;//Initialization: int i = 1; is done before the loop starts.

            do
            {
                Console.Write($"{term} ");//Loop Body: The code inside the do block is executed first, printing the current term and then updating it.
                term += 2;
                i++;
            }
            while (i <= numOfTerms);//Condition: After executing the loop body, the condition i <= numOfTerms is checked. If it's true, the loop repeats; if false, the loop exits.
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
            Console.WriteLine("--------------TestPrintSeries10_12_14.. Using do While loop.--------------");
            TestPrintSeries10_12_14();
            Console.WriteLine("--------------End TestPrintSeries10_12_14..  Using do While loop.--------------");
            Console.WriteLine("Press any key to contine...");
            Console.ReadKey();
        }
    }
}
