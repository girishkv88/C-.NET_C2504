using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeligateExamples
{// Declare a delegate named DWriteLine that can hold references to any method
 // that takes a string as an input parameter and returns void.
    delegate void DWriteLine(string str);

    internal class Program
    {
        // A method named Print that takes a string as input and prints it to the console.
        static void Print(string a)
        {
            Console.WriteLine(a);
        }

        static void Main()
        {
            // Assign the method Console.WriteLine to the delegate wr.
            // This means wr can now be used to call Console.WriteLine with a string argument.
            DWriteLine wr = Console.WriteLine; // or DWriteLine wr = new DWriteLine(Console.WriteLine);

            // Using the delegate wr to call Console.WriteLine indirectly.
            wr("Hello World!!!");
            wr("Hi Ashna!");
            wr("Hi Collin!");

            // The following line is commented out because the signatures do not match.
            // DWriteLine expects a method that returns void and takes a string as an argument,
            // but Console.ReadLine returns a string and takes no arguments.
            // DWriteLine rl = Console.ReadLine; // this would cause a compilation error.

            // Assign the Print method to the delegate rPrint.
            DWriteLine rPrint = Print; // or new DWriteLine(Print)

            // Call the Print method indirectly using the rPrint delegate.
            rPrint("I am printing...");

            // Assign the PrintLettersOneByOne method to the delegate rPrintLettersOneByOne.
            DWriteLine rPrintLettersOneByOne = PrintLettersOneByOne;

            // Multi-cast delegate: adding another method to the delegate's invocation list.
            // Now, rPrintLettersOneByOne will call both PrintLettersOneByOne and PrintLettersCount.
            rPrintLettersOneByOne += PrintLettersCount;

            // Call both methods in the multi-cast delegate with the string "Obj".
            rPrintLettersOneByOne("Obj");

            // Remove the PrintLettersOneByOne method from the delegate's invocation list.
            rPrintLettersOneByOne -= PrintLettersOneByOne;

            // Now, only PrintLettersCount will be called when the delegate is invoked.
            rPrintLettersOneByOne("Oriented");
        }

        // A method that prints each character of the string one by one.
        static void PrintLettersOneByOne(string x)
        {
            foreach (var letter in x)
            {
                Console.WriteLine(letter);
            }
        }

        // A method that counts and prints the number of characters in the string.
        // This method does not use the Length property, but instead manually counts the characters.
        static void PrintLettersCount(string x)
        {
            int c = 0;
            foreach (var letter in x)
            {
                c++; // Increment the counter for each character in the string.
            }
            // Print the total count of characters.
            Console.WriteLine($"Count is {c}");
        }
    }

}
