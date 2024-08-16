using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enum
{
    
    internal class Program
    {
        enum Conversions
        {
            Trim,
            ToUpper,
            ToLower
        }

        static void Convert(string text, Conversions  action)
        {
            switch (action)
            {
                case Conversions.Trim:
                   
                    break;
                case Conversions.ToUpper:
                    Console.WriteLine(text.ToUpper());
                    break;
                case Conversions.ToLower:
                    Console.WriteLine(text.ToLower());
                    break;
                default:
                    break;
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the string");
            string text = Console.ReadLine();
            Console.WriteLine($"The resultant string is {Convert(text ,Convertions.Upper)}");
        }
    }
}
